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
    public partial class ClientesMenu: Form
    {
        public ClientesMenu()
        {
            InitializeComponent();
        }

        private void ClientesMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo_Editar_Informacion_Tarjetas_NFC.Editar_Informacion_Tarjetas_NFC NFC = new Modulo_Editar_Informacion_Tarjetas_NFC.Editar_Informacion_Tarjetas_NFC();
            NFC.Show();
        }
    }
}
