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

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            INFORMACION_TIENDA.INFORMACIÓN_TIENDA Info = new INFORMACION_TIENDA.INFORMACIÓN_TIENDA();
            Info.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UsuariosRegistrados USR = new UsuariosRegistrados();
            USR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo_Generar_Pedido.Generar_pedido Pedido = new Modulo_Generar_Pedido.Generar_pedido();
            Pedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaCuentaAdmin Admin = new NuevaCuentaAdmin();
            Admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            recomendaciones_v2.Recomendaciones recomendaciones = new recomendaciones_v2.Recomendaciones();
            recomendaciones.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modulo_Editar_Informacion_Tarjetas_NFC.Editar_Informacion_Tarjetas_NFC NFC = new Modulo_Editar_Informacion_Tarjetas_NFC.Editar_Informacion_Tarjetas_NFC();
            NFC.Show();
        }
    }
}
