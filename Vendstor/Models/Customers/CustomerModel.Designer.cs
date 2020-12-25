namespace Vendstor.Models.Customers
{
    partial class CustomerModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModel));
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblAccountAmount = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblStoreCreditAmount = new System.Windows.Forms.Label();
            this.lblCustomerTokenWithEmail = new System.Windows.Forms.Label();
            this.lblCustomerNames = new System.Windows.Forms.Label();
            this.CustomerGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgbtnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridSeperator_Collapse = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(903, 20);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator3.TabIndex = 151;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = true;
            this.GridTitle_Separator3.Visible = false;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(704, 20);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator2.TabIndex = 150;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            this.GridTitle_Separator2.Visible = false;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(385, 20);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(21, 39);
            this.GridTitle_Separator1.TabIndex = 149;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // lblAccountAmount
            // 
            this.lblAccountAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccountAmount.AutoSize = true;
            this.lblAccountAmount.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblAccountAmount.Location = new System.Drawing.Point(926, 25);
            this.lblAccountAmount.Name = "lblAccountAmount";
            this.lblAccountAmount.Size = new System.Drawing.Size(65, 28);
            this.lblAccountAmount.TabIndex = 148;
            this.lblAccountAmount.Text = "@Beta";
            this.lblAccountAmount.Click += new System.EventHandler(this.OnClick);
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(407, 11);
            this.lblCustomerAddress.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(251, 56);
            this.lblCustomerAddress.TabIndex = 147;
            this.lblCustomerAddress.Text = "_Street + _Postcode + _City + _Country ";
            this.lblCustomerAddress.Click += new System.EventHandler(this.OnClick);
            // 
            // lblStoreCreditAmount
            // 
            this.lblStoreCreditAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCreditAmount.AutoSize = true;
            this.lblStoreCreditAmount.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStoreCreditAmount.Location = new System.Drawing.Point(749, 25);
            this.lblStoreCreditAmount.Name = "lblStoreCreditAmount";
            this.lblStoreCreditAmount.Size = new System.Drawing.Size(114, 28);
            this.lblStoreCreditAmount.TabIndex = 146;
            this.lblStoreCreditAmount.Text = "_StoreCredit";
            this.lblStoreCreditAmount.Click += new System.EventHandler(this.OnClick);
            // 
            // lblCustomerTokenWithEmail
            // 
            this.lblCustomerTokenWithEmail.AutoSize = true;
            this.lblCustomerTokenWithEmail.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblCustomerTokenWithEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblCustomerTokenWithEmail.Location = new System.Drawing.Point(25, 43);
            this.lblCustomerTokenWithEmail.MaximumSize = new System.Drawing.Size(365, 0);
            this.lblCustomerTokenWithEmail.Name = "lblCustomerTokenWithEmail";
            this.lblCustomerTokenWithEmail.Size = new System.Drawing.Size(363, 25);
            this.lblCustomerTokenWithEmail.TabIndex = 153;
            this.lblCustomerTokenWithEmail.Text = "_CustomerToken, _ CustomerEmail@example.com";
            this.lblCustomerTokenWithEmail.Click += new System.EventHandler(this.OnClick);
            // 
            // lblCustomerNames
            // 
            this.lblCustomerNames.AutoSize = true;
            this.lblCustomerNames.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.lblCustomerNames.Location = new System.Drawing.Point(25, 12);
            this.lblCustomerNames.MaximumSize = new System.Drawing.Size(190, 0);
            this.lblCustomerNames.Name = "lblCustomerNames";
            this.lblCustomerNames.Size = new System.Drawing.Size(174, 25);
            this.lblCustomerNames.TabIndex = 152;
            this.lblCustomerNames.Text = "_FirstName, _LastName";
            this.lblCustomerNames.Click += new System.EventHandler(this.OnClick);
            // 
            // CustomerGroup
            // 
            this.CustomerGroup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerGroup.BorderRadius = 5;
            this.CustomerGroup.ButtonText = "_CustomerGroup";
            this.CustomerGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerGroup.DisabledColor = System.Drawing.Color.Gray;
            this.CustomerGroup.Iconcolor = System.Drawing.Color.Transparent;
            this.CustomerGroup.Iconimage = ((System.Drawing.Image)(resources.GetObject("CustomerGroup.Iconimage")));
            this.CustomerGroup.Iconimage_right = null;
            this.CustomerGroup.Iconimage_right_Selected = null;
            this.CustomerGroup.Iconimage_Selected = null;
            this.CustomerGroup.IconMarginLeft = 0;
            this.CustomerGroup.IconMarginRight = 0;
            this.CustomerGroup.IconRightVisible = true;
            this.CustomerGroup.IconRightZoom = 0D;
            this.CustomerGroup.IconVisible = false;
            this.CustomerGroup.IconZoom = 90D;
            this.CustomerGroup.IsTab = false;
            this.CustomerGroup.Location = new System.Drawing.Point(231, 10);
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.CustomerGroup.selected = false;
            this.CustomerGroup.Size = new System.Drawing.Size(146, 29);
            this.CustomerGroup.TabIndex = 154;
            this.CustomerGroup.Text = "_CustomerGroup";
            this.CustomerGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerGroup.Textcolor = System.Drawing.Color.White;
            this.CustomerGroup.TextFont = new System.Drawing.Font("Poppins Light", 10F);
            // 
            // imgbtnEdit
            // 
            this.imgbtnEdit.BackColor = System.Drawing.Color.White;
            this.imgbtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnEdit.Image = global::Vendstor.Properties.Resources.edit_filled_w;
            this.imgbtnEdit.ImageActive = null;
            this.imgbtnEdit.Location = new System.Drawing.Point(1017, 30);
            this.imgbtnEdit.Name = "imgbtnEdit";
            this.imgbtnEdit.Size = new System.Drawing.Size(21, 18);
            this.imgbtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnEdit.TabIndex = 209;
            this.imgbtnEdit.TabStop = false;
            this.imgbtnEdit.Zoom = 10;
            this.imgbtnEdit.Click += new System.EventHandler(this.ImgbtnEdit_Click);
            // 
            // GridSeperator_Collapse
            // 
            this.GridSeperator_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Collapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Collapse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Collapse.LineThickness = 1;
            this.GridSeperator_Collapse.Location = new System.Drawing.Point(0, 75);
            this.GridSeperator_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Collapse.Name = "GridSeperator_Collapse";
            this.GridSeperator_Collapse.Size = new System.Drawing.Size(1066, 4);
            this.GridSeperator_Collapse.TabIndex = 210;
            this.GridSeperator_Collapse.Transparency = 255;
            this.GridSeperator_Collapse.Vertical = false;
            // 
            // CustomerModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridSeperator_Collapse);
            this.Controls.Add(this.imgbtnEdit);
            this.Controls.Add(this.CustomerGroup);
            this.Controls.Add(this.lblCustomerTokenWithEmail);
            this.Controls.Add(this.lblCustomerNames);
            this.Controls.Add(this.GridTitle_Separator3);
            this.Controls.Add(this.GridTitle_Separator2);
            this.Controls.Add(this.GridTitle_Separator1);
            this.Controls.Add(this.lblAccountAmount);
            this.Controls.Add(this.lblStoreCreditAmount);
            this.Controls.Add(this.lblCustomerAddress);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomerModel";
            this.Size = new System.Drawing.Size(1066, 79);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblAccountAmount;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblStoreCreditAmount;
        private System.Windows.Forms.Label lblCustomerTokenWithEmail;
        private System.Windows.Forms.Label lblCustomerNames;
        private Bunifu.Framework.UI.BunifuFlatButton CustomerGroup;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnEdit;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Collapse;
    }
}
