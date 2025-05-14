namespace Tickets
{
    partial class Ticket_repartidor
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
            this.label_ticket = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_ticket = new System.Windows.Forms.TextBox();
            this.listView_ticket = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label_ticket
            // 
            this.label_ticket.AutoSize = true;
            this.label_ticket.Location = new System.Drawing.Point(43, 32);
            this.label_ticket.Name = "label_ticket";
            this.label_ticket.Size = new System.Drawing.Size(0, 21);
            this.label_ticket.TabIndex = 0;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.LightGray;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(270, 267);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(94, 28);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_ticket
            // 
            this.textBox_ticket.BackColor = System.Drawing.Color.White;
            this.textBox_ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ticket.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ticket.Location = new System.Drawing.Point(4, 2);
            this.textBox_ticket.Multiline = true;
            this.textBox_ticket.Name = "textBox_ticket";
            this.textBox_ticket.ReadOnly = true;
            this.textBox_ticket.Size = new System.Drawing.Size(360, 131);
            this.textBox_ticket.TabIndex = 2;
            this.textBox_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView_ticket
            // 
            this.listView_ticket.BackColor = System.Drawing.Color.White;
            this.listView_ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_ticket.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ticket.HideSelection = false;
            this.listView_ticket.Location = new System.Drawing.Point(4, 135);
            this.listView_ticket.Margin = new System.Windows.Forms.Padding(4);
            this.listView_ticket.Name = "listView_ticket";
            this.listView_ticket.Size = new System.Drawing.Size(360, 125);
            this.listView_ticket.TabIndex = 6;
            this.listView_ticket.UseCompatibleStateImageBehavior = false;
            // 
            // Ticket_repartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 303);
            this.ControlBox = false;
            this.Controls.Add(this.listView_ticket);
            this.Controls.Add(this.textBox_ticket);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_ticket);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ticket_repartidor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Repartidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ticket;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_ticket;
        private System.Windows.Forms.ListView listView_ticket;
    }
}