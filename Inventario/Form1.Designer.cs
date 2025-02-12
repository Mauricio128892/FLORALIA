namespace MAURIYYOO2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtId = new TextBox();
            MostrarInventario = new Button();
            lstInventario = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightCoral;
            btnAgregar.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(2, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(382, 38);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 23);
            txtCantidad.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(266, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(498, 38);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 4;
            // 
            // MostrarInventario
            // 
            MostrarInventario.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MostrarInventario.Location = new Point(614, 20);
            MostrarInventario.Name = "MostrarInventario";
            MostrarInventario.Size = new Size(101, 41);
            MostrarInventario.TabIndex = 5;
            MostrarInventario.Text = "Inventario ";
            MostrarInventario.UseVisualStyleBackColor = true;
            MostrarInventario.Click += MostrarInventario_Click;
            // 
            // lstInventario
            // 
            lstInventario.FormattingEnabled = true;
            lstInventario.ItemHeight = 15;
            lstInventario.Location = new Point(11, 89);
            lstInventario.Name = "lstInventario";
            lstInventario.Size = new Size(704, 184);
            lstInventario.TabIndex = 6;
            lstInventario.SelectedIndexChanged += lstInventario_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 19);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 7;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 19);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(406, 19);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(529, 19);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstInventario);
            Controls.Add(MostrarInventario);
            Controls.Add(txtId);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCantidad);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Floralia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtId;
        private Button MostrarInventario;
        private ListBox lstInventario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
