namespace Vendstor.Forms.Customers
{
    partial class CustomerGroup
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
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtGroupName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_GroupName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAction
            // 
            this.btnAction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.BorderRadius = 5;
            this.btnAction.ButtonText = "Add Group";
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.DisabledColor = System.Drawing.Color.Gray;
            this.btnAction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAction.Iconimage = global::Vendstor.Properties.Resources.group_filled_w;
            this.btnAction.Iconimage_right = null;
            this.btnAction.Iconimage_right_Selected = null;
            this.btnAction.Iconimage_Selected = null;
            this.btnAction.IconMarginLeft = 0;
            this.btnAction.IconMarginRight = 0;
            this.btnAction.IconRightVisible = true;
            this.btnAction.IconRightZoom = 0D;
            this.btnAction.IconVisible = true;
            this.btnAction.IconZoom = 40D;
            this.btnAction.IsTab = false;
            this.btnAction.Location = new System.Drawing.Point(289, 202);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAction.selected = false;
            this.btnAction.Size = new System.Drawing.Size(155, 40);
            this.btnAction.TabIndex = 220;
            this.btnAction.Text = "Add Group";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAction.Textcolor = System.Drawing.Color.White;
            this.btnAction.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.AutoScroll = true;
            this.txtGroupName.AutoSize = true;
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtGroupName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtGroupName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtGroupName.BorderThickness = 2;
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtGroupName.ForeColor = System.Drawing.Color.DimGray;
            this.txtGroupName.isPassword = false;
            this.txtGroupName.Location = new System.Drawing.Point(49, 130);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(401, 43);
            this.txtGroupName.TabIndex = 219;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_GroupName
            // 
            this.text_GroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_GroupName.AutoSize = true;
            this.text_GroupName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_GroupName.Location = new System.Drawing.Point(38, 88);
            this.text_GroupName.Name = "text_GroupName";
            this.text_GroupName.Size = new System.Drawing.Size(106, 26);
            this.text_GroupName.TabIndex = 218;
            this.text_GroupName.Text = "Group Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 13F);
            this.lblTitle.Location = new System.Drawing.Point(18, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 32);
            this.lblTitle.TabIndex = 217;
            this.lblTitle.Text = "Group";
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(451, 25);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 216;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // CustomerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 276);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.text_GroupName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgbtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Customer  Group  ";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuFlatButton btnAction;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGroupName;
        private System.Windows.Forms.Label text_GroupName;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}