namespace Tickets
{
    partial class Ticket_interno
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
            this.listView_ticket = new System.Windows.Forms.ListView();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_ticket
            // 
            this.listView_ticket.BackColor = System.Drawing.Color.White;
            this.listView_ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_ticket.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ticket.HideSelection = false;
            this.listView_ticket.Location = new System.Drawing.Point(3, 2);
            this.listView_ticket.Margin = new System.Windows.Forms.Padding(4);
            this.listView_ticket.Name = "listView_ticket";
            this.listView_ticket.Size = new System.Drawing.Size(291, 149);
            this.listView_ticket.TabIndex = 0;
            this.listView_ticket.UseCompatibleStateImageBehavior = false;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.LightGray;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(199, 157);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(95, 28);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Ticket_interno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 193);
            this.ControlBox = false;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.listView_ticket);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ticket_interno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Interno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_ticket;
        private System.Windows.Forms.Button button_ok;
    }
}