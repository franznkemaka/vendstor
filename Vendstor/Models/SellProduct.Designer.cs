namespace Vendstor.Models
{
    partial class SellProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellProduct));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.card_PriceBG = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.Indicator = new System.Windows.Forms.Panel();
            this.pic_Discount = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_ProductImg = new Bunifu.Framework.UI.BunifuImageButton();
            this.card_PriceBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // card_PriceBG
            // 
            this.card_PriceBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_PriceBG.BorderRadius = 5;
            this.card_PriceBG.BottomSahddow = true;
            this.card_PriceBG.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_PriceBG.Controls.Add(this.lbl_ProductPrice);
            this.card_PriceBG.LeftSahddow = false;
            this.card_PriceBG.Location = new System.Drawing.Point(99, 10);
            this.card_PriceBG.Name = "card_PriceBG";
            this.card_PriceBG.RightSahddow = true;
            this.card_PriceBG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_PriceBG.ShadowDepth = 20;
            this.card_PriceBG.Size = new System.Drawing.Size(77, 29);
            this.card_PriceBG.TabIndex = 60;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Poppins", 10F);
            this.lbl_ProductPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(77, 29);
            this.lbl_ProductPrice.TabIndex = 59;
            this.lbl_ProductPrice.Text = "99,45 €";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ProductPrice.Click += new System.EventHandler(this.Control_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductName.Font = new System.Drawing.Font("Poppins", 10F);
            this.lbl_ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ProductName.Location = new System.Drawing.Point(42, 125);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(107, 31);
            this.lbl_ProductName.TabIndex = 61;
            this.lbl_ProductName.Text = "African Fufu ";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ProductName.Click += new System.EventHandler(this.Control_Click);
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
            // pic_Discount
            // 
            this.pic_Discount.BackColor = System.Drawing.Color.Transparent;
            this.pic_Discount.Image = global::Vendstor.Properties.Resources.discount_colored;
            this.pic_Discount.ImageActive = null;
            this.pic_Discount.Location = new System.Drawing.Point(4, 103);
            this.pic_Discount.Name = "pic_Discount";
            this.pic_Discount.Size = new System.Drawing.Size(33, 32);
            this.pic_Discount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Discount.TabIndex = 63;
            this.pic_Discount.TabStop = false;
            this.pic_Discount.Zoom = 10;
            // 
            // pic_ProductImg
            // 
            this.pic_ProductImg.BackColor = System.Drawing.Color.Transparent;
            this.pic_ProductImg.Image = ((System.Drawing.Image)(resources.GetObject("pic_ProductImg.Image")));
            this.pic_ProductImg.ImageActive = null;
            this.pic_ProductImg.Location = new System.Drawing.Point(7, 31);
            this.pic_ProductImg.Name = "pic_ProductImg";
            this.pic_ProductImg.Size = new System.Drawing.Size(166, 89);
            this.pic_ProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProductImg.TabIndex = 44;
            this.pic_ProductImg.TabStop = false;
            this.pic_ProductImg.Zoom = 10;
            this.pic_ProductImg.Click += new System.EventHandler(this.Control_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic_Discount);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.card_PriceBG);
            this.Controls.Add(this.pic_ProductImg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SellProduct";
            this.Size = new System.Drawing.Size(183, 156);
            this.Load += new System.EventHandler(this.SellProduct_Load);
            this.Click += new System.EventHandler(this.Control_Click);
            this.card_PriceBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuCards card_PriceBG;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Panel Indicator;
        public Bunifu.Framework.UI.BunifuImageButton pic_ProductImg;
        public Bunifu.Framework.UI.BunifuImageButton pic_Discount;
    }
}
