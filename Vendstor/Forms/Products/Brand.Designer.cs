namespace Vendstor.Forms.Products
{
    partial class Brand
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
            this.txtBrandName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_BrandName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtxtBrandDescription = new System.Windows.Forms.RichTextBox();
            this.text_Description = new System.Windows.Forms.Label();
            this.btnAction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgValidInput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidInput)).BeginInit();
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
            // txtBrandName
            // 
            this.txtBrandName.AutoScroll = true;
            this.txtBrandName.AutoSize = true;
            this.txtBrandName.BackColor = System.Drawing.Color.White;
            this.txtBrandName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtBrandName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtBrandName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtBrandName.BorderThickness = 2;
            this.txtBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrandName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtBrandName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBrandName.isPassword = false;
            this.txtBrandName.Location = new System.Drawing.Point(35, 82);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(401, 43);
            this.txtBrandName.TabIndex = 219;
            this.txtBrandName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBrandName.OnValueChanged += new System.EventHandler(this.BrandNameValueChanged);
            // 
            // text_BrandName
            // 
            this.text_BrandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_BrandName.AutoSize = true;
            this.text_BrandName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_BrandName.Location = new System.Drawing.Point(30, 50);
            this.text_BrandName.Name = "text_BrandName";
            this.text_BrandName.Size = new System.Drawing.Size(103, 26);
            this.text_BrandName.TabIndex = 218;
            this.text_BrandName.Text = "Brand Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 13F);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 32);
            this.lblTitle.TabIndex = 217;
            this.lblTitle.Text = " Brand";
            // 
            // rtxtBrandDescription
            // 
            this.rtxtBrandDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.rtxtBrandDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBrandDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.rtxtBrandDescription.Location = new System.Drawing.Point(35, 169);
            this.rtxtBrandDescription.Name = "rtxtBrandDescription";
            this.rtxtBrandDescription.Size = new System.Drawing.Size(401, 111);
            this.rtxtBrandDescription.TabIndex = 221;
            this.rtxtBrandDescription.Text = "";
            // 
            // text_Description
            // 
            this.text_Description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Description.AutoSize = true;
            this.text_Description.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Description.Location = new System.Drawing.Point(30, 139);
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(98, 26);
            this.text_Description.TabIndex = 222;
            this.text_Description.Text = "Description ";
            // 
            // btnAction
            // 
            this.btnAction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.BorderRadius = 5;
            this.btnAction.ButtonText = "Add Brand";
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.DisabledColor = System.Drawing.Color.Gray;
            this.btnAction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAction.Iconimage = global::Vendstor.Properties.Resources.mark_filled_w;
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
            this.btnAction.Location = new System.Drawing.Point(281, 301);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAction.selected = false;
            this.btnAction.Size = new System.Drawing.Size(155, 40);
            this.btnAction.TabIndex = 220;
            this.btnAction.Text = "Add Brand";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAction.Textcolor = System.Drawing.Color.White;
            this.btnAction.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(442, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 216;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // imgValidInput
            // 
            this.imgValidInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidInput.Location = new System.Drawing.Point(408, 87);
            this.imgValidInput.Name = "imgValidInput";
            this.imgValidInput.Size = new System.Drawing.Size(21, 31);
            this.imgValidInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidInput.TabIndex = 223;
            this.imgValidInput.TabStop = false;
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 372);
            this.Controls.Add(this.imgValidInput);
            this.Controls.Add(this.text_Description);
            this.Controls.Add(this.rtxtBrandDescription);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.text_BrandName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgbtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Brand";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuFlatButton btnAction;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBrandName;
        private System.Windows.Forms.Label text_BrandName;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.RichTextBox rtxtBrandDescription;
        private System.Windows.Forms.Label text_Description;
        private System.Windows.Forms.PictureBox imgValidInput;
    }
}