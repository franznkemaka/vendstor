namespace Vendstor.Models
{
    partial class ProductSellModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSellModel));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cardPrice = new Bunifu.Framework.UI.BunifuCards();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.Indicator = new System.Windows.Forms.Panel();
            this.imgBtnDiscount = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgIsBalanceRequired = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSelectProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBtnDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsBalanceRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // cardPrice
            // 
            this.cardPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cardPrice.BorderRadius = 5;
            this.cardPrice.BottomSahddow = true;
            this.cardPrice.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cardPrice.Controls.Add(this.lblProductPrice);
            this.cardPrice.LeftSahddow = false;
            this.cardPrice.Location = new System.Drawing.Point(99, 10);
            this.cardPrice.Name = "cardPrice";
            this.cardPrice.RightSahddow = true;
            this.cardPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cardPrice.ShadowDepth = 20;
            this.cardPrice.Size = new System.Drawing.Size(77, 29);
            this.cardPrice.TabIndex = 60;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductPrice.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblProductPrice.Location = new System.Drawing.Point(0, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(77, 29);
            this.lblProductPrice.TabIndex = 59;
            this.lblProductPrice.Text = "99,45 €";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductPrice.Click += new System.EventHandler(this.OnClick);
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProductName.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductName.Location = new System.Drawing.Point(0, 125);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(183, 31);
            this.lblProductName.TabIndex = 61;
            this.lblProductName.Text = "African Fufu ";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Click += new System.EventHandler(this.OnClick);
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.Indicator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Indicator.Location = new System.Drawing.Point(0, 0);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(183, 4);
            this.Indicator.TabIndex = 62;
            // 
            // imgBtnDiscount
            // 
            this.imgBtnDiscount.BackColor = System.Drawing.Color.Transparent;
            this.imgBtnDiscount.Image = global::Vendstor.Properties.Resources.discount_colored;
            this.imgBtnDiscount.ImageActive = null;
            this.imgBtnDiscount.Location = new System.Drawing.Point(4, 103);
            this.imgBtnDiscount.Name = "imgBtnDiscount";
            this.imgBtnDiscount.Size = new System.Drawing.Size(33, 32);
            this.imgBtnDiscount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBtnDiscount.TabIndex = 63;
            this.imgBtnDiscount.TabStop = false;
            this.imgBtnDiscount.Zoom = 10;
            this.imgBtnDiscount.Click += new System.EventHandler(this.ImgBtnDiscount_Click);
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProductImage.Image = ((System.Drawing.Image)(resources.GetObject("imgProductImage.Image")));
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(7, 31);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(166, 89);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 44;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            this.imgProductImage.Click += new System.EventHandler(this.OnClick);
            // 
            // imgIsBalanceRequired
            // 
            this.imgIsBalanceRequired.BackColor = System.Drawing.Color.Transparent;
            this.imgIsBalanceRequired.Image = global::Vendstor.Properties.Resources.scale_colored;
            this.imgIsBalanceRequired.ImageActive = null;
            this.imgIsBalanceRequired.Location = new System.Drawing.Point(147, 103);
            this.imgIsBalanceRequired.Name = "imgIsBalanceRequired";
            this.imgIsBalanceRequired.Size = new System.Drawing.Size(33, 32);
            this.imgIsBalanceRequired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIsBalanceRequired.TabIndex = 64;
            this.imgIsBalanceRequired.TabStop = false;
            this.imgIsBalanceRequired.Zoom = 10;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectProduct.Image = global::Vendstor.Properties.Resources.details_filled_W;
            this.btnSelectProduct.ImageActive = null;
            this.btnSelectProduct.Location = new System.Drawing.Point(7, 10);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(14, 15);
            this.btnSelectProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelectProduct.TabIndex = 65;
            this.btnSelectProduct.TabStop = false;
            this.btnSelectProduct.Zoom = 10;
            this.btnSelectProduct.Click += new System.EventHandler(this.BtnSelectProduct_Click);
            // 
            // ProductSellModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSelectProduct);
            this.Controls.Add(this.imgIsBalanceRequired);
            this.Controls.Add(this.imgBtnDiscount);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cardPrice);
            this.Controls.Add(this.imgProductImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProductSellModel";
            this.Size = new System.Drawing.Size(183, 156);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.DoubleClick += new System.EventHandler(this.ProductSellModel_DoubleClick);
            this.cardPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBtnDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsBalanceRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuCards cardPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel Indicator;
        public Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        public Bunifu.Framework.UI.BunifuImageButton imgBtnDiscount;
        public Bunifu.Framework.UI.BunifuImageButton imgIsBalanceRequired;
        public Bunifu.Framework.UI.BunifuImageButton btnSelectProduct;
    }
}
