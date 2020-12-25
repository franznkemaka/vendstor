namespace Vendstor.Models.Customers
{
    partial class CustomerItemModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerItemModel));
            this.GridSeperator_Collapse = new Bunifu.Framework.UI.BunifuSeparator();
            this.CustomerGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCustomerTokenWithEmail = new System.Windows.Forms.Label();
            this.lblCustomerNames = new System.Windows.Forms.Label();
            this.lblStoreCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GridSeperator_Collapse
            // 
            this.GridSeperator_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Collapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Collapse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Collapse.LineThickness = 1;
            this.GridSeperator_Collapse.Location = new System.Drawing.Point(0, 65);
            this.GridSeperator_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Collapse.Name = "GridSeperator_Collapse";
            this.GridSeperator_Collapse.Size = new System.Drawing.Size(580, 4);
            this.GridSeperator_Collapse.TabIndex = 221;
            this.GridSeperator_Collapse.Transparency = 255;
            this.GridSeperator_Collapse.Vertical = false;
            this.GridSeperator_Collapse.Click += new System.EventHandler(this.OnClick);
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
            this.CustomerGroup.Location = new System.Drawing.Point(278, 3);
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.CustomerGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.CustomerGroup.selected = false;
            this.CustomerGroup.Size = new System.Drawing.Size(146, 29);
            this.CustomerGroup.TabIndex = 219;
            this.CustomerGroup.Text = "_CustomerGroup";
            this.CustomerGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerGroup.Textcolor = System.Drawing.Color.White;
            this.CustomerGroup.TextFont = new System.Drawing.Font("Poppins Light", 10F);
            this.CustomerGroup.Click += new System.EventHandler(this.OnClick);
            // 
            // lblCustomerTokenWithEmail
            // 
            this.lblCustomerTokenWithEmail.AutoSize = true;
            this.lblCustomerTokenWithEmail.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblCustomerTokenWithEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblCustomerTokenWithEmail.Location = new System.Drawing.Point(25, 38);
            this.lblCustomerTokenWithEmail.MaximumSize = new System.Drawing.Size(365, 0);
            this.lblCustomerTokenWithEmail.Name = "lblCustomerTokenWithEmail";
            this.lblCustomerTokenWithEmail.Size = new System.Drawing.Size(363, 25);
            this.lblCustomerTokenWithEmail.TabIndex = 218;
            this.lblCustomerTokenWithEmail.Text = "_CustomerToken, _ CustomerEmail@example.com";
            this.lblCustomerTokenWithEmail.Click += new System.EventHandler(this.OnClick);
            // 
            // lblCustomerNames
            // 
            this.lblCustomerNames.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.lblCustomerNames.Location = new System.Drawing.Point(25, 5);
            this.lblCustomerNames.Name = "lblCustomerNames";
            this.lblCustomerNames.Size = new System.Drawing.Size(247, 27);
            this.lblCustomerNames.TabIndex = 217;
            this.lblCustomerNames.Text = "_FirstName, _LastName";
            this.lblCustomerNames.Click += new System.EventHandler(this.OnClick);
            // 
            // lblStoreCredit
            // 
            this.lblStoreCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoreCredit.AutoSize = true;
            this.lblStoreCredit.Font = new System.Drawing.Font("Poppins", 18F);
            this.lblStoreCredit.Location = new System.Drawing.Point(448, 19);
            this.lblStoreCredit.Name = "lblStoreCredit";
            this.lblStoreCredit.Size = new System.Drawing.Size(108, 42);
            this.lblStoreCredit.TabIndex = 222;
            this.lblStoreCredit.Text = "€ 99.99";
            this.lblStoreCredit.Click += new System.EventHandler(this.OnClick);
            // 
            // CustomerItemModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblStoreCredit);
            this.Controls.Add(this.GridSeperator_Collapse);
            this.Controls.Add(this.CustomerGroup);
            this.Controls.Add(this.lblCustomerTokenWithEmail);
            this.Controls.Add(this.lblCustomerNames);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomerItemModel";
            this.Size = new System.Drawing.Size(580, 69);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Collapse;
        private Bunifu.Framework.UI.BunifuFlatButton CustomerGroup;
        private System.Windows.Forms.Label lblCustomerTokenWithEmail;
        private System.Windows.Forms.Label lblCustomerNames;
        private System.Windows.Forms.Label lblStoreCredit;
    }
}
