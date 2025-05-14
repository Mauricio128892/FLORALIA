namespace WindowsFormsApp1
{
    partial class GenerarPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_seleccionFlores = new System.Windows.Forms.GroupBox();
            this.label_infoProducto = new System.Windows.Forms.Label();
            this.comboBox_flores = new System.Windows.Forms.ComboBox();
            this.button_anadirCarrito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_flores = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_carritoCompra = new System.Windows.Forms.ListView();
            this.groupBox_datosCliente = new System.Windows.Forms.GroupBox();
            this.textBox_domicilio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_confirmarCliente = new System.Windows.Forms.Button();
            this.textBox_idTarjeta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton_pedidoDomicilio = new System.Windows.Forms.RadioButton();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_apellidoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox_carritoCompra = new System.Windows.Forms.GroupBox();
            this.button_eliminarProducto = new System.Windows.Forms.Button();
            this.button_ticketInterno = new System.Windows.Forms.Button();
            this.groupBox_tiempoEntrega = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_confirmarFecha = new System.Windows.Forms.Button();
            this.dateTimePicker_hora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox_formaPago = new System.Windows.Forms.GroupBox();
            this.radioButton_pagoTransferencia = new System.Windows.Forms.RadioButton();
            this.radioButton_pagoPuntos = new System.Windows.Forms.RadioButton();
            this.button_confirmarFormaPago = new System.Windows.Forms.Button();
            this.radioButton_pagoTarjeta = new System.Windows.Forms.RadioButton();
            this.radioButton_pagoEfectivo = new System.Windows.Forms.RadioButton();
            this.groupBox_pagoTotal = new System.Windows.Forms.GroupBox();
            this.button_cancelarPedido = new System.Windows.Forms.Button();
            this.button_confirmarPedido = new System.Windows.Forms.Button();
            this.button_generarTotal = new System.Windows.Forms.Button();
            this.textBox_pagoTotal = new System.Windows.Forms.TextBox();
            this.groupBox_tipoTicket = new System.Windows.Forms.GroupBox();
            this.button_ticketRepartidor = new System.Windows.Forms.Button();
            this.groupBox_seleccionFlores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flores)).BeginInit();
            this.groupBox_datosCliente.SuspendLayout();
            this.groupBox_carritoCompra.SuspendLayout();
            this.groupBox_tiempoEntrega.SuspendLayout();
            this.groupBox_formaPago.SuspendLayout();
            this.groupBox_pagoTotal.SuspendLayout();
            this.groupBox_tipoTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar Pedido";
            // 
            // groupBox_seleccionFlores
            // 
            this.groupBox_seleccionFlores.Controls.Add(this.label_infoProducto);
            this.groupBox_seleccionFlores.Controls.Add(this.comboBox_flores);
            this.groupBox_seleccionFlores.Controls.Add(this.button_anadirCarrito);
            this.groupBox_seleccionFlores.Controls.Add(this.label3);
            this.groupBox_seleccionFlores.Controls.Add(this.numericUpDown_flores);
            this.groupBox_seleccionFlores.Controls.Add(this.label2);
            this.groupBox_seleccionFlores.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_seleccionFlores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_seleccionFlores.Location = new System.Drawing.Point(12, 66);
            this.groupBox_seleccionFlores.Name = "groupBox_seleccionFlores";
            this.groupBox_seleccionFlores.Size = new System.Drawing.Size(753, 92);
            this.groupBox_seleccionFlores.TabIndex = 1;
            this.groupBox_seleccionFlores.TabStop = false;
            this.groupBox_seleccionFlores.Text = "Selección de productos";
            // 
            // label_infoProducto
            // 
            this.label_infoProducto.AutoSize = true;
            this.label_infoProducto.BackColor = System.Drawing.Color.Transparent;
            this.label_infoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_infoProducto.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoProducto.Location = new System.Drawing.Point(148, 52);
            this.label_infoProducto.Name = "label_infoProducto";
            this.label_infoProducto.Size = new System.Drawing.Size(51, 21);
            this.label_infoProducto.TabIndex = 6;
            this.label_infoProducto.Text = "label";
            // 
            // comboBox_flores
            // 
            this.comboBox_flores.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_flores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_flores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_flores.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_flores.FormattingEnabled = true;
            this.comboBox_flores.Location = new System.Drawing.Point(10, 47);
            this.comboBox_flores.Name = "comboBox_flores";
            this.comboBox_flores.Size = new System.Drawing.Size(132, 29);
            this.comboBox_flores.TabIndex = 5;
            this.comboBox_flores.TabStop = false;
            this.comboBox_flores.SelectedIndexChanged += new System.EventHandler(this.comboBox_flores_SelectedIndexChanged);
            // 
            // button_anadirCarrito
            // 
            this.button_anadirCarrito.BackColor = System.Drawing.Color.LightPink;
            this.button_anadirCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_anadirCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anadirCarrito.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_anadirCarrito.Location = new System.Drawing.Point(557, 48);
            this.button_anadirCarrito.Name = "button_anadirCarrito";
            this.button_anadirCarrito.Size = new System.Drawing.Size(165, 28);
            this.button_anadirCarrito.TabIndex = 4;
            this.button_anadirCarrito.TabStop = false;
            this.button_anadirCarrito.Text = "Añadir al carrito";
            this.button_anadirCarrito.UseVisualStyleBackColor = false;
            this.button_anadirCarrito.Click += new System.EventHandler(this.button_anadirCarrito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // numericUpDown_flores
            // 
            this.numericUpDown_flores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_flores.Location = new System.Drawing.Point(405, 48);
            this.numericUpDown_flores.Name = "numericUpDown_flores";
            this.numericUpDown_flores.Size = new System.Drawing.Size(88, 28);
            this.numericUpDown_flores.TabIndex = 2;
            this.numericUpDown_flores.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selección de flores";
            // 
            // listView_carritoCompra
            // 
            this.listView_carritoCompra.HideSelection = false;
            this.listView_carritoCompra.Location = new System.Drawing.Point(14, 21);
            this.listView_carritoCompra.Name = "listView_carritoCompra";
            this.listView_carritoCompra.Size = new System.Drawing.Size(476, 204);
            this.listView_carritoCompra.TabIndex = 0;
            this.listView_carritoCompra.TabStop = false;
            this.listView_carritoCompra.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox_datosCliente
            // 
            this.groupBox_datosCliente.Controls.Add(this.textBox_domicilio);
            this.groupBox_datosCliente.Controls.Add(this.label10);
            this.groupBox_datosCliente.Controls.Add(this.button_confirmarCliente);
            this.groupBox_datosCliente.Controls.Add(this.textBox_idTarjeta);
            this.groupBox_datosCliente.Controls.Add(this.label9);
            this.groupBox_datosCliente.Controls.Add(this.radioButton_pedidoDomicilio);
            this.groupBox_datosCliente.Controls.Add(this.textBox_telefono);
            this.groupBox_datosCliente.Controls.Add(this.label8);
            this.groupBox_datosCliente.Controls.Add(this.textBox_apellidoCliente);
            this.groupBox_datosCliente.Controls.Add(this.label5);
            this.groupBox_datosCliente.Controls.Add(this.label4);
            this.groupBox_datosCliente.Controls.Add(this.textBox_nombreCliente);
            this.groupBox_datosCliente.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datosCliente.Location = new System.Drawing.Point(12, 164);
            this.groupBox_datosCliente.Name = "groupBox_datosCliente";
            this.groupBox_datosCliente.Size = new System.Drawing.Size(241, 277);
            this.groupBox_datosCliente.TabIndex = 2;
            this.groupBox_datosCliente.TabStop = false;
            this.groupBox_datosCliente.Text = "Datos del cliente";
            // 
            // textBox_domicilio
            // 
            this.textBox_domicilio.Location = new System.Drawing.Point(108, 177);
            this.textBox_domicilio.Name = "textBox_domicilio";
            this.textBox_domicilio.Size = new System.Drawing.Size(114, 28);
            this.textBox_domicilio.TabIndex = 12;
            this.textBox_domicilio.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Domicilio";
            // 
            // button_confirmarCliente
            // 
            this.button_confirmarCliente.BackColor = System.Drawing.Color.LightPink;
            this.button_confirmarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirmarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmarCliente.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmarCliente.Location = new System.Drawing.Point(108, 221);
            this.button_confirmarCliente.Name = "button_confirmarCliente";
            this.button_confirmarCliente.Size = new System.Drawing.Size(114, 29);
            this.button_confirmarCliente.TabIndex = 6;
            this.button_confirmarCliente.TabStop = false;
            this.button_confirmarCliente.Text = "Confirmar";
            this.button_confirmarCliente.UseVisualStyleBackColor = false;
            this.button_confirmarCliente.Click += new System.EventHandler(this.button_confirmarCliente_Click);
            // 
            // textBox_idTarjeta
            // 
            this.textBox_idTarjeta.Location = new System.Drawing.Point(108, 57);
            this.textBox_idTarjeta.Name = "textBox_idTarjeta";
            this.textBox_idTarjeta.Size = new System.Drawing.Size(114, 28);
            this.textBox_idTarjeta.TabIndex = 10;
            this.textBox_idTarjeta.TabStop = false;
            this.textBox_idTarjeta.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "ID Tarjeta";
            // 
            // radioButton_pedidoDomicilio
            // 
            this.radioButton_pedidoDomicilio.AutoSize = true;
            this.radioButton_pedidoDomicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pedidoDomicilio.Location = new System.Drawing.Point(0, 24);
            this.radioButton_pedidoDomicilio.Name = "radioButton_pedidoDomicilio";
            this.radioButton_pedidoDomicilio.Size = new System.Drawing.Size(236, 25);
            this.radioButton_pedidoDomicilio.TabIndex = 5;
            this.radioButton_pedidoDomicilio.Text = "El pedido es a domicilio?";
            this.radioButton_pedidoDomicilio.UseVisualStyleBackColor = true;
            this.radioButton_pedidoDomicilio.CheckedChanged += new System.EventHandler(this.radioButton_pedidoDomicilio_CheckedChanged);
            this.radioButton_pedidoDomicilio.Click += new System.EventHandler(this.radioButton_pedidoDomicilio_Click);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(108, 146);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(114, 28);
            this.textBox_telefono.TabIndex = 8;
            this.textBox_telefono.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tel";
            // 
            // textBox_apellidoCliente
            // 
            this.textBox_apellidoCliente.Location = new System.Drawing.Point(108, 117);
            this.textBox_apellidoCliente.Name = "textBox_apellidoCliente";
            this.textBox_apellidoCliente.Size = new System.Drawing.Size(114, 28);
            this.textBox_apellidoCliente.TabIndex = 5;
            this.textBox_apellidoCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // textBox_nombreCliente
            // 
            this.textBox_nombreCliente.Location = new System.Drawing.Point(108, 88);
            this.textBox_nombreCliente.Name = "textBox_nombreCliente";
            this.textBox_nombreCliente.Size = new System.Drawing.Size(114, 28);
            this.textBox_nombreCliente.TabIndex = 0;
            this.textBox_nombreCliente.TabStop = false;
            // 
            // groupBox_carritoCompra
            // 
            this.groupBox_carritoCompra.Controls.Add(this.button_eliminarProducto);
            this.groupBox_carritoCompra.Controls.Add(this.listView_carritoCompra);
            this.groupBox_carritoCompra.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_carritoCompra.Location = new System.Drawing.Point(275, 167);
            this.groupBox_carritoCompra.Name = "groupBox_carritoCompra";
            this.groupBox_carritoCompra.Size = new System.Drawing.Size(490, 274);
            this.groupBox_carritoCompra.TabIndex = 3;
            this.groupBox_carritoCompra.TabStop = false;
            this.groupBox_carritoCompra.Text = "Carrito de compra";
            // 
            // button_eliminarProducto
            // 
            this.button_eliminarProducto.BackColor = System.Drawing.Color.LightPink;
            this.button_eliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminarProducto.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminarProducto.Location = new System.Drawing.Point(319, 231);
            this.button_eliminarProducto.Name = "button_eliminarProducto";
            this.button_eliminarProducto.Size = new System.Drawing.Size(165, 29);
            this.button_eliminarProducto.TabIndex = 1;
            this.button_eliminarProducto.TabStop = false;
            this.button_eliminarProducto.Text = "Eliminar producto";
            this.button_eliminarProducto.UseVisualStyleBackColor = false;
            this.button_eliminarProducto.Click += new System.EventHandler(this.button_eliminarProducto_Click);
            // 
            // button_ticketInterno
            // 
            this.button_ticketInterno.BackColor = System.Drawing.Color.LightPink;
            this.button_ticketInterno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ticketInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ticketInterno.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ticketInterno.Location = new System.Drawing.Point(14, 24);
            this.button_ticketInterno.Name = "button_ticketInterno";
            this.button_ticketInterno.Size = new System.Drawing.Size(165, 29);
            this.button_ticketInterno.TabIndex = 4;
            this.button_ticketInterno.TabStop = false;
            this.button_ticketInterno.Text = "Ticket interno";
            this.button_ticketInterno.UseVisualStyleBackColor = false;
            this.button_ticketInterno.Click += new System.EventHandler(this.button_ticketInterno_Click);
            // 
            // groupBox_tiempoEntrega
            // 
            this.groupBox_tiempoEntrega.Controls.Add(this.label7);
            this.groupBox_tiempoEntrega.Controls.Add(this.label6);
            this.groupBox_tiempoEntrega.Controls.Add(this.button_confirmarFecha);
            this.groupBox_tiempoEntrega.Controls.Add(this.dateTimePicker_hora);
            this.groupBox_tiempoEntrega.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox_tiempoEntrega.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tiempoEntrega.Location = new System.Drawing.Point(12, 447);
            this.groupBox_tiempoEntrega.Name = "groupBox_tiempoEntrega";
            this.groupBox_tiempoEntrega.Size = new System.Drawing.Size(241, 166);
            this.groupBox_tiempoEntrega.TabIndex = 4;
            this.groupBox_tiempoEntrega.TabStop = false;
            this.groupBox_tiempoEntrega.Text = "Tiempo de entrega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha";
            // 
            // button_confirmarFecha
            // 
            this.button_confirmarFecha.BackColor = System.Drawing.Color.LightPink;
            this.button_confirmarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirmarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmarFecha.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmarFecha.Location = new System.Drawing.Point(108, 101);
            this.button_confirmarFecha.Name = "button_confirmarFecha";
            this.button_confirmarFecha.Size = new System.Drawing.Size(114, 29);
            this.button_confirmarFecha.TabIndex = 2;
            this.button_confirmarFecha.TabStop = false;
            this.button_confirmarFecha.Text = "Confirmar";
            this.button_confirmarFecha.UseVisualStyleBackColor = false;
            this.button_confirmarFecha.Click += new System.EventHandler(this.button_confirmarFecha_Click);
            // 
            // dateTimePicker_hora
            // 
            this.dateTimePicker_hora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_hora.Location = new System.Drawing.Point(108, 66);
            this.dateTimePicker_hora.Name = "dateTimePicker_hora";
            this.dateTimePicker_hora.ShowUpDown = true;
            this.dateTimePicker_hora.Size = new System.Drawing.Size(114, 28);
            this.dateTimePicker_hora.TabIndex = 1;
            this.dateTimePicker_hora.TabStop = false;
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(108, 33);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(114, 28);
            this.dateTimePicker_fecha.TabIndex = 0;
            this.dateTimePicker_fecha.TabStop = false;
            // 
            // groupBox_formaPago
            // 
            this.groupBox_formaPago.Controls.Add(this.radioButton_pagoTransferencia);
            this.groupBox_formaPago.Controls.Add(this.radioButton_pagoPuntos);
            this.groupBox_formaPago.Controls.Add(this.button_confirmarFormaPago);
            this.groupBox_formaPago.Controls.Add(this.radioButton_pagoTarjeta);
            this.groupBox_formaPago.Controls.Add(this.radioButton_pagoEfectivo);
            this.groupBox_formaPago.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_formaPago.Location = new System.Drawing.Point(275, 447);
            this.groupBox_formaPago.Name = "groupBox_formaPago";
            this.groupBox_formaPago.Size = new System.Drawing.Size(490, 94);
            this.groupBox_formaPago.TabIndex = 5;
            this.groupBox_formaPago.TabStop = false;
            this.groupBox_formaPago.Text = "Formas de pago";
            // 
            // radioButton_pagoTransferencia
            // 
            this.radioButton_pagoTransferencia.AutoSize = true;
            this.radioButton_pagoTransferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pagoTransferencia.Location = new System.Drawing.Point(111, 26);
            this.radioButton_pagoTransferencia.Name = "radioButton_pagoTransferencia";
            this.radioButton_pagoTransferencia.Size = new System.Drawing.Size(141, 25);
            this.radioButton_pagoTransferencia.TabIndex = 5;
            this.radioButton_pagoTransferencia.Text = "Transferencia";
            this.radioButton_pagoTransferencia.UseVisualStyleBackColor = true;
            // 
            // radioButton_pagoPuntos
            // 
            this.radioButton_pagoPuntos.AutoSize = true;
            this.radioButton_pagoPuntos.BackColor = System.Drawing.Color.LavenderBlush;
            this.radioButton_pagoPuntos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pagoPuntos.Location = new System.Drawing.Point(111, 54);
            this.radioButton_pagoPuntos.Name = "radioButton_pagoPuntos";
            this.radioButton_pagoPuntos.Size = new System.Drawing.Size(86, 25);
            this.radioButton_pagoPuntos.TabIndex = 4;
            this.radioButton_pagoPuntos.Text = "Puntos";
            this.radioButton_pagoPuntos.UseVisualStyleBackColor = false;
            // 
            // button_confirmarFormaPago
            // 
            this.button_confirmarFormaPago.BackColor = System.Drawing.Color.LightPink;
            this.button_confirmarFormaPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirmarFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmarFormaPago.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmarFormaPago.Location = new System.Drawing.Point(341, 50);
            this.button_confirmarFormaPago.Name = "button_confirmarFormaPago";
            this.button_confirmarFormaPago.Size = new System.Drawing.Size(143, 29);
            this.button_confirmarFormaPago.TabIndex = 3;
            this.button_confirmarFormaPago.TabStop = false;
            this.button_confirmarFormaPago.Text = "Confirmar";
            this.button_confirmarFormaPago.UseVisualStyleBackColor = false;
            this.button_confirmarFormaPago.Click += new System.EventHandler(this.button_confirmarFormaPago_Click);
            // 
            // radioButton_pagoTarjeta
            // 
            this.radioButton_pagoTarjeta.AutoSize = true;
            this.radioButton_pagoTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pagoTarjeta.Location = new System.Drawing.Point(6, 54);
            this.radioButton_pagoTarjeta.Name = "radioButton_pagoTarjeta";
            this.radioButton_pagoTarjeta.Size = new System.Drawing.Size(89, 25);
            this.radioButton_pagoTarjeta.TabIndex = 2;
            this.radioButton_pagoTarjeta.Text = "Tarjeta";
            this.radioButton_pagoTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButton_pagoEfectivo
            // 
            this.radioButton_pagoEfectivo.AutoSize = true;
            this.radioButton_pagoEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pagoEfectivo.Location = new System.Drawing.Point(6, 26);
            this.radioButton_pagoEfectivo.Name = "radioButton_pagoEfectivo";
            this.radioButton_pagoEfectivo.Size = new System.Drawing.Size(99, 25);
            this.radioButton_pagoEfectivo.TabIndex = 0;
            this.radioButton_pagoEfectivo.Text = "Efectivo";
            this.radioButton_pagoEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox_pagoTotal
            // 
            this.groupBox_pagoTotal.Controls.Add(this.button_cancelarPedido);
            this.groupBox_pagoTotal.Controls.Add(this.button_confirmarPedido);
            this.groupBox_pagoTotal.Controls.Add(this.button_generarTotal);
            this.groupBox_pagoTotal.Controls.Add(this.textBox_pagoTotal);
            this.groupBox_pagoTotal.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pagoTotal.Location = new System.Drawing.Point(12, 619);
            this.groupBox_pagoTotal.Name = "groupBox_pagoTotal";
            this.groupBox_pagoTotal.Size = new System.Drawing.Size(753, 67);
            this.groupBox_pagoTotal.TabIndex = 6;
            this.groupBox_pagoTotal.TabStop = false;
            this.groupBox_pagoTotal.Text = "Total a pagar";
            // 
            // button_cancelarPedido
            // 
            this.button_cancelarPedido.BackColor = System.Drawing.Color.Plum;
            this.button_cancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelarPedido.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelarPedido.Location = new System.Drawing.Point(604, 24);
            this.button_cancelarPedido.Name = "button_cancelarPedido";
            this.button_cancelarPedido.Size = new System.Drawing.Size(143, 30);
            this.button_cancelarPedido.TabIndex = 3;
            this.button_cancelarPedido.TabStop = false;
            this.button_cancelarPedido.Text = "Cancelar";
            this.button_cancelarPedido.UseVisualStyleBackColor = false;
            this.button_cancelarPedido.Click += new System.EventHandler(this.button_cancelarPedido_Click_1);
            // 
            // button_confirmarPedido
            // 
            this.button_confirmarPedido.BackColor = System.Drawing.Color.Gainsboro;
            this.button_confirmarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmarPedido.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmarPedido.Location = new System.Drawing.Point(422, 25);
            this.button_confirmarPedido.Name = "button_confirmarPedido";
            this.button_confirmarPedido.Size = new System.Drawing.Size(149, 28);
            this.button_confirmarPedido.TabIndex = 2;
            this.button_confirmarPedido.TabStop = false;
            this.button_confirmarPedido.Text = "Confirmar pedido";
            this.button_confirmarPedido.UseVisualStyleBackColor = false;
            this.button_confirmarPedido.Click += new System.EventHandler(this.button_confirmarPedido_Click);
            // 
            // button_generarTotal
            // 
            this.button_generarTotal.BackColor = System.Drawing.Color.LightPink;
            this.button_generarTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_generarTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generarTotal.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generarTotal.Location = new System.Drawing.Point(168, 24);
            this.button_generarTotal.Name = "button_generarTotal";
            this.button_generarTotal.Size = new System.Drawing.Size(152, 28);
            this.button_generarTotal.TabIndex = 1;
            this.button_generarTotal.TabStop = false;
            this.button_generarTotal.Text = "Generar total";
            this.button_generarTotal.UseVisualStyleBackColor = false;
            this.button_generarTotal.Click += new System.EventHandler(this.button_generarTotal_Click);
            // 
            // textBox_pagoTotal
            // 
            this.textBox_pagoTotal.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_pagoTotal.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pagoTotal.Location = new System.Drawing.Point(10, 26);
            this.textBox_pagoTotal.Name = "textBox_pagoTotal";
            this.textBox_pagoTotal.ReadOnly = true;
            this.textBox_pagoTotal.Size = new System.Drawing.Size(115, 28);
            this.textBox_pagoTotal.TabIndex = 0;
            this.textBox_pagoTotal.TabStop = false;
            this.textBox_pagoTotal.Text = "$0.00";
            // 
            // groupBox_tipoTicket
            // 
            this.groupBox_tipoTicket.Controls.Add(this.button_ticketRepartidor);
            this.groupBox_tipoTicket.Controls.Add(this.button_ticketInterno);
            this.groupBox_tipoTicket.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoTicket.Location = new System.Drawing.Point(275, 547);
            this.groupBox_tipoTicket.Name = "groupBox_tipoTicket";
            this.groupBox_tipoTicket.Size = new System.Drawing.Size(490, 66);
            this.groupBox_tipoTicket.TabIndex = 7;
            this.groupBox_tipoTicket.TabStop = false;
            this.groupBox_tipoTicket.Text = "Tipos de ticket";
            // 
            // button_ticketRepartidor
            // 
            this.button_ticketRepartidor.BackColor = System.Drawing.Color.LightPink;
            this.button_ticketRepartidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ticketRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ticketRepartidor.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ticketRepartidor.Location = new System.Drawing.Point(319, 24);
            this.button_ticketRepartidor.Name = "button_ticketRepartidor";
            this.button_ticketRepartidor.Size = new System.Drawing.Size(165, 29);
            this.button_ticketRepartidor.TabIndex = 5;
            this.button_ticketRepartidor.TabStop = false;
            this.button_ticketRepartidor.Text = "Ticket repartidor";
            this.button_ticketRepartidor.UseVisualStyleBackColor = false;
            this.button_ticketRepartidor.Click += new System.EventHandler(this.button_ticketRepartidor_Click);
            // 
            // GenerarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(774, 699);
            this.Controls.Add(this.groupBox_tipoTicket);
            this.Controls.Add(this.groupBox_pagoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_formaPago);
            this.Controls.Add(this.groupBox_tiempoEntrega);
            this.Controls.Add(this.groupBox_carritoCompra);
            this.Controls.Add(this.groupBox_datosCliente);
            this.Controls.Add(this.groupBox_seleccionFlores);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GenerarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floralia v2.0";
            this.Load += new System.EventHandler(this.Generar_pedido_Load);
            this.groupBox_seleccionFlores.ResumeLayout(false);
            this.groupBox_seleccionFlores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flores)).EndInit();
            this.groupBox_datosCliente.ResumeLayout(false);
            this.groupBox_datosCliente.PerformLayout();
            this.groupBox_carritoCompra.ResumeLayout(false);
            this.groupBox_tiempoEntrega.ResumeLayout(false);
            this.groupBox_tiempoEntrega.PerformLayout();
            this.groupBox_formaPago.ResumeLayout(false);
            this.groupBox_formaPago.PerformLayout();
            this.groupBox_pagoTotal.ResumeLayout(false);
            this.groupBox_pagoTotal.PerformLayout();
            this.groupBox_tipoTicket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_seleccionFlores;
        private System.Windows.Forms.ListView listView_carritoCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_flores;
        private System.Windows.Forms.Button button_anadirCarrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_datosCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_apellidoCliente;
        private System.Windows.Forms.Button button_confirmarCliente;
        private System.Windows.Forms.GroupBox groupBox_carritoCompra;
        private System.Windows.Forms.Button button_eliminarProducto;
        private System.Windows.Forms.GroupBox groupBox_tiempoEntrega;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hora;
        private System.Windows.Forms.Button button_confirmarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_formaPago;
        private System.Windows.Forms.RadioButton radioButton_pagoTarjeta;
        private System.Windows.Forms.RadioButton radioButton_pagoEfectivo;
        private System.Windows.Forms.Button button_confirmarFormaPago;
        private System.Windows.Forms.GroupBox groupBox_pagoTotal;
        private System.Windows.Forms.TextBox textBox_pagoTotal;
        private System.Windows.Forms.Button button_generarTotal;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_confirmarPedido;
        private System.Windows.Forms.Button button_cancelarPedido;
        private System.Windows.Forms.ComboBox comboBox_flores;
        private System.Windows.Forms.RadioButton radioButton_pagoPuntos;
        private System.Windows.Forms.RadioButton radioButton_pedidoDomicilio;
        private System.Windows.Forms.TextBox textBox_domicilio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_idTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_pagoTransferencia;
        private System.Windows.Forms.Button button_ticketInterno;
        private System.Windows.Forms.GroupBox groupBox_tipoTicket;
        private System.Windows.Forms.Button button_ticketRepartidor;
        private System.Windows.Forms.Label label_infoProducto;
    }
}

