namespace WindowsFormsApp1
{
    partial class RegistroRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRoles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonTodos = new System.Windows.Forms.Button();
            this.ButtonAdmin = new System.Windows.Forms.Button();
            this.ButtonClientes = new System.Windows.Forms.Button();
            this.ButtonTrabajadores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonTodos
            // 
            this.ButtonTodos.BackColor = System.Drawing.Color.LightPink;
            this.ButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTodos.Location = new System.Drawing.Point(2, 29);
            this.ButtonTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonTodos.Name = "ButtonTodos";
            this.ButtonTodos.Size = new System.Drawing.Size(76, 31);
            this.ButtonTodos.TabIndex = 1;
            this.ButtonTodos.Text = "Todos";
            this.ButtonTodos.UseVisualStyleBackColor = false;
            this.ButtonTodos.Click += new System.EventHandler(this.ButtonTodos_Click);
            // 
            // ButtonAdmin
            // 
            this.ButtonAdmin.BackColor = System.Drawing.Color.LightPink;
            this.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdmin.Location = new System.Drawing.Point(81, 29);
            this.ButtonAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAdmin.Name = "ButtonAdmin";
            this.ButtonAdmin.Size = new System.Drawing.Size(120, 31);
            this.ButtonAdmin.TabIndex = 2;
            this.ButtonAdmin.Text = "Administrador";
            this.ButtonAdmin.UseVisualStyleBackColor = false;
            this.ButtonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // ButtonClientes
            // 
            this.ButtonClientes.BackColor = System.Drawing.Color.LightPink;
            this.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClientes.Location = new System.Drawing.Point(335, 29);
            this.ButtonClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonClientes.Name = "ButtonClientes";
            this.ButtonClientes.Size = new System.Drawing.Size(129, 31);
            this.ButtonClientes.TabIndex = 3;
            this.ButtonClientes.Text = "Clientes";
            this.ButtonClientes.UseVisualStyleBackColor = false;
            this.ButtonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // ButtonTrabajadores
            // 
            this.ButtonTrabajadores.BackColor = System.Drawing.Color.LightPink;
            this.ButtonTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrabajadores.Location = new System.Drawing.Point(204, 29);
            this.ButtonTrabajadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonTrabajadores.Name = "ButtonTrabajadores";
            this.ButtonTrabajadores.Size = new System.Drawing.Size(129, 31);
            this.ButtonTrabajadores.TabIndex = 4;
            this.ButtonTrabajadores.Text = "Trabajadores";
            this.ButtonTrabajadores.UseVisualStyleBackColor = false;
            this.ButtonTrabajadores.Click += new System.EventHandler(this.ButtonTrabajadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(768, 30);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(244, 28);
            this.TxtBuscar.TabIndex = 9;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Lupa_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(634, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonTrabajadores);
            this.Controls.Add(this.ButtonClientes);
            this.Controls.Add(this.ButtonAdmin);
            this.Controls.Add(this.ButtonTodos);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistroRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floralia v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonTodos;
        private System.Windows.Forms.Button ButtonAdmin;
        private System.Windows.Forms.Button ButtonClientes;
        private System.Windows.Forms.Button ButtonTrabajadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}