using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class TicketTransferencia : Form
    {

        private string pagoTotal;
        private string idTicket;

        public TicketTransferencia(string idTicket, string pagoTotal)
        {
            InitializeComponent();
            CultureInfo culturaMexicana = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culturaMexicana;
            Thread.CurrentThread.CurrentUICulture = culturaMexicana;
            this.pagoTotal = pagoTotal;
            this.idTicket = idTicket;
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("------------------------------");
            info.AppendLine($"ID Ticket: {idTicket}");
            info.AppendLine("Forma de pago: Transferencia Bancaria");
            info.AppendLine("Banco: Banco Ejemplo");
            info.AppendLine("Cuenta: 1234567890");
            info.AppendLine("CLABE: 012345678901234567");
            info.AppendLine("Titular: Floralia");
            info.AppendLine($"Total a pagar: {pagoTotal}");
            info.AppendLine("\nTiene 24 horas para realizar el pago.");
            info.AppendLine("Incluye el ID del ticket como referencia en la transferencia.");
            info.AppendLine("------------------------------");

            textBox_transferencia.Text = info.ToString();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
