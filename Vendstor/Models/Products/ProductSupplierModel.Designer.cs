namespace Vendstor.Models.Products
{
    partial class ProductSupplierModel
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
            this.GridSeperator_Expand = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.btnEditSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMarkupPtg = new System.Windows.Forms.Label();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // GridSeperator_Expand
            // 
            this.GridSeperator_Expand.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Expand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Expand.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Expand.LineThickness = 1;
            this.GridSeperator_Expand.Location = new System.Drawing.Point(0, 50);
            this.GridSeperator_Expand.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Expand.Name = "GridSeperator_Expand";
            this.GridSeperator_Expand.Size = new System.Drawing.Size(1045, 5);
            this.GridSeperator_Expand.TabIndex = 201;
            this.GridSeperator_Expand.Transparency = 255;
            this.GridSeperator_Expand.Vertical = false;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSupplierName.Location = new System.Drawing.Point(22, 14);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(124, 26);
            this.lblSupplierName.TabIndex = 196;
            this.lblSupplierName.Text = "_SupplierName";
            this.lblSupplierName.Click += new System.EventHandler(this.OnClick);
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblProductsCount.Location = new System.Drawing.Point(766, 13);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(50, 26);
            this.lblProductsCount.TabIndex = 197;
            this.lblProductsCount.Text = "_000";
            this.lblProductsCount.Click += new System.EventHandler(this.OnClick);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSupplier.BorderRadius = 5;
            this.btnEditSupplier.ButtonText = "";
            this.btnEditSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupplier.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditSupplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditSupplier.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.btnEditSupplier.Iconimage_right = null;
            this.btnEditSupplier.Iconimage_right_Selected = null;
            this.btnEditSupplier.Iconimage_Selected = null;
            this.btnEditSupplier.IconMarginLeft = 0;
            this.btnEditSupplier.IconMarginRight = 0;
            this.btnEditSupplier.IconRightVisible = true;
            this.btnEditSupplier.IconRightZoom = 0D;
            this.btnEditSupplier.IconVisible = true;
            this.btnEditSupplier.IconZoom = 37D;
            this.btnEditSupplier.IsTab = false;
            this.btnEditSupplier.Location = new System.Drawing.Point(939, 13);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditSupplier.selected = false;
            this.btnEditSupplier.Size = new System.Drawing.Size(30, 26);
            this.btnEditSupplier.TabIndex = 198;
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditSupplier.Textcolor = System.Drawing.Color.White;
            this.btnEditSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Click += new System.EventHandler(this.BtnEditSupplier_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewProducts.BorderRadius = 5;
            this.btnViewProducts.ButtonText = "";
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewProducts.Iconimage = global::Vendstor.Properties.Resources.details_filled_W;
            this.btnViewProducts.Iconimage_right = null;
            this.btnViewProducts.Iconimage_right_Selected = null;
            this.btnViewProducts.Iconimage_Selected = null;
            this.btnViewProducts.IconMarginLeft = 0;
            this.btnViewProducts.IconMarginRight = 0;
            this.btnViewProducts.IconRightVisible = true;
            this.btnViewProducts.IconRightZoom = 0D;
            this.btnViewProducts.IconVisible = true;
            this.btnViewProducts.IconZoom = 37D;
            this.btnViewProducts.IsTab = false;
            this.btnViewProducts.Location = new System.Drawing.Point(901, 13);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewProducts.selected = false;
            this.btnViewProducts.Size = new System.Drawing.Size(30, 26);
            this.btnViewProducts.TabIndex = 199;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProducts.Textcolor = System.Drawing.Color.White;
            this.btnViewProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.Click += new System.EventHandler(this.BtnViewProducts_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 37D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(977, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 200;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblDescription.Location = new System.Drawing.Point(249, 13);
            this.lblDescription.MaximumSize = new System.Drawing.Size(300, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(162, 26);
            this.lblDescription.TabIndex = 210;
            this.lblDescription.Text = "_SupplierDescription";
            this.lblDescription.Click += new System.EventHandler(this.OnClick);
            // 
            // lblMarkupPtg
            // 
            this.lblMarkupPtg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarkupPtg.AutoSize = true;
            this.lblMarkupPtg.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblMarkupPtg.Location = new System.Drawing.Point(578, 14);
            this.lblMarkupPtg.Name = "lblMarkupPtg";
            this.lblMarkupPtg.Size = new System.Drawing.Size(91, 26);
            this.lblMarkupPtg.TabIndex = 209;
            this.lblMarkupPtg.Text = "_Markup %";
            this.lblMarkupPtg.Click += new System.EventHandler(this.OnClick);
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(694, 13);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 204;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            this.GridTitle_Separator1.Click += new System.EventHandler(this.OnClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(545, 13);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(8, 28);
            this.bunifuSeparator1.TabIndex = 207;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            this.bunifuSeparator1.Visible = false;
            this.bunifuSeparator1.Click += new System.EventHandler(this.OnClick);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(231, 13);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(8, 28);
            this.bunifuSeparator2.TabIndex = 208;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            this.bunifuSeparator2.Visible = false;
            this.bunifuSeparator2.Click += new System.EventHandler(this.OnClick);
            // 
            // ProductSupplierModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMarkupPtg);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.GridTitle_Separator1);
            this.Controls.Add(this.GridSeperator_Expand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.lblProductsCount);
            this.Controls.Add(this.lblSupplierName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProductSupplierModel";
            this.Size = new System.Drawing.Size(1045, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Expand;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblProductsCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditSupplier;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewProducts;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMarkupPtg;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}
