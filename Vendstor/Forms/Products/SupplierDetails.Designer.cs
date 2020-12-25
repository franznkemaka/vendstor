namespace Vendstor.Forms.Products
{
    partial class SupplierDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSupplierDescription = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_Markup = new System.Windows.Forms.Label();
            this.lblMarkupPtg = new System.Windows.Forms.Label();
            this.text_Company = new System.Windows.Forms.Label();
            this.text_Contact = new System.Windows.Forms.Label();
            this.text_Website = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.text_PhoneN = new System.Windows.Forms.Label();
            this.text_Address = new System.Windows.Forms.Label();
            this.text_EmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblAddress_Street = new System.Windows.Forms.Label();
            this.lblAddress_PostCode = new System.Windows.Forms.Label();
            this.lblAddress_City = new System.Windows.Forms.Label();
            this.lblAddress_Country = new System.Windows.Forms.Label();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardAddress = new Bunifu.Framework.UI.BunifuCards();
            this.pnlToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.cardAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // HSeperator
            // 
            this.HSeperator.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator.LineThickness = 1;
            this.HSeperator.Location = new System.Drawing.Point(29, 197);
            this.HSeperator.Margin = new System.Windows.Forms.Padding(8);
            this.HSeperator.Name = "HSeperator";
            this.HSeperator.Size = new System.Drawing.Size(792, 10);
            this.HSeperator.TabIndex = 179;
            this.HSeperator.Transparency = 255;
            this.HSeperator.Vertical = false;
            // 
            // lblSupplierDescription
            // 
            this.lblSupplierDescription.AutoSize = true;
            this.lblSupplierDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSupplierDescription.Location = new System.Drawing.Point(116, 103);
            this.lblSupplierDescription.MaximumSize = new System.Drawing.Size(700, 120);
            this.lblSupplierDescription.Name = "lblSupplierDescription";
            this.lblSupplierDescription.Size = new System.Drawing.Size(107, 26);
            this.lblSupplierDescription.TabIndex = 180;
            this.lblSupplierDescription.Text = "_description ";
            this.lblSupplierDescription.SizeChanged += new System.EventHandler(this.LblSupplierDescription_SizeChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Poppins", 14F);
            this.lblSupplierName.Location = new System.Drawing.Point(22, 7);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(165, 33);
            this.lblSupplierName.TabIndex = 182;
            this.lblSupplierName.Text = "_SupplierName";
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.AllowDrop = true;
            this.pnlToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlToolBox.Controls.Add(this.lblHint);
            this.pnlToolBox.Controls.Add(this.btnDelete);
            this.pnlToolBox.Controls.Add(this.btnEdit);
            this.pnlToolBox.Location = new System.Drawing.Point(12, 44);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(827, 42);
            this.pnlToolBox.TabIndex = 187;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(12, 9);
            this.lblHint.MaximumSize = new System.Drawing.Size(700, 120);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(198, 25);
            this.lblHint.TabIndex = 192;
            this.lblHint.Text = "View and edit your supplier";
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
            this.btnDelete.Location = new System.Drawing.Point(791, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 191;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(753, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(30, 26);
            this.btnEdit.TabIndex = 188;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // text_Markup
            // 
            this.text_Markup.AutoSize = true;
            this.text_Markup.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Markup.Location = new System.Drawing.Point(23, 215);
            this.text_Markup.Name = "text_Markup";
            this.text_Markup.Size = new System.Drawing.Size(72, 28);
            this.text_Markup.TabIndex = 189;
            this.text_Markup.Text = "Markup";
            // 
            // lblMarkupPtg
            // 
            this.lblMarkupPtg.AutoSize = true;
            this.lblMarkupPtg.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblMarkupPtg.Location = new System.Drawing.Point(171, 217);
            this.lblMarkupPtg.Name = "lblMarkupPtg";
            this.lblMarkupPtg.Size = new System.Drawing.Size(95, 26);
            this.lblMarkupPtg.TabIndex = 190;
            this.lblMarkupPtg.Text = "_Markup % ";
            // 
            // text_Company
            // 
            this.text_Company.AutoSize = true;
            this.text_Company.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Company.Location = new System.Drawing.Point(24, 258);
            this.text_Company.Name = "text_Company";
            this.text_Company.Size = new System.Drawing.Size(95, 28);
            this.text_Company.TabIndex = 191;
            this.text_Company.Text = "Company ";
            // 
            // text_Contact
            // 
            this.text_Contact.AutoSize = true;
            this.text_Contact.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Contact.Location = new System.Drawing.Point(24, 304);
            this.text_Contact.Name = "text_Contact";
            this.text_Contact.Size = new System.Drawing.Size(77, 28);
            this.text_Contact.TabIndex = 194;
            this.text_Contact.Text = "Contact";
            // 
            // text_Website
            // 
            this.text_Website.AutoSize = true;
            this.text_Website.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Website.Location = new System.Drawing.Point(24, 416);
            this.text_Website.Name = "text_Website";
            this.text_Website.Size = new System.Drawing.Size(77, 28);
            this.text_Website.TabIndex = 195;
            this.text_Website.Text = "Website";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblCompany.Location = new System.Drawing.Point(171, 258);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(140, 26);
            this.lblCompany.TabIndex = 196;
            this.lblCompany.Text = "_CompanyName";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblContact.Location = new System.Drawing.Point(171, 306);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(196, 26);
            this.lblContact.TabIndex = 198;
            this.lblContact.Text = "_FirstName && _LastName";
            // 
            // text_PhoneN
            // 
            this.text_PhoneN.AutoSize = true;
            this.text_PhoneN.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_PhoneN.Location = new System.Drawing.Point(24, 341);
            this.text_PhoneN.Name = "text_PhoneN";
            this.text_PhoneN.Size = new System.Drawing.Size(129, 28);
            this.text_PhoneN.TabIndex = 200;
            this.text_PhoneN.Text = "Phone Number";
            // 
            // text_Address
            // 
            this.text_Address.AutoSize = true;
            this.text_Address.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Address.Location = new System.Drawing.Point(427, 217);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(77, 28);
            this.text_Address.TabIndex = 202;
            this.text_Address.Text = "Address";
            // 
            // text_EmailAddress
            // 
            this.text_EmailAddress.AutoSize = true;
            this.text_EmailAddress.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_EmailAddress.Location = new System.Drawing.Point(23, 378);
            this.text_EmailAddress.Name = "text_EmailAddress";
            this.text_EmailAddress.Size = new System.Drawing.Size(124, 28);
            this.text_EmailAddress.TabIndex = 210;
            this.text_EmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(171, 343);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(125, 26);
            this.lblPhoneNumber.TabIndex = 211;
            this.lblPhoneNumber.Text = "_PhoneNumber";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(171, 380);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(137, 26);
            this.lblEmailAddress.TabIndex = 212;
            this.lblEmailAddress.Text = "_email@address";
            this.lblEmailAddress.Click += new System.EventHandler(this.LblEmailAddress_Click);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblWebsite.Location = new System.Drawing.Point(171, 416);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(138, 26);
            this.lblWebsite.TabIndex = 213;
            this.lblWebsite.Text = "_website.domain";
            this.lblWebsite.Click += new System.EventHandler(this.LblWebsite_Click);
            // 
            // lblAddress_Street
            // 
            this.lblAddress_Street.AutoSize = true;
            this.lblAddress_Street.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblAddress_Street.Location = new System.Drawing.Point(23, 14);
            this.lblAddress_Street.Name = "lblAddress_Street";
            this.lblAddress_Street.Size = new System.Drawing.Size(197, 26);
            this.lblAddress_Street.TabIndex = 214;
            this.lblAddress_Street.Text = "_Street && _HouseNumber";
            // 
            // lblAddress_PostCode
            // 
            this.lblAddress_PostCode.AutoSize = true;
            this.lblAddress_PostCode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblAddress_PostCode.Location = new System.Drawing.Point(23, 40);
            this.lblAddress_PostCode.Name = "lblAddress_PostCode";
            this.lblAddress_PostCode.Size = new System.Drawing.Size(94, 26);
            this.lblAddress_PostCode.TabIndex = 215;
            this.lblAddress_PostCode.Text = "_PostCode";
            // 
            // lblAddress_City
            // 
            this.lblAddress_City.AutoSize = true;
            this.lblAddress_City.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblAddress_City.Location = new System.Drawing.Point(23, 66);
            this.lblAddress_City.Name = "lblAddress_City";
            this.lblAddress_City.Size = new System.Drawing.Size(50, 26);
            this.lblAddress_City.TabIndex = 216;
            this.lblAddress_City.Text = "_City";
            // 
            // lblAddress_Country
            // 
            this.lblAddress_Country.AutoSize = true;
            this.lblAddress_Country.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblAddress_Country.Location = new System.Drawing.Point(23, 92);
            this.lblAddress_Country.Name = "lblAddress_Country";
            this.lblAddress_Country.Size = new System.Drawing.Size(80, 26);
            this.lblAddress_Country.TabIndex = 216;
            this.lblAddress_Country.Text = "_Country";
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(817, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 209;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // cardAddress
            // 
            this.cardAddress.BackColor = System.Drawing.Color.White;
            this.cardAddress.BorderRadius = 5;
            this.cardAddress.BottomSahddow = true;
            this.cardAddress.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardAddress.Controls.Add(this.lblAddress_Country);
            this.cardAddress.Controls.Add(this.lblAddress_City);
            this.cardAddress.Controls.Add(this.lblAddress_PostCode);
            this.cardAddress.Controls.Add(this.lblAddress_Street);
            this.cardAddress.LeftSahddow = false;
            this.cardAddress.Location = new System.Drawing.Point(510, 240);
            this.cardAddress.Name = "cardAddress";
            this.cardAddress.RightSahddow = true;
            this.cardAddress.ShadowDepth = 20;
            this.cardAddress.Size = new System.Drawing.Size(295, 136);
            this.cardAddress.TabIndex = 217;
            // 
            // SupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(this.cardAddress);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.text_EmailAddress);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.text_PhoneN);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.text_Website);
            this.Controls.Add(this.text_Contact);
            this.Controls.Add(this.text_Company);
            this.Controls.Add(this.lblMarkupPtg);
            this.Controls.Add(this.text_Markup);
            this.Controls.Add(this.HSeperator);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Supplier Details";
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.cardAddress.ResumeLayout(false);
            this.cardAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator;
        private System.Windows.Forms.Label lblSupplierDescription;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Label text_Markup;
        private System.Windows.Forms.Label text_PhoneN;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label text_Website;
        private System.Windows.Forms.Label text_Contact;
        private System.Windows.Forms.Label text_Company;
        private System.Windows.Forms.Label lblMarkupPtg;
        private System.Windows.Forms.Label text_Address;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label text_EmailAddress;
        private System.Windows.Forms.Label lblAddress_Country;
        private System.Windows.Forms.Label lblAddress_City;
        private System.Windows.Forms.Label lblAddress_PostCode;
        private System.Windows.Forms.Label lblAddress_Street;
        private Bunifu.Framework.UI.BunifuCards cardAddress;
        private System.Windows.Forms.Label lblHint;
    }
}