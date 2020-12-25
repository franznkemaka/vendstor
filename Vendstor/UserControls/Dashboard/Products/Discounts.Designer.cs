namespace Vendstor.UserControls.Dashboard.Products
{
    partial class Discounts
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
            this.dpdDiscountStatus = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAddDiscount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStartDate_Grid = new System.Windows.Forms.Label();
            this.lblName_Grid = new System.Windows.Forms.Label();
            this.lblEndDate_Grid = new System.Windows.Forms.Label();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.DiscountsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.cardFeatures = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorry_Alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbText_Card = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            this.cardFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).BeginInit();
            this.SuspendLayout();
            // 
            // dpdDiscountStatus
            // 
            this.dpdDiscountStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdDiscountStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdDiscountStatus.BorderRadius = 3;
            this.dpdDiscountStatus.DisabledColor = System.Drawing.Color.Gray;
            this.dpdDiscountStatus.ForeColor = System.Drawing.Color.DimGray;
            this.dpdDiscountStatus.Items = new string[0];
            this.dpdDiscountStatus.Location = new System.Drawing.Point(650, 11);
            this.dpdDiscountStatus.Margin = new System.Windows.Forms.Padding(4);
            this.dpdDiscountStatus.Name = "dpdDiscountStatus";
            this.dpdDiscountStatus.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdDiscountStatus.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdDiscountStatus.selectedIndex = -1;
            this.dpdDiscountStatus.Size = new System.Drawing.Size(208, 30);
            this.dpdDiscountStatus.TabIndex = 128;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHint);
            this.pnlHeader.Controls.Add(this.btnAddDiscount);
            this.pnlHeader.Controls.Add(this.dpdDiscountStatus);
            this.pnlHeader.Location = new System.Drawing.Point(13, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1106, 56);
            this.pnlHeader.TabIndex = 122;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Silver;
            this.lblHint.Location = new System.Drawing.Point(19, 16);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(432, 25);
            this.lblHint.TabIndex = 170;
            this.lblHint.Text = "Create Discounts and manage current and upcoming ones. ";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDiscount.BorderRadius = 5;
            this.btnAddDiscount.ButtonText = "Add Discount";
            this.btnAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiscount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDiscount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.Iconimage = global::Vendstor.Properties.Resources.discount_filled_w;
            this.btnAddDiscount.Iconimage_right = null;
            this.btnAddDiscount.Iconimage_right_Selected = null;
            this.btnAddDiscount.Iconimage_Selected = null;
            this.btnAddDiscount.IconMarginLeft = 0;
            this.btnAddDiscount.IconMarginRight = 0;
            this.btnAddDiscount.IconRightVisible = true;
            this.btnAddDiscount.IconRightZoom = 0D;
            this.btnAddDiscount.IconVisible = true;
            this.btnAddDiscount.IconZoom = 45D;
            this.btnAddDiscount.IsTab = false;
            this.btnAddDiscount.Location = new System.Drawing.Point(934, 8);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddDiscount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddDiscount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDiscount.selected = false;
            this.btnAddDiscount.Size = new System.Drawing.Size(159, 40);
            this.btnAddDiscount.TabIndex = 133;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDiscount.Textcolor = System.Drawing.Color.White;
            this.btnAddDiscount.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddDiscount.Click += new System.EventHandler(this.BtnAddDiscount_Click);
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(1189, 14);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(24, 44);
            this.bunifuSeparator8.TabIndex = 148;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // lblStartDate_Grid
            // 
            this.lblStartDate_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartDate_Grid.AutoSize = true;
            this.lblStartDate_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblStartDate_Grid.Location = new System.Drawing.Point(67, 10);
            this.lblStartDate_Grid.Name = "lblStartDate_Grid";
            this.lblStartDate_Grid.Size = new System.Drawing.Size(92, 28);
            this.lblStartDate_Grid.TabIndex = 169;
            this.lblStartDate_Grid.Text = "Start Date";
            // 
            // lblName_Grid
            // 
            this.lblName_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName_Grid.AutoSize = true;
            this.lblName_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblName_Grid.Location = new System.Drawing.Point(711, 10);
            this.lblName_Grid.Name = "lblName_Grid";
            this.lblName_Grid.Size = new System.Drawing.Size(60, 28);
            this.lblName_Grid.TabIndex = 170;
            this.lblName_Grid.Text = "Name";
            // 
            // lblEndDate_Grid
            // 
            this.lblEndDate_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndDate_Grid.AutoSize = true;
            this.lblEndDate_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblEndDate_Grid.Location = new System.Drawing.Point(387, 10);
            this.lblEndDate_Grid.Name = "lblEndDate_Grid";
            this.lblEndDate_Grid.Size = new System.Drawing.Size(83, 28);
            this.lblEndDate_Grid.TabIndex = 171;
            this.lblEndDate_Grid.Text = "End Date";
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(371, 10);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(694, 10);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator2.TabIndex = 176;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator2);
            this.pnlGridHeader.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridHeader.Controls.Add(this.lblEndDate_Grid);
            this.pnlGridHeader.Controls.Add(this.lblName_Grid);
            this.pnlGridHeader.Controls.Add(this.lblStartDate_Grid);
            this.pnlGridHeader.Controls.Add(this.bunifuSeparator8);
            this.pnlGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridHeader.Location = new System.Drawing.Point(13, 65);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridHeader.Size = new System.Drawing.Size(1106, 48);
            this.pnlGridHeader.TabIndex = 125;
            // 
            // DiscountsGrid
            // 
            this.DiscountsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiscountsGrid.AutoScroll = true;
            this.DiscountsGrid.BackColor = System.Drawing.Color.White;
            this.DiscountsGrid.Location = new System.Drawing.Point(13, 118);
            this.DiscountsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DiscountsGrid.Name = "DiscountsGrid";
            this.DiscountsGrid.Size = new System.Drawing.Size(1106, 465);
            this.DiscountsGrid.TabIndex = 126;
            this.DiscountsGrid.DoubleClick += new System.EventHandler(this.DiscountsGrid_DoubleClick);
            // 
            // cardFeatures
            // 
            this.cardFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardFeatures.BackColor = System.Drawing.Color.White;
            this.cardFeatures.BorderRadius = 5;
            this.cardFeatures.BottomSahddow = true;
            this.cardFeatures.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardFeatures.Controls.Add(this.imgSorry_Alert);
            this.cardFeatures.Controls.Add(this.seperator_Alert);
            this.cardFeatures.Controls.Add(this.lbText_Card);
            this.cardFeatures.LeftSahddow = false;
            this.cardFeatures.Location = new System.Drawing.Point(339, 155);
            this.cardFeatures.Name = "cardFeatures";
            this.cardFeatures.RightSahddow = true;
            this.cardFeatures.ShadowDepth = 20;
            this.cardFeatures.Size = new System.Drawing.Size(451, 286);
            this.cardFeatures.TabIndex = 137;
            this.cardFeatures.Visible = false;
            // 
            // imgSorry_Alert
            // 
            this.imgSorry_Alert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorry_Alert.Image = global::Vendstor.Properties.Resources.vector_features_blue;
            this.imgSorry_Alert.ImageActive = null;
            this.imgSorry_Alert.Location = new System.Drawing.Point(104, 25);
            this.imgSorry_Alert.Name = "imgSorry_Alert";
            this.imgSorry_Alert.Size = new System.Drawing.Size(242, 131);
            this.imgSorry_Alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSorry_Alert.TabIndex = 182;
            this.imgSorry_Alert.TabStop = false;
            this.imgSorry_Alert.Zoom = 10;
            // 
            // seperator_Alert
            // 
            this.seperator_Alert.BackColor = System.Drawing.Color.Transparent;
            this.seperator_Alert.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperator_Alert.LineThickness = 1;
            this.seperator_Alert.Location = new System.Drawing.Point(188, 236);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 181;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lbText_Card
            // 
            this.lbText_Card.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbText_Card.AutoSize = true;
            this.lbText_Card.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lbText_Card.Location = new System.Drawing.Point(43, 177);
            this.lbText_Card.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbText_Card.Name = "lbText_Card";
            this.lbText_Card.Size = new System.Drawing.Size(364, 52);
            this.lbText_Card.TabIndex = 180;
            this.lbText_Card.Text = "Keep an eye here for discounts that are currently happening, or ones that will ha" +
    "ppen soon.";
            this.lbText_Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Discounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.DiscountsGrid);
            this.Controls.Add(this.cardFeatures);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Discounts";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.cardFeatures.ResumeLayout(false);
            this.cardFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown dpdDiscountStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDiscount;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private System.Windows.Forms.Label lblStartDate_Grid;
        private System.Windows.Forms.Label lblName_Grid;
        private System.Windows.Forms.Label lblEndDate_Grid;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private System.Windows.Forms.Panel pnlGridHeader;
        public System.Windows.Forms.FlowLayoutPanel DiscountsGrid;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuCards cardFeatures;
        private Bunifu.Framework.UI.BunifuImageButton imgSorry_Alert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lbText_Card;
    }
}
