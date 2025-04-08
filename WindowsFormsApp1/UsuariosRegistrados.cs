using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UsuariosRegistrados : Form
    {
        string connectionString = "Server=DELL_JACV;Database=LoginFloraria;Integrated Security=True;TrustServerCertificate=True;";

        public UsuariosRegistrados()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatos("Todos");
            TxtBuscar.TextChanged += TxtBuscar_TextChanged; // Agregar evento de búsqueda
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Clear();

            // Columna para el ID (oculta)
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns["ID"].Visible = false;  // Hacerla oculta

            // Imagen
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Imagen";
            imgCol.Name = "Imagen";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imgCol);

            // Nombre
            dataGridView1.Columns.Add("Nombre", "Nombre");

            // Botón Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "";
            btnEditar.Name = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEditar);

            // Botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEliminar);

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void CargarDatos(string rol)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, Image, Nombre FROM URegistros";  // Incluye el ID

                    if (rol != "Todos")
                    {
                        query += " WHERE Rol = @Rol";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (rol != "Todos")
                        {
                            cmd.Parameters.AddWithValue("@Rol", rol);
                        }

                        SqlDataReader reader = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);  // Obtener el ID de la base de datos
                            byte[] imgBytes = reader["Image"] as byte[];
                            string nombre = reader["Nombre"].ToString();
                            Image imagen = null;

                            if (imgBytes != null && imgBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    imagen = Image.FromStream(ms);
                                }
                            }

                            // Añadir el ID como la primera celda oculta, junto con la imagen y el nombre
                            dataGridView1.Rows.Add(id, imagen, nombre);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void BuscarUsuario(string nombreBuscado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, Image, Nombre FROM URegistros WHERE Nombre LIKE @Nombre";  // Incluye el ID

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "%" + nombreBuscado + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);  // Obtener el ID de la base de datos
                            byte[] imgBytes = reader["Image"] as byte[];
                            string nombre = reader["Nombre"].ToString();
                            Image imagen = null;

                            if (imgBytes != null && imgBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    imagen = Image.FromStream(ms);
                                }
                            }

                            // Añadir el ID como la primera celda oculta, junto con la imagen y el nombre
                            dataGridView1.Rows.Add(id, imagen, nombre);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(TxtBuscar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el ID desde la primera columna (oculta)
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                // Si se presionó el botón Editar
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    UsuarioEdit formEditar = new UsuarioEdit(id);  // Pasar el ID al formulario de edición
                    formEditar.Show();
                    this.Hide();
                }

                // Si se presionó el botón Eliminar
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    DialogResult result = MessageBox.Show($"¿Seguro que quieres eliminar a {nombre}?", "Confirmar eliminación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        EliminarUsuario(id);  // Eliminar usando el ID
                        CargarDatos("Todos");  // Recargar datos después de eliminar
                    }
                }
            }
        }

        private void EliminarUsuario(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM URegistros WHERE ID = @ID";  // Usar el ID para eliminar

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);  // Eliminar usando el ID
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            CargarDatos("Administrador");
        }

        private void ButtonTodos_Click(object sender, EventArgs e)
        {
            CargarDatos("Todos");
        }

        private void ButtonTrabajadores_Click(object sender, EventArgs e)
        {
            CargarDatos("Trabajador");
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            CargarDatos("Cliente");
        }
    }
}
