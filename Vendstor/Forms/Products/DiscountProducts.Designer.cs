namespace Vendstor.Forms.Discounts
{
    partial class DiscountProducts
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
            this.components = new System.ComponentModel.Container();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProductsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDiscountName = new System.Windows.Forms.Label();
            this.lblDiscountDescription = new System.Windows.Forms.Label();
            this.GridSeperator_Collapse = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Duration = new System.Windows.Forms.Label();
            this.text_Amount = new System.Windows.Forms.Label();
            this.text_Ptg = new System.Windows.Forms.Label();
            this.lblDiscountDuration = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscountPtg = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Products = new System.Windows.Forms.Label();
            this.text_RetailPrice = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AutoScroll = true;
            this.ProductsGrid.BackColor = System.Drawing.Color.White;
            this.ProductsGrid.Location = new System.Drawing.Point(12, 175);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(776, 280);
            this.ProductsGrid.TabIndex = 62;
            // 
            // lblDiscountName
            // 
            this.lblDiscountName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountName.Font = new System.Drawing.Font("Poppins", 15F);
            this.lblDiscountName.Location = new System.Drawing.Point(12, 9);
            this.lblDiscountName.Name = "lblDiscountName";
            this.lblDiscountName.Size = new System.Drawing.Size(744, 35);
            this.lblDiscountName.TabIndex = 183;
            this.lblDiscountName.Text = "_name";
            this.lblDiscountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscountDescription
            // 
            this.lblDiscountDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountDescription.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDiscountDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblDiscountDescription.Location = new System.Drawing.Point(12, 48);
            this.lblDiscountDescription.Name = "lblDiscountDescription";
            this.lblDiscountDescription.Size = new System.Drawing.Size(775, 25);
            this.lblDiscountDescription.TabIndex = 184;
            this.lblDiscountDescription.Text = "_description";
            this.lblDiscountDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridSeperator_Collapse
            // 
            this.GridSeperator_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Collapse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Collapse.LineThickness = 1;
            this.GridSeperator_Collapse.Location = new System.Drawing.Point(310, 68);
            this.GridSeperator_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Collapse.Name = "GridSeperator_Collapse";
            this.GridSeperator_Collapse.Size = new System.Drawing.Size(180, 12);
            this.GridSeperator_Collapse.TabIndex = 185;
            this.GridSeperator_Collapse.Transparency = 255;
            this.GridSeperator_Collapse.Vertical = false;
            this.GridSeperator_Collapse.Visible = false;
            // 
            // text_Duration
            // 
            this.text_Duration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Duration.AutoSize = true;
            this.text_Duration.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_Duration.ForeColor = System.Drawing.Color.Silver;
            this.text_Duration.Location = new System.Drawing.Point(70, 84);
            this.text_Duration.Name = "text_Duration";
            this.text_Duration.Size = new System.Drawing.Size(75, 25);
            this.text_Duration.TabIndex = 186;
            this.text_Duration.Text = "Duration ";
            // 
            // text_Amount
            // 
            this.text_Amount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Amount.AutoSize = true;
            this.text_Amount.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_Amount.ForeColor = System.Drawing.Color.Silver;
            this.text_Amount.Location = new System.Drawing.Point(358, 84);
            this.text_Amount.Name = "text_Amount";
            this.text_Amount.Size = new System.Drawing.Size(67, 25);
            this.text_Amount.TabIndex = 187;
            this.text_Amount.Text = "Amount";
            // 
            // text_Ptg
            // 
            this.text_Ptg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Ptg.AutoSize = true;
            this.text_Ptg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_Ptg.ForeColor = System.Drawing.Color.Silver;
            this.text_Ptg.Location = new System.Drawing.Point(617, 84);
            this.text_Ptg.Name = "text_Ptg";
            this.text_Ptg.Size = new System.Drawing.Size(93, 25);
            this.text_Ptg.TabIndex = 188;
            this.text_Ptg.Text = "Percentage";
            // 
            // lblDiscountDuration
            // 
            this.lblDiscountDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountDuration.AutoSize = true;
            this.lblDiscountDuration.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDiscountDuration.Location = new System.Drawing.Point(24, 109);
            this.lblDiscountDuration.Name = "lblDiscountDuration";
            this.lblDiscountDuration.Size = new System.Drawing.Size(162, 25);
            this.lblDiscountDuration.TabIndex = 189;
            this.lblDiscountDuration.Text = "Start Date  - End Date";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDiscountAmount.Location = new System.Drawing.Point(358, 109);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(65, 25);
            this.lblDiscountAmount.TabIndex = 190;
            this.lblDiscountAmount.Text = "00,00 €";
            // 
            // lblDiscountPtg
            // 
            this.lblDiscountPtg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountPtg.AutoSize = true;
            this.lblDiscountPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDiscountPtg.Location = new System.Drawing.Point(633, 109);
            this.lblDiscountPtg.Name = "lblDiscountPtg";
            this.lblDiscountPtg.Size = new System.Drawing.Size(64, 25);
            this.lblDiscountPtg.TabIndex = 191;
            this.lblDiscountPtg.Text = "00,00 %";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 165);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(774, 10);
            this.bunifuSeparator1.TabIndex = 192;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // text_Products
            // 
            this.text_Products.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Products.AutoSize = true;
            this.text_Products.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Products.Location = new System.Drawing.Point(24, 134);
            this.text_Products.Name = "text_Products";
            this.text_Products.Size = new System.Drawing.Size(82, 28);
            this.text_Products.TabIndex = 193;
            this.text_Products.Text = "Products";
            // 
            // text_RetailPrice
            // 
            this.text_RetailPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_RetailPrice.AutoSize = true;
            this.text_RetailPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_RetailPrice.Location = new System.Drawing.Point(608, 134);
            this.text_RetailPrice.Name = "text_RetailPrice";
            this.text_RetailPrice.Size = new System.Drawing.Size(100, 28);
            this.text_RetailPrice.TabIndex = 194;
            this.text_RetailPrice.Text = "Retail Price";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(762, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 17);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 210;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DiscountProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.text_RetailPrice);
            this.Controls.Add(this.text_Products);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblDiscountPtg);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountDuration);
            this.Controls.Add(this.text_Ptg);
            this.Controls.Add(this.text_Amount);
            this.Controls.Add(this.text_Duration);
            this.Controls.Add(this.GridSeperator_Collapse);
            this.Controls.Add(this.lblDiscountDescription);
            this.Controls.Add(this.lblDiscountName);
            this.Controls.Add(this.ProductsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Discount Products";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        public System.Windows.Forms.FlowLayoutPanel ProductsGrid;
        private System.Windows.Forms.Label lblDiscountName;
        private System.Windows.Forms.Label lblDiscountDescription;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Collapse;
        private System.Windows.Forms.Label text_Duration;
        private System.Windows.Forms.Label text_Ptg;
        private System.Windows.Forms.Label text_Amount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblDiscountDuration;
        private System.Windows.Forms.Label lblDiscountPtg;
        private System.Windows.Forms.Label text_Products;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label text_RetailPrice;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
    }
}