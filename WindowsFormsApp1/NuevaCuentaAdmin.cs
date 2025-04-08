using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NuevaCuentaAdmin : Form
    {
        public NuevaCuentaAdmin()
        {
            InitializeComponent();
            TxtNFC.Text = "NULL";
            TxtNFC.ForeColor = Color.Gray;
            TxtNFC.Enter += TxtNFC_Enter;
            TxtNFC.Leave += TxtNFC_Leave;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rol = ObtenerRolSeleccionado();
            if (rol == "")
            {
                MessageBox.Show("Seleccione un rol antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imagenBytes = ImagenABytes();
            string conexionString = "Data Source=DELL_JACV;Initial Catalog=LoginFloraria;Integrated Security=True;TrustServerCertificate=True;";
            string nfcTexto = TxtNFC.Text.Trim();
            bool tieneNFC = !(string.IsNullOrWhiteSpace(nfcTexto) || nfcTexto.ToUpper() == "NULL");

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    // Insertar en URegistros
                    string query = "INSERT INTO URegistros (Nombre, Telefono, Email, Domicilio, Contrasena, CURP, Rol, Image, NFC) " +
                                   "VALUES (@Nombre, @Telefono, @Email, @Domicilio, @Contrasena, @CURP, @Rol, @Imagen, @NFC);" +
                                   "SELECT SCOPE_IDENTITY();";

                    int idInsertado;

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        comando.Parameters.AddWithValue("@Telefono", TxtCel.Text);
                        comando.Parameters.AddWithValue("@Email", TxtEmail.Text);
                        comando.Parameters.AddWithValue("@Domicilio", string.IsNullOrWhiteSpace(TxtDomicilio.Text) ? (object)DBNull.Value : TxtDomicilio.Text);
                        comando.Parameters.AddWithValue("@Contrasena", TxtContra.Text);
                        comando.Parameters.AddWithValue("@CURP", string.IsNullOrWhiteSpace(TxtCURP.Text) ? (object)DBNull.Value : TxtCURP.Text);
                        comando.Parameters.AddWithValue("@Rol", rol);
                        comando.Parameters.AddWithValue("@Imagen", imagenBytes.Length == 0 ? (object)DBNull.Value : imagenBytes);

                        if (tieneNFC)
                            comando.Parameters.AddWithValue("@NFC", nfcTexto);
                        else
                            comando.Parameters.AddWithValue("@NFC", DBNull.Value);

                        idInsertado = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    // Si tiene NFC, insertar también en NFCU
                    if (tieneNFC)
                    {
                        string queryNFC = "INSERT INTO NFCU (UsuarioId, PuntosDisponibles, EstadoTarjeta, FechaActivacion, FechaExpiracion) " +
                                          "VALUES (@UsuarioId, @Puntos, @Estado, @FechaA, @FechaE);";

                        using (SqlCommand comandoNFC = new SqlCommand(queryNFC, conexion))
                        {
                            comandoNFC.Parameters.AddWithValue("@UsuarioId", idInsertado);
                            comandoNFC.Parameters.AddWithValue("@Puntos", 0);
                            comandoNFC.Parameters.AddWithValue("@Estado", "Activo");
                            comandoNFC.Parameters.AddWithValue("@FechaA", DateTime.Today);
                            comandoNFC.Parameters.AddWithValue("@FechaE", DateTime.Today.AddYears(3));
                            comandoNFC.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cuenta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en URegistros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ObtenerRolSeleccionado()
        {
            if (radioAdmin.Checked)
                return "Administrador";
            else if (radioTrabajador.Checked)
                return "Trabajador";
            else if (radioCliente.Checked)
                return "Cliente";
            else
                return "";
        }

        private byte[] ImagenABytes()
        {
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return new byte[0];
        }

        private void TxtNFC_Enter(object sender, EventArgs e)
        {
            if (TxtNFC.Text == "NULL")
            {
                TxtNFC.Text = "";
                TxtNFC.ForeColor = Color.Black;
            }
        }

        private void TxtNFC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNFC.Text))
            {
                TxtNFC.Text = "NULL";
                TxtNFC.ForeColor = Color.Gray;
            }
        }

    }
}
