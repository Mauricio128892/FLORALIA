namespace WindowsFormsApp1
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.button2 = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PNOMOSTRAR = new System.Windows.Forms.PictureBox();
            this.PMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PNOMOSTRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(381, 337);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // IngresarButton
            // 
            this.IngresarButton.BackColor = System.Drawing.Color.LightPink;
            this.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarButton.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarButton.Location = new System.Drawing.Point(541, 337);
            this.IngresarButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(132, 31);
            this.IngresarButton.TabIndex = 2;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = false;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click_1);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(381, 95);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(284, 28);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtContra
            // 
            this.TxtContra.Location = new System.Drawing.Point(381, 192);
            this.TxtContra.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(266, 28);
            this.TxtContra.TabIndex = 4;
            this.TxtContra.TextChanged += new System.EventHandler(this.TxtContra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(99, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Floralia 2.0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PNOMOSTRAR
            // 
            this.PNOMOSTRAR.Image = global::WindowsFormsApp1.Properties.Resources.Ojo_Cerrado_removebg_preview;
            this.PNOMOSTRAR.Location = new System.Drawing.Point(655, 192);
            this.PNOMOSTRAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PNOMOSTRAR.Name = "PNOMOSTRAR";
            this.PNOMOSTRAR.Size = new System.Drawing.Size(31, 30);
            this.PNOMOSTRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PNOMOSTRAR.TabIndex = 10;
            this.PNOMOSTRAR.TabStop = false;
            this.PNOMOSTRAR.Click += new System.EventHandler(this.PNOMOSTRAR_Click);
            // 
            // PMostrar
            // 
            this.PMostrar.Image = global::WindowsFormsApp1.Properties.Resources.Ojo_abierto_removebg_preview;
            this.PMostrar.Location = new System.Drawing.Point(652, 187);
            this.PMostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PMostrar.Name = "PMostrar";
            this.PMostrar.Size = new System.Drawing.Size(45, 42);
            this.PMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PMostrar.TabIndex = 9;
            this.PMostrar.TabStop = false;
            this.PMostrar.Click += new System.EventHandler(this.PMostrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.luxa_org_opacity_changed___Imagen_de_Floraria_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(24, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(746, 394);
            this.Controls.Add(this.PMostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PNOMOSTRAR);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Floralia v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.PNOMOSTRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PMostrar;
        private System.Windows.Forms.PictureBox PNOMOSTRAR;
    }
}

