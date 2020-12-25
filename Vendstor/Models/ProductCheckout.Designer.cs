namespace Vendstor.Models
{
    partial class ProductCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCheckout));
            this.Indicator = new System.Windows.Forms.Panel();
            this.cardProductQuantity = new Bunifu.Framework.UI.BunifuCards();
            this.lblProductQuantity_Card = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblDiscountPrice = new System.Windows.Forms.Label();
            this.text_Quantity = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.text_Discount = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice_Sub = new System.Windows.Forms.Label();
            this.txtDiscountValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_notes = new System.Windows.Forms.Label();
            this.txtNote = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblShowProductDetails = new System.Windows.Forms.Label();
            this.btnAddQuantity = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnReduceQuantity = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnToggleControl = new Bunifu.Framework.UI.BunifuImageButton();
            this.Seperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardProductQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleControl)).BeginInit();
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
            // cardProductQuantity
            // 
            this.cardProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cardProductQuantity.BorderRadius = 5;
            this.cardProductQuantity.BottomSahddow = true;
            this.cardProductQuantity.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cardProductQuantity.Controls.Add(this.lblProductQuantity_Card);
            this.cardProductQuantity.LeftSahddow = false;
            this.cardProductQuantity.Location = new System.Drawing.Point(37, 9);
            this.cardProductQuantity.Name = "cardProductQuantity";
            this.cardProductQuantity.RightSahddow = true;
            this.cardProductQuantity.ShadowDepth = 20;
            this.cardProductQuantity.Size = new System.Drawing.Size(31, 24);
            this.cardProductQuantity.TabIndex = 57;
            // 
            // lblProductQuantity_Card
            // 
            this.lblProductQuantity_Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductQuantity_Card.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductQuantity_Card.ForeColor = System.Drawing.Color.White;
            this.lblProductQuantity_Card.Location = new System.Drawing.Point(0, 0);
            this.lblProductQuantity_Card.Name = "lblProductQuantity_Card";
            this.lblProductQuantity_Card.Size = new System.Drawing.Size(31, 24);
            this.lblProductQuantity_Card.TabIndex = 58;
            this.lblProductQuantity_Card.Text = "99";
            this.lblProductQuantity_Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.lblProductName.Location = new System.Drawing.Point(102, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(177, 26);
            this.lblProductName.TabIndex = 58;
            this.lblProductName.Text = "Cassava Manioc, Gari ";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblProductBarcode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProductBarcode.Location = new System.Drawing.Point(102, 30);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(83, 25);
            this.lblProductBarcode.TabIndex = 59;
            this.lblProductBarcode.Text = "Big Bucket";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(285, 8);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(67, 28);
            this.lblProductPrice.TabIndex = 60;
            this.lblProductPrice.Text = "€ 10,50";
            // 
            // lblDiscountPrice
            // 
            this.lblDiscountPrice.AutoSize = true;
            this.lblDiscountPrice.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Strikeout);
            this.lblDiscountPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblDiscountPrice.Location = new System.Drawing.Point(286, 33);
            this.lblDiscountPrice.Name = "lblDiscountPrice";
            this.lblDiscountPrice.Size = new System.Drawing.Size(64, 25);
            this.lblDiscountPrice.TabIndex = 61;
            this.lblDiscountPrice.Text = "€ 25,50";
            this.lblDiscountPrice.Visible = false;
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
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblProductQuantity.Location = new System.Drawing.Point(42, 110);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(30, 25);
            this.lblProductQuantity.TabIndex = 67;
            this.lblProductQuantity.Text = "99";
            // 
            // lblProductPrice_Sub
            // 
            this.lblProductPrice_Sub.AutoSize = true;
            this.lblProductPrice_Sub.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblProductPrice_Sub.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice_Sub.Location = new System.Drawing.Point(160, 107);
            this.lblProductPrice_Sub.Name = "lblProductPrice_Sub";
            this.lblProductPrice_Sub.Size = new System.Drawing.Size(67, 28);
            this.lblProductPrice_Sub.TabIndex = 68;
            this.lblProductPrice_Sub.Text = "€ 10,50";
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.AutoScroll = true;
            this.txtDiscountValue.AutoSize = true;
            this.txtDiscountValue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtDiscountValue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.BorderThickness = 2;
            this.txtDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountValue.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.txtDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscountValue.isPassword = false;
            this.txtDiscountValue.Location = new System.Drawing.Point(316, 103);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(63, 33);
            this.txtDiscountValue.TabIndex = 69;
            this.txtDiscountValue.Text = "0";
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDiscountValue_KeyDown);
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
            // txtNote
            // 
            this.txtNote.AutoScroll = true;
            this.txtNote.AutoSize = true;
            this.txtNote.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtNote.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtNote.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtNote.BorderThickness = 2;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.txtNote.ForeColor = System.Drawing.Color.DimGray;
            this.txtNote.isPassword = false;
            this.txtNote.Location = new System.Drawing.Point(23, 177);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(366, 42);
            this.txtNote.TabIndex = 71;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNote_KeyDown);
            // 
            // lblShowProductDetails
            // 
            this.lblShowProductDetails.AutoSize = true;
            this.lblShowProductDetails.Font = new System.Drawing.Font("Poppins Light", 8.85F);
            this.lblShowProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblShowProductDetails.Location = new System.Drawing.Point(255, 225);
            this.lblShowProductDetails.Name = "lblShowProductDetails";
            this.lblShowProductDetails.Size = new System.Drawing.Size(134, 21);
            this.lblShowProductDetails.TabIndex = 72;
            this.lblShowProductDetails.Text = "Show Product Details";
            this.lblShowProductDetails.Click += new System.EventHandler(this.LblShowProductDetails_Click);
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuantity.Image = global::Vendstor.Properties.Resources.plus_checkout_w;
            this.btnAddQuantity.ImageActive = null;
            this.btnAddQuantity.Location = new System.Drawing.Point(90, 103);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(18, 32);
            this.btnAddQuantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddQuantity.TabIndex = 66;
            this.btnAddQuantity.TabStop = false;
            this.btnAddQuantity.Zoom = 10;
            this.btnAddQuantity.Click += new System.EventHandler(this.BtnAddQuantity_Click);
            // 
            // btnReduceQuantity
            // 
            this.btnReduceQuantity.BackColor = System.Drawing.Color.Transparent;
            this.btnReduceQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReduceQuantity.Image = global::Vendstor.Properties.Resources.minus_checkout_w;
            this.btnReduceQuantity.ImageActive = null;
            this.btnReduceQuantity.Location = new System.Drawing.Point(18, 103);
            this.btnReduceQuantity.Name = "btnReduceQuantity";
            this.btnReduceQuantity.Size = new System.Drawing.Size(18, 32);
            this.btnReduceQuantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReduceQuantity.TabIndex = 65;
            this.btnReduceQuantity.TabStop = false;
            this.btnReduceQuantity.Zoom = 10;
            this.btnReduceQuantity.Click += new System.EventHandler(this.BtnReduceQuantity_Click);
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgProductImage.Image = ((System.Drawing.Image)(resources.GetObject("imgProductImage.Image")));
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(43, 14);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(53, 43);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 56;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // btnToggleControl
            // 
            this.btnToggleControl.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleControl.Image = global::Vendstor.Properties.Resources.expand_checkout_w;
            this.btnToggleControl.ImageActive = null;
            this.btnToggleControl.Location = new System.Drawing.Point(13, 12);
            this.btnToggleControl.Name = "btnToggleControl";
            this.btnToggleControl.Size = new System.Drawing.Size(13, 13);
            this.btnToggleControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleControl.TabIndex = 52;
            this.btnToggleControl.TabStop = false;
            this.btnToggleControl.Zoom = 10;
            this.btnToggleControl.Click += new System.EventHandler(this.BtnToggleControl_Click);
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
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnDelete.Location = new System.Drawing.Point(364, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 220;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ProductCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.lblShowProductDetails);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.text_notes);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.lblProductPrice_Sub);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.btnReduceQuantity);
            this.Controls.Add(this.text_Discount);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.text_Quantity);
            this.Controls.Add(this.lblDiscountPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cardProductQuantity);
            this.Controls.Add(this.imgProductImage);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.btnToggleControl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ProductCheckout";
            this.Size = new System.Drawing.Size(400, 263);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.cardProductQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuImageButton btnToggleControl;
        private System.Windows.Forms.Panel Indicator;
        internal Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private Bunifu.Framework.UI.BunifuCards cardProductQuantity;
        private System.Windows.Forms.Label lblProductQuantity_Card;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblDiscountPrice;
        private System.Windows.Forms.Label text_Quantity;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label text_Discount;
        internal Bunifu.Framework.UI.BunifuImageButton btnReduceQuantity;
        internal Bunifu.Framework.UI.BunifuImageButton btnAddQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice_Sub;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscountValue;
        private System.Windows.Forms.Label text_notes;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNote;
        private System.Windows.Forms.Label lblShowProductDetails;
        private Bunifu.Framework.UI.BunifuSeparator Seperator;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}
