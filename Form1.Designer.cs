namespace Inventario
{
    partial class Form1
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
            this.pictureBox_agregar = new System.Windows.Forms.PictureBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox_previsualizacion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.button_cargarFoto = new System.Windows.Forms.Button();
            this.button_agregarTabla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_datoFlor = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_previsualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_datoFlor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_agregar
            // 
            this.pictureBox_agregar.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox_agregar.Location = new System.Drawing.Point(78, 50);
            this.pictureBox_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_agregar.Name = "pictureBox_agregar";
            this.pictureBox_agregar.Size = new System.Drawing.Size(101, 71);
            this.pictureBox_agregar.TabIndex = 1;
            this.pictureBox_agregar.TabStop = false;
            this.pictureBox_agregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(220, 91);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(143, 34);
            this.textBox_nombre.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(78, 148);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(790, 329);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox_previsualizacion
            // 
            this.pictureBox_previsualizacion.Location = new System.Drawing.Point(929, 127);
            this.pictureBox_previsualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_previsualizacion.Name = "pictureBox_previsualizacion";
            this.pictureBox_previsualizacion.Size = new System.Drawing.Size(206, 171);
            this.pictureBox_previsualizacion.TabIndex = 10;
            this.pictureBox_previsualizacion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(404, 91);
            this.textBox_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(143, 34);
            this.textBox_cantidad.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio";
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(584, 91);
            this.textBox_precio.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(143, 34);
            this.textBox_precio.TabIndex = 14;
            // 
            // button_cargarFoto
            // 
            this.button_cargarFoto.BackColor = System.Drawing.Color.LightPink;
            this.button_cargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargarFoto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargarFoto.Location = new System.Drawing.Point(946, 318);
            this.button_cargarFoto.Name = "button_cargarFoto";
            this.button_cargarFoto.Size = new System.Drawing.Size(176, 41);
            this.button_cargarFoto.TabIndex = 16;
            this.button_cargarFoto.Text = "Cargar Foto";
            this.button_cargarFoto.UseVisualStyleBackColor = false;
            this.button_cargarFoto.Click += new System.EventHandler(this.button_cargarFoto_Click);
            // 
            // button_agregarTabla
            // 
            this.button_agregarTabla.BackColor = System.Drawing.Color.LightPink;
            this.button_agregarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregarTabla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregarTabla.Location = new System.Drawing.Point(929, 365);
            this.button_agregarTabla.Name = "button_agregarTabla";
            this.button_agregarTabla.Size = new System.Drawing.Size(206, 45);
            this.button_agregarTabla.TabIndex = 17;
            this.button_agregarTabla.Text = "Agregar a la Tabla";
            this.button_agregarTabla.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox1.Location = new System.Drawing.Point(1109, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 48);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_datoFlor
            // 
            this.groupBox_datoFlor.Controls.Add(this.label2);
            this.groupBox_datoFlor.Location = new System.Drawing.Point(67, 28);
            this.groupBox_datoFlor.Name = "groupBox_datoFlor";
            this.groupBox_datoFlor.Size = new System.Drawing.Size(684, 103);
            this.groupBox_datoFlor.TabIndex = 19;
            this.groupBox_datoFlor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(67, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 358);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(918, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 385);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1179, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_agregarTabla);
            this.Controls.Add(this.button_cargarFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_previsualizacion);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.pictureBox_agregar);
            this.Controls.Add(this.groupBox_datoFlor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Floralia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_previsualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_datoFlor.ResumeLayout(false);
            this.groupBox_datoFlor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_agregar;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox_previsualizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Button button_cargarFoto;
        private System.Windows.Forms.Button button_agregarTabla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_datoFlor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

