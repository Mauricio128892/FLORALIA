using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Inventario : Form
    {
        private int idSeleccionado = -1;

        public Inventario()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Seleccionar una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ButtonGuardar_Click_1(object sender, EventArgs e)
        {
            string conexionString = "Server=DELL_JACV;Database=LoginFloraria;Trusted_Connection=True;";
            byte[] imagenBytes = ImagenABytes(pictureBox1.Image);

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "INSERT INTO Inventario2(Nombre, Precio, Cantidad, Image) VALUES (@Nombre, @Precio, @Cantidad, @Imagen)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text);

                    string precioTexto = TxtPrecio.Text.Trim().Replace(",", ".");
                    if (!decimal.TryParse(precioTexto, out decimal precio))
                    {
                        MessageBox.Show("El precio ingresado no tiene un formato válido.");
                        return;
                    }

                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(TxtCantidad.Text));
                    comando.Parameters.AddWithValue("@Imagen", imagenBytes);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Datos guardados correctamente." : "No se guardó ningún dato.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                }
            }
        }

        private void CargarDatos()
        {
            string conexionString = "Server=DELL_JACV;Database=LoginFloraria;Trusted_Connection=True;";
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "SELECT Id, Nombre, Precio, Cantidad, Image FROM Inventario2";
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    tabla.Columns.Add("ImagenMostrada", typeof(Image));

                    foreach (DataRow row in tabla.Rows)
                    {
                        if (row["Image"] != DBNull.Value)
                        {
                            byte[] imagenBytes = (byte[])row["Image"];
                            using (MemoryStream ms = new MemoryStream(imagenBytes))
                            {
                                row["ImagenMostrada"] = Image.FromStream(ms);
                            }
                        }
                    }

                    tabla.Columns.Remove("Image");
                    tabla.Columns["ImagenMostrada"].ColumnName = "Image";

                    dataGridView1.DataSource = tabla;
                    ConfigurarDataGridView();
                }
            }
        }
        private void TxtModificar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado < 0)
            {
                MessageBox.Show("Selecciona un producto para modificar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Seguro que quieres hacer las modificaciones?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            string conexionString = "Server=DELL_JACV;Database=LoginFloraria;Trusted_Connection=True;";
            byte[] imagenBytes = ImagenABytes(pictureBox1.Image);

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "UPDATE Inventario2 SET Nombre = @Nombre, Precio = @Precio, Cantidad = @Cantidad, Image = @Imagen WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", idSeleccionado);
                    comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text);

                    string precioTexto = TxtPrecio.Text.Trim().Replace(",", ".");
                    if (!decimal.TryParse(precioTexto, out decimal precio))
                    {
                        MessageBox.Show("El precio no es válido.");
                        return;
                    }

                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(TxtCantidad.Text));
                    comando.Parameters.AddWithValue("@Imagen", imagenBytes);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show(filas > 0 ? "Producto modificado correctamente." : "No se modificó ningún dato.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar: " + ex.Message);
                    }
                }
            }
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns["Id"].Width = 50;
            dataGridView1.Columns["Nombre"].Width = 150;
            dataGridView1.Columns["Precio"].Width = 80;
            dataGridView1.Columns["Cantidad"].Width = 80;
            dataGridView1.Columns["Image"].Width = 100;

            DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                TxtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                TxtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                TxtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();

                if (fila.Cells["Image"].Value != DBNull.Value)
                {
                    pictureBox1.Image = (Image)fila.Cells["Image"].Value;
                }
            }
        }



        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtCantidad.Clear();
            pictureBox1.Image = null;
            idSeleccionado = -1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox4.Text.Trim();
            string conexionString = "Server=DELL_JACV;Database=LoginFloraria;Trusted_Connection=True;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "SELECT Id, Nombre, Precio, Cantidad, Image FROM Inventario2 WHERE Nombre LIKE @Busqueda";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Busqueda", "%" + textoBusqueda + "%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        // Agregar columna de imagen para mostrarla
                        tabla.Columns.Add("ImagenMostrada", typeof(Image));
                        foreach (DataRow row in tabla.Rows)
                        {
                            if (row["Image"] != DBNull.Value)
                            {
                                byte[] imagenBytes = (byte[])row["Image"];
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    row["ImagenMostrada"] = Image.FromStream(ms);
                                }
                            }
                        }

                        tabla.Columns.Remove("Image");
                        tabla.Columns["ImagenMostrada"].ColumnName = "Image";

                        dataGridView1.DataSource = tabla;
                        ConfigurarDataGridView();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
