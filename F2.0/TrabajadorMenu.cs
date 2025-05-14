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
    public partial class TrabajadorMenu: Form
    {
        public TrabajadorMenu()
        {
            InitializeComponent();
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

        private void pictureBoxCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion form1 = new InicioSesion();
            form1.Show();
        }
    }
}
