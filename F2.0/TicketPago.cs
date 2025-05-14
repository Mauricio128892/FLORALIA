using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class TicketPago : Form
    {
        private decimal subtotal;
        private int puntosRestantes;
        private int puntosDespues;
        private string idTicket_global;
        private string nombreCompleto;
        private string telefono_global;
        private string domicilio_global;
        private DateTime fechaEntrega_global;
        private DateTime horaEntrega_global;
        private string metodoPago_global;
        private decimal pagoTotal_global;
        private int puntosAntes_global;
        private int puntosObtenidos_global;

        public TicketPago(
        string idTicket,
        string nombre, string apellido, string telefono, string domicilio,
        DateTime fechaEntrega, DateTime horaEntrega, string metodoPago,
        decimal pagoTotal, int puntosAntes, int puntosObtenidos, ListView listViewCarritoCompra)
        {
            InitializeComponent();
            CultureInfo culturaMexicana = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culturaMexicana;
            Thread.CurrentThread.CurrentUICulture = culturaMexicana;
            ConfigurarTextBox();
            ConfigurarListView();
            GenerarTicket(idTicket, nombre, apellido, telefono, domicilio, fechaEntrega, horaEntrega, metodoPago, pagoTotal, puntosAntes, puntosObtenidos, listViewCarritoCompra);
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
            listView_ticket.Columns.Add("Precio Unitario", 100);
            listView_ticket.Columns.Add("Total", 100);
        }

        private void GenerarTicket(
        string idTicket,
        string nombre, string apellido, string telefono, string domicilio,
        DateTime fechaEntrega, DateTime horaEntrega, string metodoPago,
        decimal pagoTotal, int puntosAntes, int puntosObtenidos, ListView listViewCarritoCompra)
        {
            StringBuilder ticket = new StringBuilder();

            int puntosRestantes = puntosAntes - (metodoPago == "Puntos" ? (int)pagoTotal : 0);
            int puntosDespues = puntosRestantes + puntosObtenidos;

            decimal subtotal = pagoTotal / 1.21m;
            decimal IVA = subtotal * 0.16m;
            decimal impuestosAdicionales = subtotal * 0.05m;

            // Guardar en variables globales para usar en la base de datos
            idTicket_global = idTicket;
            nombreCompleto = nombre + " " + apellido;
            telefono_global = telefono;
            domicilio_global = domicilio;
            fechaEntrega_global = fechaEntrega;
            horaEntrega_global = horaEntrega;
            metodoPago_global = metodoPago;
            pagoTotal_global = pagoTotal;
            puntosAntes_global = puntosAntes;
            puntosObtenidos_global = puntosObtenidos;

            ticket.AppendLine("------------------------------");
            ticket.AppendLine($"ID Ticket: {idTicket}");
            ticket.AppendLine($"Cliente: {nombre} {apellido}");
            ticket.AppendLine($"Teléfono: {telefono}");
            ticket.AppendLine($"Dirección: {domicilio}");
            ticket.AppendLine($"Fecha de entrega: {fechaEntrega:dd/MM/yyyy}");
            ticket.AppendLine($"Hora de entrega: {horaEntrega:hh:mm tt}");
            ticket.AppendLine($"Método de pago: {metodoPago}");
            ticket.AppendLine($"Subtotal: {subtotal:C2} MXN");
            ticket.AppendLine($"IVA (16%): {IVA:C2} MXN");
            ticket.AppendLine($"Impuestos adicionales (5%): {impuestosAdicionales:C2} MXN");
            ticket.AppendLine($"Total a pagar: {pagoTotal:C2} MXN");
            ticket.AppendLine($"Puntos antes del pago: {puntosAntes}");
            ticket.AppendLine($"Puntos restantes: {puntosRestantes}\n");
            ticket.AppendLine($"Total de puntos obtenidos: {puntosObtenidos}");
            ticket.AppendLine($"Total de puntos después de la compra: {puntosDespues}");
            ticket.AppendLine("------------------------------");

            textBox_ticket.Text = ticket.ToString();

            foreach (ListViewItem item in listViewCarritoCompra.Items)
            {
                ListViewItem newItem = new ListViewItem(item.SubItems[0].Text);
                newItem.SubItems.Add(item.SubItems[1].Text);
                newItem.SubItems.Add(item.SubItems[2].Text);
                newItem.SubItems.Add(item.SubItems[3].Text);
                listView_ticket.Items.Add(newItem);
            }
        }

        private void GuardarEnBaseDeDatos()
        {
            string conexionString = "Data Source=MAURICIO;Initial Catalog=LoginFloraria;Integrated Security=True";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Insertar en tabla HPedidos
                    string queryPedido = @"
                    INSERT INTO HPedidos 
                    (IdTicket, Nombre, Telefono, Domicilio, FechaEntrega, HoraEntrega, MetodoPago, Subtotal, PagoTotal, PuntosAntes, PuntosRestantes, PuntosObtenidos, PuntosDespues)
                    VALUES 
                    (@IdTicket, @Nombre, @Telefono, @Domicilio, @FechaEntrega, @HoraEntrega, @MetodoPago, @Subtotal, @PagoTotal, @PuntosAntes, @PuntosRestantes, @PuntosObtenidos, @PuntosDespues);
                    SELECT SCOPE_IDENTITY();";

                    int idPedidoGenerado;

                    using (SqlCommand cmd = new SqlCommand(queryPedido, conexion, transaccion))
                    {
                        subtotal = pagoTotal_global / 1.21m;
                        puntosRestantes = puntosAntes_global - (metodoPago_global == "Puntos" ? (int)pagoTotal_global : 0);
                        puntosDespues = puntosRestantes + puntosObtenidos_global;

                        // Conversión explícita de todos los campos a string
                        cmd.Parameters.AddWithValue("@IdTicket", idTicket_global); // Es string (nvarchar(MAX))
                        cmd.Parameters.AddWithValue("@Nombre", nombreCompleto);    // string
                        cmd.Parameters.AddWithValue("@Telefono", telefono_global); // string
                        cmd.Parameters.AddWithValue("@Domicilio", domicilio_global); // string
                        cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega_global.ToString("yyyy-MM-dd")); // string (nvarchar)
                        cmd.Parameters.AddWithValue("@HoraEntrega", horaEntrega_global.ToString("HH:mm:ss"));     // string (varchar)
                        cmd.Parameters.AddWithValue("@MetodoPago", metodoPago_global);  // string
                        cmd.Parameters.AddWithValue("@Subtotal", subtotal.ToString());  // convertir decimal a string
                        cmd.Parameters.AddWithValue("@PagoTotal", pagoTotal_global.ToString()); // convertir decimal a string
                        cmd.Parameters.AddWithValue("@PuntosAntes", puntosAntes_global.ToString()); // int a string
                        cmd.Parameters.AddWithValue("@PuntosRestantes", puntosRestantes.ToString()); // int a string
                        cmd.Parameters.AddWithValue("@PuntosObtenidos", puntosObtenidos_global.ToString()); // int a string
                        cmd.Parameters.AddWithValue("@PuntosDespues", puntosDespues); // int

                        idPedidoGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insertar productos relacionados en tabla HProductos
                    foreach (ListViewItem item in listView_ticket.Items)
                    {
                        string producto = item.SubItems[0].Text;
                        string cantidad = item.SubItems[1].Text;
                        string precio = item.SubItems[2].Text;
                        string total = item.SubItems[3].Text;

                        string queryProducto = @"
                        INSERT INTO HProductos 
                        (IdPedidos, Producto, Cantidad, Precio, Total)
                        VALUES
                        (@IdPedidos, @Producto, @Cantidad, @Precio, @Total)";

                        using (SqlCommand cmd = new SqlCommand(queryProducto, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@IdPedidos", idPedidoGenerado);
                            cmd.Parameters.AddWithValue("@Producto", producto);
                            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@Precio", precio);
                            cmd.Parameters.AddWithValue("@Total", total);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                    MessageBox.Show("Pedido guardado exitosamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al guardar el pedido: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            GuardarEnBaseDeDatos();
            this.Close();
        }
    }
}