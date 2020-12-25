namespace Vendstor.Forms.Products
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDuplicate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintLabel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardProductImage = new Bunifu.Framework.UI.BunifuCards();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_type = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.text_Brand = new System.Windows.Forms.Label();
            this.text_SHU = new System.Windows.Forms.Label();
            this.text_ProductId = new System.Windows.Forms.Label();
            this.text_AverageCost = new System.Windows.Forms.Label();
            this.text_SupplyPrice = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblProductAvgCost = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.text_Supplier = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.text_Markup = new System.Windows.Forms.Label();
            this.text_tax = new System.Windows.Forms.Label();
            this.text_RetailPrice = new System.Windows.Forms.Label();
            this.lblProductSupplyPrice = new System.Windows.Forms.Label();
            this.lblProductMarkupPtg = new System.Windows.Forms.Label();
            this.lblProductTax = new System.Windows.Forms.Label();
            this.lblProductRetailPrice = new System.Windows.Forms.Label();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.flpnlTags = new System.Windows.Forms.FlowLayoutPanel();
            this.TagModel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgProductBarcode = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlToolBox.SuspendLayout();
            this.cardProductImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.flpnlTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // HSeperator
            // 
            this.HSeperator.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator.LineThickness = 1;
            this.HSeperator.Location = new System.Drawing.Point(29, 260);
            this.HSeperator.Margin = new System.Windows.Forms.Padding(8);
            this.HSeperator.Name = "HSeperator";
            this.HSeperator.Size = new System.Drawing.Size(792, 10);
            this.HSeperator.TabIndex = 179;
            this.HSeperator.Transparency = 255;
            this.HSeperator.Vertical = false;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductDescription.Location = new System.Drawing.Point(194, 106);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(440, 120);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(436, 78);
            this.lblProductDescription.TabIndex = 180;
            this.lblProductDescription.Text = "_description bla bla _description bla bla  _description bla bla _description bla " +
    "bla \r\n _description bla bla _description bla bla \r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 14F);
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 33);
            this.lblTitle.TabIndex = 182;
            this.lblTitle.Text = "_Product_Name  , _Product_Type | _Price €";
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.AllowDrop = true;
            this.pnlToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlToolBox.Controls.Add(this.btnDelete);
            this.pnlToolBox.Controls.Add(this.btnDuplicate);
            this.pnlToolBox.Controls.Add(this.btnPrintLabel);
            this.pnlToolBox.Controls.Add(this.btnEditProduct);
            this.pnlToolBox.Location = new System.Drawing.Point(12, 44);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(827, 42);
            this.pnlToolBox.TabIndex = 187;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 37D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(791, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 191;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDuplicate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDuplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDuplicate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuplicate.BorderRadius = 5;
            this.btnDuplicate.ButtonText = "";
            this.btnDuplicate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuplicate.DisabledColor = System.Drawing.Color.Gray;
            this.btnDuplicate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDuplicate.Iconimage = global::Vendstor.Properties.Resources.duplicate_filled_w;
            this.btnDuplicate.Iconimage_right = null;
            this.btnDuplicate.Iconimage_right_Selected = null;
            this.btnDuplicate.Iconimage_Selected = null;
            this.btnDuplicate.IconMarginLeft = 0;
            this.btnDuplicate.IconMarginRight = 0;
            this.btnDuplicate.IconRightVisible = true;
            this.btnDuplicate.IconRightZoom = 0D;
            this.btnDuplicate.IconVisible = true;
            this.btnDuplicate.IconZoom = 37D;
            this.btnDuplicate.IsTab = false;
            this.btnDuplicate.Location = new System.Drawing.Point(80, 8);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDuplicate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDuplicate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDuplicate.selected = false;
            this.btnDuplicate.Size = new System.Drawing.Size(30, 26);
            this.btnDuplicate.TabIndex = 190;
            this.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuplicate.Textcolor = System.Drawing.Color.White;
            this.btnDuplicate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnPrintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnPrintLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintLabel.BorderRadius = 5;
            this.btnPrintLabel.ButtonText = "";
            this.btnPrintLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintLabel.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintLabel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintLabel.Iconimage = global::Vendstor.Properties.Resources.printer_filled_w;
            this.btnPrintLabel.Iconimage_right = null;
            this.btnPrintLabel.Iconimage_right_Selected = null;
            this.btnPrintLabel.Iconimage_Selected = null;
            this.btnPrintLabel.IconMarginLeft = 0;
            this.btnPrintLabel.IconMarginRight = 0;
            this.btnPrintLabel.IconRightVisible = true;
            this.btnPrintLabel.IconRightZoom = 0D;
            this.btnPrintLabel.IconVisible = true;
            this.btnPrintLabel.IconZoom = 37D;
            this.btnPrintLabel.IsTab = false;
            this.btnPrintLabel.Location = new System.Drawing.Point(42, 8);
            this.btnPrintLabel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnPrintLabel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnPrintLabel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintLabel.selected = false;
            this.btnPrintLabel.Size = new System.Drawing.Size(30, 26);
            this.btnPrintLabel.TabIndex = 189;
            this.btnPrintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintLabel.Textcolor = System.Drawing.Color.White;
            this.btnPrintLabel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLabel.Click += new System.EventHandler(this.BtnPrintLabel_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditProduct.BorderRadius = 5;
            this.btnEditProduct.ButtonText = "";
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditProduct.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.btnEditProduct.Iconimage_right = null;
            this.btnEditProduct.Iconimage_right_Selected = null;
            this.btnEditProduct.Iconimage_Selected = null;
            this.btnEditProduct.IconMarginLeft = 0;
            this.btnEditProduct.IconMarginRight = 0;
            this.btnEditProduct.IconRightVisible = true;
            this.btnEditProduct.IconRightZoom = 0D;
            this.btnEditProduct.IconVisible = true;
            this.btnEditProduct.IconZoom = 32D;
            this.btnEditProduct.IsTab = false;
            this.btnEditProduct.Location = new System.Drawing.Point(4, 8);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditProduct.selected = false;
            this.btnEditProduct.Size = new System.Drawing.Size(30, 26);
            this.btnEditProduct.TabIndex = 188;
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProduct.Textcolor = System.Drawing.Color.White;
            this.btnEditProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // cardProductImage
            // 
            this.cardProductImage.BackColor = System.Drawing.Color.White;
            this.cardProductImage.BorderRadius = 5;
            this.cardProductImage.BottomSahddow = true;
            this.cardProductImage.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.cardProductImage.Controls.Add(this.imgProductImage);
            this.cardProductImage.LeftSahddow = false;
            this.cardProductImage.Location = new System.Drawing.Point(658, 94);
            this.cardProductImage.Name = "cardProductImage";
            this.cardProductImage.RightSahddow = true;
            this.cardProductImage.ShadowDepth = 20;
            this.cardProductImage.Size = new System.Drawing.Size(177, 122);
            this.cardProductImage.TabIndex = 188;
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProductImage.Image = ((System.Drawing.Image)(resources.GetObject("imgProductImage.Image")));
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(0, 0);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(177, 122);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 2;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // text_type
            // 
            this.text_type.AutoSize = true;
            this.text_type.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_type.Location = new System.Drawing.Point(33, 359);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(51, 28);
            this.text_type.TabIndex = 189;
            this.text_type.Text = "Type";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductType.Location = new System.Drawing.Point(159, 361);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(123, 26);
            this.lblProductType.TabIndex = 190;
            this.lblProductType.Text = "_Product_Type";
            // 
            // text_Brand
            // 
            this.text_Brand.AutoSize = true;
            this.text_Brand.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Brand.Location = new System.Drawing.Point(33, 399);
            this.text_Brand.Name = "text_Brand";
            this.text_Brand.Size = new System.Drawing.Size(60, 28);
            this.text_Brand.TabIndex = 191;
            this.text_Brand.Text = "Brand";
            // 
            // text_SHU
            // 
            this.text_SHU.AutoSize = true;
            this.text_SHU.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_SHU.Location = new System.Drawing.Point(30, 320);
            this.text_SHU.Name = "text_SHU";
            this.text_SHU.Size = new System.Drawing.Size(80, 28);
            this.text_SHU.TabIndex = 192;
            this.text_SHU.Text = "Barcode";
            // 
            // text_ProductId
            // 
            this.text_ProductId.AutoSize = true;
            this.text_ProductId.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_ProductId.Location = new System.Drawing.Point(30, 283);
            this.text_ProductId.Name = "text_ProductId";
            this.text_ProductId.Size = new System.Drawing.Size(93, 28);
            this.text_ProductId.TabIndex = 193;
            this.text_ProductId.Text = "Product Id";
            // 
            // text_AverageCost
            // 
            this.text_AverageCost.AutoSize = true;
            this.text_AverageCost.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_AverageCost.Location = new System.Drawing.Point(33, 449);
            this.text_AverageCost.Name = "text_AverageCost";
            this.text_AverageCost.Size = new System.Drawing.Size(52, 28);
            this.text_AverageCost.TabIndex = 194;
            this.text_AverageCost.Text = " Cost";
            // 
            // text_SupplyPrice
            // 
            this.text_SupplyPrice.AutoSize = true;
            this.text_SupplyPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_SupplyPrice.Location = new System.Drawing.Point(427, 322);
            this.text_SupplyPrice.Name = "text_SupplyPrice";
            this.text_SupplyPrice.Size = new System.Drawing.Size(109, 28);
            this.text_SupplyPrice.TabIndex = 195;
            this.text_SupplyPrice.Text = "Supply Price";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductBrand.Location = new System.Drawing.Point(159, 401);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(131, 26);
            this.lblProductBrand.TabIndex = 196;
            this.lblProductBrand.Text = "_Product_Brand";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductBarcode.Location = new System.Drawing.Point(159, 324);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(150, 26);
            this.lblProductBarcode.TabIndex = 197;
            this.lblProductBarcode.Text = "_Product_Barcode";
            // 
            // lblProductAvgCost
            // 
            this.lblProductAvgCost.AutoSize = true;
            this.lblProductAvgCost.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductAvgCost.Location = new System.Drawing.Point(159, 451);
            this.lblProductAvgCost.Name = "lblProductAvgCost";
            this.lblProductAvgCost.Size = new System.Drawing.Size(60, 26);
            this.lblProductAvgCost.TabIndex = 198;
            this.lblProductAvgCost.Text = "@Beta";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductId.Location = new System.Drawing.Point(159, 284);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(101, 26);
            this.lblProductId.TabIndex = 199;
            this.lblProductId.Text = "_Product_Id";
            // 
            // text_Supplier
            // 
            this.text_Supplier.AutoSize = true;
            this.text_Supplier.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Supplier.Location = new System.Drawing.Point(426, 280);
            this.text_Supplier.Name = "text_Supplier";
            this.text_Supplier.Size = new System.Drawing.Size(77, 28);
            this.text_Supplier.TabIndex = 200;
            this.text_Supplier.Text = "Supplier";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductSupplier.Location = new System.Drawing.Point(560, 281);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(146, 26);
            this.lblProductSupplier.TabIndex = 201;
            this.lblProductSupplier.Text = "_Product_Supplier";
            // 
            // text_Markup
            // 
            this.text_Markup.AutoSize = true;
            this.text_Markup.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Markup.Location = new System.Drawing.Point(427, 359);
            this.text_Markup.Name = "text_Markup";
            this.text_Markup.Size = new System.Drawing.Size(76, 28);
            this.text_Markup.TabIndex = 202;
            this.text_Markup.Text = "Markup ";
            // 
            // text_tax
            // 
            this.text_tax.AutoSize = true;
            this.text_tax.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_tax.Location = new System.Drawing.Point(427, 401);
            this.text_tax.Name = "text_tax";
            this.text_tax.Size = new System.Drawing.Size(40, 28);
            this.text_tax.TabIndex = 203;
            this.text_tax.Text = "Tax";
            // 
            // text_RetailPrice
            // 
            this.text_RetailPrice.AutoSize = true;
            this.text_RetailPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_RetailPrice.Location = new System.Drawing.Point(426, 445);
            this.text_RetailPrice.Name = "text_RetailPrice";
            this.text_RetailPrice.Size = new System.Drawing.Size(51, 28);
            this.text_RetailPrice.TabIndex = 204;
            this.text_RetailPrice.Text = "Price";
            // 
            // lblProductSupplyPrice
            // 
            this.lblProductSupplyPrice.AutoSize = true;
            this.lblProductSupplyPrice.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductSupplyPrice.Location = new System.Drawing.Point(560, 322);
            this.lblProductSupplyPrice.Name = "lblProductSupplyPrice";
            this.lblProductSupplyPrice.Size = new System.Drawing.Size(181, 26);
            this.lblProductSupplyPrice.TabIndex = 205;
            this.lblProductSupplyPrice.Text = "_Product_Supply_Price";
            // 
            // lblProductMarkupPtg
            // 
            this.lblProductMarkupPtg.AutoSize = true;
            this.lblProductMarkupPtg.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductMarkupPtg.Location = new System.Drawing.Point(560, 361);
            this.lblProductMarkupPtg.Name = "lblProductMarkupPtg";
            this.lblProductMarkupPtg.Size = new System.Drawing.Size(142, 26);
            this.lblProductMarkupPtg.TabIndex = 206;
            this.lblProductMarkupPtg.Text = "_Product_Markup";
            // 
            // lblProductTax
            // 
            this.lblProductTax.AutoSize = true;
            this.lblProductTax.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductTax.Location = new System.Drawing.Point(560, 400);
            this.lblProductTax.Name = "lblProductTax";
            this.lblProductTax.Size = new System.Drawing.Size(113, 26);
            this.lblProductTax.TabIndex = 207;
            this.lblProductTax.Text = "_Product_Tax";
            // 
            // lblProductRetailPrice
            // 
            this.lblProductRetailPrice.AutoSize = true;
            this.lblProductRetailPrice.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductRetailPrice.Location = new System.Drawing.Point(560, 445);
            this.lblProductRetailPrice.Name = "lblProductRetailPrice";
            this.lblProductRetailPrice.Size = new System.Drawing.Size(171, 26);
            this.lblProductRetailPrice.TabIndex = 208;
            this.lblProductRetailPrice.Text = "_Product_Retail_Price";
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(817, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 209;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // flpnlTags
            // 
            this.flpnlTags.Controls.Add(this.TagModel);
            this.flpnlTags.Location = new System.Drawing.Point(27, 219);
            this.flpnlTags.Name = "flpnlTags";
            this.flpnlTags.Size = new System.Drawing.Size(538, 40);
            this.flpnlTags.TabIndex = 210;
            // 
            // TagModel
            // 
            this.TagModel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TagModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TagModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TagModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TagModel.BorderRadius = 5;
            this.TagModel.ButtonText = "@Beta";
            this.TagModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TagModel.DisabledColor = System.Drawing.Color.Gray;
            this.TagModel.Iconcolor = System.Drawing.Color.Transparent;
            this.TagModel.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.TagModel.Iconimage_right = null;
            this.TagModel.Iconimage_right_Selected = null;
            this.TagModel.Iconimage_Selected = null;
            this.TagModel.IconMarginLeft = 0;
            this.TagModel.IconMarginRight = 0;
            this.TagModel.IconRightVisible = true;
            this.TagModel.IconRightZoom = 0D;
            this.TagModel.IconVisible = false;
            this.TagModel.IconZoom = 37D;
            this.TagModel.IsTab = false;
            this.TagModel.Location = new System.Drawing.Point(4, 4);
            this.TagModel.Margin = new System.Windows.Forms.Padding(4);
            this.TagModel.Name = "TagModel";
            this.TagModel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TagModel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TagModel.OnHoverTextColor = System.Drawing.Color.White;
            this.TagModel.selected = false;
            this.TagModel.Size = new System.Drawing.Size(74, 26);
            this.TagModel.TabIndex = 189;
            this.TagModel.Text = "@Beta";
            this.TagModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TagModel.Textcolor = System.Drawing.Color.White;
            this.TagModel.TextFont = new System.Drawing.Font("Poppins Light", 8F);
            // 
            // imgProductBarcode
            // 
            this.imgProductBarcode.BackColor = System.Drawing.Color.Transparent;
            this.imgProductBarcode.Image = ((System.Drawing.Image)(resources.GetObject("imgProductBarcode.Image")));
            this.imgProductBarcode.ImageActive = null;
            this.imgProductBarcode.Location = new System.Drawing.Point(12, 92);
            this.imgProductBarcode.Name = "imgProductBarcode";
            this.imgProductBarcode.Size = new System.Drawing.Size(176, 68);
            this.imgProductBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductBarcode.TabIndex = 211;
            this.imgProductBarcode.TabStop = false;
            this.imgProductBarcode.Zoom = 10;
            this.imgProductBarcode.Click += new System.EventHandler(this.ImgProductBarcode_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(this.imgProductBarcode);
            this.Controls.Add(this.flpnlTags);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.lblProductRetailPrice);
            this.Controls.Add(this.lblProductTax);
            this.Controls.Add(this.lblProductMarkupPtg);
            this.Controls.Add(this.lblProductSupplyPrice);
            this.Controls.Add(this.text_RetailPrice);
            this.Controls.Add(this.text_tax);
            this.Controls.Add(this.text_Markup);
            this.Controls.Add(this.lblProductSupplier);
            this.Controls.Add(this.text_Supplier);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblProductAvgCost);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.lblProductBrand);
            this.Controls.Add(this.text_SupplyPrice);
            this.Controls.Add(this.text_AverageCost);
            this.Controls.Add(this.text_ProductId);
            this.Controls.Add(this.text_SHU);
            this.Controls.Add(this.text_Brand);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.cardProductImage);
            this.Controls.Add(this.HSeperator);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProductDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Product Details";
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlToolBox.ResumeLayout(false);
            this.cardProductImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.flpnlTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolBox;
        private Bunifu.Framework.UI.BunifuCards cardProductImage;
        private Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private System.Windows.Forms.Label text_type;
        private System.Windows.Forms.Label text_Supplier;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductAvgCost;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label text_SupplyPrice;
        private System.Windows.Forms.Label text_AverageCost;
        private System.Windows.Forms.Label text_ProductId;
        private System.Windows.Forms.Label text_SHU;
        private System.Windows.Forms.Label text_Brand;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Label lblProductRetailPrice;
        private System.Windows.Forms.Label lblProductTax;
        private System.Windows.Forms.Label lblProductMarkupPtg;
        private System.Windows.Forms.Label lblProductSupplyPrice;
        private System.Windows.Forms.Label text_RetailPrice;
        private System.Windows.Forms.Label text_tax;
        private System.Windows.Forms.Label text_Markup;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnDuplicate;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintLabel;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.FlowLayoutPanel flpnlTags;
        private Bunifu.Framework.UI.BunifuFlatButton TagModel;
        private Bunifu.Framework.UI.BunifuImageButton imgProductBarcode;
    }
}