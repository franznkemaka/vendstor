namespace Vendstor.Models.Products
{
    partial class ProductBrandModel
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.GridSeperator_Expand = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblDescription.Location = new System.Drawing.Point(295, 13);
            this.lblDescription.MaximumSize = new System.Drawing.Size(300, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 26);
            this.lblDescription.TabIndex = 216;
            this.lblDescription.Text = "_Description";
            this.lblDescription.Click += new System.EventHandler(this.OnClick);
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
            this.btnDelete.Location = new System.Drawing.Point(985, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 215;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnViewProducts.Location = new System.Drawing.Point(909, 14);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewProducts.selected = false;
            this.btnViewProducts.Size = new System.Drawing.Size(30, 26);
            this.btnViewProducts.TabIndex = 214;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProducts.Textcolor = System.Drawing.Color.White;
            this.btnViewProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.Click += new System.EventHandler(this.BtnViewProducts_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.ButtonText = "";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 37D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(947, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(30, 26);
            this.btnEdit.TabIndex = 213;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblProductsCount.Location = new System.Drawing.Point(694, 13);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(50, 26);
            this.lblProductsCount.TabIndex = 212;
            this.lblProductsCount.Text = "_000";
            // 
            // lblBrandName
            // 
            this.lblBrandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblBrandName.Location = new System.Drawing.Point(30, 15);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(109, 26);
            this.lblBrandName.TabIndex = 211;
            this.lblBrandName.Text = "_BrandName";
            this.lblBrandName.Click += new System.EventHandler(this.OnClick);
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
            this.GridSeperator_Expand.TabIndex = 217;
            this.GridSeperator_Expand.Transparency = 255;
            this.GridSeperator_Expand.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(277, 12);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(8, 28);
            this.bunifuSeparator2.TabIndex = 222;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            this.bunifuSeparator2.Visible = false;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(621, 12);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 220;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // ProductBrandModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.GridTitle_Separator1);
            this.Controls.Add(this.GridSeperator_Expand);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblProductsCount);
            this.Controls.Add(this.lblBrandName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProductBrandModel";
            this.Size = new System.Drawing.Size(1045, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewProducts;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label lblBrandName;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Expand;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
    }
}
