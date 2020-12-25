namespace Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.hSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.text_Products = new System.Windows.Forms.Label();
            this.lblSoftName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoftwareId = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUninstall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInstall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLaunch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgSoftImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.cpgbStatus = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoftImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = null;
            this.DragControl.Vertical = true;
            // 
            // hSeperator
            // 
            this.hSeperator.BackColor = System.Drawing.Color.Transparent;
            this.hSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.hSeperator.LineThickness = 2;
            this.hSeperator.Location = new System.Drawing.Point(2, 82);
            this.hSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.hSeperator.Name = "hSeperator";
            this.hSeperator.Size = new System.Drawing.Size(768, 12);
            this.hSeperator.TabIndex = 76;
            this.hSeperator.Transparency = 255;
            this.hSeperator.Vertical = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Product Sans", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 34);
            this.lblTitle.TabIndex = 77;
            this.lblTitle.Text = "Vendstor Installer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_Products
            // 
            this.text_Products.AutoSize = true;
            this.text_Products.Font = new System.Drawing.Font("Poppins", 13F);
            this.text_Products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Products.Location = new System.Drawing.Point(22, 55);
            this.text_Products.Name = "text_Products";
            this.text_Products.Size = new System.Drawing.Size(95, 32);
            this.text_Products.TabIndex = 78;
            this.text_Products.Text = "Products";
            // 
            // lblSoftName
            // 
            this.lblSoftName.AutoSize = true;
            this.lblSoftName.Font = new System.Drawing.Font("Poppins", 15F);
            this.lblSoftName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoftName.Location = new System.Drawing.Point(107, 115);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(155, 35);
            this.lblSoftName.TabIndex = 81;
            this.lblSoftName.Text = "Vendstor Beta";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVersion.Location = new System.Drawing.Point(108, 150);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(34, 25);
            this.lblVersion.TabIndex = 82;
            this.lblVersion.Text = "N.A";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(108, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(456, 75);
            this.lblDescription.TabIndex = 83;
            this.lblDescription.Text = "A Point Of Sale Software With Simplicity and Mobility";
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuild.Location = new System.Drawing.Point(168, 150);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(46, 25);
            this.lblBuild.TabIndex = 88;
            this.lblBuild.Text = "#N.A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(23, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Released At : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(93, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 90;
            this.label6.Text = "Id :  ";
            // 
            // lblSoftwareId
            // 
            this.lblSoftwareId.AutoSize = true;
            this.lblSoftwareId.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblSoftwareId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoftwareId.Location = new System.Drawing.Point(138, 259);
            this.lblSoftwareId.Name = "lblSoftwareId";
            this.lblSoftwareId.Size = new System.Drawing.Size(83, 25);
            this.lblSoftwareId.TabIndex = 91;
            this.lblSoftwareId.Text = "Undefined";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReleaseDate.Location = new System.Drawing.Point(138, 295);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(83, 25);
            this.lblReleaseDate.TabIndex = 92;
            this.lblReleaseDate.Text = "Undefined";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Installer.Properties.Resources.close_w;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(768, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 94;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Installer.Properties.Resources.minimize_w;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(742, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 93;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUninstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUninstall.BorderRadius = 5;
            this.btnUninstall.ButtonText = "Uninstall";
            this.btnUninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUninstall.DisabledColor = System.Drawing.Color.Gray;
            this.btnUninstall.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUninstall.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUninstall.Iconimage")));
            this.btnUninstall.Iconimage_right = null;
            this.btnUninstall.Iconimage_right_Selected = null;
            this.btnUninstall.Iconimage_Selected = null;
            this.btnUninstall.IconMarginLeft = 10;
            this.btnUninstall.IconMarginRight = 0;
            this.btnUninstall.IconRightVisible = true;
            this.btnUninstall.IconRightZoom = 0D;
            this.btnUninstall.IconVisible = false;
            this.btnUninstall.IconZoom = 30D;
            this.btnUninstall.IsTab = false;
            this.btnUninstall.Location = new System.Drawing.Point(525, 295);
            this.btnUninstall.Margin = new System.Windows.Forms.Padding(4);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUninstall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUninstall.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUninstall.selected = false;
            this.btnUninstall.Size = new System.Drawing.Size(124, 40);
            this.btnUninstall.TabIndex = 87;
            this.btnUninstall.Tag = "Uninstall";
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUninstall.Textcolor = System.Drawing.Color.White;
            this.btnUninstall.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnUninstall.Visible = false;
            this.btnUninstall.Click += new System.EventHandler(this.BtnUninstall_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstall.BorderRadius = 5;
            this.btnInstall.ButtonText = "Install";
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.DisabledColor = System.Drawing.Color.Gray;
            this.btnInstall.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInstall.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInstall.Iconimage")));
            this.btnInstall.Iconimage_right = null;
            this.btnInstall.Iconimage_right_Selected = null;
            this.btnInstall.Iconimage_Selected = null;
            this.btnInstall.IconMarginLeft = 10;
            this.btnInstall.IconMarginRight = 0;
            this.btnInstall.IconRightVisible = true;
            this.btnInstall.IconRightZoom = 0D;
            this.btnInstall.IconVisible = false;
            this.btnInstall.IconZoom = 30D;
            this.btnInstall.IsTab = false;
            this.btnInstall.Location = new System.Drawing.Point(470, 350);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnInstall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnInstall.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInstall.selected = false;
            this.btnInstall.Size = new System.Drawing.Size(124, 40);
            this.btnInstall.TabIndex = 86;
            this.btnInstall.Tag = "Install";
            this.btnInstall.Text = "Install";
            this.btnInstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInstall.Textcolor = System.Drawing.Color.White;
            this.btnInstall.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnInstall.Visible = false;
            this.btnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaunch.BorderRadius = 5;
            this.btnLaunch.ButtonText = "Launch";
            this.btnLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaunch.DisabledColor = System.Drawing.Color.Gray;
            this.btnLaunch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLaunch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Iconimage")));
            this.btnLaunch.Iconimage_right = null;
            this.btnLaunch.Iconimage_right_Selected = null;
            this.btnLaunch.Iconimage_Selected = null;
            this.btnLaunch.IconMarginLeft = 10;
            this.btnLaunch.IconMarginRight = 0;
            this.btnLaunch.IconRightVisible = true;
            this.btnLaunch.IconRightZoom = 0D;
            this.btnLaunch.IconVisible = false;
            this.btnLaunch.IconZoom = 30D;
            this.btnLaunch.IsTab = false;
            this.btnLaunch.Location = new System.Drawing.Point(206, 350);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnLaunch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnLaunch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLaunch.selected = false;
            this.btnLaunch.Size = new System.Drawing.Size(124, 40);
            this.btnLaunch.TabIndex = 85;
            this.btnLaunch.Tag = "Launch";
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLaunch.Textcolor = System.Drawing.Color.White;
            this.btnLaunch.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnLaunch.Visible = false;
            this.btnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 10;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = false;
            this.btnUpdate.IconZoom = 30D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(338, 350);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(124, 40);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Tag = "Update";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // imgSoftImage
            // 
            this.imgSoftImage.BackColor = System.Drawing.Color.Transparent;
            this.imgSoftImage.Image = global::Installer.Properties.Resources.Vendstor_big_img;
            this.imgSoftImage.ImageActive = null;
            this.imgSoftImage.Location = new System.Drawing.Point(28, 115);
            this.imgSoftImage.Name = "imgSoftImage";
            this.imgSoftImage.Size = new System.Drawing.Size(63, 42);
            this.imgSoftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSoftImage.TabIndex = 80;
            this.imgSoftImage.TabStop = false;
            this.imgSoftImage.Zoom = 10;
            // 
            // cpgbStatus
            // 
            this.cpgbStatus.animated = true;
            this.cpgbStatus.animationIterval = 5;
            this.cpgbStatus.animationSpeed = 1;
            this.cpgbStatus.BackColor = System.Drawing.Color.White;
            this.cpgbStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgbStatus.BackgroundImage")));
            this.cpgbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cpgbStatus.LabelVisible = false;
            this.cpgbStatus.LineProgressThickness = 2;
            this.cpgbStatus.LineThickness = 1;
            this.cpgbStatus.Location = new System.Drawing.Point(710, 90);
            this.cpgbStatus.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgbStatus.MaxValue = 100;
            this.cpgbStatus.Name = "cpgbStatus";
            this.cpgbStatus.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpgbStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cpgbStatus.Size = new System.Drawing.Size(60, 60);
            this.cpgbStatus.TabIndex = 95;
            this.cpgbStatus.Value = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpgbStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblSoftwareId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSoftName);
            this.Controls.Add(this.imgSoftImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.hSeperator);
            this.Controls.Add(this.text_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor Installer";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoftImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuSeparator hSeperator;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label text_Products;
        private Bunifu.Framework.UI.BunifuImageButton imgSoftImage;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.Label lblDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnLaunch;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnUninstall;
        private Bunifu.Framework.UI.BunifuFlatButton btnInstall;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblSoftwareId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBuild;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgbStatus;
    }
}

