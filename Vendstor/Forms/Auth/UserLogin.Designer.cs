namespace Vendstor.Forms.Auth
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlLoginOptions = new System.Windows.Forms.Panel();
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.btnLogoutStore = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnForceUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.imgbtnUserLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnCodeLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnPinLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSoftName = new System.Windows.Forms.Label();
            this.lblSoftRelease = new System.Windows.Forms.Label();
            this.lblSoft_Copyright = new System.Windows.Forms.Label();
            this.timLoadingSplash = new System.Windows.Forms.Timer(this.components);
            this.pnlVendstorSplash = new System.Windows.Forms.Panel();
            this.cpgb_VendstorSplash = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.text_SoftRelease = new System.Windows.Forms.Label();
            this.text_SoftName = new System.Windows.Forms.Label();
            this.pnlSoftName = new System.Windows.Forms.Panel();
            this.pnlSoftView = new System.Windows.Forms.Panel();
            this.imgbtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnNormalize = new Bunifu.Framework.UI.BunifuImageButton();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.lblStoreName = new System.Windows.Forms.Label();
            this.imgStoreImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.timHide = new System.Windows.Forms.Timer(this.components);
            this.pnlTaskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnUserLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCodeLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPinLogin)).BeginInit();
            this.pnlVendstorSplash.SuspendLayout();
            this.pnlSoftName.SuspendLayout();
            this.pnlSoftView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStoreImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // dgMain
            // 
            this.dgMain.Fixed = true;
            this.dgMain.Horizontal = true;
            this.dgMain.TargetControl = this;
            this.dgMain.Vertical = true;
            // 
            // pnlLoginOptions
            // 
            this.pnlLoginOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginOptions.Location = new System.Drawing.Point(301, 189);
            this.pnlLoginOptions.Name = "pnlLoginOptions";
            this.pnlLoginOptions.Size = new System.Drawing.Size(543, 378);
            this.pnlLoginOptions.TabIndex = 1;
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(150)))), ((int)(((byte)(82)))));
            this.pnlTaskbar.Controls.Add(this.btnLogoutStore);
            this.pnlTaskbar.Controls.Add(this.imgbtnForceUpdate);
            this.pnlTaskbar.Controls.Add(this.lblCurrentTime);
            this.pnlTaskbar.Controls.Add(this.imgbtnUserLogin);
            this.pnlTaskbar.Controls.Add(this.imgbtnCodeLogin);
            this.pnlTaskbar.Controls.Add(this.imgbtn_Exit);
            this.pnlTaskbar.Controls.Add(this.imgbtnPinLogin);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTaskbar.Location = new System.Drawing.Point(0, 635);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(1145, 49);
            this.pnlTaskbar.TabIndex = 2;
            // 
            // btnLogoutStore
            // 
            this.btnLogoutStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutStore.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutStore.Image = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnLogoutStore.ImageActive = null;
            this.btnLogoutStore.Location = new System.Drawing.Point(1033, 13);
            this.btnLogoutStore.Name = "btnLogoutStore";
            this.btnLogoutStore.Size = new System.Drawing.Size(25, 25);
            this.btnLogoutStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogoutStore.TabIndex = 94;
            this.btnLogoutStore.TabStop = false;
            this.btnLogoutStore.Zoom = 10;
            this.btnLogoutStore.Click += new System.EventHandler(this.ImgbtnLogoutStore_Click);
            // 
            // imgbtnForceUpdate
            // 
            this.imgbtnForceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnForceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnForceUpdate.Image = global::Vendstor.Properties.Resources.update_filled_w;
            this.imgbtnForceUpdate.ImageActive = null;
            this.imgbtnForceUpdate.Location = new System.Drawing.Point(1064, 13);
            this.imgbtnForceUpdate.Name = "imgbtnForceUpdate";
            this.imgbtnForceUpdate.Size = new System.Drawing.Size(25, 25);
            this.imgbtnForceUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnForceUpdate.TabIndex = 93;
            this.imgbtnForceUpdate.TabStop = false;
            this.imgbtnForceUpdate.Zoom = 10;
            this.imgbtnForceUpdate.Click += new System.EventHandler(this.ImgbtnForceUpdate_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.Font = new System.Drawing.Font("Poppins ExtraLight", 11F);
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(548, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(45, 26);
            this.lblCurrentTime.TabIndex = 11;
            this.lblCurrentTime.Text = "Beta";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgbtnUserLogin
            // 
            this.imgbtnUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnUserLogin.Image = global::Vendstor.Properties.Resources.userL_w;
            this.imgbtnUserLogin.ImageActive = null;
            this.imgbtnUserLogin.Location = new System.Drawing.Point(87, 12);
            this.imgbtnUserLogin.Name = "imgbtnUserLogin";
            this.imgbtnUserLogin.Size = new System.Drawing.Size(25, 25);
            this.imgbtnUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnUserLogin.TabIndex = 11;
            this.imgbtnUserLogin.TabStop = false;
            this.imgbtnUserLogin.Zoom = 10;
            this.imgbtnUserLogin.Click += new System.EventHandler(this.ImgbtnUserLogin_Click);
            // 
            // imgbtnCodeLogin
            // 
            this.imgbtnCodeLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCodeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnCodeLogin.Image = global::Vendstor.Properties.Resources.qrCode_w;
            this.imgbtnCodeLogin.ImageActive = null;
            this.imgbtnCodeLogin.Location = new System.Drawing.Point(56, 13);
            this.imgbtnCodeLogin.Name = "imgbtnCodeLogin";
            this.imgbtnCodeLogin.Size = new System.Drawing.Size(25, 25);
            this.imgbtnCodeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCodeLogin.TabIndex = 11;
            this.imgbtnCodeLogin.TabStop = false;
            this.imgbtnCodeLogin.Zoom = 10;
            this.imgbtnCodeLogin.Click += new System.EventHandler(this.ImgbtnCodeLogin_Click);
            // 
            // imgbtn_Exit
            // 
            this.imgbtn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_Exit.Image = global::Vendstor.Properties.Resources.exit_w;
            this.imgbtn_Exit.ImageActive = null;
            this.imgbtn_Exit.Location = new System.Drawing.Point(1095, 13);
            this.imgbtn_Exit.Name = "imgbtn_Exit";
            this.imgbtn_Exit.Size = new System.Drawing.Size(25, 25);
            this.imgbtn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_Exit.TabIndex = 11;
            this.imgbtn_Exit.TabStop = false;
            this.imgbtn_Exit.Zoom = 10;
            this.imgbtn_Exit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // imgbtnPinLogin
            // 
            this.imgbtnPinLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnPinLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnPinLogin.Image = global::Vendstor.Properties.Resources.PIN_w;
            this.imgbtnPinLogin.ImageActive = null;
            this.imgbtnPinLogin.Location = new System.Drawing.Point(25, 13);
            this.imgbtnPinLogin.Name = "imgbtnPinLogin";
            this.imgbtnPinLogin.Size = new System.Drawing.Size(25, 25);
            this.imgbtnPinLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnPinLogin.TabIndex = 11;
            this.imgbtnPinLogin.TabStop = false;
            this.imgbtnPinLogin.Zoom = 10;
            this.imgbtnPinLogin.Click += new System.EventHandler(this.ImgbtnPinLogin_Click);
            // 
            // lblSoftName
            // 
            this.lblSoftName.AutoSize = true;
            this.lblSoftName.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftName.Font = new System.Drawing.Font("Product Sans", 18F);
            this.lblSoftName.ForeColor = System.Drawing.Color.White;
            this.lblSoftName.Location = new System.Drawing.Point(13, 2);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(109, 30);
            this.lblSoftName.TabIndex = 9;
            this.lblSoftName.Text = "Vendstor";
            // 
            // lblSoftRelease
            // 
            this.lblSoftRelease.AutoSize = true;
            this.lblSoftRelease.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftRelease.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftRelease.ForeColor = System.Drawing.Color.White;
            this.lblSoftRelease.Location = new System.Drawing.Point(133, 8);
            this.lblSoftRelease.Name = "lblSoftRelease";
            this.lblSoftRelease.Size = new System.Drawing.Size(44, 19);
            this.lblSoftRelease.TabIndex = 10;
            this.lblSoftRelease.Text = "Beta";
            // 
            // lblSoft_Copyright
            // 
            this.lblSoft_Copyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSoft_Copyright.AutoSize = true;
            this.lblSoft_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Copyright.Font = new System.Drawing.Font("Product Sans", 9.5F);
            this.lblSoft_Copyright.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Copyright.Location = new System.Drawing.Point(443, 605);
            this.lblSoft_Copyright.Name = "lblSoft_Copyright";
            this.lblSoft_Copyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSoft_Copyright.Size = new System.Drawing.Size(259, 17);
            this.lblSoft_Copyright.TabIndex = 20;
            this.lblSoft_Copyright.Text = "Copyright © 2018 RigleSoft™ Franz Nkemaka";
            this.lblSoft_Copyright.Visible = false;
            // 
            // timLoadingSplash
            // 
            this.timLoadingSplash.Tick += new System.EventHandler(this.TimVendstorSplash_Tick);
            // 
            // pnlVendstorSplash
            // 
            this.pnlVendstorSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVendstorSplash.Controls.Add(this.cpgb_VendstorSplash);
            this.pnlVendstorSplash.Controls.Add(this.lblSlogan);
            this.pnlVendstorSplash.Controls.Add(this.text_SoftRelease);
            this.pnlVendstorSplash.Controls.Add(this.text_SoftName);
            this.pnlVendstorSplash.Location = new System.Drawing.Point(276, 99);
            this.pnlVendstorSplash.Name = "pnlVendstorSplash";
            this.pnlVendstorSplash.Size = new System.Drawing.Size(592, 486);
            this.pnlVendstorSplash.TabIndex = 21;
            this.pnlVendstorSplash.Visible = false;
            // 
            // cpgb_VendstorSplash
            // 
            this.cpgb_VendstorSplash.animated = true;
            this.cpgb_VendstorSplash.animationIterval = 5;
            this.cpgb_VendstorSplash.animationSpeed = 10;
            this.cpgb_VendstorSplash.BackColor = System.Drawing.Color.Transparent;
            this.cpgb_VendstorSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgb_VendstorSplash.BackgroundImage")));
            this.cpgb_VendstorSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgb_VendstorSplash.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpgb_VendstorSplash.LabelVisible = false;
            this.cpgb_VendstorSplash.LineProgressThickness = 2;
            this.cpgb_VendstorSplash.LineThickness = 2;
            this.cpgb_VendstorSplash.Location = new System.Drawing.Point(267, 256);
            this.cpgb_VendstorSplash.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgb_VendstorSplash.MaxValue = 100;
            this.cpgb_VendstorSplash.Name = "cpgb_VendstorSplash";
            this.cpgb_VendstorSplash.ProgressBackColor = System.Drawing.Color.Transparent;
            this.cpgb_VendstorSplash.ProgressColor = System.Drawing.Color.White;
            this.cpgb_VendstorSplash.Size = new System.Drawing.Size(65, 65);
            this.cpgb_VendstorSplash.TabIndex = 11;
            this.cpgb_VendstorSplash.Value = 1;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Poppins ExtraLight", 11F);
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(181, 227);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(222, 26);
            this.lblSlogan.TabIndex = 10;
            this.lblSlogan.Text = "Bringing Simple to your Store!";
            // 
            // text_SoftRelease
            // 
            this.text_SoftRelease.AutoSize = true;
            this.text_SoftRelease.BackColor = System.Drawing.Color.Transparent;
            this.text_SoftRelease.Font = new System.Drawing.Font("Champagne & Limousines", 24F);
            this.text_SoftRelease.ForeColor = System.Drawing.Color.White;
            this.text_SoftRelease.Location = new System.Drawing.Point(365, 184);
            this.text_SoftRelease.Name = "text_SoftRelease";
            this.text_SoftRelease.Size = new System.Drawing.Size(73, 32);
            this.text_SoftRelease.TabIndex = 2;
            this.text_SoftRelease.Text = "Beta";
            // 
            // text_SoftName
            // 
            this.text_SoftName.AutoSize = true;
            this.text_SoftName.BackColor = System.Drawing.Color.Transparent;
            this.text_SoftName.Font = new System.Drawing.Font("Product Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SoftName.ForeColor = System.Drawing.Color.White;
            this.text_SoftName.Location = new System.Drawing.Point(155, 166);
            this.text_SoftName.Name = "text_SoftName";
            this.text_SoftName.Size = new System.Drawing.Size(218, 61);
            this.text_SoftName.TabIndex = 3;
            this.text_SoftName.Text = "Vendstor";
            // 
            // pnlSoftName
            // 
            this.pnlSoftName.Controls.Add(this.lblSoftName);
            this.pnlSoftName.Controls.Add(this.lblSoftRelease);
            this.pnlSoftName.Location = new System.Drawing.Point(6, 9);
            this.pnlSoftName.Name = "pnlSoftName";
            this.pnlSoftName.Size = new System.Drawing.Size(181, 38);
            this.pnlSoftName.TabIndex = 22;
            // 
            // pnlSoftView
            // 
            this.pnlSoftView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSoftView.Controls.Add(this.imgbtnMaximize);
            this.pnlSoftView.Controls.Add(this.imgbtnMinimize);
            this.pnlSoftView.Controls.Add(this.imgbtnNormalize);
            this.pnlSoftView.Location = new System.Drawing.Point(1053, 10);
            this.pnlSoftView.Name = "pnlSoftView";
            this.pnlSoftView.Size = new System.Drawing.Size(80, 24);
            this.pnlSoftView.TabIndex = 23;
            // 
            // imgbtnMaximize
            // 
            this.imgbtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnMaximize.Image = global::Vendstor.Properties.Resources.full_screen_w;
            this.imgbtnMaximize.ImageActive = null;
            this.imgbtnMaximize.Location = new System.Drawing.Point(55, 3);
            this.imgbtnMaximize.Name = "imgbtnMaximize";
            this.imgbtnMaximize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMaximize.TabIndex = 4;
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
            this.imgbtnMinimize.Location = new System.Drawing.Point(13, 3);
            this.imgbtnMinimize.Name = "imgbtnMinimize";
            this.imgbtnMinimize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnMinimize.TabIndex = 5;
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
            this.imgbtnNormalize.Location = new System.Drawing.Point(34, 3);
            this.imgbtnNormalize.Name = "imgbtnNormalize";
            this.imgbtnNormalize.Size = new System.Drawing.Size(15, 15);
            this.imgbtnNormalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnNormalize.TabIndex = 6;
            this.imgbtnNormalize.TabStop = false;
            this.imgbtnNormalize.Zoom = 10;
            this.imgbtnNormalize.Click += new System.EventHandler(this.ImgbtnNormalize_Click);
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Interval = 30000;
            this.timTime.Tick += new System.EventHandler(this.TimTime_Tick);
            // 
            // lblStoreName
            // 
            this.lblStoreName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(503, 145);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(138, 35);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "_StoreName";
            this.lblStoreName.Visible = false;
            // 
            // imgStoreImage
            // 
            this.imgStoreImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgStoreImage.BackColor = System.Drawing.Color.Transparent;
            this.imgStoreImage.Image = global::Vendstor.Properties.Resources.logo_app;
            this.imgStoreImage.ImageActive = null;
            this.imgStoreImage.Location = new System.Drawing.Point(515, 38);
            this.imgStoreImage.Name = "imgStoreImage";
            this.imgStoreImage.Size = new System.Drawing.Size(115, 93);
            this.imgStoreImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStoreImage.TabIndex = 0;
            this.imgStoreImage.TabStop = false;
            this.imgStoreImage.Visible = false;
            this.imgStoreImage.Zoom = 10;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1145, 684);
            this.Controls.Add(this.pnlVendstorSplash);
            this.Controls.Add(this.imgStoreImage);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.pnlSoftName);
            this.Controls.Add(this.lblSoft_Copyright);
            this.Controls.Add(this.pnlTaskbar);
            this.Controls.Add(this.pnlLoginOptions);
            this.Controls.Add(this.pnlSoftView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Account Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlTaskbar.ResumeLayout(false);
            this.pnlTaskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnUserLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCodeLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPinLogin)).EndInit();
            this.pnlVendstorSplash.ResumeLayout(false);
            this.pnlVendstorSplash.PerformLayout();
            this.pnlSoftName.ResumeLayout(false);
            this.pnlSoftName.PerformLayout();
            this.pnlSoftView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnNormalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStoreImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl dgMain;
        private System.Windows.Forms.Panel pnlTaskbar;
        private System.Windows.Forms.Panel pnlLoginOptions;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnNormalize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnMaximize;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.Label lblSoftRelease;
        private System.Windows.Forms.Label lblSoft_Copyright;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnPinLogin;
        private Bunifu.Framework.UI.BunifuImageButton imgbtn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnUserLogin;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCodeLogin;
        private System.Windows.Forms.Timer timLoadingSplash;
        private System.Windows.Forms.Panel pnlVendstorSplash;
        private System.Windows.Forms.Label text_SoftRelease;
        private System.Windows.Forms.Label text_SoftName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel pnlSoftView;
        private System.Windows.Forms.Panel pnlSoftName;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgb_VendstorSplash;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timTime;
        private Bunifu.Framework.UI.BunifuImageButton imgStoreImage;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Timer timHide;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnForceUpdate;
        private Bunifu.Framework.UI.BunifuImageButton btnLogoutStore;
    }
}