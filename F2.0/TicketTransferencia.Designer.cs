namespace Tickets
{
    partial class TicketTransferencia
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
            this.textBox_transferencia = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_transferencia
            // 
            this.textBox_transferencia.BackColor = System.Drawing.Color.White;
            this.textBox_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_transferencia.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_transferencia.Location = new System.Drawing.Point(4, 2);
            this.textBox_transferencia.Multiline = true;
            this.textBox_transferencia.Name = "textBox_transferencia";
            this.textBox_transferencia.ReadOnly = true;
            this.textBox_transferencia.Size = new System.Drawing.Size(265, 178);
            this.textBox_transferencia.TabIndex = 0;
            this.textBox_transferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.LightGray;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(170, 186);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(99, 28);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // TicketTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 220);
            this.ControlBox = false;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_transferencia);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketTransferencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_transferencia;
        private System.Windows.Forms.Button button_ok;
    }
}