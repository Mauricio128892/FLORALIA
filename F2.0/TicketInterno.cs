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
    public partial class Ticket_interno : Form
    {
        public Ticket_interno(ListView listViewCarritoCompra)
        {
            InitializeComponent();
            CultureInfo culturaMexicana = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culturaMexicana;
            Thread.CurrentThread.CurrentUICulture = culturaMexicana;
            ConfigurarListView();
            CargarTicket(listViewCarritoCompra);
        }

        private void ConfigurarListView()
        {
            listView_ticket.View = View.Details;
            listView_ticket.Columns.Clear();
            int width = listView_ticket.Width / 2;
            listView_ticket.Columns.Add("Producto", width);
            listView_ticket.Columns.Add("Cantidad", width);
        }

        private void CargarTicket(ListView listViewCarritoCompra)
        {
            listView_ticket.Items.Clear();

            foreach (ListViewItem item in listViewCarritoCompra.Items)
            {
                ListViewItem listViewItem = new ListViewItem(item.SubItems[0].Text);
                listViewItem.SubItems.Add(item.SubItems[1].Text);
                listView_ticket.Items.Add(listViewItem);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
