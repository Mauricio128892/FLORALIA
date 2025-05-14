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
    public partial class Recomendaciones: Form
    {
        public Recomendaciones()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Recomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_comprarcumpleaños_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido();
            generarPedido.Show();
        }

        private void button2_comprarbodas_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido();
            generarPedido.Show();
        }

        private void button3_comprareventos_Click(object sender, EventArgs e)
        {
            GenerarPedido generarPedido = new GenerarPedido();
            generarPedido.Show();
        }
    }
}
