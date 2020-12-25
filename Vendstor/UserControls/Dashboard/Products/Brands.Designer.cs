namespace Vendstor.UserControls.Dashboard.Products
{
    partial class Brands
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
            this.BrandsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridTitle = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblDescription_Grid = new System.Windows.Forms.Label();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAddBrand = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardEmptyData = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorry_Alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNoBrands_Alert = new System.Windows.Forms.Label();
            this.lblSorry_Alert = new System.Windows.Forms.Label();
            this.btnAddBrand_Alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlGridTitle.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cardEmptyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandsGrid
            // 
            this.BrandsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrandsGrid.AutoScroll = true;
            this.BrandsGrid.BackColor = System.Drawing.Color.White;
            this.BrandsGrid.Location = new System.Drawing.Point(2, 123);
            this.BrandsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BrandsGrid.Name = "BrandsGrid";
            this.BrandsGrid.Size = new System.Drawing.Size(1107, 465);
            this.BrandsGrid.TabIndex = 135;
            this.BrandsGrid.DoubleClick += new System.EventHandler(this.BrandsGrid_DoubleClick);
            // 
            // pnlGridTitle
            // 
            this.pnlGridTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridTitle.Controls.Add(this.bunifuSeparator2);
            this.pnlGridTitle.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridTitle.Controls.Add(this.lblDescription_Grid);
            this.pnlGridTitle.Controls.Add(this.lblNumberOfProducts);
            this.pnlGridTitle.Controls.Add(this.lblBrandName);
            this.pnlGridTitle.Controls.Add(this.bunifuSeparator8);
            this.pnlGridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridTitle.Location = new System.Drawing.Point(3, 70);
            this.pnlGridTitle.Name = "pnlGridTitle";
            this.pnlGridTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridTitle.Size = new System.Drawing.Size(1106, 48);
            this.pnlGridTitle.TabIndex = 134;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(269, 10);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(8, 28);
            this.bunifuSeparator2.TabIndex = 181;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            this.bunifuSeparator2.Visible = false;
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
            // lblDescription_Grid
            // 
            this.lblDescription_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription_Grid.AutoSize = true;
            this.lblDescription_Grid.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblDescription_Grid.Location = new System.Drawing.Point(287, 10);
            this.lblDescription_Grid.Name = "lblDescription_Grid";
            this.lblDescription_Grid.Size = new System.Drawing.Size(102, 28);
            this.lblDescription_Grid.TabIndex = 180;
            this.lblDescription_Grid.Text = "Description";
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblNumberOfProducts.Location = new System.Drawing.Point(660, 10);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(169, 28);
            this.lblNumberOfProducts.TabIndex = 171;
            this.lblNumberOfProducts.Text = "Number of Products";
            // 
            // lblBrandName
            // 
            this.lblBrandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblBrandName.Location = new System.Drawing.Point(22, 10);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(60, 28);
            this.lblBrandName.TabIndex = 169;
            this.lblBrandName.Text = "Name";
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
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHint);
            this.pnlHeader.Controls.Add(this.btnAddBrand);
            this.pnlHeader.Location = new System.Drawing.Point(3, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1106, 56);
            this.pnlHeader.TabIndex = 133;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Silver;
            this.lblHint.Location = new System.Drawing.Point(22, 16);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(187, 25);
            this.lblHint.TabIndex = 171;
            this.lblHint.Text = "A list of all of your Brands.";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBrand.BorderRadius = 5;
            this.btnAddBrand.ButtonText = "Add Brand";
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddBrand.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddBrand.Iconimage = global::Vendstor.Properties.Resources.mark_filled_w;
            this.btnAddBrand.Iconimage_right = null;
            this.btnAddBrand.Iconimage_right_Selected = null;
            this.btnAddBrand.Iconimage_Selected = null;
            this.btnAddBrand.IconMarginLeft = 0;
            this.btnAddBrand.IconMarginRight = 0;
            this.btnAddBrand.IconRightVisible = true;
            this.btnAddBrand.IconRightZoom = 0D;
            this.btnAddBrand.IconVisible = true;
            this.btnAddBrand.IconZoom = 45D;
            this.btnAddBrand.IsTab = false;
            this.btnAddBrand.Location = new System.Drawing.Point(859, 8);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddBrand.selected = false;
            this.btnAddBrand.Size = new System.Drawing.Size(155, 40);
            this.btnAddBrand.TabIndex = 133;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddBrand.Textcolor = System.Drawing.Color.White;
            this.btnAddBrand.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddBrand.Click += new System.EventHandler(this.BtnAddBrand_Click);
            // 
            // cardEmptyData
            // 
            this.cardEmptyData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardEmptyData.BackColor = System.Drawing.Color.White;
            this.cardEmptyData.BorderRadius = 5;
            this.cardEmptyData.BottomSahddow = true;
            this.cardEmptyData.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardEmptyData.Controls.Add(this.imgSorry_Alert);
            this.cardEmptyData.Controls.Add(this.seperator_Alert);
            this.cardEmptyData.Controls.Add(this.lblNoBrands_Alert);
            this.cardEmptyData.Controls.Add(this.lblSorry_Alert);
            this.cardEmptyData.Controls.Add(this.btnAddBrand_Alert);
            this.cardEmptyData.LeftSahddow = false;
            this.cardEmptyData.Location = new System.Drawing.Point(339, 155);
            this.cardEmptyData.Name = "cardEmptyData";
            this.cardEmptyData.RightSahddow = true;
            this.cardEmptyData.ShadowDepth = 20;
            this.cardEmptyData.Size = new System.Drawing.Size(451, 286);
            this.cardEmptyData.TabIndex = 136;
            // 
            // imgSorry_Alert
            // 
            this.imgSorry_Alert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorry_Alert.Image = global::Vendstor.Properties.Resources.vector_sorrygirl;
            this.imgSorry_Alert.ImageActive = null;
            this.imgSorry_Alert.Location = new System.Drawing.Point(166, 25);
            this.imgSorry_Alert.Name = "imgSorry_Alert";
            this.imgSorry_Alert.Size = new System.Drawing.Size(118, 91);
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
            this.seperator_Alert.Location = new System.Drawing.Point(192, 180);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 181;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lblNoBrands_Alert
            // 
            this.lblNoBrands_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoBrands_Alert.AutoSize = true;
            this.lblNoBrands_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblNoBrands_Alert.Location = new System.Drawing.Point(75, 157);
            this.lblNoBrands_Alert.Name = "lblNoBrands_Alert";
            this.lblNoBrands_Alert.Size = new System.Drawing.Size(300, 26);
            this.lblNoBrands_Alert.TabIndex = 180;
            this.lblNoBrands_Alert.Text = "You haven\'t added any product brands.";
            // 
            // lblSorry_Alert
            // 
            this.lblSorry_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSorry_Alert.AutoSize = true;
            this.lblSorry_Alert.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSorry_Alert.Location = new System.Drawing.Point(178, 123);
            this.lblSorry_Alert.Name = "lblSorry_Alert";
            this.lblSorry_Alert.Size = new System.Drawing.Size(94, 26);
            this.lblSorry_Alert.TabIndex = 179;
            this.lblSorry_Alert.Text = "We\'re sorry,";
            // 
            // btnAddBrand_Alert
            // 
            this.btnAddBrand_Alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand_Alert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBrand_Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand_Alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBrand_Alert.BorderRadius = 5;
            this.btnAddBrand_Alert.ButtonText = "Add Brand";
            this.btnAddBrand_Alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand_Alert.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddBrand_Alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddBrand_Alert.Iconimage = global::Vendstor.Properties.Resources.mark_filled_w;
            this.btnAddBrand_Alert.Iconimage_right = null;
            this.btnAddBrand_Alert.Iconimage_right_Selected = null;
            this.btnAddBrand_Alert.Iconimage_Selected = null;
            this.btnAddBrand_Alert.IconMarginLeft = 0;
            this.btnAddBrand_Alert.IconMarginRight = 0;
            this.btnAddBrand_Alert.IconRightVisible = true;
            this.btnAddBrand_Alert.IconRightZoom = 0D;
            this.btnAddBrand_Alert.IconVisible = true;
            this.btnAddBrand_Alert.IconZoom = 45D;
            this.btnAddBrand_Alert.IsTab = false;
            this.btnAddBrand_Alert.Location = new System.Drawing.Point(147, 218);
            this.btnAddBrand_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBrand_Alert.Name = "btnAddBrand_Alert";
            this.btnAddBrand_Alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand_Alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddBrand_Alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddBrand_Alert.selected = false;
            this.btnAddBrand_Alert.Size = new System.Drawing.Size(155, 40);
            this.btnAddBrand_Alert.TabIndex = 172;
            this.btnAddBrand_Alert.Text = "Add Brand";
            this.btnAddBrand_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddBrand_Alert.Textcolor = System.Drawing.Color.White;
            this.btnAddBrand_Alert.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddBrand_Alert.Click += new System.EventHandler(this.BtnAddBrand_Click);
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.BrandsGrid);
            this.Controls.Add(this.cardEmptyData);
            this.Controls.Add(this.pnlGridTitle);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Brands";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlGridTitle.ResumeLayout(false);
            this.pnlGridTitle.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardEmptyData.ResumeLayout(false);
            this.cardEmptyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel BrandsGrid;
        private System.Windows.Forms.Panel pnlGridTitle;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label lblBrandName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddBrand;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblDescription_Grid;
        private Bunifu.Framework.UI.BunifuCards cardEmptyData;
        private Bunifu.Framework.UI.BunifuImageButton imgSorry_Alert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lblNoBrands_Alert;
        private System.Windows.Forms.Label lblSorry_Alert;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddBrand_Alert;
    }
}
