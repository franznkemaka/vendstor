namespace Vendstor.UserControls.Dashboard
{
    partial class Reporting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabIndicator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabDashboard = new System.Windows.Forms.Label();
            this.TabPayment = new System.Windows.Forms.Label();
            this.TabTax = new System.Windows.Forms.Label();
            this.TabStoreCredit = new System.Windows.Forms.Label();
            this.TabInventory = new System.Windows.Forms.Label();
            this.TabSales = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.Panel();
            this.ReportsControl = new System.Windows.Forms.FlowLayoutPanel();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabIndicator
            // 
            this.TabIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabIndicator.BackColor = System.Drawing.Color.Transparent;
            this.TabIndicator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TabIndicator.LineThickness = 2;
            this.TabIndicator.Location = new System.Drawing.Point(95, 42);
            this.TabIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.TabIndicator.Name = "TabIndicator";
            this.TabIndicator.Size = new System.Drawing.Size(107, 10);
            this.TabIndicator.TabIndex = 11;
            this.TabIndicator.Transparency = 255;
            this.TabIndicator.Vertical = false;
            // 
            // TabSeperator
            // 
            this.TabSeperator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSeperator.BackColor = System.Drawing.Color.Transparent;
            this.TabSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.TabSeperator.LineThickness = 1;
            this.TabSeperator.Location = new System.Drawing.Point(3, 42);
            this.TabSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.TabSeperator.Name = "TabSeperator";
            this.TabSeperator.Size = new System.Drawing.Size(1135, 10);
            this.TabSeperator.TabIndex = 10;
            this.TabSeperator.Transparency = 255;
            this.TabSeperator.Vertical = false;
            // 
            // TabDashboard
            // 
            this.TabDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabDashboard.AutoSize = true;
            this.TabDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabDashboard.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabDashboard.Location = new System.Drawing.Point(100, 11);
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.Size = new System.Drawing.Size(101, 28);
            this.TabDashboard.TabIndex = 117;
            this.TabDashboard.Tag = "Dashboard";
            this.TabDashboard.Text = "Dashboard";
            this.TabDashboard.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabPayment
            // 
            this.TabPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabPayment.AutoSize = true;
            this.TabPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPayment.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabPayment.ForeColor = System.Drawing.Color.DarkGray;
            this.TabPayment.Location = new System.Drawing.Point(592, 10);
            this.TabPayment.Name = "TabPayment";
            this.TabPayment.Size = new System.Drawing.Size(147, 28);
            this.TabPayment.TabIndex = 118;
            this.TabPayment.Tag = "Payment";
            this.TabPayment.Text = "Payment Reports";
            this.TabPayment.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabTax
            // 
            this.TabTax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabTax.AutoSize = true;
            this.TabTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabTax.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabTax.ForeColor = System.Drawing.Color.DarkGray;
            this.TabTax.Location = new System.Drawing.Point(927, 11);
            this.TabTax.Name = "TabTax";
            this.TabTax.Size = new System.Drawing.Size(102, 28);
            this.TabTax.TabIndex = 119;
            this.TabTax.Tag = "Tax";
            this.TabTax.Text = "Tax Reports";
            this.TabTax.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabStoreCredit
            // 
            this.TabStoreCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabStoreCredit.AutoSize = true;
            this.TabStoreCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabStoreCredit.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabStoreCredit.ForeColor = System.Drawing.Color.DarkGray;
            this.TabStoreCredit.Location = new System.Drawing.Point(780, 10);
            this.TabStoreCredit.Name = "TabStoreCredit";
            this.TabStoreCredit.Size = new System.Drawing.Size(106, 28);
            this.TabStoreCredit.TabIndex = 120;
            this.TabStoreCredit.Tag = "StoreCredit";
            this.TabStoreCredit.Text = "Store Credit";
            this.TabStoreCredit.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabInventory
            // 
            this.TabInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabInventory.AutoSize = true;
            this.TabInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabInventory.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabInventory.ForeColor = System.Drawing.Color.DarkGray;
            this.TabInventory.Location = new System.Drawing.Point(401, 11);
            this.TabInventory.Name = "TabInventory";
            this.TabInventory.Size = new System.Drawing.Size(150, 28);
            this.TabInventory.TabIndex = 121;
            this.TabInventory.Tag = "Inventory";
            this.TabInventory.Text = "Inventory Reports";
            this.TabInventory.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabSales
            // 
            this.TabSales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSales.AutoSize = true;
            this.TabSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSales.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabSales.ForeColor = System.Drawing.Color.DarkGray;
            this.TabSales.Location = new System.Drawing.Point(242, 11);
            this.TabSales.Name = "TabSales";
            this.TabSales.Size = new System.Drawing.Size(118, 28);
            this.TabSales.TabIndex = 122;
            this.TabSales.Tag = "Sales";
            this.TabSales.Text = "Sales Reports";
            this.TabSales.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // Tabs
            // 
            this.Tabs.BackColor = System.Drawing.Color.Transparent;
            this.Tabs.Controls.Add(this.TabIndicator);
            this.Tabs.Controls.Add(this.TabInventory);
            this.Tabs.Controls.Add(this.TabSales);
            this.Tabs.Controls.Add(this.TabSeperator);
            this.Tabs.Controls.Add(this.TabStoreCredit);
            this.Tabs.Controls.Add(this.TabDashboard);
            this.Tabs.Controls.Add(this.TabTax);
            this.Tabs.Controls.Add(this.TabPayment);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(1128, 53);
            this.Tabs.TabIndex = 123;
            // 
            // ReportsControl
            // 
            this.ReportsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportsControl.Location = new System.Drawing.Point(0, 53);
            this.ReportsControl.Name = "ReportsControl";
            this.ReportsControl.Size = new System.Drawing.Size(1128, 597);
            this.ReportsControl.TabIndex = 124;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.ReportsControl);
            this.Controls.Add(this.Tabs);
            this.Name = "Reporting";
            this.Size = new System.Drawing.Size(1128, 650);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.Tabs.ResumeLayout(false);
            this.Tabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Bunifu.Framework.UI.BunifuSeparator TabIndicator;
        internal Bunifu.Framework.UI.BunifuSeparator TabSeperator;
        private System.Windows.Forms.Label TabDashboard;
        private System.Windows.Forms.Label TabPayment;
        private System.Windows.Forms.Label TabTax;
        private System.Windows.Forms.Label TabStoreCredit;
        private System.Windows.Forms.Label TabInventory;
        private System.Windows.Forms.Label TabSales;
        private System.Windows.Forms.Panel Tabs;
        private System.Windows.Forms.FlowLayoutPanel ReportsControl;
    }
}
