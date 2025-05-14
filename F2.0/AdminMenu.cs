using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminMenu: Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarNuevoUsuario = new AgregarUsuario();
            agregarNuevoUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido();
            generarPedido.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recomendaciones recomendaciones = new Recomendaciones();
            recomendaciones.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HistorialPedidos historialPedidos = new HistorialPedidos();
            historialPedidos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistroRoles registroRoles = new RegistroRoles();
            registroRoles.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InformacionTienda informacionTienda = new InformacionTienda();
            informacionTienda.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion form1 = new InicioSesion();
            form1.Show();
        }

        private void pictureBoxCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion form1 = new InicioSesion();
            form1.Show();
        }
    }
}
