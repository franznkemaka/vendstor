namespace Vendstor.UserControls.Dashboard.Products
{
    partial class StockControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            this.cardProduct = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHideProductDetails = new System.Windows.Forms.Panel();
            this.text_SelectProduct = new System.Windows.Forms.Label();
            this.btnSelectProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.lblProductSupplyPrice = new System.Windows.Forms.Label();
            this.text_SupplyPrice = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.text_Supplier = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.cardProductImage = new Bunifu.Framework.UI.BunifuCards();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_Barcode = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cardStock = new Bunifu.Framework.UI.BunifuCards();
            this.btnRemoveStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtStock = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cardStockDetails = new Bunifu.Framework.UI.BunifuCards();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.text_CurrentStock = new System.Windows.Forms.Label();
            this.imgpnlProduct_Card = new System.Windows.Forms.Panel();
            this.imgProduct_Card = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardProduct.SuspendLayout();
            this.pnlHideProductDetails.SuspendLayout();
            this.cardProductImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.cardStock.SuspendLayout();
            this.cardStockDetails.SuspendLayout();
            this.imgpnlProduct_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct_Card)).BeginInit();
            this.SuspendLayout();
            // 
            // cardProduct
            // 
            this.cardProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardProduct.BackColor = System.Drawing.Color.White;
            this.cardProduct.BorderRadius = 10;
            this.cardProduct.BottomSahddow = false;
            this.cardProduct.color = System.Drawing.Color.White;
            this.cardProduct.Controls.Add(this.pnlHideProductDetails);
            this.cardProduct.Controls.Add(this.btnSelectProduct);
            this.cardProduct.Controls.Add(this.lblProductPrice);
            this.cardProduct.Controls.Add(this.text_Price);
            this.cardProduct.Controls.Add(this.lblProductSupplyPrice);
            this.cardProduct.Controls.Add(this.text_SupplyPrice);
            this.cardProduct.Controls.Add(this.lblProductSupplier);
            this.cardProduct.Controls.Add(this.text_Supplier);
            this.cardProduct.Controls.Add(this.lblProductBarcode);
            this.cardProduct.Controls.Add(this.cardProductImage);
            this.cardProduct.Controls.Add(this.text_Barcode);
            this.cardProduct.Controls.Add(this.lblProductId);
            this.cardProduct.Controls.Add(this.lblProductName);
            this.cardProduct.LeftSahddow = false;
            this.cardProduct.Location = new System.Drawing.Point(135, 22);
            this.cardProduct.Name = "cardProduct";
            this.cardProduct.RightSahddow = false;
            this.cardProduct.ShadowDepth = 20;
            this.cardProduct.Size = new System.Drawing.Size(858, 180);
            this.cardProduct.TabIndex = 4;
            // 
            // pnlHideProductDetails
            // 
            this.pnlHideProductDetails.Controls.Add(this.text_SelectProduct);
            this.pnlHideProductDetails.Location = new System.Drawing.Point(22, 24);
            this.pnlHideProductDetails.Name = "pnlHideProductDetails";
            this.pnlHideProductDetails.Size = new System.Drawing.Size(650, 99);
            this.pnlHideProductDetails.TabIndex = 6;
            // 
            // text_SelectProduct
            // 
            this.text_SelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_SelectProduct.Font = new System.Drawing.Font("Poppins", 16F);
            this.text_SelectProduct.Location = new System.Drawing.Point(0, 30);
            this.text_SelectProduct.Name = "text_SelectProduct";
            this.text_SelectProduct.Size = new System.Drawing.Size(650, 39);
            this.text_SelectProduct.TabIndex = 208;
            this.text_SelectProduct.Text = "Select a Product to Update Stock";
            this.text_SelectProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSelectProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectProduct.BorderRadius = 5;
            this.btnSelectProduct.ButtonText = "Select Product";
            this.btnSelectProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelectProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelectProduct.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnSelectProduct.Iconimage_right = null;
            this.btnSelectProduct.Iconimage_right_Selected = null;
            this.btnSelectProduct.Iconimage_Selected = null;
            this.btnSelectProduct.IconMarginLeft = 0;
            this.btnSelectProduct.IconMarginRight = 0;
            this.btnSelectProduct.IconRightVisible = true;
            this.btnSelectProduct.IconRightZoom = 0D;
            this.btnSelectProduct.IconVisible = true;
            this.btnSelectProduct.IconZoom = 45D;
            this.btnSelectProduct.IsTab = false;
            this.btnSelectProduct.Location = new System.Drawing.Point(678, 132);
            this.btnSelectProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSelectProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSelectProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelectProduct.selected = false;
            this.btnSelectProduct.Size = new System.Drawing.Size(162, 37);
            this.btnSelectProduct.TabIndex = 145;
            this.btnSelectProduct.Text = "Select Product";
            this.btnSelectProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectProduct.Textcolor = System.Drawing.Color.White;
            this.btnSelectProduct.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnSelectProduct.Click += new System.EventHandler(this.BtnSelectProduct_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblProductPrice.Location = new System.Drawing.Point(499, 92);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(104, 39);
            this.lblProductPrice.TabIndex = 218;
            this.lblProductPrice.Text = "€_Price";
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Price.Location = new System.Drawing.Point(364, 98);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(51, 28);
            this.text_Price.TabIndex = 217;
            this.text_Price.Text = "Price";
            // 
            // lblProductSupplyPrice
            // 
            this.lblProductSupplyPrice.AutoSize = true;
            this.lblProductSupplyPrice.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductSupplyPrice.Location = new System.Drawing.Point(491, 60);
            this.lblProductSupplyPrice.Name = "lblProductSupplyPrice";
            this.lblProductSupplyPrice.Size = new System.Drawing.Size(181, 26);
            this.lblProductSupplyPrice.TabIndex = 216;
            this.lblProductSupplyPrice.Text = "_Product_Supply_Price";
            // 
            // text_SupplyPrice
            // 
            this.text_SupplyPrice.AutoSize = true;
            this.text_SupplyPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_SupplyPrice.Location = new System.Drawing.Point(364, 58);
            this.text_SupplyPrice.Name = "text_SupplyPrice";
            this.text_SupplyPrice.Size = new System.Drawing.Size(109, 28);
            this.text_SupplyPrice.TabIndex = 215;
            this.text_SupplyPrice.Text = "Supply Price";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductSupplier.Location = new System.Drawing.Point(491, 24);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(146, 26);
            this.lblProductSupplier.TabIndex = 214;
            this.lblProductSupplier.Text = "_Product_Supplier";
            // 
            // text_Supplier
            // 
            this.text_Supplier.AutoSize = true;
            this.text_Supplier.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Supplier.Location = new System.Drawing.Point(364, 24);
            this.text_Supplier.Name = "text_Supplier";
            this.text_Supplier.Size = new System.Drawing.Size(77, 28);
            this.text_Supplier.TabIndex = 213;
            this.text_Supplier.Text = "Supplier";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductBarcode.Location = new System.Drawing.Point(137, 97);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(150, 26);
            this.lblProductBarcode.TabIndex = 199;
            this.lblProductBarcode.Text = "_Product_Barcode";
            // 
            // cardProductImage
            // 
            this.cardProductImage.BackColor = System.Drawing.Color.White;
            this.cardProductImage.BorderRadius = 5;
            this.cardProductImage.BottomSahddow = true;
            this.cardProductImage.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.cardProductImage.Controls.Add(this.imgProductImage);
            this.cardProductImage.LeftSahddow = false;
            this.cardProductImage.Location = new System.Drawing.Point(678, 12);
            this.cardProductImage.Name = "cardProductImage";
            this.cardProductImage.RightSahddow = true;
            this.cardProductImage.ShadowDepth = 20;
            this.cardProductImage.Size = new System.Drawing.Size(161, 113);
            this.cardProductImage.TabIndex = 212;
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProductImage.Image = ((System.Drawing.Image)(resources.GetObject("imgProductImage.Image")));
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(0, 0);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(161, 113);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 2;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // text_Barcode
            // 
            this.text_Barcode.AutoSize = true;
            this.text_Barcode.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Barcode.Location = new System.Drawing.Point(51, 97);
            this.text_Barcode.Name = "text_Barcode";
            this.text_Barcode.Size = new System.Drawing.Size(80, 28);
            this.text_Barcode.TabIndex = 198;
            this.text_Barcode.Text = "Barcode";
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.Silver;
            this.lblProductId.Location = new System.Drawing.Point(51, 58);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(101, 26);
            this.lblProductId.TabIndex = 208;
            this.lblProductId.Text = "_Product_Id";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblProductName.Location = new System.Drawing.Point(42, 19);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(201, 39);
            this.lblProductName.TabIndex = 207;
            this.lblProductName.Text = "_Product_Name";
            // 
            // cardStock
            // 
            this.cardStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStock.BackColor = System.Drawing.Color.White;
            this.cardStock.BorderRadius = 10;
            this.cardStock.BottomSahddow = false;
            this.cardStock.color = System.Drawing.Color.White;
            this.cardStock.Controls.Add(this.btnRemoveStock);
            this.cardStock.Controls.Add(this.txtStock);
            this.cardStock.Controls.Add(this.cardStockDetails);
            this.cardStock.Controls.Add(this.btnAddStock);
            this.cardStock.LeftSahddow = false;
            this.cardStock.Location = new System.Drawing.Point(370, 218);
            this.cardStock.Name = "cardStock";
            this.cardStock.RightSahddow = false;
            this.cardStock.ShadowDepth = 20;
            this.cardStock.Size = new System.Drawing.Size(402, 302);
            this.cardStock.TabIndex = 5;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Activecolor = System.Drawing.Color.Tomato;
            this.btnRemoveStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveStock.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnRemoveStock.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveStock.BorderRadius = 5;
            this.btnRemoveStock.ButtonText = "Decrease";
            this.btnRemoveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemoveStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemoveStock.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnRemoveStock.Iconimage_right = null;
            this.btnRemoveStock.Iconimage_right_Selected = null;
            this.btnRemoveStock.Iconimage_Selected = null;
            this.btnRemoveStock.IconMarginLeft = 0;
            this.btnRemoveStock.IconMarginRight = 0;
            this.btnRemoveStock.IconRightVisible = true;
            this.btnRemoveStock.IconRightZoom = 0D;
            this.btnRemoveStock.IconVisible = true;
            this.btnRemoveStock.IconZoom = 45D;
            this.btnRemoveStock.IsTab = false;
            this.btnRemoveStock.Location = new System.Drawing.Point(36, 245);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Normalcolor = System.Drawing.Color.Tomato;
            this.btnRemoveStock.OnHovercolor = System.Drawing.Color.Tomato;
            this.btnRemoveStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveStock.selected = false;
            this.btnRemoveStock.Size = new System.Drawing.Size(127, 37);
            this.btnRemoveStock.TabIndex = 216;
            this.btnRemoveStock.Text = "Decrease";
            this.btnRemoveStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveStock.Textcolor = System.Drawing.Color.White;
            this.btnRemoveStock.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // txtStock
            // 
            this.txtStock.AutoScroll = true;
            this.txtStock.AutoSize = true;
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStock.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStock.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStock.BorderThickness = 2;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.txtStock.ForeColor = System.Drawing.Color.DimGray;
            this.txtStock.isPassword = false;
            this.txtStock.Location = new System.Drawing.Point(157, 133);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(89, 61);
            this.txtStock.TabIndex = 215;
            this.txtStock.Text = "0";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardStockDetails
            // 
            this.cardStockDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStockDetails.BackColor = System.Drawing.Color.White;
            this.cardStockDetails.BorderRadius = 10;
            this.cardStockDetails.BottomSahddow = true;
            this.cardStockDetails.color = System.Drawing.Color.Transparent;
            this.cardStockDetails.Controls.Add(this.lblCurrentStock);
            this.cardStockDetails.Controls.Add(this.text_CurrentStock);
            this.cardStockDetails.Controls.Add(this.imgpnlProduct_Card);
            this.cardStockDetails.LeftSahddow = false;
            this.cardStockDetails.Location = new System.Drawing.Point(49, 29);
            this.cardStockDetails.Name = "cardStockDetails";
            this.cardStockDetails.RightSahddow = true;
            this.cardStockDetails.ShadowDepth = 10;
            this.cardStockDetails.Size = new System.Drawing.Size(304, 95);
            this.cardStockDetails.TabIndex = 212;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentStock.Location = new System.Drawing.Point(152, 38);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(71, 48);
            this.lblCurrentStock.TabIndex = 2;
            this.lblCurrentStock.Text = "999";
            // 
            // text_CurrentStock
            // 
            this.text_CurrentStock.AutoSize = true;
            this.text_CurrentStock.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_CurrentStock.Location = new System.Drawing.Point(122, 10);
            this.text_CurrentStock.Name = "text_CurrentStock";
            this.text_CurrentStock.Size = new System.Drawing.Size(119, 28);
            this.text_CurrentStock.TabIndex = 1;
            this.text_CurrentStock.Text = "Current Stock";
            // 
            // imgpnlProduct_Card
            // 
            this.imgpnlProduct_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlProduct_Card.Controls.Add(this.imgProduct_Card);
            this.imgpnlProduct_Card.Location = new System.Drawing.Point(23, 18);
            this.imgpnlProduct_Card.Name = "imgpnlProduct_Card";
            this.imgpnlProduct_Card.Size = new System.Drawing.Size(49, 47);
            this.imgpnlProduct_Card.TabIndex = 8;
            // 
            // imgProduct_Card
            // 
            this.imgProduct_Card.BackColor = System.Drawing.Color.Transparent;
            this.imgProduct_Card.Image = global::Vendstor.Properties.Resources.products_filled_w;
            this.imgProduct_Card.ImageActive = null;
            this.imgProduct_Card.Location = new System.Drawing.Point(7, 6);
            this.imgProduct_Card.Name = "imgProduct_Card";
            this.imgProduct_Card.Size = new System.Drawing.Size(35, 35);
            this.imgProduct_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct_Card.TabIndex = 3;
            this.imgProduct_Card.TabStop = false;
            this.imgProduct_Card.Zoom = 10;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStock.BorderRadius = 5;
            this.btnAddStock.ButtonText = "Add";
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddStock.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnAddStock.Iconimage_right = null;
            this.btnAddStock.Iconimage_right_Selected = null;
            this.btnAddStock.Iconimage_Selected = null;
            this.btnAddStock.IconMarginLeft = 0;
            this.btnAddStock.IconMarginRight = 0;
            this.btnAddStock.IconRightVisible = true;
            this.btnAddStock.IconRightZoom = 0D;
            this.btnAddStock.IconVisible = true;
            this.btnAddStock.IconZoom = 45D;
            this.btnAddStock.IsTab = false;
            this.btnAddStock.Location = new System.Drawing.Point(246, 245);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddStock.selected = false;
            this.btnAddStock.Size = new System.Drawing.Size(107, 37);
            this.btnAddStock.TabIndex = 143;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStock.Textcolor = System.Drawing.Color.White;
            this.btnAddStock.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardStock);
            this.Controls.Add(this.cardProduct);
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.cardProduct.ResumeLayout(false);
            this.cardProduct.PerformLayout();
            this.pnlHideProductDetails.ResumeLayout(false);
            this.cardProductImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.cardStock.ResumeLayout(false);
            this.cardStock.PerformLayout();
            this.cardStockDetails.ResumeLayout(false);
            this.cardStockDetails.PerformLayout();
            this.imgpnlProduct_Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct_Card)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardProduct;
        private Bunifu.Framework.UI.BunifuCards cardStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddStock;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private Bunifu.Framework.UI.BunifuCards cardProductImage;
        private Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label text_Barcode;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Label text_Supplier;
        private System.Windows.Forms.Label lblProductSupplyPrice;
        private System.Windows.Forms.Label text_SupplyPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label text_Price;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelectProduct;
        private Bunifu.Framework.UI.BunifuCards cardStockDetails;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label text_CurrentStock;
        private System.Windows.Forms.Panel imgpnlProduct_Card;
        private Bunifu.Framework.UI.BunifuImageButton imgProduct_Card;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemoveStock;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStock;
        private System.Windows.Forms.Panel pnlHideProductDetails;
        private System.Windows.Forms.Label text_SelectProduct;
    }
}
