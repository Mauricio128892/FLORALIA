using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class InicioSesion: Form
    {
        public InicioSesion()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }
            private string connectionString = "Server=MAURICIO;Database=LoginFloraria;Trusted_Connection=True;";

            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void IngresarButton_Click_1(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string contra = TxtContra.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contra))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtContra.Focus();
                return;
            }

            // Conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar si hay usuarios registrados en la base de datos
                    string query = "SELECT COUNT(*) FROM URegistros";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount == 0)
                        {
                            MessageBox.Show("Debe llenar el formulario primero para crear una cuenta.", "Formulario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Consulta SQL para verificar credenciales y obtener el rol
                        string loginQuery = "SELECT Rol FROM URegistros WHERE Nombre = @Nombre AND Contrasena = @Contrasena";
                        using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                        {
                            loginCmd.Parameters.AddWithValue("@nombre", nombre);
                            loginCmd.Parameters.AddWithValue("@contrasena", contra);

                            object result = loginCmd.ExecuteScalar();

                            if (result != null)  // Si encontró un usuario
                            {
                                string rol = result.ToString();

                                if (rol == "Cliente")
                                {
                                    MessageBox.Show("Error: Acceso Denegado");
                                    return;
                                }
                                else if (rol == "Trabajador")
                                {
                                    TrabajadorMenu trabajadorMenu = new TrabajadorMenu();  // Abre el menú de trabajadores
                                    trabajadorMenu.Show();
                                }
                                else if (rol == "Administrador")
                                {
                                    AdminMenu adminMenu = new AdminMenu();  // Abre el menú de administradores
                                    adminMenu.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PMostrar_Click(object sender, EventArgs e)
        {
            PMostrar.Visible = false;  
            PNOMOSTRAR.Visible = true; 
            TxtContra.PasswordChar = '\0'; 
        }

        private void PNOMOSTRAR_Click(object sender, EventArgs e)
        {
            PNOMOSTRAR.Visible = false; 
            PMostrar.Visible = true;    
            TxtContra.PasswordChar = '*'; 
        }

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {
            TxtContra.PasswordChar = '*';
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
