namespace Vendstor.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.imgbtnForceUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSoftName = new System.Windows.Forms.Panel();
            this.lblSoftRelease = new System.Windows.Forms.Label();
            this.lblSoftName = new System.Windows.Forms.Label();
            this.imgbtnToggleUserTab = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblStoreName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserDisplayName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgUserProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnNotifications = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnNormalize = new Bunifu.Framework.UI.BunifuImageButton();
            this.serverSignal = new Vendstor.Controls.ServerStatus();
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.IndicatorSlider = new Bunifu.Framework.UI.BunifuSeparator();
            this.tbtnSettings = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnCustomers = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnProducts = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnReporting = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnSalesLedger = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnSell = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlSliderTab = new System.Windows.Forms.Panel();
            this.ChildControls = new System.Windows.Forms.FlowLayoutPanel();
            this.dgHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.pgbLoading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).BeginInit();
            this.pnlSoftName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnToggleUserTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).BeginInit();
            this.pnlSlider.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.imgbtnForceUpdate);
            this.pnlHeader.Controls.Add(this.pnlSoftName);
            this.pnlHeader.Controls.Add(this.imgbtnToggleUserTab);
            this.pnlHeader.Controls.Add(this.lblStoreName);
            this.pnlHeader.Controls.Add(this.lblUserDisplayName);
            this.pnlHeader.Controls.Add(this.imgUserProfile);
            this.pnlHeader.Controls.Add(this.imgbtnNotifications);
            this.pnlHeader.Controls.Add(this.imgbtnExit);
            this.pnlHeader.Controls.Add(this.imgbtnMaximize);
            this.pnlHeader.Controls.Add(this.imgbtnMinimize);
            this.pnlHeader.Controls.Add(this.imgbtnNormalize);
            this.pnlHeader.Controls.Add(this.serverSignal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1274, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // imgbtnForceUpdate
            // 
            this.imgbtnForceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnForceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnForceUpdate.Image = global::Vendstor.Properties.Resources.update_filled_w;
            this.imgbtnForceUpdate.ImageActive = null;
            this.imgbtnForceUpdate.Location = new System.Drawing.Point(1127, 10);
            this.imgbtnForceUpdate.Name = "imgbtnForceUpdate";
            this.imgbtnForceUpdate.Size = new System.Drawing.Size(20, 20);
            this.imgbtnForceUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnForceUpdate.TabIndex = 94;
            this.imgbtnForceUpdate.TabStop = false;
            this.imgbtnForceUpdate.Zoom = 10;
            this.imgbtnForceUpdate.Click += new System.EventHandler(this.ImgbtnForceUpdate_Click);
            // 
            // pnlSoftName
            // 
            this.pnlSoftName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pnlSoftName.Controls.Add(this.lblSoftRelease);
            this.pnlSoftName.Controls.Add(this.lblSoftName);
            this.pnlSoftName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSoftName.Location = new System.Drawing.Point(0, 0);
            this.pnlSoftName.Name = "pnlSoftName";
            this.pnlSoftName.Size = new System.Drawing.Size(136, 75);
            this.pnlSoftName.TabIndex = 51;
            // 
            // lblSoftRelease
            // 
            this.lblSoftRelease.AutoSize = true;
            this.lblSoftRelease.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftRelease.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftRelease.ForeColor = System.Drawing.Color.White;
            this.lblSoftRelease.Location = new System.Drawing.Point(77, 50);
            this.lblSoftRelease.Name = "lblSoftRelease";
            this.lblSoftRelease.Size = new System.Drawing.Size(37, 16);
            this.lblSoftRelease.TabIndex = 38;
            this.lblSoftRelease.Text = "Beta";
            // 
            // lblSoftName
            // 
            this.lblSoftName.AutoSize = true;
            this.lblSoftName.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftName.Font = new System.Drawing.Font("Product Sans", 18F);
            this.lblSoftName.ForeColor = System.Drawing.Color.White;
            this.lblSoftName.Location = new System.Drawing.Point(14, 24);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(109, 30);
            this.lblSoftName.TabIndex = 37;
            this.lblSoftName.Text = "Vendstor";
            // 
            // imgbtnToggleUserTab
            // 
            this.imgbtnToggleUserTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnToggleUserTab.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnToggleUserTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnToggleUserTab.Image = global::Vendstor.Properties.Resources.expand_arrow_w;
            this.imgbtnToggleUserTab.ImageActive = null;
            this.imgbtnToggleUserTab.Location = new System.Drawing.Point(1240, 45);
            this.imgbtnToggleUserTab.Name = "imgbtnToggleUserTab";
            this.imgbtnToggleUserTab.Size = new System.Drawing.Size(15, 20);
            this.imgbtnToggleUserTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnToggleUserTab.TabIndex = 50;
            this.imgbtnToggleUserTab.TabStop = false;
            this.imgbtnToggleUserTab.Zoom = 10;
            this.imgbtnToggleUserTab.Click += new System.EventHandler(this.ImgbtnToggleUserTab_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.lblStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblStoreName.Location = new System.Drawing.Point(564, 21);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(28, 33);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "_";
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDisplayName.AutoSize = true;
            this.lblUserDisplayName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.lblUserDisplayName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserDisplayName.Location = new System.Drawing.Point(1086, 45);
            this.lblUserDisplayName.MaximumSize = new System.Drawing.Size(170, 23);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(19, 23);
            this.lblUserDisplayName.TabIndex = 46;
            this.lblUserDisplayName.Text = "_";
            this.lblUserDisplayName.Click += new System.EventHandler(this.ImgbtnToggleUserTab_Click);
            // 
            // imgUserProfile
            // 
            this.imgUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.imgUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("imgUserProfile.Image")));
            this.imgUserProfile.ImageActive = null;
            this.imgUserProfile.Location = new System.Drawing.Point(1045, 36);
            this.imgUserProfile.Name = "imgUserProfile";
            this.imgUserProfile.Size = new System.Drawing.Size(34, 30);
            this.imgUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserProfile.TabIndex = 49;
            this.imgUserProfile.TabStop = false;
            this.imgUserProfile.Zoom = 10;
            this.imgUserProfile.Click += new System.EventHandler(this.ImgbtnToggleUserTab_Click);
            // 
            // imgbtnNotifications
            // 
            this.imgbtnNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnNotifications.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("imgbtnNotifications.Image")));
            this.imgbtnNotifications.ImageActive = null;
            this.imgbtnNotifications.Location = new System.Drawing.Point(1002, 45);
            this.imgbtnNotifications.Name = "imgbtnNotifications";
            this.imgbtnNotifications.Size = new System.Drawing.Size(27, 20);
            this.imgbtnNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnNotifications.TabIndex = 48;
            this.imgbtnNotifications.TabStop = false;
            this.imgbtnNotifications.Zoom = 10;
            this.imgbtnNotifications.Click += new System.EventHandler(this.ImgbtnNotifications_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(1231, 10);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(20, 20);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 45;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // imgbtnMaximize
            // 
            this.imgbtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnMaximize.Image = global::Vendstor.Properties.Resources.full_screen_w;
            this.imgbtnMaximize.ImageActive = null;
            this.imgbtnMaximize.Location = new System.Drawing.Point(1205, 10);
            this.imgbtnMaximize.Name = "imgbtnMaximize";
            this.imgbtnMaximize.Size = new System.Drawing.Size(20, 20);
            this.imgbtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMaximize.TabIndex = 42;
            this.imgbtnMaximize.TabStop = false;
            this.imgbtnMaximize.Zoom = 10;
            this.imgbtnMaximize.Click += new System.EventHandler(this.ImgbtnMaximize_Click);
            // 
            // imgbtnMinimize
            // 
            this.imgbtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnMinimize.Image = global::Vendstor.Properties.Resources.minimize_w;
            this.imgbtnMinimize.ImageActive = null;
            this.imgbtnMinimize.Location = new System.Drawing.Point(1153, 10);
            this.imgbtnMinimize.Name = "imgbtnMinimize";
            this.imgbtnMinimize.Size = new System.Drawing.Size(20, 20);
            this.imgbtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMinimize.TabIndex = 43;
            this.imgbtnMinimize.TabStop = false;
            this.imgbtnMinimize.Zoom = 10;
            this.imgbtnMinimize.Click += new System.EventHandler(this.ImgbtnMinimize_Click);
            // 
            // imgbtnNormalize
            // 
            this.imgbtnNormalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnNormalize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnNormalize.Image = global::Vendstor.Properties.Resources.normalize_w;
            this.imgbtnNormalize.ImageActive = null;
            this.imgbtnNormalize.Location = new System.Drawing.Point(1179, 10);
            this.imgbtnNormalize.Name = "imgbtnNormalize";
            this.imgbtnNormalize.Size = new System.Drawing.Size(20, 20);
            this.imgbtnNormalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnNormalize.TabIndex = 44;
            this.imgbtnNormalize.TabStop = false;
            this.imgbtnNormalize.Zoom = 10;
            this.imgbtnNormalize.Click += new System.EventHandler(this.ImgbtnNormalize_Click);
            // 
            // serverSignal
            // 
            this.serverSignal.BackColor = System.Drawing.Color.White;
            this.serverSignal.IsPlaying = false;
            this.serverSignal.IsStateOk = false;
            this.serverSignal.Location = new System.Drawing.Point(109, -7);
            this.serverSignal.Name = "serverSignal";
            this.serverSignal.Size = new System.Drawing.Size(70, 31);
            this.serverSignal.TabIndex = 95;
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSlider.Controls.Add(this.IndicatorSlider);
            this.pnlSlider.Controls.Add(this.tbtnSettings);
            this.pnlSlider.Controls.Add(this.tbtnCustomers);
            this.pnlSlider.Controls.Add(this.tbtnProducts);
            this.pnlSlider.Controls.Add(this.tbtnReporting);
            this.pnlSlider.Controls.Add(this.tbtnSalesLedger);
            this.pnlSlider.Controls.Add(this.tbtnSell);
            this.pnlSlider.Controls.Add(this.tbtnHome);
            this.pnlSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlider.ForeColor = System.Drawing.Color.LightGray;
            this.pnlSlider.Location = new System.Drawing.Point(0, 75);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(136, 660);
            this.pnlSlider.TabIndex = 5;
            // 
            // IndicatorSlider
            // 
            this.IndicatorSlider.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorSlider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.IndicatorSlider.LineThickness = 2;
            this.IndicatorSlider.Location = new System.Drawing.Point(134, 3);
            this.IndicatorSlider.Name = "IndicatorSlider";
            this.IndicatorSlider.Size = new System.Drawing.Size(2, 84);
            this.IndicatorSlider.TabIndex = 10;
            this.IndicatorSlider.Transparency = 255;
            this.IndicatorSlider.Vertical = true;
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.BackColor = System.Drawing.Color.White;
            this.tbtnSettings.color = System.Drawing.Color.White;
            this.tbtnSettings.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSettings.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnSettings.Image = global::Vendstor.Properties.Resources.settings_dashboard_w;
            this.tbtnSettings.ImagePosition = 15;
            this.tbtnSettings.ImageZoom = 20;
            this.tbtnSettings.LabelPosition = 45;
            this.tbtnSettings.LabelText = "Setup";
            this.tbtnSettings.Location = new System.Drawing.Point(0, 525);
            this.tbtnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Size = new System.Drawing.Size(136, 84);
            this.tbtnSettings.TabIndex = 9;
            this.tbtnSettings.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnCustomers
            // 
            this.tbtnCustomers.BackColor = System.Drawing.Color.White;
            this.tbtnCustomers.color = System.Drawing.Color.White;
            this.tbtnCustomers.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCustomers.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnCustomers.Image = global::Vendstor.Properties.Resources.users_dashboard_w;
            this.tbtnCustomers.ImagePosition = 15;
            this.tbtnCustomers.ImageZoom = 20;
            this.tbtnCustomers.LabelPosition = 45;
            this.tbtnCustomers.LabelText = "Customers";
            this.tbtnCustomers.Location = new System.Drawing.Point(0, 438);
            this.tbtnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnCustomers.Name = "tbtnCustomers";
            this.tbtnCustomers.Size = new System.Drawing.Size(136, 84);
            this.tbtnCustomers.TabIndex = 8;
            this.tbtnCustomers.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnProducts
            // 
            this.tbtnProducts.BackColor = System.Drawing.Color.White;
            this.tbtnProducts.color = System.Drawing.Color.White;
            this.tbtnProducts.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnProducts.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnProducts.Image = global::Vendstor.Properties.Resources.products_dashboard_w;
            this.tbtnProducts.ImagePosition = 15;
            this.tbtnProducts.ImageZoom = 20;
            this.tbtnProducts.LabelPosition = 45;
            this.tbtnProducts.LabelText = "Products";
            this.tbtnProducts.Location = new System.Drawing.Point(0, 351);
            this.tbtnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnProducts.Name = "tbtnProducts";
            this.tbtnProducts.Size = new System.Drawing.Size(136, 84);
            this.tbtnProducts.TabIndex = 7;
            this.tbtnProducts.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnReporting
            // 
            this.tbtnReporting.BackColor = System.Drawing.Color.White;
            this.tbtnReporting.color = System.Drawing.Color.White;
            this.tbtnReporting.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnReporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnReporting.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnReporting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnReporting.Image = global::Vendstor.Properties.Resources.Statistics_dashboard_w;
            this.tbtnReporting.ImagePosition = 15;
            this.tbtnReporting.ImageZoom = 20;
            this.tbtnReporting.LabelPosition = 45;
            this.tbtnReporting.LabelText = "Reporting";
            this.tbtnReporting.Location = new System.Drawing.Point(0, 264);
            this.tbtnReporting.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnReporting.Name = "tbtnReporting";
            this.tbtnReporting.Size = new System.Drawing.Size(136, 84);
            this.tbtnReporting.TabIndex = 6;
            this.tbtnReporting.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnSalesLedger
            // 
            this.tbtnSalesLedger.BackColor = System.Drawing.Color.White;
            this.tbtnSalesLedger.color = System.Drawing.Color.White;
            this.tbtnSalesLedger.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnSalesLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSalesLedger.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnSalesLedger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnSalesLedger.Image = global::Vendstor.Properties.Resources.sales_ledger_w_dashboard_w;
            this.tbtnSalesLedger.ImagePosition = 15;
            this.tbtnSalesLedger.ImageZoom = 20;
            this.tbtnSalesLedger.LabelPosition = 45;
            this.tbtnSalesLedger.LabelText = "Sales Ledger";
            this.tbtnSalesLedger.Location = new System.Drawing.Point(0, 177);
            this.tbtnSalesLedger.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnSalesLedger.Name = "tbtnSalesLedger";
            this.tbtnSalesLedger.Size = new System.Drawing.Size(136, 84);
            this.tbtnSalesLedger.TabIndex = 5;
            this.tbtnSalesLedger.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnSell
            // 
            this.tbtnSell.BackColor = System.Drawing.Color.White;
            this.tbtnSell.color = System.Drawing.Color.White;
            this.tbtnSell.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSell.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnSell.Image = global::Vendstor.Properties.Resources.sell__dashboard_w;
            this.tbtnSell.ImagePosition = 15;
            this.tbtnSell.ImageZoom = 20;
            this.tbtnSell.LabelPosition = 45;
            this.tbtnSell.LabelText = "Sell";
            this.tbtnSell.Location = new System.Drawing.Point(0, 90);
            this.tbtnSell.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnSell.Name = "tbtnSell";
            this.tbtnSell.Size = new System.Drawing.Size(136, 84);
            this.tbtnSell.TabIndex = 4;
            this.tbtnSell.Click += new System.EventHandler(this.SliderButton);
            // 
            // tbtnHome
            // 
            this.tbtnHome.BackColor = System.Drawing.Color.White;
            this.tbtnHome.color = System.Drawing.Color.White;
            this.tbtnHome.colorActive = System.Drawing.Color.WhiteSmoke;
            this.tbtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnHome.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.tbtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(144)))), ((int)(((byte)(157)))));
            this.tbtnHome.Image = global::Vendstor.Properties.Resources.home_dashboard_w;
            this.tbtnHome.ImagePosition = 16;
            this.tbtnHome.ImageZoom = 20;
            this.tbtnHome.LabelPosition = 44;
            this.tbtnHome.LabelText = "Home";
            this.tbtnHome.Location = new System.Drawing.Point(0, 3);
            this.tbtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnHome.Name = "tbtnHome";
            this.tbtnHome.Size = new System.Drawing.Size(136, 84);
            this.tbtnHome.TabIndex = 3;
            this.tbtnHome.Click += new System.EventHandler(this.SliderButton);
            // 
            // pnlSliderTab
            // 
            this.pnlSliderTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSliderTab.BackColor = System.Drawing.Color.White;
            this.pnlSliderTab.Location = new System.Drawing.Point(1264, 75);
            this.pnlSliderTab.Name = "pnlSliderTab";
            this.pnlSliderTab.Size = new System.Drawing.Size(10, 660);
            this.pnlSliderTab.TabIndex = 7;
            // 
            // ChildControls
            // 
            this.ChildControls.AutoSize = true;
            this.ChildControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ChildControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChildControls.Location = new System.Drawing.Point(136, 75);
            this.ChildControls.Name = "ChildControls";
            this.ChildControls.Size = new System.Drawing.Size(1138, 660);
            this.ChildControls.TabIndex = 8;
            // 
            // dgHeader
            // 
            this.dgHeader.Fixed = true;
            this.dgHeader.Horizontal = true;
            this.dgHeader.TargetControl = this.pnlHeader;
            this.dgHeader.Vertical = true;
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingPanel.Controls.Add(this.pgbLoading);
            this.LoadingPanel.Location = new System.Drawing.Point(440, 245);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(394, 245);
            this.LoadingPanel.TabIndex = 96;
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
            this.pgbLoading.Location = new System.Drawing.Point(158, 83);
            this.pgbLoading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbLoading.MaxValue = 100;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pgbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pgbLoading.Size = new System.Drawing.Size(79, 79);
            this.pgbLoading.TabIndex = 0;
            this.pgbLoading.Value = 10;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1274, 735);
            this.Controls.Add(this.ChildControls);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.pnlSliderTab);
            this.Controls.Add(this.pnlSlider);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).EndInit();
            this.pnlSoftName.ResumeLayout(false);
            this.pnlSoftName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnToggleUserTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).EndInit();
            this.pnlSlider.ResumeLayout(false);
            this.LoadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        internal System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnNormalize;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnToggleUserTab;
        internal Bunifu.Framework.UI.BunifuCustomLabel lblUserDisplayName;
        internal Bunifu.Framework.UI.BunifuImageButton imgUserProfile;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnNotifications;
        internal System.Windows.Forms.Panel pnlSoftName;
        private System.Windows.Forms.Label lblSoftRelease;
        private System.Windows.Forms.Label lblSoftName;
        internal Bunifu.Framework.UI.BunifuCustomLabel lblStoreName;
        private System.Windows.Forms.Panel pnlSliderTab;
        public System.Windows.Forms.Panel pnlSlider;
        public Bunifu.Framework.UI.BunifuTileButton tbtnHome;
        public Bunifu.Framework.UI.BunifuTileButton tbtnSell;
        public Bunifu.Framework.UI.BunifuTileButton tbtnCustomers;
        public Bunifu.Framework.UI.BunifuTileButton tbtnProducts;
        public Bunifu.Framework.UI.BunifuTileButton tbtnReporting;
        public Bunifu.Framework.UI.BunifuTileButton tbtnSalesLedger;
        public Bunifu.Framework.UI.BunifuTileButton tbtnSettings;
        public Bunifu.Framework.UI.BunifuSeparator IndicatorSlider;
        private Bunifu.Framework.UI.BunifuDragControl dgHeader;
        public System.Windows.Forms.FlowLayoutPanel ChildControls;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnForceUpdate;
        private Controls.ServerStatus serverSignal;
        private System.Windows.Forms.Panel LoadingPanel;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pgbLoading;
    }
}