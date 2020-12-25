namespace Vendstor.Forms.Products
{
    partial class ProductLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductLabel));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlLabelViewer = new System.Windows.Forms.Panel();
            this.labelViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_ProductLabel = new System.Windows.Forms.Label();
            this.vSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Name = new System.Windows.Forms.Label();
            this.txtProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_StoreName = new System.Windows.Forms.Label();
            this.txtStoreName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_StoreAddress = new System.Windows.Forms.Label();
            this.txtStoreAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Barcode = new System.Windows.Forms.Label();
            this.txtProductBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Address = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_SupplierName = new System.Windows.Forms.Label();
            this.txtSupplierName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtProductPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Price = new System.Windows.Forms.Label();
            this.text_Note = new System.Windows.Forms.Label();
            this.txtNote = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtX = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.pnlLabelViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(830, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 209;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // pnlLabelViewer
            // 
            this.pnlLabelViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlLabelViewer.Controls.Add(this.labelViewer);
            this.pnlLabelViewer.Location = new System.Drawing.Point(12, 59);
            this.pnlLabelViewer.Name = "pnlLabelViewer";
            this.pnlLabelViewer.Size = new System.Drawing.Size(373, 417);
            this.pnlLabelViewer.TabIndex = 213;
            // 
            // labelViewer
            // 
            this.labelViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.labelViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelViewer.LocalReport.ReportEmbeddedResource = "Vendstor.Templates.ProductLabel.rdlc";
            this.labelViewer.Location = new System.Drawing.Point(0, 0);
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.ServerReport.BearerToken = null;
            this.labelViewer.Size = new System.Drawing.Size(373, 417);
            this.labelViewer.TabIndex = 184;
            // 
            // hSep
            // 
            this.hSep.BackColor = System.Drawing.Color.Transparent;
            this.hSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.hSep.LineThickness = 2;
            this.hSep.Location = new System.Drawing.Point(19, 42);
            this.hSep.Margin = new System.Windows.Forms.Padding(4);
            this.hSep.Name = "hSep";
            this.hSep.Size = new System.Drawing.Size(151, 10);
            this.hSep.TabIndex = 212;
            this.hSep.Transparency = 255;
            this.hSep.Vertical = false;
            // 
            // text_ProductLabel
            // 
            this.text_ProductLabel.AutoSize = true;
            this.text_ProductLabel.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_ProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_ProductLabel.Location = new System.Drawing.Point(13, 9);
            this.text_ProductLabel.Name = "text_ProductLabel";
            this.text_ProductLabel.Size = new System.Drawing.Size(152, 35);
            this.text_ProductLabel.TabIndex = 211;
            this.text_ProductLabel.Text = "Product Label";
            // 
            // vSep
            // 
            this.vSep.BackColor = System.Drawing.Color.Transparent;
            this.vSep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.vSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.vSep.LineThickness = 1;
            this.vSep.Location = new System.Drawing.Point(392, 10);
            this.vSep.Margin = new System.Windows.Forms.Padding(4);
            this.vSep.Name = "vSep";
            this.vSep.Size = new System.Drawing.Size(18, 506);
            this.vSep.TabIndex = 210;
            this.vSep.Transparency = 255;
            this.vSep.Vertical = true;
            // 
            // text_Name
            // 
            this.text_Name.AutoSize = true;
            this.text_Name.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Name.Location = new System.Drawing.Point(415, 195);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(116, 26);
            this.text_Name.TabIndex = 214;
            this.text_Name.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.AutoScroll = true;
            this.txtProductName.AutoSize = true;
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtProductName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductName.BorderThickness = 2;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtProductName.ForeColor = System.Drawing.Color.DimGray;
            this.txtProductName.isPassword = false;
            this.txtProductName.Location = new System.Drawing.Point(418, 227);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(402, 43);
            this.txtProductName.TabIndex = 215;
            this.txtProductName.Tag = " ";
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_StoreName
            // 
            this.text_StoreName.AutoSize = true;
            this.text_StoreName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_StoreName.Location = new System.Drawing.Point(413, 18);
            this.text_StoreName.Name = "text_StoreName";
            this.text_StoreName.Size = new System.Drawing.Size(98, 26);
            this.text_StoreName.TabIndex = 216;
            this.text_StoreName.Text = "Store Name";
            // 
            // txtStoreName
            // 
            this.txtStoreName.AutoScroll = true;
            this.txtStoreName.AutoSize = true;
            this.txtStoreName.BackColor = System.Drawing.Color.White;
            this.txtStoreName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreName.BorderThickness = 2;
            this.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStoreName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreName.isPassword = false;
            this.txtStoreName.Location = new System.Drawing.Point(409, 50);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(216, 43);
            this.txtStoreName.TabIndex = 217;
            this.txtStoreName.Tag = " ";
            this.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_StoreAddress
            // 
            this.text_StoreAddress.AutoSize = true;
            this.text_StoreAddress.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_StoreAddress.Location = new System.Drawing.Point(644, 18);
            this.text_StoreAddress.Name = "text_StoreAddress";
            this.text_StoreAddress.Size = new System.Drawing.Size(72, 26);
            this.text_StoreAddress.TabIndex = 218;
            this.text_StoreAddress.Text = "Address";
            // 
            // txtStoreAddress
            // 
            this.txtStoreAddress.AutoScroll = true;
            this.txtStoreAddress.AutoSize = true;
            this.txtStoreAddress.BackColor = System.Drawing.Color.White;
            this.txtStoreAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreAddress.BorderThickness = 2;
            this.txtStoreAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreAddress.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStoreAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreAddress.isPassword = false;
            this.txtStoreAddress.Location = new System.Drawing.Point(640, 50);
            this.txtStoreAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStoreAddress.Name = "txtStoreAddress";
            this.txtStoreAddress.Size = new System.Drawing.Size(180, 43);
            this.txtStoreAddress.TabIndex = 219;
            this.txtStoreAddress.Tag = " ";
            this.txtStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_Barcode
            // 
            this.text_Barcode.AutoSize = true;
            this.text_Barcode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Barcode.Location = new System.Drawing.Point(415, 276);
            this.text_Barcode.Name = "text_Barcode";
            this.text_Barcode.Size = new System.Drawing.Size(74, 26);
            this.text_Barcode.TabIndex = 220;
            this.text_Barcode.Text = "Barcode";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.AutoScroll = true;
            this.txtProductBarcode.AutoSize = true;
            this.txtProductBarcode.BackColor = System.Drawing.Color.White;
            this.txtProductBarcode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtProductBarcode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductBarcode.BorderThickness = 2;
            this.txtProductBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductBarcode.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtProductBarcode.ForeColor = System.Drawing.Color.DimGray;
            this.txtProductBarcode.isPassword = false;
            this.txtProductBarcode.Location = new System.Drawing.Point(418, 308);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(203, 43);
            this.txtProductBarcode.TabIndex = 221;
            this.txtProductBarcode.Tag = " ";
            this.txtProductBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_Address
            // 
            this.text_Address.AutoSize = true;
            this.text_Address.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Address.Location = new System.Drawing.Point(644, 103);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(72, 26);
            this.text_Address.TabIndex = 224;
            this.text_Address.Text = "Address";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.AutoScroll = true;
            this.txtSupplierAddress.AutoSize = true;
            this.txtSupplierAddress.BackColor = System.Drawing.Color.White;
            this.txtSupplierAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtSupplierAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierAddress.BorderThickness = 2;
            this.txtSupplierAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtSupplierAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupplierAddress.isPassword = false;
            this.txtSupplierAddress.Location = new System.Drawing.Point(640, 135);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(180, 43);
            this.txtSupplierAddress.TabIndex = 225;
            this.txtSupplierAddress.Tag = " ";
            this.txtSupplierAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_SupplierName
            // 
            this.text_SupplierName.AutoSize = true;
            this.text_SupplierName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_SupplierName.Location = new System.Drawing.Point(413, 103);
            this.text_SupplierName.Name = "text_SupplierName";
            this.text_SupplierName.Size = new System.Drawing.Size(118, 26);
            this.text_SupplierName.TabIndex = 222;
            this.text_SupplierName.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AutoScroll = true;
            this.txtSupplierName.AutoSize = true;
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtSupplierName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierName.BorderThickness = 2;
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtSupplierName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupplierName.isPassword = false;
            this.txtSupplierName.Location = new System.Drawing.Point(409, 135);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(216, 43);
            this.txtSupplierName.TabIndex = 223;
            this.txtSupplierName.Tag = " ";
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AutoScroll = true;
            this.txtProductPrice.AutoSize = true;
            this.txtProductPrice.BackColor = System.Drawing.Color.White;
            this.txtProductPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtProductPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtProductPrice.BorderThickness = 2;
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtProductPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtProductPrice.isPassword = false;
            this.txtProductPrice.Location = new System.Drawing.Point(629, 308);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(191, 43);
            this.txtProductPrice.TabIndex = 227;
            this.txtProductPrice.Tag = " ";
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Price.Location = new System.Drawing.Point(635, 276);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(46, 26);
            this.text_Price.TabIndex = 226;
            this.text_Price.Text = "Price";
            // 
            // text_Note
            // 
            this.text_Note.AutoSize = true;
            this.text_Note.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Note.Location = new System.Drawing.Point(415, 368);
            this.text_Note.Name = "text_Note";
            this.text_Note.Size = new System.Drawing.Size(46, 26);
            this.text_Note.TabIndex = 228;
            this.text_Note.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.AutoScroll = true;
            this.txtNote.AutoSize = true;
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtNote.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtNote.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtNote.BorderThickness = 2;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtNote.ForeColor = System.Drawing.Color.DimGray;
            this.txtNote.isPassword = false;
            this.txtNote.Location = new System.Drawing.Point(418, 400);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(402, 43);
            this.txtNote.TabIndex = 229;
            this.txtNote.Text = "Best Before : ";
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.BorderRadius = 5;
            this.btnGenerate.ButtonText = "Generate (F7)";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Iconimage")));
            this.btnGenerate.Iconimage_right = null;
            this.btnGenerate.Iconimage_right_Selected = null;
            this.btnGenerate.Iconimage_Selected = null;
            this.btnGenerate.IconMarginLeft = 10;
            this.btnGenerate.IconMarginRight = 0;
            this.btnGenerate.IconRightVisible = true;
            this.btnGenerate.IconRightZoom = 0D;
            this.btnGenerate.IconVisible = true;
            this.btnGenerate.IconZoom = 30D;
            this.btnGenerate.IsTab = false;
            this.btnGenerate.Location = new System.Drawing.Point(431, 453);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGenerate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerate.selected = false;
            this.btnGenerate.Size = new System.Drawing.Size(377, 47);
            this.btnGenerate.TabIndex = 230;
            this.btnGenerate.Text = "Generate (F7)";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Textcolor = System.Drawing.Color.White;
            this.btnGenerate.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // txtX
            // 
            this.txtX.AutoScroll = true;
            this.txtX.AutoSize = true;
            this.txtX.BackColor = System.Drawing.Color.White;
            this.txtX.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtX.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtX.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtX.BorderThickness = 2;
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtX.ForeColor = System.Drawing.Color.DimGray;
            this.txtX.isPassword = false;
            this.txtX.Location = new System.Drawing.Point(118, 481);
            this.txtX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(47, 37);
            this.txtX.TabIndex = 231;
            this.txtX.Text = "326";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label1.Location = new System.Drawing.Point(26, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 232;
            this.label1.Text = "Width (X) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label2.Location = new System.Drawing.Point(176, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 234;
            this.label2.Text = "Height (Y) :";
            // 
            // txtY
            // 
            this.txtY.AutoScroll = true;
            this.txtY.AutoSize = true;
            this.txtY.BackColor = System.Drawing.Color.White;
            this.txtY.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtY.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtY.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtY.BorderThickness = 2;
            this.txtY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtY.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtY.ForeColor = System.Drawing.Color.DimGray;
            this.txtY.isPassword = false;
            this.txtY.Location = new System.Drawing.Point(272, 483);
            this.txtY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(47, 37);
            this.txtY.TabIndex = 233;
            this.txtY.Text = "112";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.text_Note);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.text_SupplierName);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.text_Barcode);
            this.Controls.Add(this.text_StoreAddress);
            this.Controls.Add(this.txtStoreAddress);
            this.Controls.Add(this.text_StoreName);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pnlLabelViewer);
            this.Controls.Add(this.hSep);
            this.Controls.Add(this.text_ProductLabel);
            this.Controls.Add(this.vSep);
            this.Controls.Add(this.imgbtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Product Label";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.pnlLabelViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Panel pnlLabelViewer;
        private Microsoft.Reporting.WinForms.ReportViewer labelViewer;
        private Bunifu.Framework.UI.BunifuSeparator hSep;
        private System.Windows.Forms.Label text_ProductLabel;
        private Bunifu.Framework.UI.BunifuSeparator vSep;
        private System.Windows.Forms.Label text_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProductName;
        private System.Windows.Forms.Label text_StoreName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProductPrice;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label text_Address;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSupplierAddress;
        private System.Windows.Forms.Label text_SupplierName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSupplierName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProductBarcode;
        private System.Windows.Forms.Label text_Barcode;
        private System.Windows.Forms.Label text_StoreAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNote;
        private System.Windows.Forms.Label text_Note;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerate;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtY;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtX;
    }
}