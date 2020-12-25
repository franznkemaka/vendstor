namespace Vendstor.Forms.Customers
{
    partial class CustomerGroups
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
            this.components = new System.ComponentModel.Container();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GroupsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridTitle = new System.Windows.Forms.Panel();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAddGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorryAlert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNoCustomers_Alert = new System.Windows.Forms.Label();
            this.lblSorry_Alert = new System.Windows.Forms.Label();
            this.btnAddGroup_Alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlGridTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorryAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // GroupsGrid
            // 
            this.GroupsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupsGrid.AutoScroll = true;
            this.GroupsGrid.BackColor = System.Drawing.Color.White;
            this.GroupsGrid.Location = new System.Drawing.Point(8, 167);
            this.GroupsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.GroupsGrid.Name = "GroupsGrid";
            this.GroupsGrid.Size = new System.Drawing.Size(1106, 443);
            this.GroupsGrid.TabIndex = 138;
            // 
            // pnlGridTitle
            // 
            this.pnlGridTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridTitle.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridTitle.Controls.Add(this.lblCustomersCount);
            this.pnlGridTitle.Controls.Add(this.lblGroupName);
            this.pnlGridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridTitle.Location = new System.Drawing.Point(8, 115);
            this.pnlGridTitle.Name = "pnlGridTitle";
            this.pnlGridTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridTitle.Size = new System.Drawing.Size(1106, 48);
            this.pnlGridTitle.TabIndex = 137;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(613, 10);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblCustomersCount.Location = new System.Drawing.Point(660, 10);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(185, 28);
            this.lblCustomersCount.TabIndex = 171;
            this.lblCustomersCount.Text = "Number of Customers";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblGroupName.Location = new System.Drawing.Point(22, 10);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(60, 28);
            this.lblGroupName.TabIndex = 169;
            this.lblGroupName.Text = "Name";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 39);
            this.lblTitle.TabIndex = 170;
            this.lblTitle.Text = "Customer Groups";
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(1092, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 217;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(13, 94);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(1101, 10);
            this.GridTitle_Separator3.TabIndex = 218;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = false;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Silver;
            this.lblHint.Location = new System.Drawing.Point(14, 58);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(304, 25);
            this.lblHint.TabIndex = 220;
            this.lblHint.Text = "Group customers for reporting and more...";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGroup.BorderRadius = 5;
            this.btnAddGroup.ButtonText = "Add Group";
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddGroup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddGroup.Iconimage = global::Vendstor.Properties.Resources.group_filled_w;
            this.btnAddGroup.Iconimage_right = null;
            this.btnAddGroup.Iconimage_right_Selected = null;
            this.btnAddGroup.Iconimage_Selected = null;
            this.btnAddGroup.IconMarginLeft = 0;
            this.btnAddGroup.IconMarginRight = 0;
            this.btnAddGroup.IconRightVisible = true;
            this.btnAddGroup.IconRightZoom = 0D;
            this.btnAddGroup.IconVisible = true;
            this.btnAddGroup.IconZoom = 45D;
            this.btnAddGroup.IsTab = false;
            this.btnAddGroup.Location = new System.Drawing.Point(932, 45);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddGroup.selected = false;
            this.btnAddGroup.Size = new System.Drawing.Size(155, 40);
            this.btnAddGroup.TabIndex = 219;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGroup.Textcolor = System.Drawing.Color.White;
            this.btnAddGroup.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddGroup.Click += new System.EventHandler(this.BtnAddGroup_Click);
            // 
            // cardEmptyData
            // 
            this.cardEmptyData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardEmptyData.BackColor = System.Drawing.Color.White;
            this.cardEmptyData.BorderRadius = 5;
            this.cardEmptyData.BottomSahddow = true;
            this.cardEmptyData.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardEmptyData.Controls.Add(this.imgSorryAlert);
            this.cardEmptyData.Controls.Add(this.seperator_Alert);
            this.cardEmptyData.Controls.Add(this.lblNoCustomers_Alert);
            this.cardEmptyData.Controls.Add(this.lblSorry_Alert);
            this.cardEmptyData.Controls.Add(this.btnAddGroup_Alert);
            this.cardEmptyData.LeftSahddow = false;
            this.cardEmptyData.Location = new System.Drawing.Point(336, 213);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(451, 286);
            this.cardEmptyData.TabIndex = 135;
            this.cardEmptyData.Visible = false;
            // 
            // imgSorryAlert
            // 
            this.imgSorryAlert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorryAlert.Image = global::Vendstor.Properties.Resources.vector_sorrygirl;
            this.imgSorryAlert.ImageActive = null;
            this.imgSorryAlert.Location = new System.Drawing.Point(166, 25);
            this.imgSorryAlert.Name = "imgSorryAlert";
            this.imgSorryAlert.Size = new System.Drawing.Size(118, 91);
            this.imgSorryAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSorryAlert.TabIndex = 182;
            this.imgSorryAlert.TabStop = false;
            this.imgSorryAlert.Zoom = 10;
            // 
            // seperator_Alert
            // 
            this.seperator_Alert.BackColor = System.Drawing.Color.Transparent;
            this.seperator_Alert.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperator_Alert.LineThickness = 1;
            this.seperator_Alert.Location = new System.Drawing.Point(190, 180);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 181;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lblNoCustomers_Alert
            // 
            this.lblNoCustomers_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoCustomers_Alert.AutoSize = true;
            this.lblNoCustomers_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblNoCustomers_Alert.Location = new System.Drawing.Point(64, 157);
            this.lblNoCustomers_Alert.Name = "lblNoCustomers_Alert";
            this.lblNoCustomers_Alert.Size = new System.Drawing.Size(323, 26);
            this.lblNoCustomers_Alert.TabIndex = 180;
            this.lblNoCustomers_Alert.Text = "You havent\'t created  any Customer Group";
            // 
            // lblSorry_Alert
            // 
            this.lblSorry_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSorry_Alert.AutoSize = true;
            this.lblSorry_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSorry_Alert.Location = new System.Drawing.Point(151, 123);
            this.lblSorry_Alert.Name = "lblSorry_Alert";
            this.lblSorry_Alert.Size = new System.Drawing.Size(94, 26);
            this.lblSorry_Alert.TabIndex = 179;
            this.lblSorry_Alert.Text = "We\'re sorry,";
            // 
            // btnAddGroup_Alert
            // 
            this.btnAddGroup_Alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddGroup_Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup_Alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGroup_Alert.BorderRadius = 5;
            this.btnAddGroup_Alert.ButtonText = "Add Group";
            this.btnAddGroup_Alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup_Alert.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddGroup_Alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddGroup_Alert.Iconimage = global::Vendstor.Properties.Resources.group_filled_w;
            this.btnAddGroup_Alert.Iconimage_right = null;
            this.btnAddGroup_Alert.Iconimage_right_Selected = null;
            this.btnAddGroup_Alert.Iconimage_Selected = null;
            this.btnAddGroup_Alert.IconMarginLeft = 0;
            this.btnAddGroup_Alert.IconMarginRight = 0;
            this.btnAddGroup_Alert.IconRightVisible = true;
            this.btnAddGroup_Alert.IconRightZoom = 0D;
            this.btnAddGroup_Alert.IconVisible = true;
            this.btnAddGroup_Alert.IconZoom = 45D;
            this.btnAddGroup_Alert.IsTab = false;
            this.btnAddGroup_Alert.Location = new System.Drawing.Point(135, 218);
            this.btnAddGroup_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGroup_Alert.Name = "btnAddGroup_Alert";
            this.btnAddGroup_Alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup_Alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddGroup_Alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddGroup_Alert.selected = false;
            this.btnAddGroup_Alert.Size = new System.Drawing.Size(180, 40);
            this.btnAddGroup_Alert.TabIndex = 172;
            this.btnAddGroup_Alert.Text = "Add Group";
            this.btnAddGroup_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGroup_Alert.Textcolor = System.Drawing.Color.White;
            this.btnAddGroup_Alert.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddGroup_Alert.Click += new System.EventHandler(this.BtnAddGroup_Click);
            // 
            // CustomerGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 621);
            this.Controls.Add(this.GroupsGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.GridTitle_Separator3);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGridTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Customer  :  Groups";
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlGridTitle.ResumeLayout(false);
            this.pnlGridTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.cardEmptyData.ResumeLayout(false);
            this.cardEmptyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorryAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        public System.Windows.Forms.FlowLayoutPanel GroupsGrid;
        private System.Windows.Forms.Panel pnlGridTitle;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddGroup;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgSorryAlert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lblNoCustomers_Alert;
        private System.Windows.Forms.Label lblSorry_Alert;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddGroup_Alert;
    }
}
