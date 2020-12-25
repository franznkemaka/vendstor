namespace Vendstor.UserControls
{
    partial class UserTab
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.imgUserImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.InsightsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlHeader.Controls.Add(this.lblSignOut);
            this.pnlHeader.Controls.Add(this.lblUserEmail);
            this.pnlHeader.Controls.Add(this.imgUserImage);
            this.pnlHeader.Controls.Add(this.lblUserRole);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(320, 167);
            this.pnlHeader.TabIndex = 42;
            // 
            // lblSignOut
            // 
            this.lblSignOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lblSignOut.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lblSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.lblSignOut.Location = new System.Drawing.Point(18, 120);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(79, 28);
            this.lblSignOut.TabIndex = 45;
            this.lblSignOut.Text = "Sign Out";
            this.lblSignOut.Click += new System.EventHandler(this.LblSignOut_Click);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblUserEmail.Font = new System.Drawing.Font("Roboto Light", 11.5F);
            this.lblUserEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblUserEmail.Location = new System.Drawing.Point(94, 73);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(155, 21);
            this.lblUserEmail.TabIndex = 44;
            this.lblUserEmail.Text = "store@vendstor.com";
            // 
            // imgUserImage
            // 
            this.imgUserImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgUserImage.BackColor = System.Drawing.Color.Transparent;
            this.imgUserImage.Image = global::Vendstor.Properties.Resources.store_defualt_icon;
            this.imgUserImage.ImageActive = null;
            this.imgUserImage.Location = new System.Drawing.Point(23, 26);
            this.imgUserImage.Name = "imgUserImage";
            this.imgUserImage.Size = new System.Drawing.Size(65, 54);
            this.imgUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserImage.TabIndex = 41;
            this.imgUserImage.TabStop = false;
            this.imgUserImage.Zoom = 10;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.lblUserRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserRole.Location = new System.Drawing.Point(94, 45);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(61, 24);
            this.lblUserRole.TabIndex = 43;
            this.lblUserRole.Text = "Admin";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Product Sans", 15F);
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(93, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 25);
            this.lblUserName.TabIndex = 42;
            this.lblUserName.Text = "Franz Nkemaka";
            // 
            // InsightsGrid
            // 
            this.InsightsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsightsGrid.Location = new System.Drawing.Point(0, 167);
            this.InsightsGrid.Name = "InsightsGrid";
            this.InsightsGrid.Size = new System.Drawing.Size(320, 447);
            this.InsightsGrid.TabIndex = 43;
            // 
            // UserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InsightsGrid);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UserTab";
            this.Size = new System.Drawing.Size(320, 614);
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Label lblUserEmail;
        private Bunifu.Framework.UI.BunifuImageButton imgUserImage;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel InsightsGrid;
    }
}
