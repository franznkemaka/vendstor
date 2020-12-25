namespace Vendstor.Models.Discounts
{
    partial class DiscountProductModel
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
            this.imgpnlProductImage = new System.Windows.Forms.Panel();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblDiscountPrice = new System.Windows.Forms.Label();
            this.BottomSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.imgpnlProductImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.Silver;
            this.lblProductId.Location = new System.Drawing.Point(83, 33);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(117, 26);
            this.lblProductId.TabIndex = 209;
            this.lblProductId.Text = "JAAREuFSAQW";
            // 
            // imgpnlProductImage
            // 
            this.imgpnlProductImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlProductImage.Controls.Add(this.imgProductImage);
            this.imgpnlProductImage.Location = new System.Drawing.Point(12, 6);
            this.imgpnlProductImage.Name = "imgpnlProductImage";
            this.imgpnlProductImage.Size = new System.Drawing.Size(65, 53);
            this.imgpnlProductImage.TabIndex = 208;
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.White;
            this.imgProductImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imgProductImage.Image = global::Vendstor.Properties.Resources.tax_filled_w;
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(0, 7);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(65, 46);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 3;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProductName.Location = new System.Drawing.Point(83, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(227, 28);
            this.lblProductName.TabIndex = 207;
            this.lblProductName.Text = "Gari Coco CocoGari  JKASD";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Poppins Light", 11F, System.Drawing.FontStyle.Strikeout);
            this.lblRetailPrice.ForeColor = System.Drawing.Color.Tomato;
            this.lblRetailPrice.Location = new System.Drawing.Point(646, 7);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(76, 26);
            this.lblRetailPrice.TabIndex = 210;
            this.lblRetailPrice.Text = "999.99 €";
            // 
            // lblDiscountPrice
            // 
            this.lblDiscountPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountPrice.AutoSize = true;
            this.lblDiscountPrice.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblDiscountPrice.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountPrice.Location = new System.Drawing.Point(646, 33);
            this.lblDiscountPrice.Name = "lblDiscountPrice";
            this.lblDiscountPrice.Size = new System.Drawing.Size(76, 26);
            this.lblDiscountPrice.TabIndex = 211;
            this.lblDiscountPrice.Text = "999.99 €";
            // 
            // BottomSeperator
            // 
            this.BottomSeperator.BackColor = System.Drawing.Color.Transparent;
            this.BottomSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.BottomSeperator.LineThickness = 1;
            this.BottomSeperator.Location = new System.Drawing.Point(0, 59);
            this.BottomSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.BottomSeperator.Name = "BottomSeperator";
            this.BottomSeperator.Size = new System.Drawing.Size(735, 5);
            this.BottomSeperator.TabIndex = 212;
            this.BottomSeperator.Transparency = 255;
            this.BottomSeperator.Vertical = false;
            // 
            // DiscountProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BottomSeperator);
            this.Controls.Add(this.lblDiscountPrice);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.imgpnlProductImage);
            this.Controls.Add(this.lblProductName);
            this.Name = "DiscountProductModel";
            this.Size = new System.Drawing.Size(735, 64);
            this.Load += new System.EventHandler(this.OnLoad);
            this.imgpnlProductImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Panel imgpnlProductImage;
        private Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblDiscountPrice;
        private Bunifu.Framework.UI.BunifuSeparator BottomSeperator;
    }
}
