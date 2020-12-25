namespace Vendstor.Models
{
    partial class UserModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModel));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cardProfileImage = new Bunifu.Framework.UI.BunifuCards();
            this.imgProfileImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblLastActive = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.cardUserTotalRevenue = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.text_total = new System.Windows.Forms.Label();
            this.imgpnlTotalRevenue = new System.Windows.Forms.Panel();
            this.imgTotalRevenue = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardUserDailyRevenue = new Bunifu.Framework.UI.BunifuCards();
            this.lblDailyRevenue = new System.Windows.Forms.Label();
            this.text_Today_cd = new System.Windows.Forms.Label();
            this.imgpnlDailyRevenue = new System.Windows.Forms.Panel();
            this.imgDailyRevenue = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardProfileImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfileImage)).BeginInit();
            this.cardUserTotalRevenue.SuspendLayout();
            this.imgpnlTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalRevenue)).BeginInit();
            this.cardUserDailyRevenue.SuspendLayout();
            this.imgpnlDailyRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDailyRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // cardProfileImage
            // 
            this.cardProfileImage.BackColor = System.Drawing.Color.White;
            this.cardProfileImage.BorderRadius = 5;
            this.cardProfileImage.BottomSahddow = true;
            this.cardProfileImage.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardProfileImage.Controls.Add(this.imgProfileImage);
            this.cardProfileImage.LeftSahddow = true;
            this.cardProfileImage.Location = new System.Drawing.Point(12, 12);
            this.cardProfileImage.Name = "cardProfileImage";
            this.cardProfileImage.RightSahddow = true;
            this.cardProfileImage.ShadowDepth = 20;
            this.cardProfileImage.Size = new System.Drawing.Size(100, 83);
            this.cardProfileImage.TabIndex = 194;
            // 
            // imgProfileImage
            // 
            this.imgProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("imgProfileImage.Image")));
            this.imgProfileImage.ImageActive = null;
            this.imgProfileImage.Location = new System.Drawing.Point(5, 9);
            this.imgProfileImage.Name = "imgProfileImage";
            this.imgProfileImage.Size = new System.Drawing.Size(90, 70);
            this.imgProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfileImage.TabIndex = 193;
            this.imgProfileImage.TabStop = false;
            this.imgProfileImage.Zoom = 10;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDisplayName.Font = new System.Drawing.Font("Poppins", 14F);
            this.lblDisplayName.Location = new System.Drawing.Point(118, 17);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(241, 33);
            this.lblDisplayName.TabIndex = 192;
            this.lblDisplayName.Text = "_FirstName _LastName";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserRole.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblUserRole.ForeColor = System.Drawing.Color.Silver;
            this.lblUserRole.Location = new System.Drawing.Point(119, 50);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(52, 26);
            this.lblUserRole.TabIndex = 195;
            this.lblUserRole.Text = "_role";
            // 
            // lblLastActive
            // 
            this.lblLastActive.AutoSize = true;
            this.lblLastActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLastActive.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblLastActive.ForeColor = System.Drawing.Color.Silver;
            this.lblLastActive.Location = new System.Drawing.Point(12, 98);
            this.lblLastActive.Name = "lblLastActive";
            this.lblLastActive.Size = new System.Drawing.Size(86, 26);
            this.lblLastActive.TabIndex = 196;
            this.lblLastActive.Text = "_timeago";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmailAddress.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblEmailAddress.Location = new System.Drawing.Point(186, 50);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(150, 26);
            this.lblEmailAddress.TabIndex = 198;
            this.lblEmailAddress.Text = "_email@_domain";
            // 
            // cardUserTotalRevenue
            // 
            this.cardUserTotalRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardUserTotalRevenue.BackColor = System.Drawing.Color.White;
            this.cardUserTotalRevenue.BorderRadius = 10;
            this.cardUserTotalRevenue.BottomSahddow = true;
            this.cardUserTotalRevenue.color = System.Drawing.Color.Transparent;
            this.cardUserTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.cardUserTotalRevenue.Controls.Add(this.text_total);
            this.cardUserTotalRevenue.Controls.Add(this.imgpnlTotalRevenue);
            this.cardUserTotalRevenue.LeftSahddow = true;
            this.cardUserTotalRevenue.Location = new System.Drawing.Point(240, 142);
            this.cardUserTotalRevenue.Name = "cardUserTotalRevenue";
            this.cardUserTotalRevenue.RightSahddow = true;
            this.cardUserTotalRevenue.ShadowDepth = 10;
            this.cardUserTotalRevenue.Size = new System.Drawing.Size(224, 78);
            this.cardUserTotalRevenue.TabIndex = 205;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(91, 24);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(123, 48);
            this.lblTotalRevenue.TabIndex = 2;
            this.lblTotalRevenue.Text = "€ 00,00";
            // 
            // text_total
            // 
            this.text_total.AutoSize = true;
            this.text_total.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_total.Location = new System.Drawing.Point(78, 0);
            this.text_total.Name = "text_total";
            this.text_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_total.Size = new System.Drawing.Size(98, 28);
            this.text_total.TabIndex = 1;
            this.text_total.Text = "Total Sales";
            // 
            // imgpnlTotalRevenue
            // 
            this.imgpnlTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlTotalRevenue.Controls.Add(this.imgTotalRevenue);
            this.imgpnlTotalRevenue.Location = new System.Drawing.Point(23, 18);
            this.imgpnlTotalRevenue.Name = "imgpnlTotalRevenue";
            this.imgpnlTotalRevenue.Size = new System.Drawing.Size(49, 47);
            this.imgpnlTotalRevenue.TabIndex = 8;
            // 
            // imgTotalRevenue
            // 
            this.imgTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.imgTotalRevenue.Image = global::Vendstor.Properties.Resources.money_d_w;
            this.imgTotalRevenue.ImageActive = null;
            this.imgTotalRevenue.Location = new System.Drawing.Point(7, 6);
            this.imgTotalRevenue.Name = "imgTotalRevenue";
            this.imgTotalRevenue.Size = new System.Drawing.Size(35, 35);
            this.imgTotalRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTotalRevenue.TabIndex = 3;
            this.imgTotalRevenue.TabStop = false;
            this.imgTotalRevenue.Zoom = 10;
            // 
            // cardUserDailyRevenue
            // 
            this.cardUserDailyRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardUserDailyRevenue.BackColor = System.Drawing.Color.White;
            this.cardUserDailyRevenue.BorderRadius = 10;
            this.cardUserDailyRevenue.BottomSahddow = true;
            this.cardUserDailyRevenue.color = System.Drawing.Color.Transparent;
            this.cardUserDailyRevenue.Controls.Add(this.lblDailyRevenue);
            this.cardUserDailyRevenue.Controls.Add(this.text_Today_cd);
            this.cardUserDailyRevenue.Controls.Add(this.imgpnlDailyRevenue);
            this.cardUserDailyRevenue.LeftSahddow = true;
            this.cardUserDailyRevenue.Location = new System.Drawing.Point(10, 142);
            this.cardUserDailyRevenue.Name = "cardUserDailyRevenue";
            this.cardUserDailyRevenue.RightSahddow = true;
            this.cardUserDailyRevenue.ShadowDepth = 10;
            this.cardUserDailyRevenue.Size = new System.Drawing.Size(224, 78);
            this.cardUserDailyRevenue.TabIndex = 207;
            // 
            // lblDailyRevenue
            // 
            this.lblDailyRevenue.AutoSize = true;
            this.lblDailyRevenue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblDailyRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDailyRevenue.Location = new System.Drawing.Point(78, 24);
            this.lblDailyRevenue.Name = "lblDailyRevenue";
            this.lblDailyRevenue.Size = new System.Drawing.Size(123, 48);
            this.lblDailyRevenue.TabIndex = 2;
            this.lblDailyRevenue.Text = "€ 00,00";
            // 
            // text_Today_cd
            // 
            this.text_Today_cd.AutoSize = true;
            this.text_Today_cd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Today_cd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Today_cd.Location = new System.Drawing.Point(78, 0);
            this.text_Today_cd.Name = "text_Today_cd";
            this.text_Today_cd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_Today_cd.Size = new System.Drawing.Size(108, 28);
            this.text_Today_cd.TabIndex = 1;
            this.text_Today_cd.Text = "Today Sales";
            // 
            // imgpnlDailyRevenue
            // 
            this.imgpnlDailyRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlDailyRevenue.Controls.Add(this.imgDailyRevenue);
            this.imgpnlDailyRevenue.Location = new System.Drawing.Point(23, 18);
            this.imgpnlDailyRevenue.Name = "imgpnlDailyRevenue";
            this.imgpnlDailyRevenue.Size = new System.Drawing.Size(49, 47);
            this.imgpnlDailyRevenue.TabIndex = 8;
            // 
            // imgDailyRevenue
            // 
            this.imgDailyRevenue.BackColor = System.Drawing.Color.Transparent;
            this.imgDailyRevenue.Image = global::Vendstor.Properties.Resources.money_d_w;
            this.imgDailyRevenue.ImageActive = null;
            this.imgDailyRevenue.Location = new System.Drawing.Point(7, 6);
            this.imgDailyRevenue.Name = "imgDailyRevenue";
            this.imgDailyRevenue.Size = new System.Drawing.Size(35, 35);
            this.imgDailyRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDailyRevenue.TabIndex = 3;
            this.imgDailyRevenue.TabStop = false;
            this.imgDailyRevenue.Zoom = 10;
            // 
            // UserModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardUserDailyRevenue);
            this.Controls.Add(this.cardUserTotalRevenue);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblLastActive);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.cardProfileImage);
            this.Controls.Add(this.lblDisplayName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(25, 10, 35, 10);
            this.Name = "UserModel";
            this.Size = new System.Drawing.Size(475, 238);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.cardProfileImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfileImage)).EndInit();
            this.cardUserTotalRevenue.ResumeLayout(false);
            this.cardUserTotalRevenue.PerformLayout();
            this.imgpnlTotalRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalRevenue)).EndInit();
            this.cardUserDailyRevenue.ResumeLayout(false);
            this.cardUserDailyRevenue.PerformLayout();
            this.imgpnlDailyRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgDailyRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuCards cardProfileImage;
        private Bunifu.Framework.UI.BunifuImageButton imgProfileImage;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblLastActive;
        private System.Windows.Forms.Label lblEmailAddress;
        private Bunifu.Framework.UI.BunifuCards cardUserTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label text_total;
        private System.Windows.Forms.Panel imgpnlTotalRevenue;
        private Bunifu.Framework.UI.BunifuImageButton imgTotalRevenue;
        private Bunifu.Framework.UI.BunifuCards cardUserDailyRevenue;
        private System.Windows.Forms.Label lblDailyRevenue;
        private System.Windows.Forms.Label text_Today_cd;
        private System.Windows.Forms.Panel imgpnlDailyRevenue;
        private Bunifu.Framework.UI.BunifuImageButton imgDailyRevenue;
    }
}