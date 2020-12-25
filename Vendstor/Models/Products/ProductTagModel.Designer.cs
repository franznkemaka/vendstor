namespace Vendstor.Models.Products
{
    partial class ProductTagModel
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
            this.lblTagName = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.GridSeperator_Expand = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblTagName
            // 
            this.lblTagName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTagName.AutoSize = true;
            this.lblTagName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblTagName.Location = new System.Drawing.Point(22, 14);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(94, 26);
            this.lblTagName.TabIndex = 178;
            this.lblTagName.Text = "_TagName";
            this.lblTagName.Click += new System.EventHandler(this.OnClick);
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblProductsCount.Location = new System.Drawing.Point(697, 14);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(50, 26);
            this.lblProductsCount.TabIndex = 179;
            this.lblProductsCount.Text = "_000";
            this.lblProductsCount.Click += new System.EventHandler(this.OnClick);
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
            this.GridSeperator_Expand.TabIndex = 195;
            this.GridSeperator_Expand.Transparency = 255;
            this.GridSeperator_Expand.Vertical = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::Vendstor.Properties.Resources.delete_filled_w;
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
            this.btnDelete.Location = new System.Drawing.Point(977, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 194;
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
            this.btnViewProducts.Location = new System.Drawing.Point(901, 14);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewProducts.selected = false;
            this.btnViewProducts.Size = new System.Drawing.Size(30, 26);
            this.btnViewProducts.TabIndex = 193;
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
            this.btnEdit.Location = new System.Drawing.Point(939, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(30, 26);
            this.btnEdit.TabIndex = 192;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // ProductTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridSeperator_Expand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblProductsCount);
            this.Controls.Add(this.lblTagName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProductTag";
            this.Size = new System.Drawing.Size(1045, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.Label lblProductsCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewProducts;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Expand;
    }
}
