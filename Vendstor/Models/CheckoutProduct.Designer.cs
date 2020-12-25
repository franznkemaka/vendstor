namespace Vendstor.Models
{
    partial class CheckoutProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutProduct));
            this.Indicator = new System.Windows.Forms.Panel();
            this.card_ProductQuantity = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_ProductQuantity = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductTag = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_DiscountPrice = new System.Windows.Forms.Label();
            this.text_Quantity = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.text_Discount = new System.Windows.Forms.Label();
            this.lbl_ProductQuantity_RS = new System.Windows.Forms.Label();
            this.lbl_ProductPrice_RS = new System.Windows.Forms.Label();
            this.txt_DiscountPtg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_notes = new System.Windows.Forms.Label();
            this.txt_Note = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_ShowProdDetails = new System.Windows.Forms.Label();
            this.imgbtn_AddQuantity = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtn_ReduceQuantity = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_ProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtn_Delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtn_ResizeControl = new Bunifu.Framework.UI.BunifuImageButton();
            this.Seperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.card_ProductQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_AddQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_ReduceQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_ResizeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.Indicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.Indicator.Location = new System.Drawing.Point(0, 0);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(4, 263);
            this.Indicator.TabIndex = 55;
            this.Indicator.Visible = false;
            // 
            // card_ProductQuantity
            // 
            this.card_ProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_ProductQuantity.BorderRadius = 5;
            this.card_ProductQuantity.BottomSahddow = true;
            this.card_ProductQuantity.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_ProductQuantity.Controls.Add(this.lbl_ProductQuantity);
            this.card_ProductQuantity.LeftSahddow = false;
            this.card_ProductQuantity.Location = new System.Drawing.Point(37, 9);
            this.card_ProductQuantity.Name = "card_ProductQuantity";
            this.card_ProductQuantity.RightSahddow = true;
            this.card_ProductQuantity.ShadowDepth = 20;
            this.card_ProductQuantity.Size = new System.Drawing.Size(31, 24);
            this.card_ProductQuantity.TabIndex = 57;
            // 
            // lbl_ProductQuantity
            // 
            this.lbl_ProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductQuantity.Font = new System.Drawing.Font("Poppins", 10F);
            this.lbl_ProductQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_ProductQuantity.Location = new System.Drawing.Point(0, 0);
            this.lbl_ProductQuantity.Name = "lbl_ProductQuantity";
            this.lbl_ProductQuantity.Size = new System.Drawing.Size(31, 24);
            this.lbl_ProductQuantity.TabIndex = 58;
            this.lbl_ProductQuantity.Text = "99";
            this.lbl_ProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.lbl_ProductName.Location = new System.Drawing.Point(102, 12);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(177, 26);
            this.lbl_ProductName.TabIndex = 58;
            this.lbl_ProductName.Text = "Cassava Manioc, Gari ";
            // 
            // lbl_ProductTag
            // 
            this.lbl_ProductTag.AutoSize = true;
            this.lbl_ProductTag.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lbl_ProductTag.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ProductTag.Location = new System.Drawing.Point(102, 30);
            this.lbl_ProductTag.Name = "lbl_ProductTag";
            this.lbl_ProductTag.Size = new System.Drawing.Size(83, 25);
            this.lbl_ProductTag.TabIndex = 59;
            this.lbl_ProductTag.Text = "Big Bucket";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.lbl_ProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(285, 8);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(67, 28);
            this.lbl_ProductPrice.TabIndex = 60;
            this.lbl_ProductPrice.Text = "€ 10,50";
            // 
            // lbl_DiscountPrice
            // 
            this.lbl_DiscountPrice.AutoSize = true;
            this.lbl_DiscountPrice.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Strikeout);
            this.lbl_DiscountPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lbl_DiscountPrice.Location = new System.Drawing.Point(286, 33);
            this.lbl_DiscountPrice.Name = "lbl_DiscountPrice";
            this.lbl_DiscountPrice.Size = new System.Drawing.Size(64, 25);
            this.lbl_DiscountPrice.TabIndex = 61;
            this.lbl_DiscountPrice.Text = "€ 25,50";
            this.lbl_DiscountPrice.Visible = false;
            // 
            // text_Quantity
            // 
            this.text_Quantity.AutoSize = true;
            this.text_Quantity.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_Quantity.Location = new System.Drawing.Point(18, 74);
            this.text_Quantity.Name = "text_Quantity";
            this.text_Quantity.Size = new System.Drawing.Size(76, 26);
            this.text_Quantity.TabIndex = 62;
            this.text_Quantity.Text = "Quantity";
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_Price.Location = new System.Drawing.Point(170, 74);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(49, 26);
            this.text_Price.TabIndex = 63;
            this.text_Price.Text = "Price";
            // 
            // text_Discount
            // 
            this.text_Discount.AutoSize = true;
            this.text_Discount.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_Discount.Location = new System.Drawing.Point(285, 74);
            this.text_Discount.Name = "text_Discount";
            this.text_Discount.Size = new System.Drawing.Size(104, 26);
            this.text_Discount.TabIndex = 64;
            this.text_Discount.Text = "Discount(%)";
            // 
            // lbl_ProductQuantity_RS
            // 
            this.lbl_ProductQuantity_RS.AutoSize = true;
            this.lbl_ProductQuantity_RS.Font = new System.Drawing.Font("Poppins", 10F);
            this.lbl_ProductQuantity_RS.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductQuantity_RS.Location = new System.Drawing.Point(42, 110);
            this.lbl_ProductQuantity_RS.Name = "lbl_ProductQuantity_RS";
            this.lbl_ProductQuantity_RS.Size = new System.Drawing.Size(30, 25);
            this.lbl_ProductQuantity_RS.TabIndex = 67;
            this.lbl_ProductQuantity_RS.Text = "99";
            // 
            // lbl_ProductPrice_RS
            // 
            this.lbl_ProductPrice_RS.AutoSize = true;
            this.lbl_ProductPrice_RS.Font = new System.Drawing.Font("Poppins", 12F);
            this.lbl_ProductPrice_RS.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProductPrice_RS.Location = new System.Drawing.Point(160, 107);
            this.lbl_ProductPrice_RS.Name = "lbl_ProductPrice_RS";
            this.lbl_ProductPrice_RS.Size = new System.Drawing.Size(67, 28);
            this.lbl_ProductPrice_RS.TabIndex = 68;
            this.lbl_ProductPrice_RS.Text = "€ 10,50";
            // 
            // txt_DiscountPtg
            // 
            this.txt_DiscountPtg.AutoScroll = true;
            this.txt_DiscountPtg.AutoSize = true;
            this.txt_DiscountPtg.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txt_DiscountPtg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txt_DiscountPtg.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txt_DiscountPtg.BorderThickness = 2;
            this.txt_DiscountPtg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiscountPtg.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.txt_DiscountPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_DiscountPtg.isPassword = false;
            this.txt_DiscountPtg.Location = new System.Drawing.Point(283, 103);
            this.txt_DiscountPtg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_DiscountPtg.Name = "txt_DiscountPtg";
            this.txt_DiscountPtg.Size = new System.Drawing.Size(101, 33);
            this.txt_DiscountPtg.TabIndex = 69;
            this.txt_DiscountPtg.Text = "0";
            this.txt_DiscountPtg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DiscountPtg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DiscountPtg_KeyDown);
            // 
            // text_notes
            // 
            this.text_notes.AutoSize = true;
            this.text_notes.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_notes.Location = new System.Drawing.Point(23, 145);
            this.text_notes.Name = "text_notes";
            this.text_notes.Size = new System.Drawing.Size(55, 26);
            this.text_notes.TabIndex = 70;
            this.text_notes.Text = "Notes";
            // 
            // txt_Note
            // 
            this.txt_Note.AutoScroll = true;
            this.txt_Note.AutoSize = true;
            this.txt_Note.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txt_Note.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txt_Note.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txt_Note.BorderThickness = 2;
            this.txt_Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Note.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.txt_Note.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Note.isPassword = false;
            this.txt_Note.Location = new System.Drawing.Point(23, 177);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(366, 42);
            this.txt_Note.TabIndex = 71;
            this.txt_Note.Text = "Type to add note...";
            this.txt_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Note_KeyDown);
            this.txt_Note.MouseEnter += new System.EventHandler(this.txt_Note_MouseEnter);
            this.txt_Note.MouseLeave += new System.EventHandler(this.txt_Note_MouseLeave);
            // 
            // lbl_ShowProdDetails
            // 
            this.lbl_ShowProdDetails.AutoSize = true;
            this.lbl_ShowProdDetails.Font = new System.Drawing.Font("Poppins Light", 8.85F);
            this.lbl_ShowProdDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lbl_ShowProdDetails.Location = new System.Drawing.Point(263, 228);
            this.lbl_ShowProdDetails.Name = "lbl_ShowProdDetails";
            this.lbl_ShowProdDetails.Size = new System.Drawing.Size(134, 21);
            this.lbl_ShowProdDetails.TabIndex = 72;
            this.lbl_ShowProdDetails.Text = "Show Product Details";
            this.lbl_ShowProdDetails.Click += new System.EventHandler(this.lbl_ShowProdDetails_Click);
            // 
            // imgbtn_AddQuantity
            // 
            this.imgbtn_AddQuantity.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_AddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_AddQuantity.Image = global::Vendstor.Properties.Resources.plus_checkout_w;
            this.imgbtn_AddQuantity.ImageActive = null;
            this.imgbtn_AddQuantity.Location = new System.Drawing.Point(90, 103);
            this.imgbtn_AddQuantity.Name = "imgbtn_AddQuantity";
            this.imgbtn_AddQuantity.Size = new System.Drawing.Size(18, 32);
            this.imgbtn_AddQuantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_AddQuantity.TabIndex = 66;
            this.imgbtn_AddQuantity.TabStop = false;
            this.imgbtn_AddQuantity.Zoom = 10;
            this.imgbtn_AddQuantity.Click += new System.EventHandler(this.imgbtn_AddQuantity_Click);
            // 
            // imgbtn_ReduceQuantity
            // 
            this.imgbtn_ReduceQuantity.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_ReduceQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_ReduceQuantity.Image = global::Vendstor.Properties.Resources.minus_checkout_w;
            this.imgbtn_ReduceQuantity.ImageActive = null;
            this.imgbtn_ReduceQuantity.Location = new System.Drawing.Point(18, 103);
            this.imgbtn_ReduceQuantity.Name = "imgbtn_ReduceQuantity";
            this.imgbtn_ReduceQuantity.Size = new System.Drawing.Size(18, 32);
            this.imgbtn_ReduceQuantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_ReduceQuantity.TabIndex = 65;
            this.imgbtn_ReduceQuantity.TabStop = false;
            this.imgbtn_ReduceQuantity.Zoom = 10;
            this.imgbtn_ReduceQuantity.Click += new System.EventHandler(this.imgbtn_ReduceQuantity_Click);
            // 
            // pic_ProductImage
            // 
            this.pic_ProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pic_ProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_ProductImage.Image")));
            this.pic_ProductImage.ImageActive = null;
            this.pic_ProductImage.Location = new System.Drawing.Point(43, 14);
            this.pic_ProductImage.Name = "pic_ProductImage";
            this.pic_ProductImage.Size = new System.Drawing.Size(53, 43);
            this.pic_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProductImage.TabIndex = 56;
            this.pic_ProductImage.TabStop = false;
            this.pic_ProductImage.Zoom = 10;
            // 
            // imgbtn_Delete
            // 
            this.imgbtn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_Delete.Image = global::Vendstor.Properties.Resources.delete_sell_w;
            this.imgbtn_Delete.ImageActive = null;
            this.imgbtn_Delete.Location = new System.Drawing.Point(369, 18);
            this.imgbtn_Delete.Name = "imgbtn_Delete";
            this.imgbtn_Delete.Size = new System.Drawing.Size(18, 18);
            this.imgbtn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_Delete.TabIndex = 54;
            this.imgbtn_Delete.TabStop = false;
            this.imgbtn_Delete.Zoom = 10;
            this.imgbtn_Delete.Click += new System.EventHandler(this.imgbtn_Delete_Click);
            // 
            // imgbtn_ResizeControl
            // 
            this.imgbtn_ResizeControl.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_ResizeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_ResizeControl.Image = global::Vendstor.Properties.Resources.expand_checkout_w;
            this.imgbtn_ResizeControl.ImageActive = null;
            this.imgbtn_ResizeControl.Location = new System.Drawing.Point(13, 12);
            this.imgbtn_ResizeControl.Name = "imgbtn_ResizeControl";
            this.imgbtn_ResizeControl.Size = new System.Drawing.Size(13, 13);
            this.imgbtn_ResizeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_ResizeControl.TabIndex = 52;
            this.imgbtn_ResizeControl.TabStop = false;
            this.imgbtn_ResizeControl.Zoom = 10;
            this.imgbtn_ResizeControl.Click += new System.EventHandler(this.imgbtn_ResizeControl_Click);
            // 
            // Seperator
            // 
            this.Seperator.BackColor = System.Drawing.Color.Transparent;
            this.Seperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator.LineThickness = 1;
            this.Seperator.Location = new System.Drawing.Point(5, 66);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(398, 10);
            this.Seperator.TabIndex = 73;
            this.Seperator.Transparency = 255;
            this.Seperator.Vertical = false;
            // 
            // CheckoutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.lbl_ShowProdDetails);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.text_notes);
            this.Controls.Add(this.txt_DiscountPtg);
            this.Controls.Add(this.lbl_ProductPrice_RS);
            this.Controls.Add(this.lbl_ProductQuantity_RS);
            this.Controls.Add(this.imgbtn_AddQuantity);
            this.Controls.Add(this.imgbtn_ReduceQuantity);
            this.Controls.Add(this.text_Discount);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.text_Quantity);
            this.Controls.Add(this.lbl_DiscountPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.lbl_ProductTag);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.card_ProductQuantity);
            this.Controls.Add(this.pic_ProductImage);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.imgbtn_Delete);
            this.Controls.Add(this.imgbtn_ResizeControl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CheckoutProduct";
            this.Size = new System.Drawing.Size(400, 263);
            this.Load += new System.EventHandler(this.ucCheckout_Product_Load);
            this.SizeChanged += new System.EventHandler(this.ucCheckout_Product_SizeChanged);
            this.Click += new System.EventHandler(this.ucCheckout_Product_Click);
            this.card_ProductQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_AddQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_ReduceQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_ResizeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuImageButton imgbtn_ResizeControl;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtn_Delete;
        private System.Windows.Forms.Panel Indicator;
        internal Bunifu.Framework.UI.BunifuImageButton pic_ProductImage;
        private Bunifu.Framework.UI.BunifuCards card_ProductQuantity;
        private System.Windows.Forms.Label lbl_ProductQuantity;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductTag;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_DiscountPrice;
        private System.Windows.Forms.Label text_Quantity;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label text_Discount;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtn_ReduceQuantity;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtn_AddQuantity;
        private System.Windows.Forms.Label lbl_ProductQuantity_RS;
        private System.Windows.Forms.Label lbl_ProductPrice_RS;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_DiscountPtg;
        private System.Windows.Forms.Label text_notes;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Note;
        private System.Windows.Forms.Label lbl_ShowProdDetails;
        private Bunifu.Framework.UI.BunifuSeparator Seperator;
    }
}
