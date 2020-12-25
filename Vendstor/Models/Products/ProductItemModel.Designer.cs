namespace Vendstor.Models.Products
{
    partial class ProductItemModel
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
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlProductColor = new System.Windows.Forms.Panel();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridSeperator_Collapse = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlProductColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.Silver;
            this.lblProductId.Location = new System.Drawing.Point(19, 31);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(117, 26);
            this.lblProductId.TabIndex = 206;
            this.lblProductId.Text = "JAAREuFSAQW";
            this.lblProductId.Click += new System.EventHandler(this.OnClick);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Poppins", 18F);
            this.lblPrice.Location = new System.Drawing.Point(290, 13);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 42);
            this.lblPrice.TabIndex = 198;
            this.lblPrice.Text = "€ 99.99";
            this.lblPrice.Click += new System.EventHandler(this.OnClick);
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProductName.Location = new System.Drawing.Point(16, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(227, 28);
            this.lblProductName.TabIndex = 190;
            this.lblProductName.Text = "Gari Coco CocoGari  JKASD";
            this.lblProductName.Click += new System.EventHandler(this.OnClick);
            // 
            // pnlProductColor
            // 
            this.pnlProductColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProductColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.pnlProductColor.Controls.Add(this.imgProductImage);
            this.pnlProductColor.Location = new System.Drawing.Point(461, 4);
            this.pnlProductColor.Name = "pnlProductColor";
            this.pnlProductColor.Size = new System.Drawing.Size(87, 53);
            this.pnlProductColor.TabIndex = 205;
            this.pnlProductColor.Click += new System.EventHandler(this.OnClick);
            // 
            // imgProductImage
            // 
            this.imgProductImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProductImage.BackColor = System.Drawing.Color.White;
            this.imgProductImage.Image = global::Vendstor.Properties.Resources.tax_filled_w;
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(1, 5);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(84, 46);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 3;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // GridSeperator_Collapse
            // 
            this.GridSeperator_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Collapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Collapse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Collapse.LineThickness = 1;
            this.GridSeperator_Collapse.Location = new System.Drawing.Point(0, 59);
            this.GridSeperator_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Collapse.Name = "GridSeperator_Collapse";
            this.GridSeperator_Collapse.Size = new System.Drawing.Size(580, 10);
            this.GridSeperator_Collapse.TabIndex = 207;
            this.GridSeperator_Collapse.Transparency = 255;
            this.GridSeperator_Collapse.Vertical = false;
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
            this.btnDelete.IconZoom = 25D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(553, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(22, 20);
            this.btnDelete.TabIndex = 216;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ProductItemModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GridSeperator_Collapse);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.pnlProductColor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProductItemModel";
            this.Size = new System.Drawing.Size(580, 69);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.pnlProductColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductId;
        private Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlProductColor;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Collapse;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}
