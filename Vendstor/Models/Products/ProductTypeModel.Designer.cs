namespace Vendstor.Models.Products
{
    partial class ProductTypeModel
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
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditType = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GridSeperator_Expand = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // lblTypeName
            // 
            this.lblTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblTypeName.Location = new System.Drawing.Point(22, 14);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(101, 26);
            this.lblTypeName.TabIndex = 178;
            this.lblTypeName.Text = "_TypeName";
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
            this.btnDelete.Location = new System.Drawing.Point(977, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
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
            // btnEditType
            // 
            this.btnEditType.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditType.BorderRadius = 5;
            this.btnEditType.ButtonText = "";
            this.btnEditType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditType.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditType.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditType.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.btnEditType.Iconimage_right = null;
            this.btnEditType.Iconimage_right_Selected = null;
            this.btnEditType.Iconimage_Selected = null;
            this.btnEditType.IconMarginLeft = 0;
            this.btnEditType.IconMarginRight = 0;
            this.btnEditType.IconRightVisible = true;
            this.btnEditType.IconRightZoom = 0D;
            this.btnEditType.IconVisible = true;
            this.btnEditType.IconZoom = 37D;
            this.btnEditType.IsTab = false;
            this.btnEditType.Location = new System.Drawing.Point(939, 14);
            this.btnEditType.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditType.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEditType.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditType.selected = false;
            this.btnEditType.Size = new System.Drawing.Size(30, 26);
            this.btnEditType.TabIndex = 192;
            this.btnEditType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditType.Textcolor = System.Drawing.Color.White;
            this.btnEditType.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditType.Click += new System.EventHandler(this.BtnEditType_Click);
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
            // ProductTypeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridSeperator_Expand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.lblProductsCount);
            this.Controls.Add(this.lblTypeName);
            this.Name = "ProductTypeModel";
            this.Size = new System.Drawing.Size(1045, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblProductsCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewProducts;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditType;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Expand;
    }
}
