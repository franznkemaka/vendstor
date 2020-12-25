namespace Vendstor.UserControls.Dashboard.Reports
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.switchFilterApply = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpDateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpDateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.text_DateTo = new System.Windows.Forms.Label();
            this.text_From = new System.Windows.Forms.Label();
            this.PaymentsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStoreCredit_Grid = new System.Windows.Forms.Label();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCash_Grid = new System.Windows.Forms.Label();
            this.lblCreditCard_Grid = new System.Windows.Forms.Label();
            this.lblDate_Grid = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cardCash = new Bunifu.Framework.UI.BunifuCards();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.text_Cash_Card = new System.Windows.Forms.Label();
            this.imgpnlCash = new System.Windows.Forms.Panel();
            this.imgbtnCash = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardCost = new Bunifu.Framework.UI.BunifuCards();
            this.lblCreditCardAmount = new System.Windows.Forms.Label();
            this.text_CreditCard = new System.Windows.Forms.Label();
            this.imgpnlCreditCard = new System.Windows.Forms.Panel();
            this.imgbtnCreditCard = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardProfit = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.text_Total = new System.Windows.Forms.Label();
            this.imgpnlTotal = new System.Windows.Forms.Panel();
            this.imgbtnTotal = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardStoreCredit = new Bunifu.Framework.UI.BunifuCards();
            this.lblStoreCreditAmount = new System.Windows.Forms.Label();
            this.text_StoreCredit = new System.Windows.Forms.Label();
            this.imgpnlStoreCredit = new System.Windows.Forms.Panel();
            this.imgbtnStoreCredit = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgVectorNoData = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperatorCard = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNothing_Card = new System.Windows.Forms.Label();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlFilter.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            this.cardCash.SuspendLayout();
            this.imgpnlCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCash)).BeginInit();
            this.cardCost.SuspendLayout();
            this.imgpnlCreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCreditCard)).BeginInit();
            this.cardProfit.SuspendLayout();
            this.imgpnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotal)).BeginInit();
            this.cardStoreCredit.SuspendLayout();
            this.imgpnlStoreCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnStoreCredit)).BeginInit();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorNoData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnNext);
            this.pnlFilter.Controls.Add(this.btnPrevious);
            this.pnlFilter.Controls.Add(this.switchFilterApply);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.dpDateTo);
            this.pnlFilter.Controls.Add(this.dpDateFrom);
            this.pnlFilter.Controls.Add(this.text_DateTo);
            this.pnlFilter.Controls.Add(this.text_From);
            this.pnlFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1108, 86);
            this.pnlFilter.TabIndex = 120;
            // 
            // switchFilterApply
            // 
            this.switchFilterApply.BackColor = System.Drawing.Color.Transparent;
            this.switchFilterApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchFilterApply.BackgroundImage")));
            this.switchFilterApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchFilterApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchFilterApply.Location = new System.Drawing.Point(705, 29);
            this.switchFilterApply.Name = "switchFilterApply";
            this.switchFilterApply.OffColor = System.Drawing.Color.Tomato;
            this.switchFilterApply.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchFilterApply.Size = new System.Drawing.Size(35, 20);
            this.switchFilterApply.TabIndex = 138;
            this.switchFilterApply.Value = false;
            this.switchFilterApply.Click += new System.EventHandler(this.SwitchFilterApply_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 5;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = global::Vendstor.Properties.Resources.filter_filled_w;
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 45D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(924, 14);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(126, 45);
            this.btnFilter.TabIndex = 129;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // dpDateTo
            // 
            this.dpDateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateTo.BorderRadius = 0;
            this.dpDateTo.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateTo.FormatCustom = null;
            this.dpDateTo.Location = new System.Drawing.Point(327, 38);
            this.dpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Size = new System.Drawing.Size(276, 36);
            this.dpDateTo.TabIndex = 128;
            this.dpDateTo.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateFrom.BorderRadius = 0;
            this.dpDateFrom.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateFrom.FormatCustom = null;
            this.dpDateFrom.Location = new System.Drawing.Point(32, 40);
            this.dpDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Size = new System.Drawing.Size(276, 36);
            this.dpDateFrom.TabIndex = 127;
            this.dpDateFrom.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // text_DateTo
            // 
            this.text_DateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_DateTo.AutoSize = true;
            this.text_DateTo.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_DateTo.Location = new System.Drawing.Point(322, 8);
            this.text_DateTo.Name = "text_DateTo";
            this.text_DateTo.Size = new System.Drawing.Size(69, 26);
            this.text_DateTo.TabIndex = 126;
            this.text_DateTo.Text = "Date To";
            // 
            // text_From
            // 
            this.text_From.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_From.AutoSize = true;
            this.text_From.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_From.Location = new System.Drawing.Point(27, 10);
            this.text_From.Name = "text_From";
            this.text_From.Size = new System.Drawing.Size(88, 26);
            this.text_From.TabIndex = 125;
            this.text_From.Text = "Date From";
            // 
            // PaymentsGrid
            // 
            this.PaymentsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentsGrid.AutoScroll = true;
            this.PaymentsGrid.BackColor = System.Drawing.Color.White;
            this.PaymentsGrid.Location = new System.Drawing.Point(10, 166);
            this.PaymentsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentsGrid.Name = "PaymentsGrid";
            this.PaymentsGrid.Size = new System.Drawing.Size(794, 418);
            this.PaymentsGrid.TabIndex = 121;
            this.PaymentsGrid.Click += new System.EventHandler(this.PaymentsGrid_Click);
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator1);
            this.pnlGridHeader.Controls.Add(this.lblStoreCredit_Grid);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblCash_Grid);
            this.pnlGridHeader.Controls.Add(this.lblCreditCard_Grid);
            this.pnlGridHeader.Controls.Add(this.lblDate_Grid);
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator8);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(10, 102);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridHeader.Size = new System.Drawing.Size(794, 48);
            this.pnlGridHeader.TabIndex = 122;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(635, 11);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(8, 28);
            this.bunifuSeparator1.TabIndex = 178;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblStoreCredit_Grid
            // 
            this.lblStoreCredit_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCredit_Grid.AutoSize = true;
            this.lblStoreCredit_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStoreCredit_Grid.Location = new System.Drawing.Point(654, 11);
            this.lblStoreCredit_Grid.Name = "lblStoreCredit_Grid";
            this.lblStoreCredit_Grid.Size = new System.Drawing.Size(106, 28);
            this.lblStoreCredit_Grid.TabIndex = 177;
            this.lblStoreCredit_Grid.Text = "Store Credit";
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(447, 9);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator2.TabIndex = 176;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(207, 11);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            // 
            // lblCash_Grid
            // 
            this.lblCash_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCash_Grid.AutoSize = true;
            this.lblCash_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCash_Grid.Location = new System.Drawing.Point(225, 11);
            this.lblCash_Grid.Name = "lblCash_Grid";
            this.lblCash_Grid.Size = new System.Drawing.Size(57, 28);
            this.lblCash_Grid.TabIndex = 171;
            this.lblCash_Grid.Text = "Cash ";
            // 
            // lblCreditCard_Grid
            // 
            this.lblCreditCard_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreditCard_Grid.AutoSize = true;
            this.lblCreditCard_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCreditCard_Grid.Location = new System.Drawing.Point(466, 9);
            this.lblCreditCard_Grid.Name = "lblCreditCard_Grid";
            this.lblCreditCard_Grid.Size = new System.Drawing.Size(105, 28);
            this.lblCreditCard_Grid.TabIndex = 170;
            this.lblCreditCard_Grid.Text = "Credit Card";
            // 
            // lblDate_Grid
            // 
            this.lblDate_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate_Grid.AutoSize = true;
            this.lblDate_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblDate_Grid.Location = new System.Drawing.Point(27, 11);
            this.lblDate_Grid.Name = "lblDate_Grid";
            this.lblDate_Grid.Size = new System.Drawing.Size(50, 28);
            this.lblDate_Grid.TabIndex = 169;
            this.lblDate_Grid.Text = "Date";
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(1189, 14);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(24, 44);
            this.bunifuSeparator8.TabIndex = 148;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // cardCash
            // 
            this.cardCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCash.BackColor = System.Drawing.Color.White;
            this.cardCash.BorderRadius = 10;
            this.cardCash.BottomSahddow = true;
            this.cardCash.color = System.Drawing.Color.Transparent;
            this.cardCash.Controls.Add(this.lblCashAmount);
            this.cardCash.Controls.Add(this.text_Cash_Card);
            this.cardCash.Controls.Add(this.imgpnlCash);
            this.cardCash.LeftSahddow = false;
            this.cardCash.Location = new System.Drawing.Point(814, 130);
            this.cardCash.Name = "cardCash";
            this.cardCash.RightSahddow = true;
            this.cardCash.ShadowDepth = 10;
            this.cardCash.Size = new System.Drawing.Size(304, 102);
            this.cardCash.TabIndex = 130;
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.AutoSize = true;
            this.lblCashAmount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCashAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCashAmount.Location = new System.Drawing.Point(148, 38);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(123, 48);
            this.lblCashAmount.TabIndex = 2;
            this.lblCashAmount.Text = "€ 00.00";
            // 
            // text_Cash_Card
            // 
            this.text_Cash_Card.AutoSize = true;
            this.text_Cash_Card.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Cash_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Cash_Card.Location = new System.Drawing.Point(154, 10);
            this.text_Cash_Card.Name = "text_Cash_Card";
            this.text_Cash_Card.Size = new System.Drawing.Size(53, 28);
            this.text_Cash_Card.TabIndex = 1;
            this.text_Cash_Card.Text = "Cash";
            // 
            // imgpnlCash
            // 
            this.imgpnlCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlCash.Controls.Add(this.imgbtnCash);
            this.imgpnlCash.Location = new System.Drawing.Point(23, 18);
            this.imgpnlCash.Name = "imgpnlCash";
            this.imgpnlCash.Size = new System.Drawing.Size(49, 47);
            this.imgpnlCash.TabIndex = 8;
            // 
            // imgbtnCash
            // 
            this.imgbtnCash.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCash.Image = global::Vendstor.Properties.Resources.cash_discount_w;
            this.imgbtnCash.ImageActive = null;
            this.imgbtnCash.Location = new System.Drawing.Point(7, 6);
            this.imgbtnCash.Name = "imgbtnCash";
            this.imgbtnCash.Size = new System.Drawing.Size(35, 35);
            this.imgbtnCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCash.TabIndex = 3;
            this.imgbtnCash.TabStop = false;
            this.imgbtnCash.Zoom = 10;
            // 
            // cardCost
            // 
            this.cardCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCost.BackColor = System.Drawing.Color.White;
            this.cardCost.BorderRadius = 10;
            this.cardCost.BottomSahddow = true;
            this.cardCost.color = System.Drawing.Color.Transparent;
            this.cardCost.Controls.Add(this.lblCreditCardAmount);
            this.cardCost.Controls.Add(this.text_CreditCard);
            this.cardCost.Controls.Add(this.imgpnlCreditCard);
            this.cardCost.LeftSahddow = false;
            this.cardCost.Location = new System.Drawing.Point(814, 239);
            this.cardCost.Name = "cardCost";
            this.cardCost.RightSahddow = true;
            this.cardCost.ShadowDepth = 10;
            this.cardCost.Size = new System.Drawing.Size(304, 102);
            this.cardCost.TabIndex = 131;
            // 
            // lblCreditCardAmount
            // 
            this.lblCreditCardAmount.AutoSize = true;
            this.lblCreditCardAmount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCreditCardAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreditCardAmount.Location = new System.Drawing.Point(148, 38);
            this.lblCreditCardAmount.Name = "lblCreditCardAmount";
            this.lblCreditCardAmount.Size = new System.Drawing.Size(123, 48);
            this.lblCreditCardAmount.TabIndex = 2;
            this.lblCreditCardAmount.Text = "€ 00.00";
            // 
            // text_CreditCard
            // 
            this.text_CreditCard.AutoSize = true;
            this.text_CreditCard.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_CreditCard.Location = new System.Drawing.Point(154, 10);
            this.text_CreditCard.Name = "text_CreditCard";
            this.text_CreditCard.Size = new System.Drawing.Size(105, 28);
            this.text_CreditCard.TabIndex = 1;
            this.text_CreditCard.Text = "Credit Card";
            // 
            // imgpnlCreditCard
            // 
            this.imgpnlCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.imgpnlCreditCard.Controls.Add(this.imgbtnCreditCard);
            this.imgpnlCreditCard.Location = new System.Drawing.Point(23, 18);
            this.imgpnlCreditCard.Name = "imgpnlCreditCard";
            this.imgpnlCreditCard.Size = new System.Drawing.Size(49, 47);
            this.imgpnlCreditCard.TabIndex = 8;
            // 
            // imgbtnCreditCard
            // 
            this.imgbtnCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCreditCard.Image = global::Vendstor.Properties.Resources.credit_card_pay_w;
            this.imgbtnCreditCard.ImageActive = null;
            this.imgbtnCreditCard.Location = new System.Drawing.Point(7, 6);
            this.imgbtnCreditCard.Name = "imgbtnCreditCard";
            this.imgbtnCreditCard.Size = new System.Drawing.Size(35, 35);
            this.imgbtnCreditCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCreditCard.TabIndex = 3;
            this.imgbtnCreditCard.TabStop = false;
            this.imgbtnCreditCard.Zoom = 10;
            // 
            // cardProfit
            // 
            this.cardProfit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardProfit.BackColor = System.Drawing.Color.White;
            this.cardProfit.BorderRadius = 10;
            this.cardProfit.BottomSahddow = true;
            this.cardProfit.color = System.Drawing.Color.Transparent;
            this.cardProfit.Controls.Add(this.lblTotalAmount);
            this.cardProfit.Controls.Add(this.text_Total);
            this.cardProfit.Controls.Add(this.imgpnlTotal);
            this.cardProfit.LeftSahddow = false;
            this.cardProfit.Location = new System.Drawing.Point(814, 457);
            this.cardProfit.Name = "cardProfit";
            this.cardProfit.RightSahddow = true;
            this.cardProfit.ShadowDepth = 10;
            this.cardProfit.Size = new System.Drawing.Size(304, 102);
            this.cardProfit.TabIndex = 132;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(148, 38);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(123, 48);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "€ 00.00";
            // 
            // text_Total
            // 
            this.text_Total.AutoSize = true;
            this.text_Total.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Total.Location = new System.Drawing.Point(154, 10);
            this.text_Total.Name = "text_Total";
            this.text_Total.Size = new System.Drawing.Size(52, 28);
            this.text_Total.TabIndex = 1;
            this.text_Total.Text = "Total";
            // 
            // imgpnlTotal
            // 
            this.imgpnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlTotal.Controls.Add(this.imgbtnTotal);
            this.imgpnlTotal.Location = new System.Drawing.Point(23, 18);
            this.imgpnlTotal.Name = "imgpnlTotal";
            this.imgpnlTotal.Size = new System.Drawing.Size(49, 47);
            this.imgpnlTotal.TabIndex = 8;
            // 
            // imgbtnTotal
            // 
            this.imgbtnTotal.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTotal.Image = global::Vendstor.Properties.Resources.total_w;
            this.imgbtnTotal.ImageActive = null;
            this.imgbtnTotal.Location = new System.Drawing.Point(7, 6);
            this.imgbtnTotal.Name = "imgbtnTotal";
            this.imgbtnTotal.Size = new System.Drawing.Size(35, 35);
            this.imgbtnTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTotal.TabIndex = 3;
            this.imgbtnTotal.TabStop = false;
            this.imgbtnTotal.Zoom = 10;
            // 
            // cardStoreCredit
            // 
            this.cardStoreCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStoreCredit.BackColor = System.Drawing.Color.White;
            this.cardStoreCredit.BorderRadius = 10;
            this.cardStoreCredit.BottomSahddow = true;
            this.cardStoreCredit.color = System.Drawing.Color.Transparent;
            this.cardStoreCredit.Controls.Add(this.lblStoreCreditAmount);
            this.cardStoreCredit.Controls.Add(this.text_StoreCredit);
            this.cardStoreCredit.Controls.Add(this.imgpnlStoreCredit);
            this.cardStoreCredit.LeftSahddow = false;
            this.cardStoreCredit.Location = new System.Drawing.Point(814, 348);
            this.cardStoreCredit.Name = "cardStoreCredit";
            this.cardStoreCredit.RightSahddow = true;
            this.cardStoreCredit.ShadowDepth = 10;
            this.cardStoreCredit.Size = new System.Drawing.Size(304, 102);
            this.cardStoreCredit.TabIndex = 132;
            // 
            // lblStoreCreditAmount
            // 
            this.lblStoreCreditAmount.AutoSize = true;
            this.lblStoreCreditAmount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblStoreCreditAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStoreCreditAmount.Location = new System.Drawing.Point(148, 38);
            this.lblStoreCreditAmount.Name = "lblStoreCreditAmount";
            this.lblStoreCreditAmount.Size = new System.Drawing.Size(123, 48);
            this.lblStoreCreditAmount.TabIndex = 2;
            this.lblStoreCreditAmount.Text = "€ 00.00";
            // 
            // text_StoreCredit
            // 
            this.text_StoreCredit.AutoSize = true;
            this.text_StoreCredit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_StoreCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_StoreCredit.Location = new System.Drawing.Point(154, 10);
            this.text_StoreCredit.Name = "text_StoreCredit";
            this.text_StoreCredit.Size = new System.Drawing.Size(106, 28);
            this.text_StoreCredit.TabIndex = 1;
            this.text_StoreCredit.Text = "Store Credit";
            // 
            // imgpnlStoreCredit
            // 
            this.imgpnlStoreCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.imgpnlStoreCredit.Controls.Add(this.imgbtnStoreCredit);
            this.imgpnlStoreCredit.Location = new System.Drawing.Point(23, 18);
            this.imgpnlStoreCredit.Name = "imgpnlStoreCredit";
            this.imgpnlStoreCredit.Size = new System.Drawing.Size(49, 47);
            this.imgpnlStoreCredit.TabIndex = 8;
            // 
            // imgbtnStoreCredit
            // 
            this.imgbtnStoreCredit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnStoreCredit.Image = global::Vendstor.Properties.Resources.stockcost_filled_w;
            this.imgbtnStoreCredit.ImageActive = null;
            this.imgbtnStoreCredit.Location = new System.Drawing.Point(7, 6);
            this.imgbtnStoreCredit.Name = "imgbtnStoreCredit";
            this.imgbtnStoreCredit.Size = new System.Drawing.Size(35, 35);
            this.imgbtnStoreCredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnStoreCredit.TabIndex = 3;
            this.imgbtnStoreCredit.TabStop = false;
            this.imgbtnStoreCredit.Zoom = 10;
            // 
            // cardEmptyData
            // 
            this.cardEmptyData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardEmptyData.BackColor = System.Drawing.Color.White;
            this.cardEmptyData.BorderRadius = 5;
            this.cardEmptyData.BottomSahddow = true;
            this.cardEmptyData.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardEmptyData.Controls.Add(this.imgVectorNoData);
            this.cardEmptyData.Controls.Add(this.seperatorCard);
            this.cardEmptyData.Controls.Add(this.lblNothing_Card);
            this.cardEmptyData.LeftSahddow = false;
            this.cardEmptyData.Location = new System.Drawing.Point(176, 240);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(449, 260);
            this.cardEmptyData.TabIndex = 140;
            this.cardEmptyData.Visible = false;
            // 
            // imgVectorNoData
            // 
            this.imgVectorNoData.BackColor = System.Drawing.Color.Transparent;
            this.imgVectorNoData.Image = global::Vendstor.Properties.Resources.vector_no_data_colored;
            this.imgVectorNoData.ImageActive = null;
            this.imgVectorNoData.Location = new System.Drawing.Point(73, 13);
            this.imgVectorNoData.Name = "imgVectorNoData";
            this.imgVectorNoData.Size = new System.Drawing.Size(303, 152);
            this.imgVectorNoData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVectorNoData.TabIndex = 182;
            this.imgVectorNoData.TabStop = false;
            this.imgVectorNoData.Zoom = 10;
            // 
            // seperatorCard
            // 
            this.seperatorCard.BackColor = System.Drawing.Color.Transparent;
            this.seperatorCard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperatorCard.LineThickness = 1;
            this.seperatorCard.Location = new System.Drawing.Point(192, 202);
            this.seperatorCard.Margin = new System.Windows.Forms.Padding(7);
            this.seperatorCard.Name = "seperatorCard";
            this.seperatorCard.Size = new System.Drawing.Size(65, 28);
            this.seperatorCard.TabIndex = 181;
            this.seperatorCard.Transparency = 255;
            this.seperatorCard.Vertical = false;
            this.seperatorCard.Visible = false;
            // 
            // lblNothing_Card
            // 
            this.lblNothing_Card.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNothing_Card.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblNothing_Card.Location = new System.Drawing.Point(0, 171);
            this.lblNothing_Card.Name = "lblNothing_Card";
            this.lblNothing_Card.Size = new System.Drawing.Size(446, 26);
            this.lblNothing_Card.TabIndex = 179;
            this.lblNothing_Card.Text = "No Results";
            this.lblNothing_Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Activecolor = System.Drawing.Color.Tomato;
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Tomato;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.BorderRadius = 5;
            this.btnNext.ButtonText = "";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledColor = System.Drawing.Color.Gray;
            this.btnNext.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNext.Iconimage = global::Vendstor.Properties.Resources.pagination_next_filled;
            this.btnNext.Iconimage_right = null;
            this.btnNext.Iconimage_right_Selected = null;
            this.btnNext.Iconimage_Selected = null;
            this.btnNext.IconMarginLeft = 0;
            this.btnNext.IconMarginRight = 0;
            this.btnNext.IconRightVisible = true;
            this.btnNext.IconRightZoom = 0D;
            this.btnNext.IconVisible = true;
            this.btnNext.IconZoom = 35D;
            this.btnNext.IsTab = false;
            this.btnNext.Location = new System.Drawing.Point(804, 46);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Normalcolor = System.Drawing.Color.Tomato;
            this.btnNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnNext.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNext.selected = false;
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 224;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Textcolor = System.Drawing.Color.White;
            this.btnNext.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Activecolor = System.Drawing.Color.Tomato;
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.BackColor = System.Drawing.Color.Tomato;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.BorderRadius = 5;
            this.btnPrevious.ButtonText = "";
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrevious.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrevious.Iconimage = global::Vendstor.Properties.Resources.pagination_previous_filled;
            this.btnPrevious.Iconimage_right = null;
            this.btnPrevious.Iconimage_right_Selected = null;
            this.btnPrevious.Iconimage_Selected = null;
            this.btnPrevious.IconMarginLeft = 0;
            this.btnPrevious.IconMarginRight = 0;
            this.btnPrevious.IconRightVisible = true;
            this.btnPrevious.IconRightZoom = 0D;
            this.btnPrevious.IconVisible = true;
            this.btnPrevious.IconZoom = 35D;
            this.btnPrevious.IsTab = false;
            this.btnPrevious.Location = new System.Drawing.Point(766, 46);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Normalcolor = System.Drawing.Color.Tomato;
            this.btnPrevious.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnPrevious.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.selected = false;
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 223;
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevious.Textcolor = System.Drawing.Color.White;
            this.btnPrevious.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.PaymentsGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.cardStoreCredit);
            this.Controls.Add(this.cardProfit);
            this.Controls.Add(this.cardCost);
            this.Controls.Add(this.cardCash);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlFilter);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.cardCash.ResumeLayout(false);
            this.cardCash.PerformLayout();
            this.imgpnlCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCash)).EndInit();
            this.cardCost.ResumeLayout(false);
            this.cardCost.PerformLayout();
            this.imgpnlCreditCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCreditCard)).EndInit();
            this.cardProfit.ResumeLayout(false);
            this.cardProfit.PerformLayout();
            this.imgpnlTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotal)).EndInit();
            this.cardStoreCredit.ResumeLayout(false);
            this.cardStoreCredit.PerformLayout();
            this.imgpnlStoreCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnStoreCredit)).EndInit();
            this.cardEmptyData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorNoData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateFrom;
        private System.Windows.Forms.Label text_DateTo;
        private System.Windows.Forms.Label text_From;
        private System.Windows.Forms.FlowLayoutPanel PaymentsGrid;
        private System.Windows.Forms.Panel pnlGridHeader;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblCash_Grid;
        private System.Windows.Forms.Label lblCreditCard_Grid;
        private System.Windows.Forms.Label lblDate_Grid;
        private Bunifu.Framework.UI.BunifuCards cardCash;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.Label text_Cash_Card;
        private System.Windows.Forms.Panel imgpnlCash;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCash;
        private Bunifu.Framework.UI.BunifuCards cardCost;
        private System.Windows.Forms.Label lblCreditCardAmount;
        private System.Windows.Forms.Label text_CreditCard;
        private System.Windows.Forms.Panel imgpnlCreditCard;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCreditCard;
        private Bunifu.Framework.UI.BunifuCards cardProfit;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label text_Total;
        private System.Windows.Forms.Panel imgpnlTotal;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuCards cardStoreCredit;
        private System.Windows.Forms.Label lblStoreCreditAmount;
        private System.Windows.Forms.Label text_StoreCredit;
        private System.Windows.Forms.Panel imgpnlStoreCredit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnStoreCredit;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblStoreCredit_Grid;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchFilterApply;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgVectorNoData;
        private Bunifu.Framework.UI.BunifuSeparator seperatorCard;
        private System.Windows.Forms.Label lblNothing_Card;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrevious;
    }
}
