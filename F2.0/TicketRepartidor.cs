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
    public partial class Ticket_repartidor : Form
    {
        public Ticket_repartidor(
        string idTicket,string nombre, string apellido, string domicilio, string pagoTotal,
        DateTime fechaEntrega, DateTime horaEntrega,
        string metodoPago, ListView listViewCarritoCompra)
        {
            InitializeComponent();
            CultureInfo culturaMexicana = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culturaMexicana;
            Thread.CurrentThread.CurrentUICulture = culturaMexicana;
            ConfigurarTextBox();
            ConfigurarListView();
            GenerarTicket(idTicket, nombre, apellido, domicilio, pagoTotal, fechaEntrega, horaEntrega, metodoPago, listViewCarritoCompra);
        }

        private void ConfigurarTextBox()
        {
            textBox_ticket.Multiline = true;
            textBox_ticket.ReadOnly = true;
        }

        private void ConfigurarListView()
        {
            listView_ticket.View = View.Details;
            listView_ticket.Columns.Add("Producto", 150);
            listView_ticket.Columns.Add("Cantidad", 70);
        }

        private void GenerarTicket(
            string idTicket, string nombre, string apellido, string domicilio, string pagoTotal,
            DateTime fechaEntrega, DateTime horaEntrega,
            string metodoPago, ListView listViewCarritoCompra)
        {
            StringBuilder ticket = new StringBuilder();

            ticket.AppendLine("------------------------------");
            ticket.AppendLine($"ID Ticket: {idTicket}");
            ticket.AppendLine($"Cliente: {nombre} {apellido}");
            ticket.AppendLine($"Dirección: {domicilio}");
            ticket.AppendLine($"Fecha de entrega: {fechaEntrega:dd/MM/yyyy}");
            ticket.AppendLine($"Hora de entrega: {horaEntrega:hh:mm tt}\n");
            ticket.AppendLine($"Método de pago: {metodoPago}\n");
            ticket.AppendLine($"Total a pagar: {pagoTotal} MXN");
            
            ticket.AppendLine("------------------------------");

            textBox_ticket.Text = ticket.ToString();

            foreach (ListViewItem item in listViewCarritoCompra.Items)
            {
                ListViewItem newItem = new ListViewItem(item.SubItems[0].Text);
                newItem.SubItems.Add(item.SubItems[1].Text);
                listView_ticket.Items.Add(newItem);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
