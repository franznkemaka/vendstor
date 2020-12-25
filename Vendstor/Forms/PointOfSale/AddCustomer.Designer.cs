namespace Vendstor.Forms.PointOfSale
{
    partial class AddCustomer
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
            this.flpnl_Controls = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpnl_Controls
            // 
            this.flpnl_Controls.AutoScroll = true;
            this.flpnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.flpnl_Controls.Name = "flpnl_Controls";
            this.flpnl_Controls.Size = new System.Drawing.Size(746, 461);
            this.flpnl_Controls.TabIndex = 0;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 461);
            this.Controls.Add(this.flpnl_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_Controls;
    }
}