namespace Vendstor.UserControls.Dashboard
{
    partial class ProductsTab
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
            this.ProductsControl = new System.Windows.Forms.FlowLayoutPanel();
            this.TabIndicator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabDiscounts = new System.Windows.Forms.Label();
            this.TabStockControl = new System.Windows.Forms.Label();
            this.TabSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabTypes = new System.Windows.Forms.Label();
            this.TabMain = new System.Windows.Forms.Label();
            this.TabSuppliers = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.Panel();
            this.TabTags = new System.Windows.Forms.Label();
            this.TabBrands = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsControl
            // 
            this.ProductsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ProductsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsControl.Location = new System.Drawing.Point(0, 53);
            this.ProductsControl.Name = "ProductsControl";
            this.ProductsControl.Size = new System.Drawing.Size(1138, 607);
            this.ProductsControl.TabIndex = 126;
            // 
            // TabIndicator
            // 
            this.TabIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabIndicator.BackColor = System.Drawing.Color.Transparent;
            this.TabIndicator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TabIndicator.LineThickness = 2;
            this.TabIndicator.Location = new System.Drawing.Point(142, 42);
            this.TabIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.TabIndicator.Name = "TabIndicator";
            this.TabIndicator.Size = new System.Drawing.Size(82, 10);
            this.TabIndicator.TabIndex = 11;
            this.TabIndicator.Transparency = 255;
            this.TabIndicator.Vertical = false;
            // 
            // TabDiscounts
            // 
            this.TabDiscounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabDiscounts.AutoSize = true;
            this.TabDiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabDiscounts.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabDiscounts.ForeColor = System.Drawing.Color.DarkGray;
            this.TabDiscounts.Location = new System.Drawing.Point(424, 12);
            this.TabDiscounts.Name = "TabDiscounts";
            this.TabDiscounts.Size = new System.Drawing.Size(89, 28);
            this.TabDiscounts.TabIndex = 121;
            this.TabDiscounts.Text = "Discounts";
            this.TabDiscounts.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabStockControl
            // 
            this.TabStockControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabStockControl.AutoSize = true;
            this.TabStockControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabStockControl.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabStockControl.ForeColor = System.Drawing.Color.DarkGray;
            this.TabStockControl.Location = new System.Drawing.Point(266, 12);
            this.TabStockControl.Name = "TabStockControl";
            this.TabStockControl.Size = new System.Drawing.Size(117, 28);
            this.TabStockControl.TabIndex = 122;
            this.TabStockControl.Text = "Stock Control";
            this.TabStockControl.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabSeperator
            // 
            this.TabSeperator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSeperator.BackColor = System.Drawing.Color.Transparent;
            this.TabSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.TabSeperator.LineThickness = 1;
            this.TabSeperator.Location = new System.Drawing.Point(8, 42);
            this.TabSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.TabSeperator.Name = "TabSeperator";
            this.TabSeperator.Size = new System.Drawing.Size(1135, 10);
            this.TabSeperator.TabIndex = 10;
            this.TabSeperator.Transparency = 255;
            this.TabSeperator.Vertical = false;
            // 
            // TabTypes
            // 
            this.TabTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabTypes.AutoSize = true;
            this.TabTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabTypes.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabTypes.ForeColor = System.Drawing.Color.DarkGray;
            this.TabTypes.Location = new System.Drawing.Point(546, 13);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Size = new System.Drawing.Size(58, 28);
            this.TabTypes.TabIndex = 120;
            this.TabTypes.Text = "Types";
            this.TabTypes.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabMain
            // 
            this.TabMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabMain.AutoSize = true;
            this.TabMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabMain.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabMain.Location = new System.Drawing.Point(143, 13);
            this.TabMain.Name = "TabMain";
            this.TabMain.Size = new System.Drawing.Size(82, 28);
            this.TabMain.TabIndex = 117;
            this.TabMain.Text = "Products";
            this.TabMain.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabSuppliers
            // 
            this.TabSuppliers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSuppliers.AutoSize = true;
            this.TabSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSuppliers.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabSuppliers.ForeColor = System.Drawing.Color.DarkGray;
            this.TabSuppliers.Location = new System.Drawing.Point(645, 13);
            this.TabSuppliers.Name = "TabSuppliers";
            this.TabSuppliers.Size = new System.Drawing.Size(85, 28);
            this.TabSuppliers.TabIndex = 119;
            this.TabSuppliers.Text = "Suppliers";
            this.TabSuppliers.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // Tabs
            // 
            this.Tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Tabs.Controls.Add(this.TabTags);
            this.Tabs.Controls.Add(this.TabBrands);
            this.Tabs.Controls.Add(this.TabIndicator);
            this.Tabs.Controls.Add(this.TabDiscounts);
            this.Tabs.Controls.Add(this.TabStockControl);
            this.Tabs.Controls.Add(this.TabSeperator);
            this.Tabs.Controls.Add(this.TabTypes);
            this.Tabs.Controls.Add(this.TabMain);
            this.Tabs.Controls.Add(this.TabSuppliers);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(1138, 53);
            this.Tabs.TabIndex = 125;
            // 
            // TabTags
            // 
            this.TabTags.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabTags.AutoSize = true;
            this.TabTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabTags.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabTags.ForeColor = System.Drawing.Color.DarkGray;
            this.TabTags.Location = new System.Drawing.Point(880, 12);
            this.TabTags.Name = "TabTags";
            this.TabTags.Size = new System.Drawing.Size(116, 28);
            this.TabTags.TabIndex = 124;
            this.TabTags.Text = "Product Tags";
            this.TabTags.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabBrands
            // 
            this.TabBrands.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabBrands.AutoSize = true;
            this.TabBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabBrands.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabBrands.ForeColor = System.Drawing.Color.DarkGray;
            this.TabBrands.Location = new System.Drawing.Point(771, 13);
            this.TabBrands.Name = "TabBrands";
            this.TabBrands.Size = new System.Drawing.Size(68, 28);
            this.TabBrands.TabIndex = 123;
            this.TabBrands.Text = "Brands";
            this.TabBrands.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // ProductsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.ProductsControl);
            this.Controls.Add(this.Tabs);
            this.Name = "ProductsTab";
            this.Size = new System.Drawing.Size(1138, 660);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.Tabs.ResumeLayout(false);
            this.Tabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Bunifu.Framework.UI.BunifuSeparator TabIndicator;
        private System.Windows.Forms.Label TabDiscounts;
        private System.Windows.Forms.Label TabStockControl;
        internal Bunifu.Framework.UI.BunifuSeparator TabSeperator;
        private System.Windows.Forms.Label TabTypes;
        private System.Windows.Forms.Label TabMain;
        private System.Windows.Forms.Label TabSuppliers;
        private System.Windows.Forms.Panel Tabs;
        private System.Windows.Forms.Label TabTags;
        private System.Windows.Forms.Label TabBrands;
        public System.Windows.Forms.FlowLayoutPanel ProductsControl;
    }
}
