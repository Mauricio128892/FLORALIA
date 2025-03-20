using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFORMACION_TIENDA
{
    public partial class Modulo_Informacion_Tienda: Form
    {
        private bool editando = false;

        public Modulo_Informacion_Tienda()
        {
            InitializeComponent();
        }

        private void button_editarInformacion_Click(object sender, EventArgs e)
        {
            // Cambia el estado de edición
            editando = !editando;

            // Habilita o deshabilita los TextBox según el estado de edición
            textBox1_Direccioninfo.ReadOnly = !editando;
            textBox2_Telefonoinfo.ReadOnly = !editando;
            textBox3_Correoinfo.ReadOnly = !editando;

            // Cambia el texto del botón según el estado
            button_editarInformacion.Text = editando ? "Guardar" : "Editar información";
        }

        private void textBox2_Telefonoinfo_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo sean números
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2_Telefonoinfo.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten números en el teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_Telefonoinfo.Text = System.Text.RegularExpressions.Regex.Replace(textBox2_Telefonoinfo.Text, "[^0-9]", "");
                textBox2_Telefonoinfo.SelectionStart = textBox2_Telefonoinfo.Text.Length; // Mantiene el cursor al final
            }

            // Limitar a 10 caracteres
            if (textBox2_Telefonoinfo.Text.Length > 10)
            {
                textBox2_Telefonoinfo.Text = textBox2_Telefonoinfo.Text.Substring(0, 10);
                textBox2_Telefonoinfo.SelectionStart = textBox2_Telefonoinfo.Text.Length; // Mantiene el cursor al final
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
