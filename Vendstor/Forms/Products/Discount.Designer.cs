namespace Vendstor.Forms.Discounts
{
    partial class Discount
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
            this.rtxtShortDescription = new System.Windows.Forms.RichTextBox();
            this.imgbtnGoSecondFields = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_General = new System.Windows.Forms.Label();
            this.text_DName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.text_ShortDescription = new System.Windows.Forms.Label();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlFirstFields = new System.Windows.Forms.Panel();
            this.dpEndDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpStartDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cardDiscountPreview = new Bunifu.Framework.UI.BunifuCards();
            this.lblHint_Card = new System.Windows.Forms.Label();
            this.seperatorH_Card = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblDiscountDescription_Card = new System.Windows.Forms.Label();
            this.imgbtnCard = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDiscountName_Card = new System.Windows.Forms.Label();
            this.text_Preview = new System.Windows.Forms.Label();
            this.txtDiscountName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSecondFields = new System.Windows.Forms.Panel();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_Discounts = new System.Windows.Forms.Label();
            this.txtDiscountValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.imgbtnPercentage = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnCash = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.productsCard = new Bunifu.Framework.UI.BunifuCards();
            this.ProductDiscountsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_BackToFields = new System.Windows.Forms.Label();
            this.imgbtnGoFirstFields = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoSecondFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.pnlFirstFields.SuspendLayout();
            this.cardDiscountPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCard)).BeginInit();
            this.pnlSecondFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCash)).BeginInit();
            this.productsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoFirstFields)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // rtxtShortDescription
            // 
            this.rtxtShortDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.rtxtShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtShortDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.rtxtShortDescription.ForeColor = System.Drawing.Color.Gray;
            this.rtxtShortDescription.Location = new System.Drawing.Point(61, 223);
            this.rtxtShortDescription.Name = "rtxtShortDescription";
            this.rtxtShortDescription.Size = new System.Drawing.Size(368, 111);
            this.rtxtShortDescription.TabIndex = 133;
            this.rtxtShortDescription.Text = "";
            this.rtxtShortDescription.TextChanged += new System.EventHandler(this.UpdateCardOn_TextChanged);
            // 
            // imgbtnGoSecondFields
            // 
            this.imgbtnGoSecondFields.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnGoSecondFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnGoSecondFields.Image = global::Vendstor.Properties.Resources.next_filled_w;
            this.imgbtnGoSecondFields.ImageActive = null;
            this.imgbtnGoSecondFields.Location = new System.Drawing.Point(808, 488);
            this.imgbtnGoSecondFields.Name = "imgbtnGoSecondFields";
            this.imgbtnGoSecondFields.Size = new System.Drawing.Size(47, 21);
            this.imgbtnGoSecondFields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnGoSecondFields.TabIndex = 130;
            this.imgbtnGoSecondFields.TabStop = false;
            this.imgbtnGoSecondFields.Zoom = 10;
            this.imgbtnGoSecondFields.Click += new System.EventHandler(this.ImgbtnGoSecondFields_Click);
            // 
            // text_General
            // 
            this.text_General.AutoSize = true;
            this.text_General.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_General.Location = new System.Drawing.Point(38, 49);
            this.text_General.Name = "text_General";
            this.text_General.Size = new System.Drawing.Size(75, 28);
            this.text_General.TabIndex = 131;
            this.text_General.Text = "General";
            // 
            // text_DName
            // 
            this.text_DName.AutoSize = true;
            this.text_DName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_DName.Location = new System.Drawing.Point(61, 90);
            this.text_DName.Name = "text_DName";
            this.text_DName.Size = new System.Drawing.Size(124, 26);
            this.text_DName.TabIndex = 93;
            this.text_DName.Text = "Discount Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 39);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "New Discount";
            // 
            // text_ShortDescription
            // 
            this.text_ShortDescription.AutoSize = true;
            this.text_ShortDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_ShortDescription.Location = new System.Drawing.Point(56, 194);
            this.text_ShortDescription.Name = "text_ShortDescription";
            this.text_ShortDescription.Size = new System.Drawing.Size(136, 26);
            this.text_ShortDescription.TabIndex = 95;
            this.text_ShortDescription.Text = "Short Description";
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(869, 10);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 135;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // pnlFirstFields
            // 
            this.pnlFirstFields.BackColor = System.Drawing.Color.White;
            this.pnlFirstFields.Controls.Add(this.dpEndDate);
            this.pnlFirstFields.Controls.Add(this.dpStartDate);
            this.pnlFirstFields.Controls.Add(this.label6);
            this.pnlFirstFields.Controls.Add(this.label7);
            this.pnlFirstFields.Controls.Add(this.cardDiscountPreview);
            this.pnlFirstFields.Controls.Add(this.text_Preview);
            this.pnlFirstFields.Controls.Add(this.rtxtShortDescription);
            this.pnlFirstFields.Controls.Add(this.text_General);
            this.pnlFirstFields.Controls.Add(this.imgbtnGoSecondFields);
            this.pnlFirstFields.Controls.Add(this.lblTitle);
            this.pnlFirstFields.Controls.Add(this.text_DName);
            this.pnlFirstFields.Controls.Add(this.text_ShortDescription);
            this.pnlFirstFields.Controls.Add(this.txtDiscountName);
            this.pnlFirstFields.Location = new System.Drawing.Point(10, 10);
            this.pnlFirstFields.Name = "pnlFirstFields";
            this.pnlFirstFields.Size = new System.Drawing.Size(864, 526);
            this.pnlFirstFields.TabIndex = 133;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpEndDate.BorderRadius = 0;
            this.dpEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpEndDate.FormatCustom = null;
            this.dpEndDate.Location = new System.Drawing.Point(500, 383);
            this.dpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(276, 36);
            this.dpEndDate.TabIndex = 144;
            this.dpEndDate.Value = new System.DateTime(2018, 10, 25, 23, 59, 59, 0);
            // 
            // dpStartDate
            // 
            this.dpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpStartDate.BorderRadius = 0;
            this.dpStartDate.ForeColor = System.Drawing.Color.DimGray;
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStartDate.FormatCustom = null;
            this.dpStartDate.Location = new System.Drawing.Point(69, 383);
            this.dpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(276, 36);
            this.dpStartDate.TabIndex = 143;
            this.dpStartDate.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label6.Location = new System.Drawing.Point(501, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 142;
            this.label6.Text = "End Date";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label7.Location = new System.Drawing.Point(73, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 141;
            this.label7.Text = "Start Date";
            // 
            // cardDiscountPreview
            // 
            this.cardDiscountPreview.BackColor = System.Drawing.Color.White;
            this.cardDiscountPreview.BorderRadius = 5;
            this.cardDiscountPreview.BottomSahddow = true;
            this.cardDiscountPreview.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardDiscountPreview.Controls.Add(this.lblHint_Card);
            this.cardDiscountPreview.Controls.Add(this.seperatorH_Card);
            this.cardDiscountPreview.Controls.Add(this.lblDiscountDescription_Card);
            this.cardDiscountPreview.Controls.Add(this.imgbtnCard);
            this.cardDiscountPreview.Controls.Add(this.lblDiscountName_Card);
            this.cardDiscountPreview.LeftSahddow = false;
            this.cardDiscountPreview.Location = new System.Drawing.Point(484, 151);
            this.cardDiscountPreview.Name = "cardDiscountPreview";
            this.cardDiscountPreview.RightSahddow = true;
            this.cardDiscountPreview.ShadowDepth = 20;
            this.cardDiscountPreview.Size = new System.Drawing.Size(354, 183);
            this.cardDiscountPreview.TabIndex = 140;
            // 
            // lblHint_Card
            // 
            this.lblHint_Card.AutoSize = true;
            this.lblHint_Card.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.lblHint_Card.Location = new System.Drawing.Point(5, 103);
            this.lblHint_Card.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblHint_Card.Name = "lblHint_Card";
            this.lblHint_Card.Size = new System.Drawing.Size(349, 42);
            this.lblHint_Card.TabIndex = 180;
            this.lblHint_Card.Text = "The name and description will be shown to both cashiers and customers, to identif" +
    "y and explain the product.";
            // 
            // seperatorH_Card
            // 
            this.seperatorH_Card.BackColor = System.Drawing.Color.Transparent;
            this.seperatorH_Card.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperatorH_Card.LineThickness = 1;
            this.seperatorH_Card.Location = new System.Drawing.Point(13, 81);
            this.seperatorH_Card.Margin = new System.Windows.Forms.Padding(8);
            this.seperatorH_Card.Name = "seperatorH_Card";
            this.seperatorH_Card.Size = new System.Drawing.Size(314, 25);
            this.seperatorH_Card.TabIndex = 179;
            this.seperatorH_Card.Transparency = 255;
            this.seperatorH_Card.Vertical = false;
            // 
            // lblDiscountDescription_Card
            // 
            this.lblDiscountDescription_Card.AutoSize = true;
            this.lblDiscountDescription_Card.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.lblDiscountDescription_Card.Location = new System.Drawing.Point(41, 41);
            this.lblDiscountDescription_Card.MaximumSize = new System.Drawing.Size(260, 0);
            this.lblDiscountDescription_Card.Name = "lblDiscountDescription_Card";
            this.lblDiscountDescription_Card.Size = new System.Drawing.Size(0, 21);
            this.lblDiscountDescription_Card.TabIndex = 141;
            // 
            // imgbtnCard
            // 
            this.imgbtnCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnCard.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnCard.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnCard.ImageActive = null;
            this.imgbtnCard.Location = new System.Drawing.Point(16, 21);
            this.imgbtnCard.Name = "imgbtnCard";
            this.imgbtnCard.Size = new System.Drawing.Size(18, 17);
            this.imgbtnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCard.TabIndex = 136;
            this.imgbtnCard.TabStop = false;
            this.imgbtnCard.Zoom = 10;
            // 
            // lblDiscountName_Card
            // 
            this.lblDiscountName_Card.AutoSize = true;
            this.lblDiscountName_Card.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblDiscountName_Card.Location = new System.Drawing.Point(40, 15);
            this.lblDiscountName_Card.Name = "lblDiscountName_Card";
            this.lblDiscountName_Card.Size = new System.Drawing.Size(0, 26);
            this.lblDiscountName_Card.TabIndex = 140;
            // 
            // text_Preview
            // 
            this.text_Preview.AutoSize = true;
            this.text_Preview.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Preview.Location = new System.Drawing.Point(479, 113);
            this.text_Preview.Name = "text_Preview";
            this.text_Preview.Size = new System.Drawing.Size(66, 26);
            this.text_Preview.TabIndex = 139;
            this.text_Preview.Text = "Preview";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.AutoScroll = true;
            this.txtDiscountName.AutoSize = true;
            this.txtDiscountName.BackColor = System.Drawing.Color.White;
            this.txtDiscountName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtDiscountName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountName.BorderThickness = 2;
            this.txtDiscountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtDiscountName.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiscountName.isPassword = false;
            this.txtDiscountName.Location = new System.Drawing.Point(66, 122);
            this.txtDiscountName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(303, 43);
            this.txtDiscountName.TabIndex = 109;
            this.txtDiscountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscountName.OnValueChanged += new System.EventHandler(this.UpdateCardOn_TextChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlSecondFields
            // 
            this.pnlSecondFields.BackColor = System.Drawing.Color.White;
            this.pnlSecondFields.Controls.Add(this.btnAddProduct);
            this.pnlSecondFields.Controls.Add(this.text_Discounts);
            this.pnlSecondFields.Controls.Add(this.txtDiscountValue);
            this.pnlSecondFields.Controls.Add(this.imgbtnPercentage);
            this.pnlSecondFields.Controls.Add(this.imgbtnCash);
            this.pnlSecondFields.Controls.Add(this.label8);
            this.pnlSecondFields.Controls.Add(this.productsCard);
            this.pnlSecondFields.Controls.Add(this.label5);
            this.pnlSecondFields.Controls.Add(this.btnDelete);
            this.pnlSecondFields.Controls.Add(this.btnSave);
            this.pnlSecondFields.Controls.Add(this.text_BackToFields);
            this.pnlSecondFields.Controls.Add(this.imgbtnGoFirstFields);
            this.pnlSecondFields.Location = new System.Drawing.Point(10, 542);
            this.pnlSecondFields.Name = "pnlSecondFields";
            this.pnlSecondFields.Size = new System.Drawing.Size(864, 526);
            this.pnlSecondFields.TabIndex = 134;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 5;
            this.btnAddProduct.ButtonText = "Add Product";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = global::Vendstor.Properties.Resources.products_filled_w;
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 45D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(566, 130);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(171, 40);
            this.btnAddProduct.TabIndex = 217;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // text_Discounts
            // 
            this.text_Discounts.AutoSize = true;
            this.text_Discounts.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Discounts.Location = new System.Drawing.Point(73, 144);
            this.text_Discounts.Name = "text_Discounts";
            this.text_Discounts.Size = new System.Drawing.Size(84, 26);
            this.text_Discounts.TabIndex = 216;
            this.text_Discounts.Text = "Discounts";
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.AutoScroll = true;
            this.txtDiscountValue.AutoSize = true;
            this.txtDiscountValue.BackColor = System.Drawing.Color.White;
            this.txtDiscountValue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtDiscountValue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.BorderThickness = 2;
            this.txtDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountValue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.txtDiscountValue.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiscountValue.isPassword = false;
            this.txtDiscountValue.Location = new System.Drawing.Point(228, 74);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(117, 63);
            this.txtDiscountValue.TabIndex = 210;
            this.txtDiscountValue.Text = "0";
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // imgbtnPercentage
            // 
            this.imgbtnPercentage.BackColor = System.Drawing.Color.White;
            this.imgbtnPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnPercentage.Image = global::Vendstor.Properties.Resources.discount_sell_w;
            this.imgbtnPercentage.ImageActive = null;
            this.imgbtnPercentage.Location = new System.Drawing.Point(132, 94);
            this.imgbtnPercentage.Name = "imgbtnPercentage";
            this.imgbtnPercentage.Size = new System.Drawing.Size(37, 25);
            this.imgbtnPercentage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnPercentage.TabIndex = 209;
            this.imgbtnPercentage.TabStop = false;
            this.imgbtnPercentage.Zoom = 10;
            this.imgbtnPercentage.Click += new System.EventHandler(this.OnDiscountTypeButton_Click);
            // 
            // imgbtnCash
            // 
            this.imgbtnCash.BackColor = System.Drawing.Color.White;
            this.imgbtnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnCash.Image = global::Vendstor.Properties.Resources.cash_discount_w;
            this.imgbtnCash.ImageActive = null;
            this.imgbtnCash.Location = new System.Drawing.Point(175, 94);
            this.imgbtnCash.Name = "imgbtnCash";
            this.imgbtnCash.Size = new System.Drawing.Size(37, 25);
            this.imgbtnCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCash.TabIndex = 208;
            this.imgbtnCash.TabStop = false;
            this.imgbtnCash.Zoom = 10;
            this.imgbtnCash.Click += new System.EventHandler(this.OnDiscountTypeButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label8.Location = new System.Drawing.Point(73, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 207;
            this.label8.Text = "Discount";
            // 
            // productsCard
            // 
            this.productsCard.BackColor = System.Drawing.Color.White;
            this.productsCard.BorderRadius = 5;
            this.productsCard.BottomSahddow = true;
            this.productsCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.productsCard.Controls.Add(this.ProductDiscountsGrid);
            this.productsCard.LeftSahddow = false;
            this.productsCard.Location = new System.Drawing.Point(128, 185);
            this.productsCard.Name = "productsCard";
            this.productsCard.RightSahddow = true;
            this.productsCard.ShadowDepth = 20;
            this.productsCard.Size = new System.Drawing.Size(609, 251);
            this.productsCard.TabIndex = 204;
            // 
            // ProductDiscountsGrid
            // 
            this.ProductDiscountsGrid.AutoScroll = true;
            this.ProductDiscountsGrid.Location = new System.Drawing.Point(4, 5);
            this.ProductDiscountsGrid.Name = "ProductDiscountsGrid";
            this.ProductDiscountsGrid.Size = new System.Drawing.Size(600, 245);
            this.ProductDiscountsGrid.TabIndex = 1;
            this.ProductDiscountsGrid.Click += new System.EventHandler(this.ProductDiscountsGrid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F);
            this.label5.Location = new System.Drawing.Point(27, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 179;
            this.label5.Text = "Type of Discount";
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "Delete";
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
            this.btnDelete.IconZoom = 45D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(594, 476);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(126, 40);
            this.btnDelete.TabIndex = 134;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 45D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(729, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnSave.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // text_BackToFields
            // 
            this.text_BackToFields.AutoSize = true;
            this.text_BackToFields.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_BackToFields.Location = new System.Drawing.Point(73, 487);
            this.text_BackToFields.Name = "text_BackToFields";
            this.text_BackToFields.Size = new System.Drawing.Size(149, 26);
            this.text_BackToFields.TabIndex = 130;
            this.text_BackToFields.Text = "Back to First Fields";
            // 
            // imgbtnGoFirstFields
            // 
            this.imgbtnGoFirstFields.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnGoFirstFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnGoFirstFields.Image = global::Vendstor.Properties.Resources.go_back_pay_w;
            this.imgbtnGoFirstFields.ImageActive = null;
            this.imgbtnGoFirstFields.Location = new System.Drawing.Point(12, 487);
            this.imgbtnGoFirstFields.Name = "imgbtnGoFirstFields";
            this.imgbtnGoFirstFields.Size = new System.Drawing.Size(47, 21);
            this.imgbtnGoFirstFields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnGoFirstFields.TabIndex = 129;
            this.imgbtnGoFirstFields.TabStop = false;
            this.imgbtnGoFirstFields.Zoom = 10;
            this.imgbtnGoFirstFields.Click += new System.EventHandler(this.ImgbtnGoFirstFields_Click);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 1100);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.pnlFirstFields);
            this.Controls.Add(this.pnlSecondFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Discount";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoSecondFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.pnlFirstFields.ResumeLayout(false);
            this.pnlFirstFields.PerformLayout();
            this.cardDiscountPreview.ResumeLayout(false);
            this.cardDiscountPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCard)).EndInit();
            this.pnlSecondFields.ResumeLayout(false);
            this.pnlSecondFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCash)).EndInit();
            this.productsCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoFirstFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Panel pnlFirstFields;
        private System.Windows.Forms.RichTextBox rtxtShortDescription;
        private System.Windows.Forms.Label text_General;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnGoSecondFields;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label text_DName;
        private System.Windows.Forms.Label text_ShortDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscountName;
        private System.Windows.Forms.Panel pnlSecondFields;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label text_BackToFields;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnGoFirstFields;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards cardDiscountPreview;
        private System.Windows.Forms.Label text_Preview;
        private System.Windows.Forms.Label lblDiscountName_Card;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCard;
        private System.Windows.Forms.Label lblDiscountDescription_Card;
        private System.Windows.Forms.Label lblHint_Card;
        private Bunifu.Framework.UI.BunifuSeparator seperatorH_Card;
        private Bunifu.Framework.UI.BunifuDatepicker dpEndDate;
        private Bunifu.Framework.UI.BunifuDatepicker dpStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscountValue;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnPercentage;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label text_Discounts;
        private Bunifu.Framework.UI.BunifuCards productsCard;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel ProductDiscountsGrid;
    }
}