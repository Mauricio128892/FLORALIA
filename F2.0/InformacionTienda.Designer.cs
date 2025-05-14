namespace WindowsFormsApp1
{
    partial class InformacionTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionTienda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonEditarImagen = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button_editarInformacion = new System.Windows.Forms.Button();
            this.textBox3_Correoinfo = new System.Windows.Forms.TextBox();
            this.textBox2_Telefonoinfo = new System.Windows.Forms.TextBox();
            this.textBox1_Direccioninfo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.buttonEditarImagen);
            this.groupBox1.Controls.Add(this.pictureBoxLogo);
            this.groupBox1.Controls.Add(this.button_editarInformacion);
            this.groupBox1.Controls.Add(this.textBox3_Correoinfo);
            this.groupBox1.Controls.Add(this.textBox2_Telefonoinfo);
            this.groupBox1.Controls.Add(this.textBox1_Direccioninfo);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(974, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FLORALIA";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(330, 180);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(595, 300);
            this.textBoxDescripcion.TabIndex = 11;
            this.textBoxDescripcion.Text = resources.GetString("textBoxDescripcion.Text");
            // 
            // buttonEditarImagen
            // 
            this.buttonEditarImagen.BackColor = System.Drawing.Color.LightPink;
            this.buttonEditarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarImagen.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarImagen.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarImagen.Location = new System.Drawing.Point(769, 59);
            this.buttonEditarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarImagen.Name = "buttonEditarImagen";
            this.buttonEditarImagen.Size = new System.Drawing.Size(169, 29);
            this.buttonEditarImagen.TabIndex = 10;
            this.buttonEditarImagen.Text = "Editar Imagen";
            this.buttonEditarImagen.UseVisualStyleBackColor = false;
            this.buttonEditarImagen.Click += new System.EventHandler(this.buttonEditarImagen_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp1.Properties.Resources.Imagen_de_Floraria;
            this.pictureBoxLogo.Location = new System.Drawing.Point(481, 33);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(220, 129);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // button_editarInformacion
            // 
            this.button_editarInformacion.BackColor = System.Drawing.Color.LightPink;
            this.button_editarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarInformacion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarInformacion.ForeColor = System.Drawing.Color.Black;
            this.button_editarInformacion.Location = new System.Drawing.Point(769, 506);
            this.button_editarInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.button_editarInformacion.Name = "button_editarInformacion";
            this.button_editarInformacion.Size = new System.Drawing.Size(169, 28);
            this.button_editarInformacion.TabIndex = 9;
            this.button_editarInformacion.Text = "Editar información";
            this.button_editarInformacion.UseVisualStyleBackColor = false;
            this.button_editarInformacion.Click += new System.EventHandler(this.button_editarInformacion_Click);
            // 
            // textBox3_Correoinfo
            // 
            this.textBox3_Correoinfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox3_Correoinfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Correoinfo.Location = new System.Drawing.Point(12, 483);
            this.textBox3_Correoinfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_Correoinfo.Name = "textBox3_Correoinfo";
            this.textBox3_Correoinfo.ReadOnly = true;
            this.textBox3_Correoinfo.Size = new System.Drawing.Size(278, 31);
            this.textBox3_Correoinfo.TabIndex = 6;
            this.textBox3_Correoinfo.Text = "floralia116@gmail.com";
            // 
            // textBox2_Telefonoinfo
            // 
            this.textBox2_Telefonoinfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox2_Telefonoinfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Telefonoinfo.Location = new System.Drawing.Point(12, 353);
            this.textBox2_Telefonoinfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Telefonoinfo.Name = "textBox2_Telefonoinfo";
            this.textBox2_Telefonoinfo.ReadOnly = true;
            this.textBox2_Telefonoinfo.Size = new System.Drawing.Size(156, 31);
            this.textBox2_Telefonoinfo.TabIndex = 5;
            this.textBox2_Telefonoinfo.Text = "9811876147";
            this.textBox2_Telefonoinfo.TextChanged += new System.EventHandler(this.textBox2_Telefonoinfo_TextChanged);
            // 
            // textBox1_Direccioninfo
            // 
            this.textBox1_Direccioninfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1_Direccioninfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Direccioninfo.Location = new System.Drawing.Point(12, 161);
            this.textBox1_Direccioninfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_Direccioninfo.Multiline = true;
            this.textBox1_Direccioninfo.Name = "textBox1_Direccioninfo";
            this.textBox1_Direccioninfo.ReadOnly = true;
            this.textBox1_Direccioninfo.Size = new System.Drawing.Size(278, 127);
            this.textBox1_Direccioninfo.TabIndex = 4;
            this.textBox1_Direccioninfo.Text = "Av. Resurgimiento 611, Bosques de Campeche, \r\n24030 San Francisco de Campeche, Ca" +
    "mp.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 143);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 32);
            this.linkLabel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electrónico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Información Tienda";
            // 
            // InformacionTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InformacionTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floralia 2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_Direccioninfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox2_Telefonoinfo;
        private System.Windows.Forms.TextBox textBox3_Correoinfo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button_editarInformacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditarImagen;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}

