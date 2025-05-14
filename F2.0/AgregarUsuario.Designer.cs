namespace WindowsFormsApp1
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioTrabajador = new System.Windows.Forms.RadioButton();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCURP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtNFC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AgregarUsuario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(86, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imagen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(59, 428);
            this.radioAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(146, 25);
            this.radioAdmin.TabIndex = 3;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administrador";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioTrabajador
            // 
            this.radioTrabajador.AutoSize = true;
            this.radioTrabajador.Location = new System.Drawing.Point(59, 461);
            this.radioTrabajador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioTrabajador.Name = "radioTrabajador";
            this.radioTrabajador.Size = new System.Drawing.Size(123, 25);
            this.radioTrabajador.TabIndex = 4;
            this.radioTrabajador.TabStop = true;
            this.radioTrabajador.Text = "Trabajador";
            this.radioTrabajador.UseVisualStyleBackColor = true;
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Location = new System.Drawing.Point(59, 493);
            this.radioCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(90, 25);
            this.radioCliente.TabIndex = 5;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "Cliente";
            this.radioCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(426, 74);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(272, 28);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtCel
            // 
            this.TxtCel.Location = new System.Drawing.Point(426, 138);
            this.TxtCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCel.Name = "TxtCel";
            this.TxtCel.Size = new System.Drawing.Size(209, 28);
            this.TxtCel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(426, 210);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(307, 28);
            this.TxtEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(426, 280);
            this.TxtDomicilio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(365, 28);
            this.TxtDomicilio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Domicilio:";
            // 
            // TxtContra
            // 
            this.TxtContra.Location = new System.Drawing.Point(426, 344);
            this.TxtContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(186, 28);
            this.TxtContra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña:";
            // 
            // TxtCURP
            // 
            this.TxtCURP.Location = new System.Drawing.Point(426, 404);
            this.TxtCURP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCURP.Name = "TxtCURP";
            this.TxtCURP.Size = new System.Drawing.Size(256, 28);
            this.TxtCURP.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "CURP:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(441, 535);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(644, 535);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 29);
            this.button3.TabIndex = 19;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(39, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 239);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.luxa_org_opacity_changed_1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(914, 578);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // TxtNFC
            // 
            this.TxtNFC.Location = new System.Drawing.Point(430, 461);
            this.TxtNFC.Name = "TxtNFC";
            this.TxtNFC.Size = new System.Drawing.Size(329, 28);
            this.TxtNFC.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "NFC:";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNFC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtCURP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioCliente);
            this.Controls.Add(this.radioTrabajador);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floralia v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioTrabajador;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCURP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtNFC;
        private System.Windows.Forms.Label label8;
    }
}