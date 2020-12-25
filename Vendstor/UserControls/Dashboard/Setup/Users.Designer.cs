namespace Vendstor.UserControls.Dashboard.Setup
{
    partial class Users
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
            this.UsersGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.imgbtnForceUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersGrid
            // 
            this.UsersGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsersGrid.Location = new System.Drawing.Point(3, 99);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.Size = new System.Drawing.Size(1122, 484);
            this.UsersGrid.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.imgbtnForceUpdate);
            this.pnlHeader.Controls.Add(this.lblHint);
            this.pnlHeader.Controls.Add(this.btnAddUser);
            this.pnlHeader.Location = new System.Drawing.Point(3, 17);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1122, 56);
            this.pnlHeader.TabIndex = 134;
            // 
            // imgbtnForceUpdate
            // 
            this.imgbtnForceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnForceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnForceUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnForceUpdate.Image = global::Vendstor.Properties.Resources.update_filled_w;
            this.imgbtnForceUpdate.ImageActive = null;
            this.imgbtnForceUpdate.Location = new System.Drawing.Point(14, 18);
            this.imgbtnForceUpdate.Name = "imgbtnForceUpdate";
            this.imgbtnForceUpdate.Size = new System.Drawing.Size(20, 20);
            this.imgbtnForceUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnForceUpdate.TabIndex = 211;
            this.imgbtnForceUpdate.TabStop = false;
            this.imgbtnForceUpdate.Zoom = 10;
            this.imgbtnForceUpdate.Click += new System.EventHandler(this.ImgbtnForceUpdate_Click);
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Silver;
            this.lblHint.Location = new System.Drawing.Point(40, 16);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(218, 25);
            this.lblHint.TabIndex = 171;
            this.lblHint.Text = "Manage users and their sales.";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 5;
            this.btnAddUser.ButtonText = "Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = global::Vendstor.Properties.Resources.add_user_filled_w;
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 45D;
            this.btnAddUser.IsTab = false;
            this.btnAddUser.Location = new System.Drawing.Point(859, 8);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(233, 40);
            this.btnAddUser.TabIndex = 133;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Textcolor = System.Drawing.Color.White;
            this.btnAddUser.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.UsersGrid);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1138, 607);
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnForceUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UsersGrid;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnForceUpdate;
    }
}
