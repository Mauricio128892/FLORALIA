namespace WindowsFormsApp1
{
    partial class EditarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDatos));
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCurp = new System.Windows.Forms.TextBox();
            this.TxtNFC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.TxtPuntos = new System.Windows.Forms.TextBox();
            this.TxtFechaExpiracion = new System.Windows.Forms.TextBox();
            this.TxtFechaActivacion = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.ComboRol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(69, 130);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(159, 28);
            this.TxtTelefono.TabIndex = 0;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(69, 299);
            this.TxtContrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(159, 28);
            this.TxtContrasena.TabIndex = 1;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(69, 240);
            this.TxtDomicilio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(159, 28);
            this.TxtDomicilio.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(69, 72);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(159, 28);
            this.TxtNombre.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(65, 49);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(82, 21);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(69, 185);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(159, 28);
            this.TxtEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "CURP:";
            // 
            // TxtCurp
            // 
            this.TxtCurp.Location = new System.Drawing.Point(69, 354);
            this.TxtCurp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(159, 28);
            this.TxtCurp.TabIndex = 11;
            // 
            // TxtNFC
            // 
            this.TxtNFC.Location = new System.Drawing.Point(586, 83);
            this.TxtNFC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNFC.Name = "TxtNFC";
            this.TxtNFC.Size = new System.Drawing.Size(159, 28);
            this.TxtNFC.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rol:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "NFC";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(312, 154);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(194, 171);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LightPink;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(556, 411);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(210, 45);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar ";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.BackColor = System.Drawing.Color.LightPink;
            this.BtnCargarImagen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarImagen.Location = new System.Drawing.Point(357, 347);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(115, 40);
            this.BtnCargarImagen.TabIndex = 18;
            this.BtnCargarImagen.Text = "Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = false;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // TxtPuntos
            // 
            this.TxtPuntos.Location = new System.Drawing.Point(586, 141);
            this.TxtPuntos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPuntos.Name = "TxtPuntos";
            this.TxtPuntos.Size = new System.Drawing.Size(159, 28);
            this.TxtPuntos.TabIndex = 19;
            // 
            // TxtFechaExpiracion
            // 
            this.TxtFechaExpiracion.Location = new System.Drawing.Point(587, 299);
            this.TxtFechaExpiracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFechaExpiracion.Name = "TxtFechaExpiracion";
            this.TxtFechaExpiracion.Size = new System.Drawing.Size(159, 28);
            this.TxtFechaExpiracion.TabIndex = 20;
            this.TxtFechaExpiracion.TextChanged += new System.EventHandler(this.TxtFechaExpiracion_TextChanged);
            // 
            // TxtFechaActivacion
            // 
            this.TxtFechaActivacion.Location = new System.Drawing.Point(587, 251);
            this.TxtFechaActivacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFechaActivacion.Name = "TxtFechaActivacion";
            this.TxtFechaActivacion.Size = new System.Drawing.Size(159, 28);
            this.TxtFechaActivacion.TabIndex = 21;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(587, 196);
            this.TxtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(159, 28);
            this.TxtEstado.TabIndex = 22;
            // 
            // ComboRol
            // 
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Items.AddRange(new object[] {
            "Administrador",
            "Trabajador",
            "Cliente"});
            this.ComboRol.Location = new System.Drawing.Point(406, 37);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(136, 29);
            this.ComboRol.TabIndex = 23;
            // 
            // EditarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(826, 485);
            this.Controls.Add(this.ComboRol);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtFechaActivacion);
            this.Controls.Add(this.TxtFechaExpiracion);
            this.Controls.Add(this.TxtPuntos);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNFC);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtTelefono);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floralia v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCurp;
        private System.Windows.Forms.TextBox TxtNFC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.TextBox TxtPuntos;
        private System.Windows.Forms.TextBox TxtFechaExpiracion;
        private System.Windows.Forms.TextBox TxtFechaActivacion;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.ComboBox ComboRol;
    }
}