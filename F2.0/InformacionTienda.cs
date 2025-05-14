using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class InformacionTienda : Form
    {
        private bool editando = false;
        private string connectionString = "Data Source=MAURICIO;Initial Catalog=LoginFloraria;Integrated Security=True";

        public InformacionTienda()
        {
            InitializeComponent();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM InfoTienda ORDER BY Id ASC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBox1_Direccioninfo.Text = reader["Direccion"].ToString();
                    textBox2_Telefonoinfo.Text = reader["Telefono"].ToString();
                    textBox3_Correoinfo.Text = reader["Correo"].ToString();
                    textBoxDescripcion.Text = reader["Descripcion"].ToString();

                    if (reader["Image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBoxLogo.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxLogo.Image = null;
                    }
                }

                reader.Close();
            }
        }

        private void GuardarInformacion()
        {
            string direccion = textBox1_Direccioninfo.Text;
            string telefono = textBox2_Telefonoinfo.Text;
            string correo = textBox3_Correoinfo.Text;
            string descripcion = textBoxDescripcion.Text;

            byte[] imageBytes = null;
            if (pictureBoxLogo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM InfoTienda";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = "UPDATE InfoTienda SET Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Descripcion = @Descripcion, Image = @Image WHERE Id = (SELECT TOP 1 Id FROM InfoTienda ORDER BY Id ASC)";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@Direccion", direccion);
                    updateCmd.Parameters.AddWithValue("@Telefono", telefono);
                    updateCmd.Parameters.AddWithValue("@Correo", correo);
                    updateCmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    updateCmd.Parameters.AddWithValue("@Image", (object)imageBytes ?? DBNull.Value);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Información actualizada correctamente.");
                }
                else
                {
                    string insertQuery = "INSERT INTO InfoTienda (Direccion, Telefono, Correo, Descripcion, Image) VALUES (@Direccion, @Telefono, @Correo, @Descripcion, @Image)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@Direccion", direccion);
                    insertCmd.Parameters.AddWithValue("@Telefono", telefono);
                    insertCmd.Parameters.AddWithValue("@Correo", correo);
                    insertCmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    insertCmd.Parameters.AddWithValue("@Image", (object)imageBytes ?? DBNull.Value);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Información guardada correctamente.");
                }
            }
        }

        private void button_editarInformacion_Click(object sender, EventArgs e)
        {
            editando = !editando;

            textBox1_Direccioninfo.ReadOnly = !editando;
            textBox2_Telefonoinfo.ReadOnly = !editando;
            textBox3_Correoinfo.ReadOnly = !editando;
            textBoxDescripcion.ReadOnly = !editando;

            button_editarInformacion.Text = editando ? "Guardar" : "Editar información";

            if (!editando)
            {
                GuardarInformacion();
                CargarInformacion();
                editando = false;

                textBox1_Direccioninfo.ReadOnly = true;
                textBox2_Telefonoinfo.ReadOnly = true;
                textBox3_Correoinfo.ReadOnly = true;
                textBoxDescripcion.ReadOnly = true;
                button_editarInformacion.Text = "Editar información";
            }
        }

        private void textBox2_Telefonoinfo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2_Telefonoinfo.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten números en el teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_Telefonoinfo.Text = System.Text.RegularExpressions.Regex.Replace(textBox2_Telefonoinfo.Text, "[^0-9]", "");
                textBox2_Telefonoinfo.SelectionStart = textBox2_Telefonoinfo.Text.Length;
            }

            if (textBox2_Telefonoinfo.Text.Length > 10)
            {
                textBox2_Telefonoinfo.Text = textBox2_Telefonoinfo.Text.Substring(0, 10);
                textBox2_Telefonoinfo.SelectionStart = textBox2_Telefonoinfo.Text.Length;
            }
        }

        private void buttonEditarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
