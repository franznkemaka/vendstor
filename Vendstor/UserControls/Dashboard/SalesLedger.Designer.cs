namespace Vendstor.UserControls.Dashboard
{
    partial class SalesLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesLedger));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.text_SalesLedger = new System.Windows.Forms.Label();
            this.SalesLedgersGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.switchFilterApply = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.cardCustomer = new Bunifu.Framework.UI.BunifuCards();
            this.btnRemoveCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.text_Customer = new System.Windows.Forms.Label();
            this.imgpnlAdd_cardCustomer = new System.Windows.Forms.Panel();
            this.imgAdd_cardCustomer = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpDateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpDateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpDateTo_Filter = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpDateFrom_Filter = new Bunifu.Framework.UI.BunifuDatepicker();
            this.text_dateFrom = new System.Windows.Forms.Label();
            this.text_DateTo = new System.Windows.Forms.Label();
            this.text_From = new System.Windows.Forms.Label();
            this.dpdUsers = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_User = new System.Windows.Forms.Label();
            this.txtToken = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_ReceiptToken = new System.Windows.Forms.Label();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStatus_Grid = new System.Windows.Forms.Label();
            this.lblSaleTotal_Grid = new System.Windows.Forms.Label();
            this.lblNote_Grid = new System.Windows.Forms.Label();
            this.lblCustomer_Grid = new System.Windows.Forms.Label();
            this.lblReceiptToken_Grid = new System.Windows.Forms.Label();
            this.lblSoldBy_Grid = new System.Windows.Forms.Label();
            this.lblDate_Grid = new System.Windows.Forms.Label();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgVectorNoData = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperatorCard = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNothing_Card = new System.Windows.Forms.Label();
            this.pgbLoading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.cardCustomer.SuspendLayout();
            this.imgpnlAdd_cardCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd_cardCustomer)).BeginInit();
            this.pnlGridHeader.SuspendLayout();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorNoData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.Controls.Add(this.lblDescription);
            this.pnlHeader.Controls.Add(this.text_SalesLedger);
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1112, 87);
            this.pnlHeader.TabIndex = 115;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblDescription.Location = new System.Drawing.Point(4, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(396, 26);
            this.lblDescription.TabIndex = 98;
            this.lblDescription.Text = "Use Sales Ledger to review Receipts, and Transaction";
            // 
            // text_SalesLedger
            // 
            this.text_SalesLedger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_SalesLedger.AutoSize = true;
            this.text_SalesLedger.Font = new System.Drawing.Font("Poppins", 16F);
            this.text_SalesLedger.Location = new System.Drawing.Point(2, 13);
            this.text_SalesLedger.Name = "text_SalesLedger";
            this.text_SalesLedger.Size = new System.Drawing.Size(157, 39);
            this.text_SalesLedger.TabIndex = 97;
            this.text_SalesLedger.Text = "Sales Ledger";
            // 
            // SalesLedgersGrid
            // 
            this.SalesLedgersGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalesLedgersGrid.AutoScroll = true;
            this.SalesLedgersGrid.BackColor = System.Drawing.Color.Transparent;
            this.SalesLedgersGrid.Location = new System.Drawing.Point(3, 335);
            this.SalesLedgersGrid.Name = "SalesLedgersGrid";
            this.SalesLedgersGrid.Size = new System.Drawing.Size(1122, 315);
            this.SalesLedgersGrid.TabIndex = 121;
            this.SalesLedgersGrid.Visible = false;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.switchFilterApply);
            this.pnlFilter.Controls.Add(this.cardCustomer);
            this.pnlFilter.Controls.Add(this.btnNext);
            this.pnlFilter.Controls.Add(this.btnPrevious);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.dpDateTo);
            this.pnlFilter.Controls.Add(this.dpDateFrom);
            this.pnlFilter.Controls.Add(this.dpDateTo_Filter);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.dpDateFrom_Filter);
            this.pnlFilter.Controls.Add(this.text_dateFrom);
            this.pnlFilter.Controls.Add(this.text_DateTo);
            this.pnlFilter.Controls.Add(this.text_From);
            this.pnlFilter.Controls.Add(this.dpdUsers);
            this.pnlFilter.Controls.Add(this.text_User);
            this.pnlFilter.Controls.Add(this.txtToken);
            this.pnlFilter.Controls.Add(this.text_ReceiptToken);
            this.pnlFilter.Location = new System.Drawing.Point(3, 94);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1112, 175);
            this.pnlFilter.TabIndex = 119;
            // 
            // switchFilterApply
            // 
            this.switchFilterApply.BackColor = System.Drawing.Color.Transparent;
            this.switchFilterApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchFilterApply.BackgroundImage")));
            this.switchFilterApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchFilterApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchFilterApply.Location = new System.Drawing.Point(1057, 137);
            this.switchFilterApply.Name = "switchFilterApply";
            this.switchFilterApply.OffColor = System.Drawing.Color.Tomato;
            this.switchFilterApply.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchFilterApply.Size = new System.Drawing.Size(35, 20);
            this.switchFilterApply.TabIndex = 226;
            this.switchFilterApply.Value = false;
            this.switchFilterApply.Click += new System.EventHandler(this.SwitchFilterApply_Click);
            // 
            // cardCustomer
            // 
            this.cardCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCustomer.BackColor = System.Drawing.Color.White;
            this.cardCustomer.BorderRadius = 10;
            this.cardCustomer.BottomSahddow = true;
            this.cardCustomer.color = System.Drawing.Color.Transparent;
            this.cardCustomer.Controls.Add(this.btnRemoveCustomer);
            this.cardCustomer.Controls.Add(this.lblCustomerName);
            this.cardCustomer.Controls.Add(this.text_Customer);
            this.cardCustomer.Controls.Add(this.imgpnlAdd_cardCustomer);
            this.cardCustomer.LeftSahddow = false;
            this.cardCustomer.Location = new System.Drawing.Point(574, 8);
            this.cardCustomer.Name = "cardCustomer";
            this.cardCustomer.RightSahddow = true;
            this.cardCustomer.ShadowDepth = 10;
            this.cardCustomer.Size = new System.Drawing.Size(308, 89);
            this.cardCustomer.TabIndex = 225;
            this.cardCustomer.Click += new System.EventHandler(this.CardCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Activecolor = System.Drawing.Color.Tomato;
            this.btnRemoveCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveCustomer.BorderRadius = 5;
            this.btnRemoveCustomer.ButtonText = "";
            this.btnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemoveCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemoveCustomer.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnRemoveCustomer.Iconimage_right = null;
            this.btnRemoveCustomer.Iconimage_right_Selected = null;
            this.btnRemoveCustomer.Iconimage_Selected = null;
            this.btnRemoveCustomer.IconMarginLeft = 0;
            this.btnRemoveCustomer.IconMarginRight = 0;
            this.btnRemoveCustomer.IconRightVisible = true;
            this.btnRemoveCustomer.IconRightZoom = 0D;
            this.btnRemoveCustomer.IconVisible = true;
            this.btnRemoveCustomer.IconZoom = 25D;
            this.btnRemoveCustomer.IsTab = false;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(269, 5);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Normalcolor = System.Drawing.Color.Tomato;
            this.btnRemoveCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnRemoveCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.selected = false;
            this.btnRemoveCustomer.Size = new System.Drawing.Size(25, 25);
            this.btnRemoveCustomer.TabIndex = 225;
            this.btnRemoveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveCustomer.Textcolor = System.Drawing.Color.White;
            this.btnRemoveCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(94, 37);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(60, 25);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "(none)";
            // 
            // text_Customer
            // 
            this.text_Customer.AutoSize = true;
            this.text_Customer.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Customer.Location = new System.Drawing.Point(96, 7);
            this.text_Customer.Name = "text_Customer";
            this.text_Customer.Size = new System.Drawing.Size(90, 28);
            this.text_Customer.TabIndex = 1;
            this.text_Customer.Text = "Customer";
            // 
            // imgpnlAdd_cardCustomer
            // 
            this.imgpnlAdd_cardCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlAdd_cardCustomer.Controls.Add(this.imgAdd_cardCustomer);
            this.imgpnlAdd_cardCustomer.Location = new System.Drawing.Point(23, 18);
            this.imgpnlAdd_cardCustomer.Name = "imgpnlAdd_cardCustomer";
            this.imgpnlAdd_cardCustomer.Size = new System.Drawing.Size(49, 47);
            this.imgpnlAdd_cardCustomer.TabIndex = 8;
            // 
            // imgAdd_cardCustomer
            // 
            this.imgAdd_cardCustomer.BackColor = System.Drawing.Color.Transparent;
            this.imgAdd_cardCustomer.Image = global::Vendstor.Properties.Resources.add_user_filled_w;
            this.imgAdd_cardCustomer.ImageActive = null;
            this.imgAdd_cardCustomer.Location = new System.Drawing.Point(7, 6);
            this.imgAdd_cardCustomer.Name = "imgAdd_cardCustomer";
            this.imgAdd_cardCustomer.Size = new System.Drawing.Size(35, 35);
            this.imgAdd_cardCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAdd_cardCustomer.TabIndex = 3;
            this.imgAdd_cardCustomer.TabStop = false;
            this.imgAdd_cardCustomer.Zoom = 10;
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
            this.btnNext.Location = new System.Drawing.Point(852, 127);
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
            this.btnPrevious.Location = new System.Drawing.Point(814, 127);
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
            this.btnFilter.Location = new System.Drawing.Point(930, 65);
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
            this.dpDateTo.Location = new System.Drawing.Point(516, 127);
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
            this.dpDateFrom.Location = new System.Drawing.Point(221, 129);
            this.dpDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Size = new System.Drawing.Size(276, 36);
            this.dpDateFrom.TabIndex = 127;
            this.dpDateFrom.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // dpDateTo_Filter
            // 
            this.dpDateTo_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateTo_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateTo_Filter.BorderRadius = 0;
            this.dpDateTo_Filter.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateTo_Filter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateTo_Filter.FormatCustom = null;
            this.dpDateTo_Filter.Location = new System.Drawing.Point(516, 127);
            this.dpDateTo_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateTo_Filter.Name = "dpDateTo_Filter";
            this.dpDateTo_Filter.Size = new System.Drawing.Size(276, 36);
            this.dpDateTo_Filter.TabIndex = 128;
            this.dpDateTo_Filter.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label2.Location = new System.Drawing.Point(520, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 126;
            this.label2.Text = "Date To";
            // 
            // dpDateFrom_Filter
            // 
            this.dpDateFrom_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateFrom_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateFrom_Filter.BorderRadius = 0;
            this.dpDateFrom_Filter.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateFrom_Filter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateFrom_Filter.FormatCustom = null;
            this.dpDateFrom_Filter.Location = new System.Drawing.Point(221, 129);
            this.dpDateFrom_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateFrom_Filter.Name = "dpDateFrom_Filter";
            this.dpDateFrom_Filter.Size = new System.Drawing.Size(276, 36);
            this.dpDateFrom_Filter.TabIndex = 127;
            this.dpDateFrom_Filter.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // text_dateFrom
            // 
            this.text_dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_dateFrom.AutoSize = true;
            this.text_dateFrom.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_dateFrom.Location = new System.Drawing.Point(225, 100);
            this.text_dateFrom.Name = "text_dateFrom";
            this.text_dateFrom.Size = new System.Drawing.Size(88, 26);
            this.text_dateFrom.TabIndex = 125;
            this.text_dateFrom.Text = "Date From";
            // 
            // text_DateTo
            // 
            this.text_DateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_DateTo.AutoSize = true;
            this.text_DateTo.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_DateTo.Location = new System.Drawing.Point(520, 100);
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
            this.text_From.Location = new System.Drawing.Point(225, 100);
            this.text_From.Name = "text_From";
            this.text_From.Size = new System.Drawing.Size(88, 26);
            this.text_From.TabIndex = 125;
            this.text_From.Text = "Date From";
            // 
            // dpdUsers
            // 
            this.dpdUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdUsers.BorderRadius = 3;
            this.dpdUsers.DisabledColor = System.Drawing.Color.Gray;
            this.dpdUsers.ForeColor = System.Drawing.Color.DimGray;
            this.dpdUsers.Items = new string[] {
        "(none)"};
            this.dpdUsers.Location = new System.Drawing.Point(6, 129);
            this.dpdUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dpdUsers.Name = "dpdUsers";
            this.dpdUsers.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdUsers.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdUsers.selectedIndex = 0;
            this.dpdUsers.Size = new System.Drawing.Size(208, 34);
            this.dpdUsers.TabIndex = 124;
            // 
            // text_User
            // 
            this.text_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_User.AutoSize = true;
            this.text_User.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_User.Location = new System.Drawing.Point(10, 100);
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(44, 26);
            this.text_User.TabIndex = 123;
            this.text_User.Text = "User";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtToken.AutoScroll = true;
            this.txtToken.AutoSize = true;
            this.txtToken.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtToken.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtToken.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtToken.BorderThickness = 2;
            this.txtToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToken.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.txtToken.ForeColor = System.Drawing.Color.DimGray;
            this.txtToken.isPassword = false;
            this.txtToken.Location = new System.Drawing.Point(15, 45);
            this.txtToken.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(482, 41);
            this.txtToken.TabIndex = 119;
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_ReceiptToken
            // 
            this.text_ReceiptToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_ReceiptToken.AutoSize = true;
            this.text_ReceiptToken.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_ReceiptToken.Location = new System.Drawing.Point(10, 13);
            this.text_ReceiptToken.Name = "text_ReceiptToken";
            this.text_ReceiptToken.Size = new System.Drawing.Size(93, 26);
            this.text_ReceiptToken.TabIndex = 117;
            this.text_ReceiptToken.Text = "Token Or Id";
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.White;
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator8);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator6);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator5);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator4);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator3);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblStatus_Grid);
            this.pnlGridHeader.Controls.Add(this.lblSaleTotal_Grid);
            this.pnlGridHeader.Controls.Add(this.lblNote_Grid);
            this.pnlGridHeader.Controls.Add(this.lblCustomer_Grid);
            this.pnlGridHeader.Controls.Add(this.lblReceiptToken_Grid);
            this.pnlGridHeader.Controls.Add(this.lblSoldBy_Grid);
            this.pnlGridHeader.Controls.Add(this.lblDate_Grid);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(3, 275);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(1112, 54);
            this.pnlGridHeader.TabIndex = 120;
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(1057, 8);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(21, 39);
            this.bunifuSeparator8.TabIndex = 148;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // GridTitle_Separator6
            // 
            this.GridTitle_Separator6.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator6.LineThickness = 1;
            this.GridTitle_Separator6.Location = new System.Drawing.Point(941, 12);
            this.GridTitle_Separator6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator6.Name = "GridTitle_Separator6";
            this.GridTitle_Separator6.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator6.TabIndex = 147;
            this.GridTitle_Separator6.Transparency = 255;
            this.GridTitle_Separator6.Vertical = true;
            // 
            // GridTitle_Separator5
            // 
            this.GridTitle_Separator5.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator5.LineThickness = 1;
            this.GridTitle_Separator5.Location = new System.Drawing.Point(812, 8);
            this.GridTitle_Separator5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator5.Name = "GridTitle_Separator5";
            this.GridTitle_Separator5.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator5.TabIndex = 146;
            this.GridTitle_Separator5.Transparency = 255;
            this.GridTitle_Separator5.Vertical = true;
            // 
            // GridTitle_Separator4
            // 
            this.GridTitle_Separator4.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator4.LineThickness = 1;
            this.GridTitle_Separator4.Location = new System.Drawing.Point(658, 8);
            this.GridTitle_Separator4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator4.Name = "GridTitle_Separator4";
            this.GridTitle_Separator4.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator4.TabIndex = 145;
            this.GridTitle_Separator4.Transparency = 255;
            this.GridTitle_Separator4.Vertical = true;
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(493, 8);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator3.TabIndex = 144;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = true;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(334, 8);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator2.TabIndex = 143;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(160, 8);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator1.TabIndex = 142;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            // 
            // lblStatus_Grid
            // 
            this.lblStatus_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus_Grid.AutoSize = true;
            this.lblStatus_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStatus_Grid.Location = new System.Drawing.Point(959, 14);
            this.lblStatus_Grid.Name = "lblStatus_Grid";
            this.lblStatus_Grid.Size = new System.Drawing.Size(62, 28);
            this.lblStatus_Grid.TabIndex = 121;
            this.lblStatus_Grid.Text = "Status";
            // 
            // lblSaleTotal_Grid
            // 
            this.lblSaleTotal_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaleTotal_Grid.AutoSize = true;
            this.lblSaleTotal_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblSaleTotal_Grid.Location = new System.Drawing.Point(838, 14);
            this.lblSaleTotal_Grid.Name = "lblSaleTotal_Grid";
            this.lblSaleTotal_Grid.Size = new System.Drawing.Size(52, 28);
            this.lblSaleTotal_Grid.TabIndex = 120;
            this.lblSaleTotal_Grid.Text = "Total";
            // 
            // lblNote_Grid
            // 
            this.lblNote_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNote_Grid.AutoSize = true;
            this.lblNote_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblNote_Grid.Location = new System.Drawing.Point(682, 14);
            this.lblNote_Grid.Name = "lblNote_Grid";
            this.lblNote_Grid.Size = new System.Drawing.Size(49, 28);
            this.lblNote_Grid.TabIndex = 119;
            this.lblNote_Grid.Text = "Note";
            // 
            // lblCustomer_Grid
            // 
            this.lblCustomer_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomer_Grid.AutoSize = true;
            this.lblCustomer_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCustomer_Grid.Location = new System.Drawing.Point(511, 14);
            this.lblCustomer_Grid.Name = "lblCustomer_Grid";
            this.lblCustomer_Grid.Size = new System.Drawing.Size(90, 28);
            this.lblCustomer_Grid.TabIndex = 118;
            this.lblCustomer_Grid.Text = "Customer";
            // 
            // lblReceiptToken_Grid
            // 
            this.lblReceiptToken_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiptToken_Grid.AutoSize = true;
            this.lblReceiptToken_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblReceiptToken_Grid.Location = new System.Drawing.Point(184, 14);
            this.lblReceiptToken_Grid.Name = "lblReceiptToken_Grid";
            this.lblReceiptToken_Grid.Size = new System.Drawing.Size(65, 28);
            this.lblReceiptToken_Grid.TabIndex = 117;
            this.lblReceiptToken_Grid.Text = "Sale Id";
            // 
            // lblSoldBy_Grid
            // 
            this.lblSoldBy_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoldBy_Grid.AutoSize = true;
            this.lblSoldBy_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblSoldBy_Grid.Location = new System.Drawing.Point(358, 14);
            this.lblSoldBy_Grid.Name = "lblSoldBy_Grid";
            this.lblSoldBy_Grid.Size = new System.Drawing.Size(69, 28);
            this.lblSoldBy_Grid.TabIndex = 116;
            this.lblSoldBy_Grid.Text = "Sold By";
            // 
            // lblDate_Grid
            // 
            this.lblDate_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate_Grid.AutoSize = true;
            this.lblDate_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblDate_Grid.Location = new System.Drawing.Point(1, 12);
            this.lblDate_Grid.Name = "lblDate_Grid";
            this.lblDate_Grid.Size = new System.Drawing.Size(50, 28);
            this.lblDate_Grid.TabIndex = 115;
            this.lblDate_Grid.Text = "Date";
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
            this.cardEmptyData.Location = new System.Drawing.Point(340, 356);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(449, 260);
            this.cardEmptyData.TabIndex = 139;
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
            // pgbLoading
            // 
            this.pgbLoading.animated = true;
            this.pgbLoading.animationIterval = 5;
            this.pgbLoading.animationSpeed = 1;
            this.pgbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pgbLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgbLoading.BackgroundImage")));
            this.pgbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pgbLoading.LabelVisible = false;
            this.pgbLoading.LineProgressThickness = 2;
            this.pgbLoading.LineThickness = 1;
            this.pgbLoading.Location = new System.Drawing.Point(525, 427);
            this.pgbLoading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbLoading.MaxValue = 100;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pgbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pgbLoading.Size = new System.Drawing.Size(79, 79);
            this.pgbLoading.TabIndex = 0;
            this.pgbLoading.Value = 10;
            // 
            // SalesLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.SalesLedgersGrid);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SalesLedger";
            this.Size = new System.Drawing.Size(1128, 650);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.cardCustomer.ResumeLayout(false);
            this.cardCustomer.PerformLayout();
            this.imgpnlAdd_cardCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd_cardCustomer)).EndInit();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.cardEmptyData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorNoData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label text_SalesLedger;
        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateTo_Filter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateFrom_Filter;
        private System.Windows.Forms.Label text_DateTo;
        private System.Windows.Forms.Label text_From;
        private Bunifu.Framework.UI.BunifuDropdown dpdUsers;
        private System.Windows.Forms.Label text_User;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtToken;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblStatus_Grid;
        private System.Windows.Forms.Label lblSaleTotal_Grid;
        private System.Windows.Forms.Label lblNote_Grid;
        private System.Windows.Forms.Label lblCustomer_Grid;
        private System.Windows.Forms.Label lblReceiptToken_Grid;
        private System.Windows.Forms.Label lblSoldBy_Grid;
        private System.Windows.Forms.Label lblDate_Grid;
        public System.Windows.Forms.FlowLayoutPanel SalesLedgersGrid;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator6;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator5;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator4;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label text_ReceiptToken;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_dateFrom;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrevious;
        private Bunifu.Framework.UI.BunifuCards cardCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemoveCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label text_Customer;
        private System.Windows.Forms.Panel imgpnlAdd_cardCustomer;
        private Bunifu.Framework.UI.BunifuImageButton imgAdd_cardCustomer;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchFilterApply;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgVectorNoData;
        private Bunifu.Framework.UI.BunifuSeparator seperatorCard;
        private System.Windows.Forms.Label lblNothing_Card;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pgbLoading;
    }
}
