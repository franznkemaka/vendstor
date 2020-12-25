namespace Vendstor.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.lblSoft_Copyright = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.imgbtnSets = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnUserSets = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.imgbtnForceUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnNotification = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnNormalize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSoft_Name = new System.Windows.Forms.Label();
            this.lblSoft_Release = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cardSell = new Bunifu.Framework.UI.BunifuCards();
            this.lblSell = new System.Windows.Forms.Label();
            this.imgbtnSell = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardProducts = new Bunifu.Framework.UI.BunifuCards();
            this.lblProducts = new System.Windows.Forms.Label();
            this.imgbtnProducts = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardHome = new Bunifu.Framework.UI.BunifuCards();
            this.lblHome = new System.Windows.Forms.Label();
            this.imgbtnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardReporting = new Bunifu.Framework.UI.BunifuCards();
            this.lblReporting = new System.Windows.Forms.Label();
            this.imgbtnReporting = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardSalesLedger = new Bunifu.Framework.UI.BunifuCards();
            this.lblSalesLedger = new System.Windows.Forms.Label();
            this.imgbtnSalesLedger = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardSettings = new Bunifu.Framework.UI.BunifuCards();
            this.lblSettings = new System.Windows.Forms.Label();
            this.imgbtnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardCustomers = new Bunifu.Framework.UI.BunifuCards();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.imgbtnCustomers = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.imgbtn_LogOut = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgUserProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserDisplayName = new System.Windows.Forms.Label();
            this.dgHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ucNotificationTab = new Vendstor.UserControls.NotificationsTab();
            this.ucUserTab = new Vendstor.UserControls.UserTab();
            this.serverStatus = new Vendstor.Controls.ServerStatus();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnUserSets)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).BeginInit();
            this.cardSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSell)).BeginInit();
            this.cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnProducts)).BeginInit();
            this.cardHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnHome)).BeginInit();
            this.cardReporting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnReporting)).BeginInit();
            this.cardSalesLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSalesLedger)).BeginInit();
            this.cardSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSettings)).BeginInit();
            this.cardCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCustomers)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // timTime
            // 
            this.timTime.Interval = 60000;
            this.timTime.Tick += new System.EventHandler(this.TimTime_Tick);
            // 
            // lblSoft_Copyright
            // 
            this.lblSoft_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoft_Copyright.AutoSize = true;
            this.lblSoft_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Copyright.Font = new System.Drawing.Font("Product Sans", 9F);
            this.lblSoft_Copyright.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Copyright.Location = new System.Drawing.Point(1262, 6);
            this.lblSoft_Copyright.MaximumSize = new System.Drawing.Size(252, 0);
            this.lblSoft_Copyright.Name = "lblSoft_Copyright";
            this.lblSoft_Copyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSoft_Copyright.Size = new System.Drawing.Size(242, 16);
            this.lblSoft_Copyright.TabIndex = 26;
            this.lblSoft_Copyright.Text = "Copyright © 2018 RigleSoft™ Franz Nkemaka";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.pnlBottom.Controls.Add(this.imgbtnSets);
            this.pnlBottom.Controls.Add(this.imgbtnUserSets);
            this.pnlBottom.Controls.Add(this.lblSoft_Copyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 655);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1145, 29);
            this.pnlBottom.TabIndex = 25;
            // 
            // imgbtnSets
            // 
            this.imgbtnSets.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnSets.Image = global::Vendstor.Properties.Resources.sets_w;
            this.imgbtnSets.ImageActive = null;
            this.imgbtnSets.Location = new System.Drawing.Point(39, 3);
            this.imgbtnSets.Name = "imgbtnSets";
            this.imgbtnSets.Size = new System.Drawing.Size(21, 21);
            this.imgbtnSets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSets.TabIndex = 46;
            this.imgbtnSets.TabStop = false;
            this.imgbtnSets.Zoom = 10;
            // 
            // imgbtnUserSets
            // 
            this.imgbtnUserSets.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnUserSets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnUserSets.Image = global::Vendstor.Properties.Resources.user_mang_w;
            this.imgbtnUserSets.ImageActive = null;
            this.imgbtnUserSets.Location = new System.Drawing.Point(12, 4);
            this.imgbtnUserSets.Name = "imgbtnUserSets";
            this.imgbtnUserSets.Size = new System.Drawing.Size(21, 21);
            this.imgbtnUserSets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnUserSets.TabIndex = 45;
            this.imgbtnUserSets.TabStop = false;
            this.imgbtnUserSets.Zoom = 10;
            // 
            // dgMain
            // 
            this.dgMain.Fixed = true;
            this.dgMain.Horizontal = true;
            this.dgMain.TargetControl = this;
            this.dgMain.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.pnlHeader.Controls.Add(this.imgbtnForceUpdate);
            this.pnlHeader.Controls.Add(this.imgbtnNotification);
            this.pnlHeader.Controls.Add(this.imgbtnExit);
            this.pnlHeader.Controls.Add(this.imgbtnMaximize);
            this.pnlHeader.Controls.Add(this.imgbtnMinimize);
            this.pnlHeader.Controls.Add(this.imgbtnNormalize);
            this.pnlHeader.Controls.Add(this.lblSoft_Name);
            this.pnlHeader.Controls.Add(this.lblSoft_Release);
            this.pnlHeader.Controls.Add(this.lblStoreName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1145, 41);
            this.pnlHeader.TabIndex = 33;
            // 
            // imgbtnForceUpdate
            // 
            this.imgbtnForceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnForceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnForceUpdate.Image = global::Vendstor.Properties.Resources.update_filled_w;
            this.imgbtnForceUpdate.ImageActive = null;
            this.imgbtnForceUpdate.Location = new System.Drawing.Point(1393, 13);
            this.imgbtnForceUpdate.Name = "imgbtnForceUpdate";
            this.imgbtnForceUpdate.Size = new System.Drawing.Size(15, 15);
            this.imgbtnForceUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnForceUpdate.TabIndex = 94;
            this.imgbtnForceUpdate.TabStop = false;
            this.imgbtnForceUpdate.Zoom = 10;
            this.imgbtnForceUpdate.Click += new System.EventHandler(this.ImgbtnForceUpdate_Click);
            // 
            // imgbtnNotification
            // 
            this.imgbtnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnNotification.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnNotification.Image = global::Vendstor.Properties.Resources.notification_w;
            this.imgbtnNotification.ImageActive = null;
            this.imgbtnNotification.Location = new System.Drawing.Point(1361, 10);
            this.imgbtnNotification.Name = "imgbtnNotification";
            this.imgbtnNotification.Size = new System.Drawing.Size(21, 21);
            this.imgbtnNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnNotification.TabIndex = 47;
            this.imgbtnNotification.TabStop = false;
            this.imgbtnNotification.Zoom = 10;
            this.imgbtnNotification.Click += new System.EventHandler(this.Imgbtn_Notifications_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(1477, 13);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(15, 15);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 41;
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
            this.imgbtnMaximize.Location = new System.Drawing.Point(1456, 13);
            this.imgbtnMaximize.Name = "imgbtnMaximize";
            this.imgbtnMaximize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMaximize.TabIndex = 38;
            this.imgbtnMaximize.TabStop = false;
            this.imgbtnMaximize.Zoom = 10;
            this.imgbtnMaximize.Click += new System.EventHandler(this.Imgbtn_Maximize_Click);
            // 
            // imgbtnMinimize
            // 
            this.imgbtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnMinimize.Image = global::Vendstor.Properties.Resources.minimize_w;
            this.imgbtnMinimize.ImageActive = null;
            this.imgbtnMinimize.Location = new System.Drawing.Point(1414, 13);
            this.imgbtnMinimize.Name = "imgbtnMinimize";
            this.imgbtnMinimize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMinimize.TabIndex = 39;
            this.imgbtnMinimize.TabStop = false;
            this.imgbtnMinimize.Zoom = 10;
            this.imgbtnMinimize.Click += new System.EventHandler(this.Imgbtn_Minimize_Click);
            // 
            // imgbtnNormalize
            // 
            this.imgbtnNormalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnNormalize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnNormalize.Image = global::Vendstor.Properties.Resources.normalize_w;
            this.imgbtnNormalize.ImageActive = null;
            this.imgbtnNormalize.Location = new System.Drawing.Point(1435, 13);
            this.imgbtnNormalize.Name = "imgbtnNormalize";
            this.imgbtnNormalize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnNormalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnNormalize.TabIndex = 40;
            this.imgbtnNormalize.TabStop = false;
            this.imgbtnNormalize.Zoom = 10;
            this.imgbtnNormalize.Click += new System.EventHandler(this.Imgbtn_Normalize_Click);
            // 
            // lblSoft_Name
            // 
            this.lblSoft_Name.AutoSize = true;
            this.lblSoft_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Name.Font = new System.Drawing.Font("Product Sans", 18F);
            this.lblSoft_Name.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Name.Location = new System.Drawing.Point(12, 5);
            this.lblSoft_Name.Name = "lblSoft_Name";
            this.lblSoft_Name.Size = new System.Drawing.Size(109, 30);
            this.lblSoft_Name.TabIndex = 36;
            this.lblSoft_Name.Text = "Vendstor";
            // 
            // lblSoft_Release
            // 
            this.lblSoft_Release.AutoSize = true;
            this.lblSoft_Release.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Release.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoft_Release.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Release.Location = new System.Drawing.Point(122, 12);
            this.lblSoft_Release.Name = "lblSoft_Release";
            this.lblSoft_Release.Size = new System.Drawing.Size(44, 19);
            this.lblSoft_Release.TabIndex = 37;
            this.lblSoft_Release.Text = "Beta";
            // 
            // lblStoreName
            // 
            this.lblStoreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.Font = new System.Drawing.Font("Product Sans", 12.5F);
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(703, 10);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(109, 21);
            this.lblStoreName.TabIndex = 34;
            this.lblStoreName.Text = "_Store_Name";
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // cardSell
            // 
            this.cardSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(110)))));
            this.cardSell.BorderRadius = 5;
            this.cardSell.BottomSahddow = true;
            this.cardSell.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.cardSell.Controls.Add(this.lblSell);
            this.cardSell.Controls.Add(this.imgbtnSell);
            this.cardSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSell.LeftSahddow = false;
            this.cardSell.Location = new System.Drawing.Point(31, 129);
            this.cardSell.Name = "cardSell";
            this.cardSell.RightSahddow = true;
            this.cardSell.ShadowDepth = 20;
            this.cardSell.Size = new System.Drawing.Size(280, 236);
            this.cardSell.TabIndex = 34;
            this.cardSell.Tag = "Sell";
            this.cardSell.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblSell
            // 
            this.lblSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSell.AutoSize = true;
            this.lblSell.BackColor = System.Drawing.Color.Transparent;
            this.lblSell.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblSell.ForeColor = System.Drawing.Color.White;
            this.lblSell.Location = new System.Drawing.Point(20, 13);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(42, 30);
            this.lblSell.TabIndex = 41;
            this.lblSell.Tag = "Sell";
            this.lblSell.Text = "Sell";
            this.lblSell.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnSell
            // 
            this.imgbtnSell.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSell.Image = global::Vendstor.Properties.Resources.cash_regit_w;
            this.imgbtnSell.ImageActive = null;
            this.imgbtnSell.Location = new System.Drawing.Point(48, 61);
            this.imgbtnSell.Name = "imgbtnSell";
            this.imgbtnSell.Size = new System.Drawing.Size(185, 114);
            this.imgbtnSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSell.TabIndex = 1;
            this.imgbtnSell.TabStop = false;
            this.imgbtnSell.Tag = "Sell";
            this.imgbtnSell.Zoom = 10;
            this.imgbtnSell.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardProducts
            // 
            this.cardProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.cardProducts.BorderRadius = 5;
            this.cardProducts.BottomSahddow = true;
            this.cardProducts.color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.cardProducts.Controls.Add(this.lblProducts);
            this.cardProducts.Controls.Add(this.imgbtnProducts);
            this.cardProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardProducts.LeftSahddow = false;
            this.cardProducts.Location = new System.Drawing.Point(326, 129);
            this.cardProducts.Name = "cardProducts";
            this.cardProducts.RightSahddow = true;
            this.cardProducts.ShadowDepth = 20;
            this.cardProducts.Size = new System.Drawing.Size(281, 236);
            this.cardProducts.TabIndex = 35;
            this.cardProducts.Tag = "Products";
            this.cardProducts.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(25, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(87, 30);
            this.lblProducts.TabIndex = 42;
            this.lblProducts.Tag = "Products";
            this.lblProducts.Text = "Products";
            this.lblProducts.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnProducts
            // 
            this.imgbtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnProducts.Image = global::Vendstor.Properties.Resources.product_w;
            this.imgbtnProducts.ImageActive = null;
            this.imgbtnProducts.Location = new System.Drawing.Point(48, 61);
            this.imgbtnProducts.Name = "imgbtnProducts";
            this.imgbtnProducts.Size = new System.Drawing.Size(185, 114);
            this.imgbtnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnProducts.TabIndex = 5;
            this.imgbtnProducts.TabStop = false;
            this.imgbtnProducts.Tag = "Products";
            this.imgbtnProducts.Zoom = 10;
            this.imgbtnProducts.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardHome
            // 
            this.cardHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(111)))), ((int)(((byte)(89)))));
            this.cardHome.BorderRadius = 5;
            this.cardHome.BottomSahddow = true;
            this.cardHome.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(111)))), ((int)(((byte)(89)))));
            this.cardHome.Controls.Add(this.lblHome);
            this.cardHome.Controls.Add(this.imgbtnHome);
            this.cardHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardHome.LeftSahddow = false;
            this.cardHome.Location = new System.Drawing.Point(31, 390);
            this.cardHome.Name = "cardHome";
            this.cardHome.RightSahddow = true;
            this.cardHome.ShadowDepth = 20;
            this.cardHome.Size = new System.Drawing.Size(576, 240);
            this.cardHome.TabIndex = 36;
            this.cardHome.Tag = "Dashboard";
            this.cardHome.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(20, 18);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(106, 30);
            this.lblHome.TabIndex = 45;
            this.lblHome.Tag = "Dashboard";
            this.lblHome.Text = "Dashboard";
            this.lblHome.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnHome
            // 
            this.imgbtnHome.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnHome.Image = global::Vendstor.Properties.Resources.inventory_w;
            this.imgbtnHome.ImageActive = null;
            this.imgbtnHome.Location = new System.Drawing.Point(365, 55);
            this.imgbtnHome.Name = "imgbtnHome";
            this.imgbtnHome.Size = new System.Drawing.Size(185, 114);
            this.imgbtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnHome.TabIndex = 3;
            this.imgbtnHome.TabStop = false;
            this.imgbtnHome.Tag = "Dashboard";
            this.imgbtnHome.Zoom = 10;
            this.imgbtnHome.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardReporting
            // 
            this.cardReporting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardReporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(85)))), ((int)(((byte)(172)))));
            this.cardReporting.BorderRadius = 5;
            this.cardReporting.BottomSahddow = true;
            this.cardReporting.color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(85)))), ((int)(((byte)(172)))));
            this.cardReporting.Controls.Add(this.lblReporting);
            this.cardReporting.Controls.Add(this.imgbtnReporting);
            this.cardReporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardReporting.LeftSahddow = false;
            this.cardReporting.Location = new System.Drawing.Point(642, 129);
            this.cardReporting.Name = "cardReporting";
            this.cardReporting.RightSahddow = true;
            this.cardReporting.ShadowDepth = 20;
            this.cardReporting.Size = new System.Drawing.Size(224, 236);
            this.cardReporting.TabIndex = 36;
            this.cardReporting.Tag = "Products";
            this.cardReporting.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblReporting
            // 
            this.lblReporting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReporting.AutoSize = true;
            this.lblReporting.BackColor = System.Drawing.Color.Transparent;
            this.lblReporting.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblReporting.ForeColor = System.Drawing.Color.White;
            this.lblReporting.Location = new System.Drawing.Point(16, 13);
            this.lblReporting.Name = "lblReporting";
            this.lblReporting.Size = new System.Drawing.Size(94, 30);
            this.lblReporting.TabIndex = 43;
            this.lblReporting.Tag = "Products";
            this.lblReporting.Text = "Reporting";
            this.lblReporting.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnReporting
            // 
            this.imgbtnReporting.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnReporting.Image = global::Vendstor.Properties.Resources.sales_w;
            this.imgbtnReporting.ImageActive = null;
            this.imgbtnReporting.Location = new System.Drawing.Point(20, 61);
            this.imgbtnReporting.Name = "imgbtnReporting";
            this.imgbtnReporting.Size = new System.Drawing.Size(185, 114);
            this.imgbtnReporting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnReporting.TabIndex = 2;
            this.imgbtnReporting.TabStop = false;
            this.imgbtnReporting.Tag = "Products";
            this.imgbtnReporting.Zoom = 10;
            this.imgbtnReporting.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardSalesLedger
            // 
            this.cardSalesLedger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardSalesLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cardSalesLedger.BorderRadius = 5;
            this.cardSalesLedger.BottomSahddow = true;
            this.cardSalesLedger.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cardSalesLedger.Controls.Add(this.lblSalesLedger);
            this.cardSalesLedger.Controls.Add(this.imgbtnSalesLedger);
            this.cardSalesLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSalesLedger.LeftSahddow = false;
            this.cardSalesLedger.Location = new System.Drawing.Point(891, 129);
            this.cardSalesLedger.Name = "cardSalesLedger";
            this.cardSalesLedger.RightSahddow = true;
            this.cardSalesLedger.ShadowDepth = 20;
            this.cardSalesLedger.Size = new System.Drawing.Size(223, 236);
            this.cardSalesLedger.TabIndex = 37;
            this.cardSalesLedger.Tag = "SalesLedger";
            this.cardSalesLedger.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblSalesLedger
            // 
            this.lblSalesLedger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalesLedger.AutoSize = true;
            this.lblSalesLedger.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesLedger.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblSalesLedger.ForeColor = System.Drawing.Color.White;
            this.lblSalesLedger.Location = new System.Drawing.Point(15, 13);
            this.lblSalesLedger.Name = "lblSalesLedger";
            this.lblSalesLedger.Size = new System.Drawing.Size(120, 30);
            this.lblSalesLedger.TabIndex = 45;
            this.lblSalesLedger.Tag = "SalesLedger";
            this.lblSalesLedger.Text = "Sales Ledger";
            this.lblSalesLedger.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnSalesLedger
            // 
            this.imgbtnSalesLedger.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSalesLedger.Image = global::Vendstor.Properties.Resources.inventory_report_w;
            this.imgbtnSalesLedger.ImageActive = null;
            this.imgbtnSalesLedger.Location = new System.Drawing.Point(19, 61);
            this.imgbtnSalesLedger.Name = "imgbtnSalesLedger";
            this.imgbtnSalesLedger.Size = new System.Drawing.Size(185, 114);
            this.imgbtnSalesLedger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSalesLedger.TabIndex = 5;
            this.imgbtnSalesLedger.TabStop = false;
            this.imgbtnSalesLedger.Tag = "SalesLedger";
            this.imgbtnSalesLedger.Zoom = 10;
            this.imgbtnSalesLedger.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardSettings
            // 
            this.cardSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.cardSettings.BorderRadius = 5;
            this.cardSettings.BottomSahddow = true;
            this.cardSettings.color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.cardSettings.Controls.Add(this.lblSettings);
            this.cardSettings.Controls.Add(this.imgbtnSettings);
            this.cardSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSettings.LeftSahddow = false;
            this.cardSettings.Location = new System.Drawing.Point(643, 390);
            this.cardSettings.Name = "cardSettings";
            this.cardSettings.RightSahddow = true;
            this.cardSettings.ShadowDepth = 20;
            this.cardSettings.Size = new System.Drawing.Size(223, 240);
            this.cardSettings.TabIndex = 37;
            this.cardSettings.Tag = "Settings";
            this.cardSettings.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(15, 18);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(62, 30);
            this.lblSettings.TabIndex = 44;
            this.lblSettings.Tag = "Settings";
            this.lblSettings.Text = "Setup";
            this.lblSettings.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnSettings
            // 
            this.imgbtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSettings.Image = global::Vendstor.Properties.Resources.setup_main_w;
            this.imgbtnSettings.ImageActive = null;
            this.imgbtnSettings.Location = new System.Drawing.Point(19, 63);
            this.imgbtnSettings.Name = "imgbtnSettings";
            this.imgbtnSettings.Size = new System.Drawing.Size(185, 114);
            this.imgbtnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSettings.TabIndex = 4;
            this.imgbtnSettings.TabStop = false;
            this.imgbtnSettings.Tag = "Settings";
            this.imgbtnSettings.Zoom = 10;
            this.imgbtnSettings.Click += new System.EventHandler(this.Cards_Click);
            // 
            // cardCustomers
            // 
            this.cardCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(123)))));
            this.cardCustomers.BorderRadius = 5;
            this.cardCustomers.BottomSahddow = true;
            this.cardCustomers.color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(123)))));
            this.cardCustomers.Controls.Add(this.lblCustomers);
            this.cardCustomers.Controls.Add(this.imgbtnCustomers);
            this.cardCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardCustomers.LeftSahddow = false;
            this.cardCustomers.Location = new System.Drawing.Point(891, 390);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.RightSahddow = true;
            this.cardCustomers.ShadowDepth = 20;
            this.cardCustomers.Size = new System.Drawing.Size(223, 240);
            this.cardCustomers.TabIndex = 38;
            this.cardCustomers.Tag = "Customers";
            this.cardCustomers.Click += new System.EventHandler(this.Cards_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Poppins Light", 12.5F);
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(14, 18);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(106, 30);
            this.lblCustomers.TabIndex = 46;
            this.lblCustomers.Tag = "Customers";
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.Click += new System.EventHandler(this.Cards_Click);
            // 
            // imgbtnCustomers
            // 
            this.imgbtnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCustomers.Image = global::Vendstor.Properties.Resources.customers_main_w;
            this.imgbtnCustomers.ImageActive = null;
            this.imgbtnCustomers.Location = new System.Drawing.Point(19, 63);
            this.imgbtnCustomers.Name = "imgbtnCustomers";
            this.imgbtnCustomers.Size = new System.Drawing.Size(185, 114);
            this.imgbtnCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCustomers.TabIndex = 5;
            this.imgbtnCustomers.TabStop = false;
            this.imgbtnCustomers.Tag = "Customers";
            this.imgbtnCustomers.Zoom = 10;
            this.imgbtnCustomers.Click += new System.EventHandler(this.Cards_Click);
            // 
            // pnlDate
            // 
            this.pnlDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDate.Controls.Add(this.lblDateDay);
            this.pnlDate.Controls.Add(this.lblDateTime);
            this.pnlDate.Location = new System.Drawing.Point(891, 49);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(223, 74);
            this.pnlDate.TabIndex = 39;
            // 
            // lblDateDay
            // 
            this.lblDateDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateDay.AutoSize = true;
            this.lblDateDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDateDay.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.lblDateDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.lblDateDay.Location = new System.Drawing.Point(38, 43);
            this.lblDateDay.Name = "lblDateDay";
            this.lblDateDay.Size = new System.Drawing.Size(182, 21);
            this.lblDateDay.TabIndex = 43;
            this.lblDateDay.Text = "_day, _month _day, _year";
            this.lblDateDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Roboto Light", 18F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(147, 11);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(76, 32);
            this.lblDateTime.TabIndex = 42;
            this.lblDateTime.Text = "00:00";
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUser.Controls.Add(this.imgbtn_LogOut);
            this.pnlUser.Controls.Add(this.imgUserProfile);
            this.pnlUser.Controls.Add(this.lblUserRole);
            this.pnlUser.Controls.Add(this.lblUserDisplayName);
            this.pnlUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUser.Location = new System.Drawing.Point(31, 57);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(233, 59);
            this.pnlUser.TabIndex = 40;
            this.pnlUser.Click += new System.EventHandler(this.PnlUser_Click);
            // 
            // imgbtn_LogOut
            // 
            this.imgbtn_LogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgbtn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_LogOut.Image = global::Vendstor.Properties.Resources.log_out_colored;
            this.imgbtn_LogOut.ImageActive = null;
            this.imgbtn_LogOut.Location = new System.Drawing.Point(173, 17);
            this.imgbtn_LogOut.Name = "imgbtn_LogOut";
            this.imgbtn_LogOut.Size = new System.Drawing.Size(29, 25);
            this.imgbtn_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_LogOut.TabIndex = 44;
            this.imgbtn_LogOut.TabStop = false;
            this.imgbtn_LogOut.Zoom = 10;
            this.imgbtn_LogOut.Click += new System.EventHandler(this.ImgbtnLogOut_Click);
            // 
            // imgUserProfile
            // 
            this.imgUserProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.imgUserProfile.Image = global::Vendstor.Properties.Resources.store_defualt_icon;
            this.imgUserProfile.ImageActive = null;
            this.imgUserProfile.Location = new System.Drawing.Point(5, 6);
            this.imgUserProfile.Name = "imgUserProfile";
            this.imgUserProfile.Size = new System.Drawing.Size(46, 45);
            this.imgUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserProfile.TabIndex = 41;
            this.imgUserProfile.TabStop = false;
            this.imgUserProfile.Zoom = 10;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Poppins ExtraLight", 10F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.lblUserRole.Location = new System.Drawing.Point(57, 26);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(56, 25);
            this.lblUserRole.TabIndex = 43;
            this.lblUserRole.Text = "Admin";
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserDisplayName.AutoSize = true;
            this.lblUserDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Product Sans", 11F);
            this.lblUserDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblUserDisplayName.Location = new System.Drawing.Point(57, 6);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(109, 19);
            this.lblUserDisplayName.TabIndex = 42;
            this.lblUserDisplayName.Text = "Franz Nkemaka";
            // 
            // dgHeader
            // 
            this.dgHeader.Fixed = true;
            this.dgHeader.Horizontal = true;
            this.dgHeader.TargetControl = this.pnlHeader;
            this.dgHeader.Vertical = true;
            // 
            // ucNotificationTab
            // 
            this.ucNotificationTab.BackColor = System.Drawing.Color.White;
            this.ucNotificationTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucNotificationTab.Location = new System.Drawing.Point(774, 41);
            this.ucNotificationTab.Margin = new System.Windows.Forms.Padding(4);
            this.ucNotificationTab.Name = "ucNotificationTab";
            this.ucNotificationTab.Size = new System.Drawing.Size(371, 614);
            this.ucNotificationTab.TabIndex = 41;
            this.ucNotificationTab.Visible = false;
            // 
            // ucUserTab
            // 
            this.ucUserTab.BackColor = System.Drawing.Color.White;
            this.ucUserTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucUserTab.Location = new System.Drawing.Point(0, 41);
            this.ucUserTab.Margin = new System.Windows.Forms.Padding(4);
            this.ucUserTab.Name = "ucUserTab";
            this.ucUserTab.Size = new System.Drawing.Size(320, 614);
            this.ucUserTab.TabIndex = 42;
            this.ucUserTab.Visible = false;
            // 
            // serverStatus
            // 
            this.serverStatus.BackColor = System.Drawing.Color.Transparent;
            this.serverStatus.Location = new System.Drawing.Point(172, 5);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(47, 29);
            this.serverStatus.TabIndex = 95;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1145, 684);
            this.Controls.Add(this.ucNotificationTab);
            this.Controls.Add(this.ucUserTab);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.cardCustomers);
            this.Controls.Add(this.cardSettings);
            this.Controls.Add(this.cardSalesLedger);
            this.Controls.Add(this.cardReporting);
            this.Controls.Add(this.cardHome);
            this.Controls.Add(this.cardProducts);
            this.Controls.Add(this.cardSell);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Vendstor - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.FrmMain_Click);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnUserSets)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).EndInit();
            this.cardSell.ResumeLayout(false);
            this.cardSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSell)).EndInit();
            this.cardProducts.ResumeLayout(false);
            this.cardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnProducts)).EndInit();
            this.cardHome.ResumeLayout(false);
            this.cardHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnHome)).EndInit();
            this.cardReporting.ResumeLayout(false);
            this.cardReporting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnReporting)).EndInit();
            this.cardSalesLedger.ResumeLayout(false);
            this.cardSalesLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSalesLedger)).EndInit();
            this.cardSettings.ResumeLayout(false);
            this.cardSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSettings)).EndInit();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCustomers)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.Label lblSoft_Copyright;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuDragControl dgMain;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStoreName;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnNormalize;
        private System.Windows.Forms.Label lblSoft_Name;
        private System.Windows.Forms.Label lblSoft_Release;
        private Bunifu.Framework.UI.BunifuCards cardCustomers;
        private Bunifu.Framework.UI.BunifuCards cardSettings;
        private Bunifu.Framework.UI.BunifuCards cardSalesLedger;
        private Bunifu.Framework.UI.BunifuCards cardReporting;
        private Bunifu.Framework.UI.BunifuCards cardHome;
        private Bunifu.Framework.UI.BunifuCards cardProducts;
        private Bunifu.Framework.UI.BunifuCards cardSell;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSell;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnReporting;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnHome;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSettings;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCustomers;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSalesLedger;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnProducts;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSalesLedger;
        private System.Windows.Forms.Label lblReporting;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSell;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSets;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnUserSets;
        private System.Windows.Forms.Panel pnlUser;
        private Bunifu.Framework.UI.BunifuImageButton imgbtn_LogOut;
        private Bunifu.Framework.UI.BunifuImageButton imgUserProfile;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserDisplayName;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblDateDay;
        private System.Windows.Forms.Label lblDateTime;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnNotification;
        private Bunifu.Framework.UI.BunifuDragControl dgHeader;
        private UserControls.NotificationsTab ucNotificationTab;
        private UserControls.UserTab ucUserTab;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnForceUpdate;
        private Controls.ServerStatus serverStatus;
    }
}