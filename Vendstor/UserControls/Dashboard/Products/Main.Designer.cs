namespace Vendstor.UserControls.Dashboard.Products
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.switchQueryType = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.pnlCoverDropDowns = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dpdStatus = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtTags = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpdTypes = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_ProductType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpdSuppliers = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Hint = new System.Windows.Forms.Label();
            this.txtFilter = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_ReportType = new System.Windows.Forms.Label();
            this.dpdBrands = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.GridTitle_Separator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPrice_Grid = new System.Windows.Forms.Label();
            this.lblCount_Grid = new System.Windows.Forms.Label();
            this.lblSupplier_Grid = new System.Windows.Forms.Label();
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblBrand_Grid = new System.Windows.Forms.Label();
            this.lblDateCreated_Grid = new System.Windows.Forms.Label();
            this.lblTags_Grid = new System.Windows.Forms.Label();
            this.lblProduct_Grid = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ProductsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorry_Alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNoResults_Alert = new System.Windows.Forms.Label();
            this.lblSorry_Alert = new System.Windows.Forms.Label();
            this.btnAddProduct_Alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlFilter.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.switchQueryType);
            this.pnlFilter.Controls.Add(this.pnlCoverDropDowns);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnAddProduct);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.dpdStatus);
            this.pnlFilter.Controls.Add(this.txtTags);
            this.pnlFilter.Controls.Add(this.dpdTypes);
            this.pnlFilter.Controls.Add(this.text_ProductType);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.dpdSuppliers);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.text_Hint);
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.text_ReportType);
            this.pnlFilter.Controls.Add(this.dpdBrands);
            this.pnlFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1112, 166);
            this.pnlFilter.TabIndex = 121;
            // 
            // switchQueryType
            // 
            this.switchQueryType.BackColor = System.Drawing.Color.Transparent;
            this.switchQueryType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchQueryType.BackgroundImage")));
            this.switchQueryType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchQueryType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchQueryType.Location = new System.Drawing.Point(638, 53);
            this.switchQueryType.Name = "switchQueryType";
            this.switchQueryType.OffColor = System.Drawing.Color.Tomato;
            this.switchQueryType.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchQueryType.Size = new System.Drawing.Size(35, 20);
            this.switchQueryType.TabIndex = 135;
            this.switchQueryType.Value = true;
            this.switchQueryType.OnValueChange += new System.EventHandler(this.SwitchQueryType_OnValueChange);
            this.switchQueryType.Click += new System.EventHandler(this.SwitchQueryType_Click);
            // 
            // pnlCoverDropDowns
            // 
            this.pnlCoverDropDowns.Location = new System.Drawing.Point(20, 89);
            this.pnlCoverDropDowns.Name = "pnlCoverDropDowns";
            this.pnlCoverDropDowns.Size = new System.Drawing.Size(904, 66);
            this.pnlCoverDropDowns.TabIndex = 134;
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
            this.btnFilter.Location = new System.Drawing.Point(965, 114);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(126, 40);
            this.btnFilter.TabIndex = 133;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
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
            this.btnAddProduct.Location = new System.Drawing.Point(920, 10);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(171, 40);
            this.btnAddProduct.TabIndex = 132;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label5.Location = new System.Drawing.Point(470, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 131;
            this.label5.Text = "Status";
            // 
            // dpdStatus
            // 
            this.dpdStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStatus.BorderRadius = 3;
            this.dpdStatus.DisabledColor = System.Drawing.Color.Gray;
            this.dpdStatus.ForeColor = System.Drawing.Color.DimGray;
            this.dpdStatus.Items = new string[] {
        "(none)"};
            this.dpdStatus.Location = new System.Drawing.Point(475, 121);
            this.dpdStatus.Margin = new System.Windows.Forms.Padding(4);
            this.dpdStatus.Name = "dpdStatus";
            this.dpdStatus.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStatus.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdStatus.selectedIndex = 0;
            this.dpdStatus.Size = new System.Drawing.Size(208, 34);
            this.dpdStatus.TabIndex = 130;
            // 
            // txtTags
            // 
            this.txtTags.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTags.AutoScroll = true;
            this.txtTags.AutoSize = true;
            this.txtTags.BackColor = System.Drawing.Color.White;
            this.txtTags.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTags.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtTags.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTags.BorderThickness = 2;
            this.txtTags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTags.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.txtTags.ForeColor = System.Drawing.Color.DimGray;
            this.txtTags.isPassword = false;
            this.txtTags.Location = new System.Drawing.Point(820, 4);
            this.txtTags.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(93, 33);
            this.txtTags.TabIndex = 129;
            this.txtTags.Text = "Enter tags";
            this.txtTags.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTags.Visible = false;
            // 
            // dpdTypes
            // 
            this.dpdTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdTypes.BorderRadius = 3;
            this.dpdTypes.DisabledColor = System.Drawing.Color.Gray;
            this.dpdTypes.ForeColor = System.Drawing.Color.DimGray;
            this.dpdTypes.Items = new string[] {
        "(none)"};
            this.dpdTypes.Location = new System.Drawing.Point(705, 120);
            this.dpdTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dpdTypes.Name = "dpdTypes";
            this.dpdTypes.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdTypes.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdTypes.selectedIndex = 0;
            this.dpdTypes.Size = new System.Drawing.Size(208, 34);
            this.dpdTypes.TabIndex = 128;
            // 
            // text_ProductType
            // 
            this.text_ProductType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_ProductType.AutoSize = true;
            this.text_ProductType.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_ProductType.Location = new System.Drawing.Point(703, 90);
            this.text_ProductType.Name = "text_ProductType";
            this.text_ProductType.Size = new System.Drawing.Size(107, 26);
            this.text_ProductType.TabIndex = 127;
            this.text_ProductType.Text = "Product Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label3.Location = new System.Drawing.Point(765, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 125;
            this.label3.Text = "Tags";
            this.label3.Visible = false;
            // 
            // dpdSuppliers
            // 
            this.dpdSuppliers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdSuppliers.BorderRadius = 3;
            this.dpdSuppliers.DisabledColor = System.Drawing.Color.Gray;
            this.dpdSuppliers.ForeColor = System.Drawing.Color.DimGray;
            this.dpdSuppliers.Items = new string[] {
        "(none)"};
            this.dpdSuppliers.Location = new System.Drawing.Point(249, 121);
            this.dpdSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.dpdSuppliers.Name = "dpdSuppliers";
            this.dpdSuppliers.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdSuppliers.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdSuppliers.selectedIndex = 0;
            this.dpdSuppliers.Size = new System.Drawing.Size(208, 34);
            this.dpdSuppliers.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.label2.Location = new System.Drawing.Point(244, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 123;
            this.label2.Text = "Supplier";
            // 
            // text_Hint
            // 
            this.text_Hint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Hint.AutoSize = true;
            this.text_Hint.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Hint.Location = new System.Drawing.Point(23, 10);
            this.text_Hint.Name = "text_Hint";
            this.text_Hint.Size = new System.Drawing.Size(396, 26);
            this.text_Hint.TabIndex = 122;
            this.text_Hint.Text = "Search Products by Name, SKU, Token, Supplier Code";
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
            this.txtFilter.Location = new System.Drawing.Point(21, 40);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(572, 43);
            this.txtFilter.TabIndex = 119;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_ReportType
            // 
            this.text_ReportType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_ReportType.AutoSize = true;
            this.text_ReportType.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_ReportType.Location = new System.Drawing.Point(23, 91);
            this.text_ReportType.Name = "text_ReportType";
            this.text_ReportType.Size = new System.Drawing.Size(55, 26);
            this.text_ReportType.TabIndex = 115;
            this.text_ReportType.Text = "Brand";
            // 
            // dpdBrands
            // 
            this.dpdBrands.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdBrands.BorderRadius = 3;
            this.dpdBrands.DisabledColor = System.Drawing.Color.Gray;
            this.dpdBrands.ForeColor = System.Drawing.Color.DimGray;
            this.dpdBrands.Items = new string[] {
        "(none)"};
            this.dpdBrands.Location = new System.Drawing.Point(19, 121);
            this.dpdBrands.Margin = new System.Windows.Forms.Padding(4);
            this.dpdBrands.Name = "dpdBrands";
            this.dpdBrands.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdBrands.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdBrands.selectedIndex = 0;
            this.dpdBrands.Size = new System.Drawing.Size(208, 34);
            this.dpdBrands.TabIndex = 120;
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator6);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator7);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator5);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator4);
            this.pnlGridHeader.Controls.Add(this.lblPrice_Grid);
            this.pnlGridHeader.Controls.Add(this.lblCount_Grid);
            this.pnlGridHeader.Controls.Add(this.lblSupplier_Grid);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator3);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblBrand_Grid);
            this.pnlGridHeader.Controls.Add(this.lblDateCreated_Grid);
            this.pnlGridHeader.Controls.Add(this.lblTags_Grid);
            this.pnlGridHeader.Controls.Add(this.lblProduct_Grid);
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator8);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(5, 175);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridHeader.Size = new System.Drawing.Size(1110, 48);
            this.pnlGridHeader.TabIndex = 123;
            // 
            // GridTitle_Separator6
            // 
            this.GridTitle_Separator6.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator6.LineThickness = 1;
            this.GridTitle_Separator6.Location = new System.Drawing.Point(956, 10);
            this.GridTitle_Separator6.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator6.Name = "GridTitle_Separator6";
            this.GridTitle_Separator6.Size = new System.Drawing.Size(10, 28);
            this.GridTitle_Separator6.TabIndex = 185;
            this.GridTitle_Separator6.Transparency = 255;
            this.GridTitle_Separator6.Vertical = true;
            // 
            // GridTitle_Separator7
            // 
            this.GridTitle_Separator7.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator7.LineThickness = 1;
            this.GridTitle_Separator7.Location = new System.Drawing.Point(1030, 10);
            this.GridTitle_Separator7.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator7.Name = "GridTitle_Separator7";
            this.GridTitle_Separator7.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator7.TabIndex = 184;
            this.GridTitle_Separator7.Transparency = 255;
            this.GridTitle_Separator7.Vertical = true;
            // 
            // GridTitle_Separator5
            // 
            this.GridTitle_Separator5.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator5.LineThickness = 1;
            this.GridTitle_Separator5.Location = new System.Drawing.Point(874, 10);
            this.GridTitle_Separator5.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator5.Name = "GridTitle_Separator5";
            this.GridTitle_Separator5.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator5.TabIndex = 183;
            this.GridTitle_Separator5.Transparency = 255;
            this.GridTitle_Separator5.Vertical = true;
            // 
            // GridTitle_Separator4
            // 
            this.GridTitle_Separator4.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator4.LineThickness = 1;
            this.GridTitle_Separator4.Location = new System.Drawing.Point(703, 10);
            this.GridTitle_Separator4.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator4.Name = "GridTitle_Separator4";
            this.GridTitle_Separator4.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator4.TabIndex = 182;
            this.GridTitle_Separator4.Transparency = 255;
            this.GridTitle_Separator4.Vertical = true;
            // 
            // lblPrice_Grid
            // 
            this.lblPrice_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice_Grid.AutoSize = true;
            this.lblPrice_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblPrice_Grid.Location = new System.Drawing.Point(895, 12);
            this.lblPrice_Grid.Name = "lblPrice_Grid";
            this.lblPrice_Grid.Size = new System.Drawing.Size(51, 28);
            this.lblPrice_Grid.TabIndex = 179;
            this.lblPrice_Grid.Text = "Price";
            // 
            // lblCount_Grid
            // 
            this.lblCount_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCount_Grid.AutoSize = true;
            this.lblCount_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCount_Grid.Location = new System.Drawing.Point(971, 11);
            this.lblCount_Grid.Name = "lblCount_Grid";
            this.lblCount_Grid.Size = new System.Drawing.Size(60, 28);
            this.lblCount_Grid.TabIndex = 180;
            this.lblCount_Grid.Text = "Count";
            // 
            // lblSupplier_Grid
            // 
            this.lblSupplier_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplier_Grid.AutoSize = true;
            this.lblSupplier_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblSupplier_Grid.Location = new System.Drawing.Point(731, 11);
            this.lblSupplier_Grid.Name = "lblSupplier_Grid";
            this.lblSupplier_Grid.Size = new System.Drawing.Size(77, 28);
            this.lblSupplier_Grid.TabIndex = 178;
            this.lblSupplier_Grid.Text = "Supplier";
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(585, 10);
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
            this.GridTitle_Separator2.Location = new System.Drawing.Point(469, 10);
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
            this.GridTitle_Separator1.Location = new System.Drawing.Point(341, 10);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            // 
            // lblBrand_Grid
            // 
            this.lblBrand_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrand_Grid.AutoSize = true;
            this.lblBrand_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblBrand_Grid.Location = new System.Drawing.Point(606, 11);
            this.lblBrand_Grid.Name = "lblBrand_Grid";
            this.lblBrand_Grid.Size = new System.Drawing.Size(60, 28);
            this.lblBrand_Grid.TabIndex = 172;
            this.lblBrand_Grid.Text = "Brand";
            // 
            // lblDateCreated_Grid
            // 
            this.lblDateCreated_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateCreated_Grid.AutoSize = true;
            this.lblDateCreated_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblDateCreated_Grid.Location = new System.Drawing.Point(361, 11);
            this.lblDateCreated_Grid.Name = "lblDateCreated_Grid";
            this.lblDateCreated_Grid.Size = new System.Drawing.Size(78, 28);
            this.lblDateCreated_Grid.TabIndex = 171;
            this.lblDateCreated_Grid.Text = "Created";
            // 
            // lblTags_Grid
            // 
            this.lblTags_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTags_Grid.AutoSize = true;
            this.lblTags_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblTags_Grid.Location = new System.Drawing.Point(490, 11);
            this.lblTags_Grid.Name = "lblTags_Grid";
            this.lblTags_Grid.Size = new System.Drawing.Size(51, 28);
            this.lblTags_Grid.TabIndex = 170;
            this.lblTags_Grid.Text = "Tags";
            // 
            // lblProduct_Grid
            // 
            this.lblProduct_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProduct_Grid.AutoSize = true;
            this.lblProduct_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProduct_Grid.Location = new System.Drawing.Point(33, 12);
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
            // ProductsGrid
            // 
            this.ProductsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductsGrid.AutoScroll = true;
            this.ProductsGrid.BackColor = System.Drawing.Color.White;
            this.ProductsGrid.Location = new System.Drawing.Point(5, 228);
            this.ProductsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(1110, 356);
            this.ProductsGrid.TabIndex = 124;
            this.ProductsGrid.DoubleClick += new System.EventHandler(this.ProductsGrid_DoubleClick);
            // 
            // cardEmptyData
            // 
            this.cardEmptyData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardEmptyData.BackColor = System.Drawing.Color.White;
            this.cardEmptyData.BorderRadius = 5;
            this.cardEmptyData.BottomSahddow = true;
            this.cardEmptyData.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardEmptyData.Controls.Add(this.imgSorry_Alert);
            this.cardEmptyData.Controls.Add(this.seperator_Alert);
            this.cardEmptyData.Controls.Add(this.lblNoResults_Alert);
            this.cardEmptyData.Controls.Add(this.lblSorry_Alert);
            this.cardEmptyData.Controls.Add(this.btnAddProduct_Alert);
            this.cardEmptyData.LeftSahddow = false;
            this.cardEmptyData.Location = new System.Drawing.Point(339, 229);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(451, 286);
            this.cardEmptyData.TabIndex = 137;
            this.cardEmptyData.Visible = false;
            // 
            // imgSorry_Alert
            // 
            this.imgSorry_Alert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorry_Alert.Image = global::Vendstor.Properties.Resources.vector_sorrygirl;
            this.imgSorry_Alert.ImageActive = null;
            this.imgSorry_Alert.Location = new System.Drawing.Point(166, 25);
            this.imgSorry_Alert.Name = "imgSorry_Alert";
            this.imgSorry_Alert.Size = new System.Drawing.Size(118, 91);
            this.imgSorry_Alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSorry_Alert.TabIndex = 182;
            this.imgSorry_Alert.TabStop = false;
            this.imgSorry_Alert.Zoom = 10;
            // 
            // seperator_Alert
            // 
            this.seperator_Alert.BackColor = System.Drawing.Color.Transparent;
            this.seperator_Alert.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperator_Alert.LineThickness = 1;
            this.seperator_Alert.Location = new System.Drawing.Point(192, 180);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 181;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lblNoResults_Alert
            // 
            this.lblNoResults_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoResults_Alert.AutoSize = true;
            this.lblNoResults_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblNoResults_Alert.Location = new System.Drawing.Point(105, 157);
            this.lblNoResults_Alert.Name = "lblNoResults_Alert";
            this.lblNoResults_Alert.Size = new System.Drawing.Size(241, 26);
            this.lblNoResults_Alert.TabIndex = 180;
            this.lblNoResults_Alert.Text = "You haven\'t added any product";
            // 
            // lblSorry_Alert
            // 
            this.lblSorry_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSorry_Alert.AutoSize = true;
            this.lblSorry_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSorry_Alert.Location = new System.Drawing.Point(178, 123);
            this.lblSorry_Alert.Name = "lblSorry_Alert";
            this.lblSorry_Alert.Size = new System.Drawing.Size(94, 26);
            this.lblSorry_Alert.TabIndex = 179;
            this.lblSorry_Alert.Text = "We\'re sorry,";
            // 
            // btnAddProduct_Alert
            // 
            this.btnAddProduct_Alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddProduct_Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct_Alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct_Alert.BorderRadius = 5;
            this.btnAddProduct_Alert.ButtonText = "Add Product";
            this.btnAddProduct_Alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct_Alert.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct_Alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct_Alert.Iconimage = global::Vendstor.Properties.Resources.products_filled_w;
            this.btnAddProduct_Alert.Iconimage_right = null;
            this.btnAddProduct_Alert.Iconimage_right_Selected = null;
            this.btnAddProduct_Alert.Iconimage_Selected = null;
            this.btnAddProduct_Alert.IconMarginLeft = 0;
            this.btnAddProduct_Alert.IconMarginRight = 0;
            this.btnAddProduct_Alert.IconRightVisible = true;
            this.btnAddProduct_Alert.IconRightZoom = 0D;
            this.btnAddProduct_Alert.IconVisible = true;
            this.btnAddProduct_Alert.IconZoom = 45D;
            this.btnAddProduct_Alert.IsTab = false;
            this.btnAddProduct_Alert.Location = new System.Drawing.Point(139, 218);
            this.btnAddProduct_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct_Alert.Name = "btnAddProduct_Alert";
            this.btnAddProduct_Alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct_Alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduct_Alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct_Alert.selected = false;
            this.btnAddProduct_Alert.Size = new System.Drawing.Size(173, 40);
            this.btnAddProduct_Alert.TabIndex = 172;
            this.btnAddProduct_Alert.Text = "Add Product";
            this.btnAddProduct_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct_Alert.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct_Alert.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddProduct_Alert.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlFilter);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.cardEmptyData.ResumeLayout(false);
            this.cardEmptyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilter;
        private Bunifu.Framework.UI.BunifuDropdown dpdBrands;
        private System.Windows.Forms.Label text_ReportType;
        private Bunifu.Framework.UI.BunifuDropdown dpdSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_Hint;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTags;
        private Bunifu.Framework.UI.BunifuDropdown dpdTypes;
        private System.Windows.Forms.Label text_ProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown dpdStatus;
        private System.Windows.Forms.Panel pnlGridHeader;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblBrand_Grid;
        private System.Windows.Forms.Label lblDateCreated_Grid;
        private System.Windows.Forms.Label lblTags_Grid;
        private System.Windows.Forms.Label lblProduct_Grid;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private System.Windows.Forms.FlowLayoutPanel ProductsGrid;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator6;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator7;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator5;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator4;
        private System.Windows.Forms.Label lblPrice_Grid;
        private System.Windows.Forms.Label lblSupplier_Grid;
        private System.Windows.Forms.Label lblCount_Grid;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgSorry_Alert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lblNoResults_Alert;
        private System.Windows.Forms.Label lblSorry_Alert;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct_Alert;
        private System.Windows.Forms.Panel pnlCoverDropDowns;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchQueryType;
    }
}
