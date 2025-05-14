using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class EditarDatos : Form
    {
        string connectionString = "Server=MAURICIO;Database=LoginFloraria;Integrated Security=True;TrustServerCertificate=True;";
        int usuarioId;

        public EditarDatos(int id)
        {
            InitializeComponent();
            usuarioId = id;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Nombre, Telefono, Email, Domicilio, Contrasena, Curp, Rol, Image, NFC FROM URegistros WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", usuarioId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            TxtNombre.Text = reader["Nombre"].ToString();
                            TxtTelefono.Text = reader["Telefono"].ToString();
                            TxtEmail.Text = reader["Email"].ToString();
                            TxtDomicilio.Text = reader["Domicilio"].ToString();
                            TxtContrasena.Text = reader["Contrasena"].ToString();
                            TxtCurp.Text = reader["Curp"].ToString();
                            ComboRol.Text = reader["Rol"].ToString(); // ← ComboBox usado
                            TxtNFC.Text = reader["NFC"].ToString();

                            byte[] imgBytes = reader["Image"] as byte[];
                            if (imgBytes != null && imgBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    pictureBox.Image = new Bitmap(Image.FromStream(ms)); // ← importante
                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el usuario con ID: " + usuarioId);
                        }

                        reader.Close();
                    }

                    string queryNFC = "SELECT PuntosDisponibles, EstadoTarjeta, FechaActivacion, FechaExpiracion FROM NFCU WHERE UsuarioId = @ID";
                    using (SqlCommand cmdNFC = new SqlCommand(queryNFC, conn))
                    {
                        cmdNFC.Parameters.AddWithValue("@ID", usuarioId);
                        SqlDataReader readerNFC = cmdNFC.ExecuteReader();

                        if (readerNFC.Read())
                        {
                            TxtPuntos.Text = readerNFC["PuntosDisponibles"].ToString();
                            TxtEstado.Text = readerNFC["EstadoTarjeta"].ToString();
                            TxtFechaActivacion.Text = Convert.ToDateTime(readerNFC["FechaActivacion"]).ToShortDateString();
                            TxtFechaExpiracion.Text = Convert.ToDateTime(readerNFC["FechaExpiracion"]).ToShortDateString();
                        }

                        readerNFC.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message);
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            open.Title = "Seleccionar imagen";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var imgTemp = Image.FromFile(open.FileName))
                    {
                        pictureBox.Image = new Bitmap(imgTemp); // ← Clonamos la imagen cargada
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar imagen: " + ex.Message);
                }
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE URegistros SET Nombre = @Nombre, Telefono = @Telefono, Email = @Email, Domicilio = @Domicilio, Contrasena = @Contrasena, Curp = @Curp, Rol = @Rol, Image = @Image, NFC = @NFC WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                        cmd.Parameters.AddWithValue("@Domicilio", TxtDomicilio.Text);
                        cmd.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text);
                        cmd.Parameters.AddWithValue("@Curp", TxtCurp.Text);
                        cmd.Parameters.AddWithValue("@Rol", ComboRol.Text); // ← ComboBox
                        cmd.Parameters.AddWithValue("@NFC", TxtNFC.Text);

                        if (pictureBox.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                using (Bitmap bmp = new Bitmap(pictureBox.Image)) // ← Clon
                                {
                                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    cmd.Parameters.AddWithValue("@Image", ms.ToArray());
                                }
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Image", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@ID", usuarioId);
                        cmd.ExecuteNonQuery();
                    }

                    string queryUpdateNFC = "UPDATE NFCU SET PuntosDisponibles = @Puntos, EstadoTarjeta = @Estado, FechaActivacion = @FechaA, FechaExpiracion = @FechaE WHERE UsuarioId = @ID";
                    using (SqlCommand cmdNFC = new SqlCommand(queryUpdateNFC, conn))
                    {
                        cmdNFC.Parameters.AddWithValue("@Puntos", int.TryParse(TxtPuntos.Text, out int puntos) ? puntos : 0);
                        cmdNFC.Parameters.AddWithValue("@Estado", string.IsNullOrWhiteSpace(TxtEstado.Text) ? "Activo" : TxtEstado.Text);
                        cmdNFC.Parameters.AddWithValue("@FechaA", DateTime.TryParse(TxtFechaActivacion.Text, out DateTime fa) ? fa : DateTime.Today);
                        cmdNFC.Parameters.AddWithValue("@FechaE", DateTime.TryParse(TxtFechaExpiracion.Text, out DateTime fe) ? fe : DateTime.Today.AddYears(3));
                        cmdNFC.Parameters.AddWithValue("@ID", usuarioId);

                        cmdNFC.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
        }

        private void TxtFechaExpiracion_TextChanged(object sender, EventArgs e) { }

        private void pictureBox_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void TxtRol_TextChanged(object sender, EventArgs e) { }
    }
}
