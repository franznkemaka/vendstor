namespace Vendstor.UserControls.Dashboard
{
    partial class Customers
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
            this.CustomersGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.dpdCustomerGroup = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_CustomerGroup = new System.Windows.Forms.Label();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFilter = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_SearchHint = new System.Windows.Forms.Label();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblAccount_Grid = new System.Windows.Forms.Label();
            this.lblLocation_Grid = new System.Windows.Forms.Label();
            this.lblStoreCredit_Grid = new System.Windows.Forms.Label();
            this.lblCustomers_Grid = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGroups = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.text_Customers = new System.Windows.Forms.Label();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorryAlert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNoCustomers_Alert = new System.Windows.Forms.Label();
            this.lblSorry_Alert = new System.Windows.Forms.Label();
            this.btnAddCustomer_Alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlFilter.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorryAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomersGrid.AutoScroll = true;
            this.CustomersGrid.BackColor = System.Drawing.Color.White;
            this.CustomersGrid.Location = new System.Drawing.Point(8, 261);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(1106, 391);
            this.CustomersGrid.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.dpdCustomerGroup);
            this.pnlFilter.Controls.Add(this.text_CustomerGroup);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.text_SearchHint);
            this.pnlFilter.Location = new System.Drawing.Point(8, 99);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1106, 96);
            this.pnlFilter.TabIndex = 3;
            // 
            // dpdCustomerGroup
            // 
            this.dpdCustomerGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdCustomerGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCustomerGroup.BorderRadius = 3;
            this.dpdCustomerGroup.DisabledColor = System.Drawing.Color.Gray;
            this.dpdCustomerGroup.ForeColor = System.Drawing.Color.DimGray;
            this.dpdCustomerGroup.Items = new string[] {
        "(none)"};
            this.dpdCustomerGroup.Location = new System.Drawing.Point(708, 46);
            this.dpdCustomerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.dpdCustomerGroup.Name = "dpdCustomerGroup";
            this.dpdCustomerGroup.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCustomerGroup.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCustomerGroup.selectedIndex = 0;
            this.dpdCustomerGroup.Size = new System.Drawing.Size(208, 34);
            this.dpdCustomerGroup.TabIndex = 3;
            this.dpdCustomerGroup.onItemSelected += new System.EventHandler(this.DpdCustomerGroup_onItemSelected);
            // 
            // text_CustomerGroup
            // 
            this.text_CustomerGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_CustomerGroup.AutoSize = true;
            this.text_CustomerGroup.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_CustomerGroup.Location = new System.Drawing.Point(712, 17);
            this.text_CustomerGroup.Name = "text_CustomerGroup";
            this.text_CustomerGroup.Size = new System.Drawing.Size(135, 26);
            this.text_CustomerGroup.TabIndex = 2;
            this.text_CustomerGroup.Text = "Customer Group";
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
            this.btnFilter.Location = new System.Drawing.Point(929, 28);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(155, 40);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.AutoScroll = true;
            this.txtFilter.AutoSize = true;
            this.txtFilter.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFilter.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtFilter.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFilter.BorderThickness = 2;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.txtFilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilter.isPassword = false;
            this.txtFilter.Location = new System.Drawing.Point(12, 42);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(531, 38);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_SearchHint
            // 
            this.text_SearchHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_SearchHint.AutoSize = true;
            this.text_SearchHint.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_SearchHint.Location = new System.Drawing.Point(7, 13);
            this.text_SearchHint.Name = "text_SearchHint";
            this.text_SearchHint.Size = new System.Drawing.Size(420, 26);
            this.text_SearchHint.TabIndex = 0;
            this.text_SearchHint.Text = "Search Customers by Name, Customer Token, or Details";
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator3);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblAccount_Grid);
            this.pnlGridHeader.Controls.Add(this.lblLocation_Grid);
            this.pnlGridHeader.Controls.Add(this.lblStoreCredit_Grid);
            this.pnlGridHeader.Controls.Add(this.lblCustomers_Grid);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(8, 201);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(1106, 54);
            this.pnlGridHeader.TabIndex = 4;
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(940, 8);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator3.TabIndex = 5;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = true;
            this.GridTitle_Separator3.Visible = false;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(695, 6);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator2.TabIndex = 3;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            this.GridTitle_Separator2.Visible = false;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(414, 6);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator1.TabIndex = 1;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // lblAccount_Grid
            // 
            this.lblAccount_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccount_Grid.AutoSize = true;
            this.lblAccount_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblAccount_Grid.Location = new System.Drawing.Point(961, 13);
            this.lblAccount_Grid.Name = "lblAccount_Grid";
            this.lblAccount_Grid.Size = new System.Drawing.Size(79, 28);
            this.lblAccount_Grid.TabIndex = 6;
            this.lblAccount_Grid.Text = "Account";
            // 
            // lblLocation_Grid
            // 
            this.lblLocation_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocation_Grid.AutoSize = true;
            this.lblLocation_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblLocation_Grid.Location = new System.Drawing.Point(440, 12);
            this.lblLocation_Grid.Name = "lblLocation_Grid";
            this.lblLocation_Grid.Size = new System.Drawing.Size(80, 28);
            this.lblLocation_Grid.TabIndex = 2;
            this.lblLocation_Grid.Text = "Location";
            // 
            // lblStoreCredit_Grid
            // 
            this.lblStoreCredit_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCredit_Grid.AutoSize = true;
            this.lblStoreCredit_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStoreCredit_Grid.Location = new System.Drawing.Point(728, 13);
            this.lblStoreCredit_Grid.Name = "lblStoreCredit_Grid";
            this.lblStoreCredit_Grid.Size = new System.Drawing.Size(106, 28);
            this.lblStoreCredit_Grid.TabIndex = 4;
            this.lblStoreCredit_Grid.Text = "Store Credit";
            // 
            // lblCustomers_Grid
            // 
            this.lblCustomers_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomers_Grid.AutoSize = true;
            this.lblCustomers_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCustomers_Grid.Location = new System.Drawing.Point(7, 12);
            this.lblCustomers_Grid.Name = "lblCustomers_Grid";
            this.lblCustomers_Grid.Size = new System.Drawing.Size(90, 28);
            this.lblCustomers_Grid.TabIndex = 0;
            this.lblCustomers_Grid.Text = "Customer";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.Controls.Add(this.btnAddCustomer);
            this.pnlHeader.Controls.Add(this.btnGroups);
            this.pnlHeader.Controls.Add(this.lblDescription);
            this.pnlHeader.Controls.Add(this.text_Customers);
            this.pnlHeader.Location = new System.Drawing.Point(8, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1106, 87);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer.BorderRadius = 5;
            this.btnAddCustomer.ButtonText = "Add Customer";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Iconimage = global::Vendstor.Properties.Resources.users_dashboard_w;
            this.btnAddCustomer.Iconimage_right = null;
            this.btnAddCustomer.Iconimage_right_Selected = null;
            this.btnAddCustomer.Iconimage_Selected = null;
            this.btnAddCustomer.IconMarginLeft = 0;
            this.btnAddCustomer.IconMarginRight = 0;
            this.btnAddCustomer.IconRightVisible = true;
            this.btnAddCustomer.IconRightZoom = 0D;
            this.btnAddCustomer.IconVisible = true;
            this.btnAddCustomer.IconZoom = 45D;
            this.btnAddCustomer.IsTab = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(744, 23);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCustomer.selected = false;
            this.btnAddCustomer.Size = new System.Drawing.Size(172, 40);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Textcolor = System.Drawing.Color.White;
            this.btnAddCustomer.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroups.BorderRadius = 5;
            this.btnGroups.ButtonText = "Groups";
            this.btnGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroups.DisabledColor = System.Drawing.Color.Gray;
            this.btnGroups.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGroups.Iconimage = global::Vendstor.Properties.Resources.group_filled_w;
            this.btnGroups.Iconimage_right = null;
            this.btnGroups.Iconimage_right_Selected = null;
            this.btnGroups.Iconimage_Selected = null;
            this.btnGroups.IconMarginLeft = 0;
            this.btnGroups.IconMarginRight = 0;
            this.btnGroups.IconRightVisible = true;
            this.btnGroups.IconRightZoom = 0D;
            this.btnGroups.IconVisible = true;
            this.btnGroups.IconZoom = 45D;
            this.btnGroups.IsTab = false;
            this.btnGroups.Location = new System.Drawing.Point(929, 23);
            this.btnGroups.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGroups.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnGroups.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGroups.selected = false;
            this.btnGroups.Size = new System.Drawing.Size(155, 40);
            this.btnGroups.TabIndex = 0;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGroups.Textcolor = System.Drawing.Color.White;
            this.btnGroups.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnGroups.Click += new System.EventHandler(this.BtnGroups_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(1, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(445, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Manage your Customers and their balances, or segment them";
            // 
            // text_Customers
            // 
            this.text_Customers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Customers.AutoSize = true;
            this.text_Customers.Font = new System.Drawing.Font("Poppins", 16F);
            this.text_Customers.Location = new System.Drawing.Point(5, 17);
            this.text_Customers.Name = "text_Customers";
            this.text_Customers.Size = new System.Drawing.Size(137, 39);
            this.text_Customers.TabIndex = 1;
            this.text_Customers.Text = "Customers";
            // 
            // cardEmptyData
            // 
            this.cardEmptyData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardEmptyData.BackColor = System.Drawing.Color.White;
            this.cardEmptyData.BorderRadius = 5;
            this.cardEmptyData.BottomSahddow = true;
            this.cardEmptyData.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardEmptyData.Controls.Add(this.imgSorryAlert);
            this.cardEmptyData.Controls.Add(this.seperator_Alert);
            this.cardEmptyData.Controls.Add(this.lblNoCustomers_Alert);
            this.cardEmptyData.Controls.Add(this.lblSorry_Alert);
            this.cardEmptyData.Controls.Add(this.btnAddCustomer_Alert);
            this.cardEmptyData.LeftSahddow = false;
            this.cardEmptyData.Location = new System.Drawing.Point(344, 286);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(451, 286);
            this.cardEmptyData.TabIndex = 1;
            this.cardEmptyData.Visible = false;
            // 
            // imgSorryAlert
            // 
            this.imgSorryAlert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorryAlert.Image = global::Vendstor.Properties.Resources.vector_sorrygirl;
            this.imgSorryAlert.ImageActive = null;
            this.imgSorryAlert.Location = new System.Drawing.Point(166, 25);
            this.imgSorryAlert.Name = "imgSorryAlert";
            this.imgSorryAlert.Size = new System.Drawing.Size(118, 91);
            this.imgSorryAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSorryAlert.TabIndex = 182;
            this.imgSorryAlert.TabStop = false;
            this.imgSorryAlert.Zoom = 10;
            // 
            // seperator_Alert
            // 
            this.seperator_Alert.BackColor = System.Drawing.Color.Transparent;
            this.seperator_Alert.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperator_Alert.LineThickness = 1;
            this.seperator_Alert.Location = new System.Drawing.Point(190, 180);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 2;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lblNoCustomers_Alert
            // 
            this.lblNoCustomers_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoCustomers_Alert.AutoSize = true;
            this.lblNoCustomers_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblNoCustomers_Alert.Location = new System.Drawing.Point(91, 157);
            this.lblNoCustomers_Alert.Name = "lblNoCustomers_Alert";
            this.lblNoCustomers_Alert.Size = new System.Drawing.Size(269, 26);
            this.lblNoCustomers_Alert.TabIndex = 1;
            this.lblNoCustomers_Alert.Text = "You havent\'t created any customer.";
            // 
            // lblSorry_Alert
            // 
            this.lblSorry_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSorry_Alert.AutoSize = true;
            this.lblSorry_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSorry_Alert.Location = new System.Drawing.Point(178, 123);
            this.lblSorry_Alert.Name = "lblSorry_Alert";
            this.lblSorry_Alert.Size = new System.Drawing.Size(94, 26);
            this.lblSorry_Alert.TabIndex = 0;
            this.lblSorry_Alert.Text = "We\'re sorry,";
            // 
            // btnAddCustomer_Alert
            // 
            this.btnAddCustomer_Alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCustomer_Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer_Alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer_Alert.BorderRadius = 5;
            this.btnAddCustomer_Alert.ButtonText = "Add Customer";
            this.btnAddCustomer_Alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer_Alert.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCustomer_Alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCustomer_Alert.Iconimage = global::Vendstor.Properties.Resources.users_dashboard_w;
            this.btnAddCustomer_Alert.Iconimage_right = null;
            this.btnAddCustomer_Alert.Iconimage_right_Selected = null;
            this.btnAddCustomer_Alert.Iconimage_Selected = null;
            this.btnAddCustomer_Alert.IconMarginLeft = 0;
            this.btnAddCustomer_Alert.IconMarginRight = 0;
            this.btnAddCustomer_Alert.IconRightVisible = true;
            this.btnAddCustomer_Alert.IconRightZoom = 0D;
            this.btnAddCustomer_Alert.IconVisible = true;
            this.btnAddCustomer_Alert.IconZoom = 45D;
            this.btnAddCustomer_Alert.IsTab = false;
            this.btnAddCustomer_Alert.Location = new System.Drawing.Point(140, 218);
            this.btnAddCustomer_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer_Alert.Name = "btnAddCustomer_Alert";
            this.btnAddCustomer_Alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer_Alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddCustomer_Alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCustomer_Alert.selected = false;
            this.btnAddCustomer_Alert.Size = new System.Drawing.Size(180, 40);
            this.btnAddCustomer_Alert.TabIndex = 3;
            this.btnAddCustomer_Alert.Text = "Add Customer";
            this.btnAddCustomer_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer_Alert.Textcolor = System.Drawing.Color.White;
            this.btnAddCustomer_Alert.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddCustomer_Alert.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1138, 660);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardEmptyData.ResumeLayout(false);
            this.cardEmptyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorryAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel CustomersGrid;
        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuDropdown dpdCustomerGroup;
        private System.Windows.Forms.Label text_CustomerGroup;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilter;
        private System.Windows.Forms.Label text_SearchHint;
        private System.Windows.Forms.Panel pnlGridHeader;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblAccount_Grid;
        private System.Windows.Forms.Label lblLocation_Grid;
        private System.Windows.Forms.Label lblStoreCredit_Grid;
        private System.Windows.Forms.Label lblCustomers_Grid;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label text_Customers;
        private Bunifu.Framework.UI.BunifuFlatButton btnGroups;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCustomer;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgSorryAlert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lblNoCustomers_Alert;
        private System.Windows.Forms.Label lblSorry_Alert;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCustomer_Alert;
    }
}
