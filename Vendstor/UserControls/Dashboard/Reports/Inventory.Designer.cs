namespace Vendstor.UserControls.Dashboard.Reports
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlCoverDropDowns = new System.Windows.Forms.Panel();
            this.switchQueryType = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.text_SearchHint = new System.Windows.Forms.Label();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpDateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtFilter = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpDateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.text_DateTo = new System.Windows.Forms.Label();
            this.text_From = new System.Windows.Forms.Label();
            this.dpdStock = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_Status = new System.Windows.Forms.Label();
            this.InventoryGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblItemValue_Grid = new System.Windows.Forms.Label();
            this.lblCurrentStock_Grid = new System.Windows.Forms.Label();
            this.lblStockValue_Grid = new System.Windows.Forms.Label();
            this.lblProduct_Grid = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cardCurrentStock = new Bunifu.Framework.UI.BunifuCards();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.text_CurrentStock = new System.Windows.Forms.Label();
            this.imgpnl_CurrentStock = new System.Windows.Forms.Panel();
            this.imgbtnCurrentStock = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardStockValue = new Bunifu.Framework.UI.BunifuCards();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.text_StockValue = new System.Windows.Forms.Label();
            this.imgpnl_StockValue = new System.Windows.Forms.Panel();
            this.imgbtnStockValue = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardItemValue = new Bunifu.Framework.UI.BunifuCards();
            this.lblItemValue = new System.Windows.Forms.Label();
            this.text_ItemValue = new System.Windows.Forms.Label();
            this.imgpnl_ItemValue = new System.Windows.Forms.Panel();
            this.imgbtnItemValue = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgVectorNoData = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperatorCard = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNothing_Card = new System.Windows.Forms.Label();
            this.pnlFilter.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            this.cardCurrentStock.SuspendLayout();
            this.imgpnl_CurrentStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCurrentStock)).BeginInit();
            this.cardStockValue.SuspendLayout();
            this.imgpnl_StockValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnStockValue)).BeginInit();
            this.cardItemValue.SuspendLayout();
            this.imgpnl_ItemValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnItemValue)).BeginInit();
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
            this.pnlFilter.Controls.Add(this.pnlCoverDropDowns);
            this.pnlFilter.Controls.Add(this.switchQueryType);
            this.pnlFilter.Controls.Add(this.text_SearchHint);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.dpDateTo);
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.dpDateFrom);
            this.pnlFilter.Controls.Add(this.text_DateTo);
            this.pnlFilter.Controls.Add(this.text_From);
            this.pnlFilter.Controls.Add(this.dpdStock);
            this.pnlFilter.Controls.Add(this.text_Status);
            this.pnlFilter.Location = new System.Drawing.Point(10, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1108, 159);
            this.pnlFilter.TabIndex = 120;
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
            this.btnNext.Location = new System.Drawing.Point(958, 120);
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
            this.btnPrevious.Location = new System.Drawing.Point(920, 120);
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
            // pnlCoverDropDowns
            // 
            this.pnlCoverDropDowns.Location = new System.Drawing.Point(3, 87);
            this.pnlCoverDropDowns.Name = "pnlCoverDropDowns";
            this.pnlCoverDropDowns.Size = new System.Drawing.Size(904, 66);
            this.pnlCoverDropDowns.TabIndex = 137;
            // 
            // switchQueryType
            // 
            this.switchQueryType.BackColor = System.Drawing.Color.Transparent;
            this.switchQueryType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchQueryType.BackgroundImage")));
            this.switchQueryType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchQueryType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchQueryType.Location = new System.Drawing.Point(657, 48);
            this.switchQueryType.Name = "switchQueryType";
            this.switchQueryType.OffColor = System.Drawing.Color.Tomato;
            this.switchQueryType.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchQueryType.Size = new System.Drawing.Size(35, 20);
            this.switchQueryType.TabIndex = 136;
            this.switchQueryType.Value = true;
            this.switchQueryType.Click += new System.EventHandler(this.SwitchQueryType_Click);
            // 
            // text_SearchHint
            // 
            this.text_SearchHint.AutoSize = true;
            this.text_SearchHint.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_SearchHint.Location = new System.Drawing.Point(15, 5);
            this.text_SearchHint.Name = "text_SearchHint";
            this.text_SearchHint.Size = new System.Drawing.Size(311, 26);
            this.text_SearchHint.TabIndex = 131;
            this.text_SearchHint.Text = "Start typing a keyword to filter your report";
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
            this.btnFilter.Location = new System.Drawing.Point(914, 57);
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
            this.dpDateTo.Location = new System.Drawing.Point(551, 112);
            this.dpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Size = new System.Drawing.Size(276, 36);
            this.dpDateTo.TabIndex = 128;
            this.dpDateTo.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.AutoScroll = true;
            this.txtFilter.AutoSize = true;
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFilter.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtFilter.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFilter.BorderThickness = 2;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.txtFilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilter.isPassword = false;
            this.txtFilter.Location = new System.Drawing.Point(19, 36);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(572, 41);
            this.txtFilter.TabIndex = 119;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateFrom.BorderRadius = 0;
            this.dpDateFrom.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateFrom.FormatCustom = null;
            this.dpDateFrom.Location = new System.Drawing.Point(256, 112);
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
            this.text_DateTo.Location = new System.Drawing.Point(555, 83);
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
            this.text_From.Location = new System.Drawing.Point(261, 83);
            this.text_From.Name = "text_From";
            this.text_From.Size = new System.Drawing.Size(88, 26);
            this.text_From.TabIndex = 125;
            this.text_From.Text = "Date From";
            // 
            // dpdStock
            // 
            this.dpdStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStock.BorderRadius = 3;
            this.dpdStock.DisabledColor = System.Drawing.Color.Gray;
            this.dpdStock.ForeColor = System.Drawing.Color.DimGray;
            this.dpdStock.Items = new string[] {
        "(none)",
        "On Stock",
        "Low Stock",
        "No Stock"};
            this.dpdStock.Location = new System.Drawing.Point(20, 114);
            this.dpdStock.Margin = new System.Windows.Forms.Padding(4);
            this.dpdStock.Name = "dpdStock";
            this.dpdStock.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStock.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStock.selectedIndex = 0;
            this.dpdStock.Size = new System.Drawing.Size(208, 34);
            this.dpdStock.TabIndex = 120;
            // 
            // text_Status
            // 
            this.text_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Status.AutoSize = true;
            this.text_Status.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Status.Location = new System.Drawing.Point(15, 82);
            this.text_Status.Name = "text_Status";
            this.text_Status.Size = new System.Drawing.Size(58, 26);
            this.text_Status.TabIndex = 115;
            this.text_Status.Text = "Status";
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InventoryGrid.AutoScroll = true;
            this.InventoryGrid.BackColor = System.Drawing.Color.White;
            this.InventoryGrid.Location = new System.Drawing.Point(10, 219);
            this.InventoryGrid.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.Size = new System.Drawing.Size(794, 365);
            this.InventoryGrid.TabIndex = 121;
            this.InventoryGrid.Click += new System.EventHandler(this.InventoryGrid_Click);
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator3);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblItemValue_Grid);
            this.pnlGridHeader.Controls.Add(this.lblCurrentStock_Grid);
            this.pnlGridHeader.Controls.Add(this.lblStockValue_Grid);
            this.pnlGridHeader.Controls.Add(this.lblProduct_Grid);
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator8);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(10, 166);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridHeader.Size = new System.Drawing.Size(794, 48);
            this.pnlGridHeader.TabIndex = 122;
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(581, 6);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator3.TabIndex = 177;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = true;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(449, 6);
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
            this.GridTitle_Separator1.Location = new System.Drawing.Point(245, 10);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            // 
            // lblItemValue_Grid
            // 
            this.lblItemValue_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItemValue_Grid.AutoSize = true;
            this.lblItemValue_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblItemValue_Grid.Location = new System.Drawing.Point(600, 7);
            this.lblItemValue_Grid.Name = "lblItemValue_Grid";
            this.lblItemValue_Grid.Size = new System.Drawing.Size(98, 28);
            this.lblItemValue_Grid.TabIndex = 172;
            this.lblItemValue_Grid.Text = "Item Value";
            // 
            // lblCurrentStock_Grid
            // 
            this.lblCurrentStock_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurrentStock_Grid.AutoSize = true;
            this.lblCurrentStock_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCurrentStock_Grid.Location = new System.Drawing.Point(256, 7);
            this.lblCurrentStock_Grid.Name = "lblCurrentStock_Grid";
            this.lblCurrentStock_Grid.Size = new System.Drawing.Size(119, 28);
            this.lblCurrentStock_Grid.TabIndex = 171;
            this.lblCurrentStock_Grid.Text = "Current Stock";
            // 
            // lblStockValue_Grid
            // 
            this.lblStockValue_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStockValue_Grid.AutoSize = true;
            this.lblStockValue_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStockValue_Grid.Location = new System.Drawing.Point(460, 6);
            this.lblStockValue_Grid.Name = "lblStockValue_Grid";
            this.lblStockValue_Grid.Size = new System.Drawing.Size(105, 28);
            this.lblStockValue_Grid.TabIndex = 170;
            this.lblStockValue_Grid.Text = "Stock Value";
            // 
            // lblProduct_Grid
            // 
            this.lblProduct_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProduct_Grid.AutoSize = true;
            this.lblProduct_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProduct_Grid.Location = new System.Drawing.Point(5, 7);
            this.lblProduct_Grid.Name = "lblProduct_Grid";
            this.lblProduct_Grid.Size = new System.Drawing.Size(74, 28);
            this.lblProduct_Grid.TabIndex = 169;
            this.lblProduct_Grid.Text = "Product";
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
            // cardCurrentStock
            // 
            this.cardCurrentStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCurrentStock.BackColor = System.Drawing.Color.White;
            this.cardCurrentStock.BorderRadius = 10;
            this.cardCurrentStock.BottomSahddow = true;
            this.cardCurrentStock.color = System.Drawing.Color.Transparent;
            this.cardCurrentStock.Controls.Add(this.lblCurrentStock);
            this.cardCurrentStock.Controls.Add(this.text_CurrentStock);
            this.cardCurrentStock.Controls.Add(this.imgpnl_CurrentStock);
            this.cardCurrentStock.LeftSahddow = false;
            this.cardCurrentStock.Location = new System.Drawing.Point(814, 199);
            this.cardCurrentStock.Name = "cardCurrentStock";
            this.cardCurrentStock.RightSahddow = true;
            this.cardCurrentStock.ShadowDepth = 10;
            this.cardCurrentStock.Size = new System.Drawing.Size(304, 102);
            this.cardCurrentStock.TabIndex = 130;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentStock.Location = new System.Drawing.Point(175, 38);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(37, 48);
            this.lblCurrentStock.TabIndex = 2;
            this.lblCurrentStock.Text = "0";
            // 
            // text_CurrentStock
            // 
            this.text_CurrentStock.AutoSize = true;
            this.text_CurrentStock.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_CurrentStock.Location = new System.Drawing.Point(144, 10);
            this.text_CurrentStock.Name = "text_CurrentStock";
            this.text_CurrentStock.Size = new System.Drawing.Size(119, 28);
            this.text_CurrentStock.TabIndex = 1;
            this.text_CurrentStock.Text = "Current Stock";
            // 
            // imgpnl_CurrentStock
            // 
            this.imgpnl_CurrentStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.imgpnl_CurrentStock.Controls.Add(this.imgbtnCurrentStock);
            this.imgpnl_CurrentStock.Location = new System.Drawing.Point(23, 18);
            this.imgpnl_CurrentStock.Name = "imgpnl_CurrentStock";
            this.imgpnl_CurrentStock.Size = new System.Drawing.Size(49, 47);
            this.imgpnl_CurrentStock.TabIndex = 8;
            // 
            // imgbtnCurrentStock
            // 
            this.imgbtnCurrentStock.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCurrentStock.Image = ((System.Drawing.Image)(resources.GetObject("imgbtnCurrentStock.Image")));
            this.imgbtnCurrentStock.ImageActive = null;
            this.imgbtnCurrentStock.Location = new System.Drawing.Point(7, 6);
            this.imgbtnCurrentStock.Name = "imgbtnCurrentStock";
            this.imgbtnCurrentStock.Size = new System.Drawing.Size(35, 35);
            this.imgbtnCurrentStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCurrentStock.TabIndex = 3;
            this.imgbtnCurrentStock.TabStop = false;
            this.imgbtnCurrentStock.Zoom = 10;
            // 
            // cardStockValue
            // 
            this.cardStockValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStockValue.BackColor = System.Drawing.Color.White;
            this.cardStockValue.BorderRadius = 10;
            this.cardStockValue.BottomSahddow = true;
            this.cardStockValue.color = System.Drawing.Color.Transparent;
            this.cardStockValue.Controls.Add(this.lblStockValue);
            this.cardStockValue.Controls.Add(this.text_StockValue);
            this.cardStockValue.Controls.Add(this.imgpnl_StockValue);
            this.cardStockValue.LeftSahddow = false;
            this.cardStockValue.Location = new System.Drawing.Point(813, 320);
            this.cardStockValue.Name = "cardStockValue";
            this.cardStockValue.RightSahddow = true;
            this.cardStockValue.ShadowDepth = 10;
            this.cardStockValue.Size = new System.Drawing.Size(304, 102);
            this.cardStockValue.TabIndex = 131;
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStockValue.Location = new System.Drawing.Point(133, 39);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(123, 48);
            this.lblStockValue.TabIndex = 2;
            this.lblStockValue.Text = "€ 00.00";
            // 
            // text_StockValue
            // 
            this.text_StockValue.AutoSize = true;
            this.text_StockValue.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_StockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_StockValue.Location = new System.Drawing.Point(152, 11);
            this.text_StockValue.Name = "text_StockValue";
            this.text_StockValue.Size = new System.Drawing.Size(105, 28);
            this.text_StockValue.TabIndex = 1;
            this.text_StockValue.Text = "Stock Value";
            // 
            // imgpnl_StockValue
            // 
            this.imgpnl_StockValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnl_StockValue.Controls.Add(this.imgbtnStockValue);
            this.imgpnl_StockValue.Location = new System.Drawing.Point(23, 18);
            this.imgpnl_StockValue.Name = "imgpnl_StockValue";
            this.imgpnl_StockValue.Size = new System.Drawing.Size(49, 47);
            this.imgpnl_StockValue.TabIndex = 8;
            // 
            // imgbtnStockValue
            // 
            this.imgbtnStockValue.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnStockValue.Image = global::Vendstor.Properties.Resources.value_f_w;
            this.imgbtnStockValue.ImageActive = null;
            this.imgbtnStockValue.Location = new System.Drawing.Point(7, 6);
            this.imgbtnStockValue.Name = "imgbtnStockValue";
            this.imgbtnStockValue.Size = new System.Drawing.Size(35, 35);
            this.imgbtnStockValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnStockValue.TabIndex = 3;
            this.imgbtnStockValue.TabStop = false;
            this.imgbtnStockValue.Zoom = 10;
            // 
            // cardItemValue
            // 
            this.cardItemValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardItemValue.BackColor = System.Drawing.Color.White;
            this.cardItemValue.BorderRadius = 10;
            this.cardItemValue.BottomSahddow = true;
            this.cardItemValue.color = System.Drawing.Color.Transparent;
            this.cardItemValue.Controls.Add(this.lblItemValue);
            this.cardItemValue.Controls.Add(this.text_ItemValue);
            this.cardItemValue.Controls.Add(this.imgpnl_ItemValue);
            this.cardItemValue.LeftSahddow = false;
            this.cardItemValue.Location = new System.Drawing.Point(813, 441);
            this.cardItemValue.Name = "cardItemValue";
            this.cardItemValue.RightSahddow = true;
            this.cardItemValue.ShadowDepth = 10;
            this.cardItemValue.Size = new System.Drawing.Size(304, 102);
            this.cardItemValue.TabIndex = 132;
            // 
            // lblItemValue
            // 
            this.lblItemValue.AutoSize = true;
            this.lblItemValue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblItemValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemValue.Location = new System.Drawing.Point(133, 43);
            this.lblItemValue.Name = "lblItemValue";
            this.lblItemValue.Size = new System.Drawing.Size(123, 48);
            this.lblItemValue.TabIndex = 2;
            this.lblItemValue.Text = "€ 00.00";
            // 
            // text_ItemValue
            // 
            this.text_ItemValue.AutoSize = true;
            this.text_ItemValue.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ItemValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_ItemValue.Location = new System.Drawing.Point(152, 15);
            this.text_ItemValue.Name = "text_ItemValue";
            this.text_ItemValue.Size = new System.Drawing.Size(98, 28);
            this.text_ItemValue.TabIndex = 1;
            this.text_ItemValue.Text = "Item Value";
            // 
            // imgpnl_ItemValue
            // 
            this.imgpnl_ItemValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnl_ItemValue.Controls.Add(this.imgbtnItemValue);
            this.imgpnl_ItemValue.Location = new System.Drawing.Point(23, 18);
            this.imgpnl_ItemValue.Name = "imgpnl_ItemValue";
            this.imgpnl_ItemValue.Size = new System.Drawing.Size(49, 47);
            this.imgpnl_ItemValue.TabIndex = 8;
            // 
            // imgbtnItemValue
            // 
            this.imgbtnItemValue.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnItemValue.Image = global::Vendstor.Properties.Resources.money_d_w;
            this.imgbtnItemValue.ImageActive = null;
            this.imgbtnItemValue.Location = new System.Drawing.Point(7, 6);
            this.imgbtnItemValue.Name = "imgbtnItemValue";
            this.imgbtnItemValue.Size = new System.Drawing.Size(35, 35);
            this.imgbtnItemValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnItemValue.TabIndex = 3;
            this.imgbtnItemValue.TabStop = false;
            this.imgbtnItemValue.Zoom = 10;
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
            this.cardEmptyData.Location = new System.Drawing.Point(176, 282);
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.cardItemValue);
            this.Controls.Add(this.cardStockValue);
            this.Controls.Add(this.cardCurrentStock);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlFilter);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.cardCurrentStock.ResumeLayout(false);
            this.cardCurrentStock.PerformLayout();
            this.imgpnl_CurrentStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCurrentStock)).EndInit();
            this.cardStockValue.ResumeLayout(false);
            this.cardStockValue.PerformLayout();
            this.imgpnl_StockValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnStockValue)).EndInit();
            this.cardItemValue.ResumeLayout(false);
            this.cardItemValue.PerformLayout();
            this.imgpnl_ItemValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnItemValue)).EndInit();
            this.cardEmptyData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorNoData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateTo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateFrom;
        private System.Windows.Forms.Label text_DateTo;
        private System.Windows.Forms.Label text_From;
        private Bunifu.Framework.UI.BunifuDropdown dpdStock;
        private System.Windows.Forms.Label text_Status;
        private System.Windows.Forms.FlowLayoutPanel InventoryGrid;
        private System.Windows.Forms.Panel pnlGridHeader;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblItemValue_Grid;
        private System.Windows.Forms.Label lblCurrentStock_Grid;
        private System.Windows.Forms.Label lblStockValue_Grid;
        private System.Windows.Forms.Label lblProduct_Grid;
        private Bunifu.Framework.UI.BunifuCards cardCurrentStock;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label text_CurrentStock;
        private System.Windows.Forms.Panel imgpnl_CurrentStock;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCurrentStock;
        private Bunifu.Framework.UI.BunifuCards cardStockValue;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label text_StockValue;
        private System.Windows.Forms.Panel imgpnl_StockValue;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnStockValue;
        private Bunifu.Framework.UI.BunifuCards cardItemValue;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Label text_ItemValue;
        private System.Windows.Forms.Panel imgpnl_ItemValue;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnItemValue;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label text_SearchHint;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchQueryType;
        private System.Windows.Forms.Panel pnlCoverDropDowns;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgVectorNoData;
        private Bunifu.Framework.UI.BunifuSeparator seperatorCard;
        private System.Windows.Forms.Label lblNothing_Card;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrevious;
    }
}
