namespace Vendstor.Forms.PointOfSale
{
    partial class Pay
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
            this.text_Pay = new System.Windows.Forms.Label();
            this.txtGivenAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnStoreCreditPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreditCardPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCashPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtExchangeAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Given = new System.Windows.Forms.Label();
            this.text_Exchange = new System.Windows.Forms.Label();
            this.quickValue1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quickValue2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quickValue3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quickValue4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quickValue5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quickValue6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblGivenAmount = new System.Windows.Forms.Label();
            this.customerPayModel = new Vendstor.Models.Customers.CustomerPayModel();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // text_Pay
            // 
            this.text_Pay.AutoSize = true;
            this.text_Pay.Font = new System.Drawing.Font("Poppins Light", 24F);
            this.text_Pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Pay.Location = new System.Drawing.Point(12, 9);
            this.text_Pay.Name = "text_Pay";
            this.text_Pay.Size = new System.Drawing.Size(81, 56);
            this.text_Pay.TabIndex = 56;
            this.text_Pay.Text = "Pay";
            // 
            // txtGivenAmount
            // 
            this.txtGivenAmount.AutoScroll = true;
            this.txtGivenAmount.AutoSize = true;
            this.txtGivenAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtGivenAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtGivenAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtGivenAmount.BorderThickness = 2;
            this.txtGivenAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGivenAmount.Font = new System.Drawing.Font("Poppins Light", 17.85F);
            this.txtGivenAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGivenAmount.isPassword = false;
            this.txtGivenAmount.Location = new System.Drawing.Point(444, 105);
            this.txtGivenAmount.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtGivenAmount.Name = "txtGivenAmount";
            this.txtGivenAmount.Size = new System.Drawing.Size(125, 55);
            this.txtGivenAmount.TabIndex = 70;
            this.txtGivenAmount.Text = "0";
            this.txtGivenAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGivenAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtGivenAmount_KeyDown);
            // 
            // btnStoreCreditPay
            // 
            this.btnStoreCreditPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnStoreCreditPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnStoreCreditPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoreCreditPay.BorderRadius = 5;
            this.btnStoreCreditPay.ButtonText = "Store Credit";
            this.btnStoreCreditPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoreCreditPay.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnStoreCreditPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStoreCreditPay.Iconimage = global::Vendstor.Properties.Resources.store_credit_pay_w;
            this.btnStoreCreditPay.Iconimage_right = null;
            this.btnStoreCreditPay.Iconimage_right_Selected = null;
            this.btnStoreCreditPay.Iconimage_Selected = null;
            this.btnStoreCreditPay.IconMarginLeft = 0;
            this.btnStoreCreditPay.IconMarginRight = 0;
            this.btnStoreCreditPay.IconRightVisible = true;
            this.btnStoreCreditPay.IconRightZoom = 0D;
            this.btnStoreCreditPay.IconVisible = true;
            this.btnStoreCreditPay.IconZoom = 45D;
            this.btnStoreCreditPay.IsTab = false;
            this.btnStoreCreditPay.Location = new System.Drawing.Point(423, 439);
            this.btnStoreCreditPay.Name = "btnStoreCreditPay";
            this.btnStoreCreditPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnStoreCreditPay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnStoreCreditPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStoreCreditPay.selected = false;
            this.btnStoreCreditPay.Size = new System.Drawing.Size(204, 55);
            this.btnStoreCreditPay.TabIndex = 58;
            this.btnStoreCreditPay.Tag = "StoreCredit";
            this.btnStoreCreditPay.Text = "Store Credit";
            this.btnStoreCreditPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreCreditPay.Textcolor = System.Drawing.Color.White;
            this.btnStoreCreditPay.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.btnStoreCreditPay.Click += new System.EventHandler(this.StoreCreditPay_Click);
            // 
            // btnCreditCardPay
            // 
            this.btnCreditCardPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCreditCardPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCreditCardPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreditCardPay.BorderRadius = 5;
            this.btnCreditCardPay.ButtonText = "Credit Card";
            this.btnCreditCardPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditCardPay.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnCreditCardPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreditCardPay.Iconimage = global::Vendstor.Properties.Resources.credit_card_pay_w;
            this.btnCreditCardPay.Iconimage_right = null;
            this.btnCreditCardPay.Iconimage_right_Selected = null;
            this.btnCreditCardPay.Iconimage_Selected = null;
            this.btnCreditCardPay.IconMarginLeft = 0;
            this.btnCreditCardPay.IconMarginRight = 0;
            this.btnCreditCardPay.IconRightVisible = true;
            this.btnCreditCardPay.IconRightZoom = 0D;
            this.btnCreditCardPay.IconVisible = true;
            this.btnCreditCardPay.IconZoom = 45D;
            this.btnCreditCardPay.IsTab = false;
            this.btnCreditCardPay.Location = new System.Drawing.Point(227, 439);
            this.btnCreditCardPay.Name = "btnCreditCardPay";
            this.btnCreditCardPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCreditCardPay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCreditCardPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreditCardPay.selected = false;
            this.btnCreditCardPay.Size = new System.Drawing.Size(184, 55);
            this.btnCreditCardPay.TabIndex = 58;
            this.btnCreditCardPay.Tag = "CreditCard";
            this.btnCreditCardPay.Text = "Credit Card";
            this.btnCreditCardPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCardPay.Textcolor = System.Drawing.Color.White;
            this.btnCreditCardPay.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.btnCreditCardPay.Click += new System.EventHandler(this.CreditCardPay_Click);
            // 
            // btnCashPay
            // 
            this.btnCashPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCashPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCashPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCashPay.BorderRadius = 5;
            this.btnCashPay.ButtonText = "Cash";
            this.btnCashPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashPay.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnCashPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCashPay.Iconimage = global::Vendstor.Properties.Resources.cash_discount_w;
            this.btnCashPay.Iconimage_right = null;
            this.btnCashPay.Iconimage_right_Selected = null;
            this.btnCashPay.Iconimage_Selected = null;
            this.btnCashPay.IconMarginLeft = 0;
            this.btnCashPay.IconMarginRight = 0;
            this.btnCashPay.IconRightVisible = true;
            this.btnCashPay.IconRightZoom = 0D;
            this.btnCashPay.IconVisible = true;
            this.btnCashPay.IconZoom = 45D;
            this.btnCashPay.IsTab = false;
            this.btnCashPay.Location = new System.Drawing.Point(51, 439);
            this.btnCashPay.Name = "btnCashPay";
            this.btnCashPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCashPay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCashPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCashPay.selected = false;
            this.btnCashPay.Size = new System.Drawing.Size(164, 55);
            this.btnCashPay.TabIndex = 57;
            this.btnCashPay.Tag = "Cash";
            this.btnCashPay.Text = "Cash";
            this.btnCashPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCashPay.Textcolor = System.Drawing.Color.White;
            this.btnCashPay.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.btnCashPay.Click += new System.EventHandler(this.CashPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Vendstor.Properties.Resources.go_back_pay_w;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(605, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 20);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 48;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Poppins", 22F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(276, 105);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(93, 53);
            this.lblTotalPrice.TabIndex = 72;
            this.lblTotalPrice.Text = "99 €";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExchangeAmount
            // 
            this.txtExchangeAmount.AutoScroll = true;
            this.txtExchangeAmount.AutoSize = true;
            this.txtExchangeAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtExchangeAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtExchangeAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtExchangeAmount.BorderThickness = 2;
            this.txtExchangeAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExchangeAmount.Font = new System.Drawing.Font("Poppins Light", 17.85F);
            this.txtExchangeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExchangeAmount.isPassword = false;
            this.txtExchangeAmount.Location = new System.Drawing.Point(51, 105);
            this.txtExchangeAmount.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtExchangeAmount.Name = "txtExchangeAmount";
            this.txtExchangeAmount.Size = new System.Drawing.Size(125, 55);
            this.txtExchangeAmount.TabIndex = 73;
            this.txtExchangeAmount.Text = "0";
            this.txtExchangeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_Given
            // 
            this.text_Given.AutoSize = true;
            this.text_Given.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.text_Given.Location = new System.Drawing.Point(490, 76);
            this.text_Given.Name = "text_Given";
            this.text_Given.Size = new System.Drawing.Size(43, 26);
            this.text_Given.TabIndex = 74;
            this.text_Given.Text = "Paid";
            // 
            // text_Exchange
            // 
            this.text_Exchange.AutoSize = true;
            this.text_Exchange.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.text_Exchange.Location = new System.Drawing.Point(70, 75);
            this.text_Exchange.Name = "text_Exchange";
            this.text_Exchange.Size = new System.Drawing.Size(83, 26);
            this.text_Exchange.TabIndex = 75;
            this.text_Exchange.Text = "Exchange";
            // 
            // quickValue1
            // 
            this.quickValue1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(171)))), ((int)(((byte)(123)))));
            this.quickValue1.BackColor = System.Drawing.Color.DimGray;
            this.quickValue1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue1.BorderRadius = 5;
            this.quickValue1.ButtonText = "5";
            this.quickValue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue1.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue1.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue1.Iconimage = null;
            this.quickValue1.Iconimage_right = null;
            this.quickValue1.Iconimage_right_Selected = null;
            this.quickValue1.Iconimage_Selected = null;
            this.quickValue1.IconMarginLeft = 0;
            this.quickValue1.IconMarginRight = 0;
            this.quickValue1.IconRightVisible = true;
            this.quickValue1.IconRightZoom = 0D;
            this.quickValue1.IconVisible = true;
            this.quickValue1.IconZoom = 45D;
            this.quickValue1.IsTab = false;
            this.quickValue1.Location = new System.Drawing.Point(76, 188);
            this.quickValue1.Name = "quickValue1";
            this.quickValue1.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue1.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue1.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue1.selected = false;
            this.quickValue1.Size = new System.Drawing.Size(75, 40);
            this.quickValue1.TabIndex = 76;
            this.quickValue1.Tag = "5";
            this.quickValue1.Text = "5";
            this.quickValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue1.Textcolor = System.Drawing.Color.White;
            this.quickValue1.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue1.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // quickValue2
            // 
            this.quickValue2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.quickValue2.BackColor = System.Drawing.Color.DimGray;
            this.quickValue2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue2.BorderRadius = 5;
            this.quickValue2.ButtonText = "10";
            this.quickValue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue2.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue2.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue2.Iconimage = null;
            this.quickValue2.Iconimage_right = null;
            this.quickValue2.Iconimage_right_Selected = null;
            this.quickValue2.Iconimage_Selected = null;
            this.quickValue2.IconMarginLeft = 0;
            this.quickValue2.IconMarginRight = 0;
            this.quickValue2.IconRightVisible = true;
            this.quickValue2.IconRightZoom = 0D;
            this.quickValue2.IconVisible = true;
            this.quickValue2.IconZoom = 45D;
            this.quickValue2.IsTab = false;
            this.quickValue2.Location = new System.Drawing.Point(162, 188);
            this.quickValue2.Name = "quickValue2";
            this.quickValue2.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue2.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue2.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue2.selected = false;
            this.quickValue2.Size = new System.Drawing.Size(75, 40);
            this.quickValue2.TabIndex = 77;
            this.quickValue2.Tag = "10";
            this.quickValue2.Text = "10";
            this.quickValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue2.Textcolor = System.Drawing.Color.White;
            this.quickValue2.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue2.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // quickValue3
            // 
            this.quickValue3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(152)))), ((int)(((byte)(193)))));
            this.quickValue3.BackColor = System.Drawing.Color.DimGray;
            this.quickValue3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue3.BorderRadius = 5;
            this.quickValue3.ButtonText = "20";
            this.quickValue3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue3.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue3.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue3.Iconimage = null;
            this.quickValue3.Iconimage_right = null;
            this.quickValue3.Iconimage_right_Selected = null;
            this.quickValue3.Iconimage_Selected = null;
            this.quickValue3.IconMarginLeft = 0;
            this.quickValue3.IconMarginRight = 0;
            this.quickValue3.IconRightVisible = true;
            this.quickValue3.IconRightZoom = 0D;
            this.quickValue3.IconVisible = true;
            this.quickValue3.IconZoom = 45D;
            this.quickValue3.IsTab = false;
            this.quickValue3.Location = new System.Drawing.Point(248, 188);
            this.quickValue3.Name = "quickValue3";
            this.quickValue3.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue3.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue3.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue3.selected = false;
            this.quickValue3.Size = new System.Drawing.Size(75, 40);
            this.quickValue3.TabIndex = 78;
            this.quickValue3.Tag = "20";
            this.quickValue3.Text = "20";
            this.quickValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue3.Textcolor = System.Drawing.Color.White;
            this.quickValue3.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue3.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // quickValue4
            // 
            this.quickValue4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(154)))), ((int)(((byte)(93)))));
            this.quickValue4.BackColor = System.Drawing.Color.DimGray;
            this.quickValue4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue4.BorderRadius = 5;
            this.quickValue4.ButtonText = "50";
            this.quickValue4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue4.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue4.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue4.Iconimage = null;
            this.quickValue4.Iconimage_right = null;
            this.quickValue4.Iconimage_right_Selected = null;
            this.quickValue4.Iconimage_Selected = null;
            this.quickValue4.IconMarginLeft = 0;
            this.quickValue4.IconMarginRight = 0;
            this.quickValue4.IconRightVisible = true;
            this.quickValue4.IconRightZoom = 0D;
            this.quickValue4.IconVisible = true;
            this.quickValue4.IconZoom = 45D;
            this.quickValue4.IsTab = false;
            this.quickValue4.Location = new System.Drawing.Point(334, 188);
            this.quickValue4.Name = "quickValue4";
            this.quickValue4.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue4.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue4.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue4.selected = false;
            this.quickValue4.Size = new System.Drawing.Size(75, 40);
            this.quickValue4.TabIndex = 79;
            this.quickValue4.Tag = "50";
            this.quickValue4.Text = "50";
            this.quickValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue4.Textcolor = System.Drawing.Color.White;
            this.quickValue4.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue4.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // quickValue5
            // 
            this.quickValue5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(229)))), ((int)(((byte)(147)))));
            this.quickValue5.BackColor = System.Drawing.Color.DimGray;
            this.quickValue5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue5.BorderRadius = 5;
            this.quickValue5.ButtonText = "100";
            this.quickValue5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue5.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue5.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue5.Iconimage = null;
            this.quickValue5.Iconimage_right = null;
            this.quickValue5.Iconimage_right_Selected = null;
            this.quickValue5.Iconimage_Selected = null;
            this.quickValue5.IconMarginLeft = 0;
            this.quickValue5.IconMarginRight = 0;
            this.quickValue5.IconRightVisible = true;
            this.quickValue5.IconRightZoom = 0D;
            this.quickValue5.IconVisible = true;
            this.quickValue5.IconZoom = 45D;
            this.quickValue5.IsTab = false;
            this.quickValue5.Location = new System.Drawing.Point(420, 188);
            this.quickValue5.Name = "quickValue5";
            this.quickValue5.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue5.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue5.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue5.selected = false;
            this.quickValue5.Size = new System.Drawing.Size(75, 40);
            this.quickValue5.TabIndex = 80;
            this.quickValue5.Tag = "100";
            this.quickValue5.Text = "100";
            this.quickValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue5.Textcolor = System.Drawing.Color.White;
            this.quickValue5.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue5.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // quickValue6
            // 
            this.quickValue6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.quickValue6.BackColor = System.Drawing.Color.DimGray;
            this.quickValue6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quickValue6.BorderRadius = 5;
            this.quickValue6.ButtonText = "500";
            this.quickValue6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickValue6.DisabledColor = System.Drawing.Color.Gray;
            this.quickValue6.Iconcolor = System.Drawing.Color.Transparent;
            this.quickValue6.Iconimage = null;
            this.quickValue6.Iconimage_right = null;
            this.quickValue6.Iconimage_right_Selected = null;
            this.quickValue6.Iconimage_Selected = null;
            this.quickValue6.IconMarginLeft = 0;
            this.quickValue6.IconMarginRight = 0;
            this.quickValue6.IconRightVisible = true;
            this.quickValue6.IconRightZoom = 0D;
            this.quickValue6.IconVisible = true;
            this.quickValue6.IconZoom = 45D;
            this.quickValue6.IsTab = false;
            this.quickValue6.Location = new System.Drawing.Point(506, 188);
            this.quickValue6.Name = "quickValue6";
            this.quickValue6.Normalcolor = System.Drawing.Color.DimGray;
            this.quickValue6.OnHovercolor = System.Drawing.Color.DimGray;
            this.quickValue6.OnHoverTextColor = System.Drawing.Color.White;
            this.quickValue6.selected = false;
            this.quickValue6.Size = new System.Drawing.Size(75, 40);
            this.quickValue6.TabIndex = 81;
            this.quickValue6.Tag = "500";
            this.quickValue6.Text = "500";
            this.quickValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickValue6.Textcolor = System.Drawing.Color.White;
            this.quickValue6.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.quickValue6.Click += new System.EventHandler(this.QuickValuePayment);
            // 
            // lblGivenAmount
            // 
            this.lblGivenAmount.AutoSize = true;
            this.lblGivenAmount.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.lblGivenAmount.Location = new System.Drawing.Point(575, 105);
            this.lblGivenAmount.Name = "lblGivenAmount";
            this.lblGivenAmount.Size = new System.Drawing.Size(37, 26);
            this.lblGivenAmount.TabIndex = 83;
            this.lblGivenAmount.Text = "0 €";
            // 
            // customerPayModel
            // 
            this.customerPayModel.BackColor = System.Drawing.Color.White;
            this.customerPayModel.Currency = null;
            this.customerPayModel.Customer = null;
            this.customerPayModel.Location = new System.Drawing.Point(54, 249);
            this.customerPayModel.Name = "customerPayModel";
            this.customerPayModel.Size = new System.Drawing.Size(548, 165);
            this.customerPayModel.TabIndex = 82;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 530);
            this.Controls.Add(this.lblGivenAmount);
            this.Controls.Add(this.customerPayModel);
            this.Controls.Add(this.quickValue6);
            this.Controls.Add(this.quickValue5);
            this.Controls.Add(this.quickValue4);
            this.Controls.Add(this.quickValue3);
            this.Controls.Add(this.quickValue2);
            this.Controls.Add(this.quickValue1);
            this.Controls.Add(this.text_Exchange);
            this.Controls.Add(this.text_Given);
            this.Controls.Add(this.txtExchangeAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStoreCreditPay);
            this.Controls.Add(this.txtGivenAmount);
            this.Controls.Add(this.btnCreditCardPay);
            this.Controls.Add(this.btnCashPay);
            this.Controls.Add(this.text_Pay);
            this.Controls.Add(this.lblTotalPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendstor - Pay";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        internal Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Label text_Pay;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreditCardPay;
        private Bunifu.Framework.UI.BunifuFlatButton btnCashPay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGivenAmount;
        private Bunifu.Framework.UI.BunifuFlatButton btnStoreCreditPay;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label text_Exchange;
        private System.Windows.Forms.Label text_Given;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtExchangeAmount;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue6;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue5;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue4;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue3;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue2;
        private Bunifu.Framework.UI.BunifuFlatButton quickValue1;
        private Models.Customers.CustomerPayModel customerPayModel;
        private System.Windows.Forms.Label lblGivenAmount;
    }
}