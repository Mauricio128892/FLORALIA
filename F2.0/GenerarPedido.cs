using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using Tickets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class GenerarPedido : Form

    {
        private Dictionary<string, (string Nombre, int Puntos)> clientesRegistrados = new Dictionary<string, (string, int)>
        {
            { "0000374072", ("Andrés Heredia", 100) },
            { "0000370590", ("Diego Pérez", 700) },
            { "0000355338", ("Melvin Gutiérrez", 300) },
            { "0000359690", ("Mauricio Valladares", 300) },
            { "5", ("José Castillo", 300) }
        };

        private Dictionary<string, (string Telefono, string Domicilio)> datosContactoClientesRegistrados = new Dictionary<string, (string, string)>
        {
            { "0000374072", ("9818187377", "Minas") },
            { "0000370590", ("9811385171", "Jardines") },
            { "0000355338", ("9811267885", "Minas") },
            { "0000359690", ("9811014484", "Prueba") },
            { "5", ("9818056306", "Prueba") }
        };

        public GenerarPedido()
        {
            InitializeComponent();
            CultureInfo culturaMexicana = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culturaMexicana;
            Thread.CurrentThread.CurrentUICulture = culturaMexicana;
        }

        private void Generar_pedido_Load(object sender, EventArgs e)
        {
            label_infoProducto.Visible = false;
            listView_carritoCompra.View = View.Details;
            listView_carritoCompra.Columns.Add("Producto", 100);
            listView_carritoCompra.Columns.Add("Cantidad", 70);
            listView_carritoCompra.Columns.Add("Precio Unitario", 100);
            listView_carritoCompra.Columns.Add("Total", 100);

            textBox_nombreCliente.KeyPress += textBox_nombreCliente_KeyPress;
            textBox_apellidoCliente.KeyPress += textBox_apellidoCliente_KeyPress;
            textBox_telefono.KeyPress += textBox_telefono_KeyPress;

            dateTimePicker_fecha.MinDate = DateTime.Today;
            dateTimePicker_hora.Format = DateTimePickerFormat.Time;
            dateTimePicker_hora.ShowUpDown = true;
            dateTimePicker_hora.MinDate = DateTime.Today.AddHours(8);
            dateTimePicker_hora.MaxDate = DateTime.Today.AddHours(20);
            dateTimePicker_hora.ValueChanged += dateTimePicker_hora_ValueChanged;

            radioButton_pedidoDomicilio.Enabled = true;
            radioButton_pedidoDomicilio.Checked = false;
            textBox_domicilio.Enabled = false;
            radioButton_pagoPuntos.Enabled = false;
            button_ticketRepartidor.Enabled = false;

            comboBox_flores.Items.AddRange(new string[] { "Rosas", "Tulipanes", "Girasoles", "Lirios", "Orquídeas", "Arreglo de cumpleaños", "Arreglo para eventos", "Arreglo para bodas"});
            listView_carritoCompra.Dock = DockStyle.Fill;

            foreach (ColumnHeader columna in listView_carritoCompra.Columns)
            {
                columna.Width = -2;
            }
        }

        private string idTicketGlobal;

        private void AgregarCargoPorEnvio()
        {
            foreach (ListViewItem item in listView_carritoCompra.Items)
            {
                if (item.Text == "Cargo por envio")
                    return;
            }

            decimal precioEnvio = ObtenerPrecioFlor("Cargo por envio");

            ListViewItem cargoEnvio = new ListViewItem("Cargo por envio");
            cargoEnvio.SubItems.Add("1");
            cargoEnvio.SubItems.Add(precioEnvio.ToString("F2"));
            cargoEnvio.SubItems.Add(precioEnvio.ToString("F2"));

            listView_carritoCompra.Items.Add(cargoEnvio);
        }


        private void button_anadirCarrito_Click(object sender, EventArgs e)
        {
            if (comboBox_flores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una flor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreFlor = comboBox_flores.SelectedItem.ToString();
            int cantidad = (int)numericUpDown_flores.Value;
            decimal precioUnitario = ObtenerPrecioFlor(nombreFlor);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = cantidad * precioUnitario;

            ListViewItem item = new ListViewItem(nombreFlor);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(precioUnitario.ToString("C2"));
            item.SubItems.Add(total.ToString("C2"));

            listView_carritoCompra.Items.Add(item);
        }

        private void button_eliminarProducto_Click(object sender, EventArgs e)
        {
            if (listView_carritoCompra.SelectedItems.Count > 0)
            {
                listView_carritoCompra.Items.Remove(listView_carritoCompra.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularTotal()
        {
            decimal subtotal = 0;
            decimal IVA = 0.16m;
            decimal impuestosAdicionales = 0.05m;

            foreach (ListViewItem item in listView_carritoCompra.Items)
            {
                decimal totalItem = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);
                subtotal += totalItem;
            }

            decimal totalConImpuestos = subtotal + (subtotal * IVA) + (subtotal * impuestosAdicionales);
            textBox_pagoTotal.Text = totalConImpuestos.ToString("C2");

            MessageBox.Show($"Total con iva e impuestos: {totalConImpuestos:C2}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal ObtenerPrecioFlor(string nombreFlor)
        {
            var precios = new Dictionary<string, decimal>
            {
                { "Rosas", 20.00m },
                { "Tulipanes", 40.00m },
                { "Girasoles", 35.00m },
                { "Lirios", 25.00m },
                { "Orquídeas", 250.00m },
                { "Arreglo de cumpleaños", 1400.00m },
                { "Arreglo para eventos", 1900.00m},
                { "Arreglo para bodas", 1600.00m},
                { "Cargo por envio", 40.00m},
            };

            return precios.ContainsKey(nombreFlor) ? precios[nombreFlor] : 0;
        }

        private int ObtenerCantidadFlor(string nombreFlor)
        {
            var cantidades = new Dictionary<string, int>
            {
                { "Rosas", 20 },
                { "Tulipanes", 30 },
                { "Girasoles", 20 },
                { "Lirios", 25 },
                { "Orquídeas", 20 },
                { "Arreglo de cumpleaños", 15 },
                { "Arreglo para eventos", 15 },
                { "Arreglo para bodas", 15 },
                { "Cargo por envio", 1 }
            };

            return cantidades.ContainsKey(nombreFlor) ? cantidades[nombreFlor] : 0;
        }

        private void comboBox_flores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_flores.SelectedIndex != -1)
            {
                string florSeleccionada = comboBox_flores.SelectedItem.ToString();

                decimal precio = ObtenerPrecioFlor(florSeleccionada);
                int cantidad = ObtenerCantidadFlor(florSeleccionada);

                label_infoProducto.Text = $"Stock: {cantidad} - Precio: ${precio:F2}";
                label_infoProducto.Visible = true;

                numericUpDown_flores.Maximum = cantidad;
                numericUpDown_flores.Value = cantidad > 0 ? 1 : 0;

                if (cantidad == 0)
                {
                    MessageBox.Show($"No hay stock disponible para {florSeleccionada}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                label_infoProducto.Visible = false;
                numericUpDown_flores.Value = 0;
                numericUpDown_flores.Maximum = 0;
            }
        }

        private bool domicilioMarcado = false;
        private void radioButton_pedidoDomicilio_Click(object sender, EventArgs e)
        {
            domicilioMarcado = !domicilioMarcado;
            radioButton_pedidoDomicilio.Checked = domicilioMarcado;
        }

        private void radioButton_pedidoDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            textBox_domicilio.Enabled = radioButton_pedidoDomicilio.Checked;
            button_ticketRepartidor.Enabled = radioButton_pedidoDomicilio.Checked;

            if (radioButton_pedidoDomicilio.Checked)
            {
                string idCliente = textBox_idTarjeta.Text.Trim();

                if (!string.IsNullOrWhiteSpace(idCliente) && datosContactoClientesRegistrados.ContainsKey(idCliente))
                {
                    var (_, domicilio) = datosContactoClientesRegistrados[idCliente];
                    textBox_domicilio.Text = domicilio;
                }
                else
                {
                    textBox_domicilio.Clear();
                }

                AgregarCargoPorEnvio();
            }
            else
            {
                foreach (ListViewItem item in listView_carritoCompra.Items)
                {
                    if (item.Text == "Cargo por envio")
                    {
                        listView_carritoCompra.Items.Remove(item);
                        break;
                    }
                }
                textBox_domicilio.Clear();
            }
        }


        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            string idCliente = textBox_idTarjeta.Text.Trim();

            if (!string.IsNullOrWhiteSpace(idCliente) && clientesRegistrados.ContainsKey(idCliente))
            {
                radioButton_pagoPuntos.Enabled = true;
                LlenarDatosCliente(idCliente);
            }
            else
            {
                radioButton_pagoPuntos.Enabled = false;
                LimpiarCamposCliente();
            }
        }

        private void LlenarDatosCliente(string idCliente)
        {
            if (clientesRegistrados.TryGetValue(idCliente, out var cliente))
            {
                string[] nombreApellido = cliente.Nombre.Split(' ');

                textBox_nombreCliente.Text = nombreApellido[0];
                textBox_apellidoCliente.Text = nombreApellido.Length > 1 ? string.Join(" ", nombreApellido.Skip(1).ToArray()) : "";
            }

            if (datosContactoClientesRegistrados.ContainsKey(idCliente))
            {
                var (telefono, domicilio) = datosContactoClientesRegistrados[idCliente];
                textBox_telefono.Text = telefono;
            }

            if (textBox_domicilio.Enabled && datosContactoClientesRegistrados.ContainsKey(idCliente))
            {
                var (_, domicilio) = datosContactoClientesRegistrados[idCliente];
                textBox_domicilio.Text = domicilio;
            }
        }

        private void LimpiarCamposCliente()
        {
            textBox_nombreCliente.Clear();
            textBox_apellidoCliente.Clear();
            textBox_telefono.Clear();
            textBox_domicilio.Clear();
        }

        private bool ValidarClienteEnSistema(string idCliente)
        {
            return clientesRegistrados.ContainsKey(idCliente);
        }

        private int ObtenerPuntosCliente(string idCliente)
        {
            if (clientesRegistrados.TryGetValue(idCliente, out var cliente))
            {
                return cliente.Puntos;
            }
            return 0;
        }

        private void button_confirmarCliente_Click(object sender, EventArgs e)
        {
            string idCliente = textBox_idTarjeta.Text.Trim();
            string nombre = textBox_nombreCliente.Text.Trim();
            string apellido = textBox_apellidoCliente.Text.Trim();
            string telefono = textBox_telefono.Text.Trim();
            string domicilio = textBox_domicilio.Text.Trim();
            bool domicilioSeleccionado = radioButton_pedidoDomicilio.Checked;

            if (string.IsNullOrWhiteSpace(nombre) || !EsTextoValido(nombre))
            {
                MessageBox.Show("Por favor, ingresa un nombre válido (solo letras).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !EsTextoValido(apellido))
            {
                MessageBox.Show("Por favor, ingresa un apellido válido (solo letras).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono) || !EsTelefonoValido(telefono))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (7 a 10 dígitos).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton_pedidoDomicilio.Checked && string.IsNullOrWhiteSpace(domicilio) && !EsDomicilioValido(domicilio))
            {
                MessageBox.Show("Por favor, ingresa un domicilio válido. Se permiten letras, números y los caracteres: , . # -",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_domicilio.Focus();
                return;
            }

            bool clienteRegistrado = false;
            string nombreClienteRegistrado = "";
            int puntosCliente = 0;

            if (!string.IsNullOrWhiteSpace(idCliente))
            {
                if (clientesRegistrados.ContainsKey(idCliente))
                {
                    clienteRegistrado = true;
                    (nombreClienteRegistrado, puntosCliente) = clientesRegistrados[idCliente];

                    radioButton_pagoPuntos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El ID ingresado no está registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                radioButton_pagoPuntos.Enabled = false;
            }

            string mensaje = "";

            if (clienteRegistrado)
            {
                mensaje += $"ID Tarjeta: {idCliente}\n";
            }

            mensaje += $"Nombre: {nombre} {apellido}\n";

            mensaje += $"Teléfono: {telefono}\n";

            if (domicilioSeleccionado && !string.IsNullOrWhiteSpace(domicilio))
            {
                mensaje += $"Domicilio: {domicilio}\n";
            }
            else if (domicilioSeleccionado)
            {
                MessageBox.Show("Por favor, registre un domicilio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                mensaje += "Entrega a domicilio: No\n";
            }

            if (clienteRegistrado)
            {
                mensaje += $"Puntos acumulados: {puntosCliente}";
            }

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool EsTextoValido(string texto)
        {
            return texto.All(char.IsLetter);
        }

        private bool EsTelefonoValido(string telefono)
        {
            return telefono.All(char.IsDigit) && (telefono.Length >= 7 && telefono.Length <= 10);
        }

        private bool EsDomicilioValido(string domicilio)
        {
            string patron = @"^[A-Za-z0-9\s\.,#\-]+$";
            return Regex.IsMatch(domicilio, patron);
        }

        private void textBox_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_apellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_domicilioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '.' &&
                e.KeyChar != '#' &&
                e.KeyChar != '-' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool FechaHoraConfirmadas = false;

        private void button_confirmarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker_fecha.Value.Date;
            DateTime horaSeleccionada = dateTimePicker_hora.Value;

            if (fechaSeleccionada.DayOfWeek == DayOfWeek.Saturday || fechaSeleccionada.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("La fecha seleccionada no es válida. Solo se atiende de lunes a viernes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (horaSeleccionada.Hour < 8 || horaSeleccionada.Hour >= 20)
            {
                MessageBox.Show("La hora seleccionada no es válida. El horario de atención es de 8:00 AM a 8:00 PM.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Fecha y hora de entrega confirmadas:\n{fechaSeleccionada.ToShortDateString()} a las {horaSeleccionada.ToShortTimeString()}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker_hora_ValueChanged(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dateTimePicker_hora.Value;

            if (horaSeleccionada.Hour < 8)
            {
                dateTimePicker_hora.Value = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 8, 0, 0);
            }
            else if (horaSeleccionada.Hour >= 20)
            {
                dateTimePicker_hora.Value = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 19, 59, 0);
            }
        }

        private void button_confirmarFormaPago_Click(object sender, EventArgs e)
        {
            idTicketGlobal = GenerarIdTicketUnico();
            decimal totalPedido;

            if (!decimal.TryParse(textBox_pagoTotal.Text, System.Globalization.NumberStyles.Currency, null, out totalPedido) || totalPedido <= 0)
            {
                MessageBox.Show("Por favor, genera el total del pedido antes de confirmar la forma de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton_pagoEfectivo.Checked)
            {
                MessageBox.Show("Forma de pago confirmada: Efectivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (radioButton_pagoTarjeta.Checked)
            {
                MessageBox.Show("Forma de pago confirmada: Tarjeta. El pago se realizará mediante la terminal en tienda o del repartidor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (radioButton_pagoPuntos.Checked)
            {
                string idCliente = textBox_idTarjeta.Text.Trim();

                if (clientesRegistrados.ContainsKey(idCliente))
                {
                    int puntosCliente = clientesRegistrados[idCliente].Puntos;

                    if (puntosCliente >= totalPedido)
                    {
                        MessageBox.Show($"Se realizo el canjeo de puntos.\nTotal descontado: {totalPedido} puntos.\nPuntos restantes: {puntosCliente - (int)totalPedido}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes puntos para realizar esta compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no está registrado, no puede pagar con puntos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (radioButton_pagoTransferencia.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBox_pagoTotal.Text))
                {
                    MessageBox.Show("Por favor, genere el total a pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pagoTotal = textBox_pagoTotal.Text.Trim();

                TicketTransferencia ticketTrans = new TicketTransferencia(idTicketGlobal, pagoTotal);
                ticketTrans.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una forma de pago antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_ticketInterno_Click(object sender, EventArgs e)
        {
            if (listView_carritoCompra.Items.Count == 0)
            {
                MessageBox.Show("El carrito de compra está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Ticket_interno ticketForm = new Ticket_interno(listView_carritoCompra);
            ticketForm.ShowDialog();
        }

        private void button_ticketRepartidor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nombreCliente.Text) ||
                string.IsNullOrWhiteSpace(textBox_apellidoCliente.Text) ||
                string.IsNullOrWhiteSpace(textBox_domicilio.Text) ||
                string.IsNullOrWhiteSpace(textBox_pagoTotal.Text))
            {
                MessageBox.Show("Por favor, complete todos los datos del cliente y el total a pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView_carritoCompra.Items.Count == 0)
            {
                MessageBox.Show("El carrito de compra está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = textBox_nombreCliente.Text.Trim();
            string apellido = textBox_apellidoCliente.Text.Trim();
            string domicilio = textBox_domicilio.Text.Trim();
            string pagoTotal = textBox_pagoTotal.Text.Trim();

            DateTime fechaSeleccionada = dateTimePicker_fecha.Value.Date;
            DateTime horaSeleccionada = dateTimePicker_hora.Value;

            if (fechaSeleccionada.DayOfWeek == DayOfWeek.Saturday || fechaSeleccionada.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Las entregas solo están disponibles de lunes a viernes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan horaEntrega = horaSeleccionada.TimeOfDay;
            TimeSpan inicioPermitido = new TimeSpan(8, 0, 0);
            TimeSpan finPermitido = new TimeSpan(20, 0, 0);

            if (horaEntrega < inicioPermitido || horaEntrega > finPermitido)
            {
                MessageBox.Show("El horario de entrega debe ser entre 8:00 AM y 8:00 PM.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radioButton_pagoEfectivo.Checked &&
                !radioButton_pagoTarjeta.Checked &&
                !radioButton_pagoPuntos.Checked &&
                !radioButton_pagoTransferencia.Checked)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodoPago = "No especificado";
            if (radioButton_pagoEfectivo.Checked) metodoPago = "Efectivo";
            if (radioButton_pagoTarjeta.Checked) metodoPago = "Tarjeta";
            if (radioButton_pagoPuntos.Checked) metodoPago = "Puntos";
            if (radioButton_pagoTransferencia.Checked) metodoPago = "Transferencia";

            Ticket_repartidor ticketForm = new Ticket_repartidor(
                idTicketGlobal, nombre, apellido, domicilio, pagoTotal,
                fechaSeleccionada, horaSeleccionada,
                metodoPago, listView_carritoCompra);

            ticketForm.ShowDialog();
        }

        private Random random = new Random();
        private HashSet<string> idsGenerados = new HashSet<string>();

        private string GenerarIdTicketUnico()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string nuevoId;

            do
            {
                char[] id = new char[6];
                for (int i = 0; i < id.Length; i++)
                {
                    id[i] = caracteres[random.Next(caracteres.Length)];
                }
                nuevoId = new string(id);
            } while (idsGenerados.Contains(nuevoId));

            idsGenerados.Add(nuevoId);
            return nuevoId;
        }

        private void button_confirmarPedido_Click(object sender, EventArgs e)
        {
            if (listView_carritoCompra.Items.Count == 0)
            {
                MessageBox.Show("El carrito de compra está vacío. Agrega al menos un producto para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = textBox_idTarjeta.Text.Trim();
            string nombre = textBox_nombreCliente.Text.Trim();
            string apellido = textBox_apellidoCliente.Text.Trim();
            string telefono = textBox_telefono.Text.Trim();
            string domicilio = textBox_domicilio.Text.Trim();
            string pagoTotalTexto = textBox_pagoTotal.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || !EsTextoValido(nombre))
            {
                MessageBox.Show("Por favor, ingresa un nombre válido (solo letras).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !EsTextoValido(apellido))
            {
                MessageBox.Show("Por favor, ingresa un apellido válido (solo letras).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono) || !EsTelefonoValido(telefono))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (7 a 10 dígitos).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton_pedidoDomicilio.Checked && string.IsNullOrWhiteSpace(domicilio))
            {
                MessageBox.Show("Por favor, ingresa un domicilio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool esClienteRegistrado = clientesRegistrados.ContainsKey(idCliente);
            int puntosCliente = esClienteRegistrado ? clientesRegistrados[idCliente].Puntos : 0;

            DateTime fechaSeleccionada = dateTimePicker_fecha.Value.Date;
            DateTime horaSeleccionada = dateTimePicker_hora.Value;

            if (fechaSeleccionada.DayOfWeek == DayOfWeek.Saturday || fechaSeleccionada.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("La fecha seleccionada no es válida. Solo se atiende de lunes a viernes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (horaSeleccionada.Hour < 8 || horaSeleccionada.Hour >= 20)
            {
                MessageBox.Show("La hora seleccionada no es válida. El horario de atención es de 8:00 AM a 8:00 PM.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radioButton_pagoEfectivo.Checked && !radioButton_pagoTarjeta.Checked &&
                !radioButton_pagoTransferencia.Checked && !radioButton_pagoPuntos.Checked)
            {
                MessageBox.Show("Por favor, selecciona una forma de pago antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(pagoTotalTexto) || pagoTotalTexto == "$0.00")
            {
                MessageBox.Show("Por favor, genera el total del pedido antes de confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPedido = decimal.Parse(pagoTotalTexto, System.Globalization.NumberStyles.Currency);

            if (radioButton_pagoPuntos.Checked)
            {
                if (!esClienteRegistrado)
                {
                    MessageBox.Show("El cliente no está registrado, no puede pagar con puntos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (puntosCliente < totalPedido)
                {
                    MessageBox.Show($"No hay suficientes puntos. Puntos disponibles: {puntosCliente}, Total del pedido: {totalPedido}.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que quieres confirmar este pedido?",
                "Cuestionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                string formaPago = radioButton_pagoEfectivo.Checked ? "Efectivo" :
                                   radioButton_pagoTarjeta.Checked ? "Tarjeta" :
                                   radioButton_pagoTransferencia.Checked ? "Transferencia" : "Puntos";

                int puntosObtenidos = esClienteRegistrado ? (int)Math.Round(totalPedido * 0.03m, MidpointRounding.AwayFromZero) : 0;
                int puntosDespues = puntosCliente - (radioButton_pagoPuntos.Checked ? (int)totalPedido : 0);
                int puntosFinales = puntosDespues + puntosObtenidos;

                TicketPago ticketPagoForm = new TicketPago(
                    idTicketGlobal, nombre, apellido, telefono, domicilio,
                    fechaSeleccionada, horaSeleccionada,
                    formaPago, totalPedido,
                    puntosCliente, puntosObtenidos,
                    listView_carritoCompra);

                ticketPagoForm.ShowDialog();
            }

            if (confirmacion == DialogResult.No)
            {
                return;
            }   

                LimpiarCampos();
        }

        private void button_cancelarPedido_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que quieres cancelar el pedido?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
                MessageBox.Show("El pedido ha sido cancelado y todos los campos fueron limpiados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            listView_carritoCompra.Items.Clear();
            radioButton_pedidoDomicilio.Checked = false;
            textBox_idTarjeta.Clear();
            textBox_nombreCliente.Clear();
            textBox_apellidoCliente.Clear();
            textBox_telefono.Clear();
            textBox_domicilio.Clear();
            dateTimePicker_fecha.Value = DateTime.Today;
            dateTimePicker_hora.Value = DateTime.Today.AddHours(8);
            radioButton_pagoEfectivo.Checked = false;
            radioButton_pagoTarjeta.Checked = false;
            radioButton_pagoTransferencia.Checked = false;
            radioButton_pagoPuntos.Checked = false;
            textBox_pagoTotal.Text = "$0.00";
            comboBox_flores.SelectedIndex = -1;
            numericUpDown_flores.Value = 0;
        }

        private void button_generarTotal_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            decimal IVA = 0.16m;
            decimal impuestosAdicionales = 0.05m;

            foreach (ListViewItem item in listView_carritoCompra.Items)
            {
                decimal totalItem = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);
                subtotal += totalItem;
            }

            decimal totalConImpuestos = subtotal + (subtotal * IVA) + (subtotal * impuestosAdicionales);
            textBox_pagoTotal.Text = totalConImpuestos.ToString("C2");

            MessageBox.Show($"El pago total con IVA e impuestos es: {totalConImpuestos:C2} MXN", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox_retroceder_Click(object sender, EventArgs e)
        {

        }
    }
}
