namespace Vendstor.Forms.Products
{
    partial class Supplier
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
            this.lblDetails_Hint = new System.Windows.Forms.Label();
            this.rtxtSupplierDescription = new System.Windows.Forms.RichTextBox();
            this.text_Details = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.text_SupplierName = new System.Windows.Forms.Label();
            this.text_Markup = new System.Windows.Forms.Label();
            this.text_Description = new System.Windows.Forms.Label();
            this.text_Addresses = new System.Windows.Forms.Label();
            this.HSeperator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_BackToFields = new System.Windows.Forms.Label();
            this.txtSupplierName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnlSecondFields = new System.Windows.Forms.Panel();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.dpdCountry = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_Email = new System.Windows.Forms.Label();
            this.text_Country = new System.Windows.Forms.Label();
            this.txtEmailAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_City = new System.Windows.Forms.Label();
            this.text_Company = new System.Windows.Forms.Label();
            this.txtCompany = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_PostCode = new System.Windows.Forms.Label();
            this.txtPostCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Street = new System.Windows.Forms.Label();
            this.txtStreet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Website = new System.Windows.Forms.Label();
            this.txtWebsite = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_PhoneN = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgbtnGoFirstFields = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlFirstFields = new System.Windows.Forms.Panel();
            this.imgFirstNameValid = new System.Windows.Forms.PictureBox();
            this.lblContactInfo_Hint = new System.Windows.Forms.Label();
            this.text_LastN = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox14 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_FirstN = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_ContactInfo = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox13 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.HSeperator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtMarkup = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.imgbtnGoSecondFields = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuMetroTextbox12 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox10 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgbtn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSecondFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoFirstFields)).BeginInit();
            this.pnlFirstFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirstNameValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoSecondFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // lblDetails_Hint
            // 
            this.lblDetails_Hint.AutoSize = true;
            this.lblDetails_Hint.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.lblDetails_Hint.Location = new System.Drawing.Point(11, 81);
            this.lblDetails_Hint.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblDetails_Hint.Name = "lblDetails_Hint";
            this.lblDetails_Hint.Size = new System.Drawing.Size(149, 147);
            this.lblDetails_Hint.TabIndex = 137;
            this.lblDetails_Hint.Text = "How your supplier is identified and described in Vendstor. You can also choose to" +
    " set a markup, making setting up products easier.";
            // 
            // rtxtSupplierDescription
            // 
            this.rtxtSupplierDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.rtxtSupplierDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSupplierDescription.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.rtxtSupplierDescription.ForeColor = System.Drawing.Color.Gray;
            this.rtxtSupplierDescription.Location = new System.Drawing.Point(168, 208);
            this.rtxtSupplierDescription.Name = "rtxtSupplierDescription";
            this.rtxtSupplierDescription.Size = new System.Drawing.Size(656, 83);
            this.rtxtSupplierDescription.TabIndex = 133;
            this.rtxtSupplierDescription.Text = "";
            // 
            // text_Details
            // 
            this.text_Details.AutoSize = true;
            this.text_Details.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Details.Location = new System.Drawing.Point(38, 51);
            this.text_Details.Name = "text_Details";
            this.text_Details.Size = new System.Drawing.Size(66, 28);
            this.text_Details.TabIndex = 131;
            this.text_Details.Text = "Details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblTitle.Location = new System.Drawing.Point(12, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 39);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "Supplier";
            // 
            // text_SupplierName
            // 
            this.text_SupplierName.AutoSize = true;
            this.text_SupplierName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_SupplierName.Location = new System.Drawing.Point(172, 78);
            this.text_SupplierName.Name = "text_SupplierName";
            this.text_SupplierName.Size = new System.Drawing.Size(118, 26);
            this.text_SupplierName.TabIndex = 93;
            this.text_SupplierName.Text = "Supplier Name";
            // 
            // text_Markup
            // 
            this.text_Markup.AutoSize = true;
            this.text_Markup.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Markup.Location = new System.Drawing.Point(528, 78);
            this.text_Markup.Name = "text_Markup";
            this.text_Markup.Size = new System.Drawing.Size(66, 26);
            this.text_Markup.TabIndex = 94;
            this.text_Markup.Text = "Markup";
            // 
            // text_Description
            // 
            this.text_Description.AutoSize = true;
            this.text_Description.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Description.Location = new System.Drawing.Point(165, 179);
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(94, 26);
            this.text_Description.TabIndex = 95;
            this.text_Description.Text = "Description";
            // 
            // text_Addresses
            // 
            this.text_Addresses.AutoSize = true;
            this.text_Addresses.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Addresses.Location = new System.Drawing.Point(14, 215);
            this.text_Addresses.Name = "text_Addresses";
            this.text_Addresses.Size = new System.Drawing.Size(77, 28);
            this.text_Addresses.TabIndex = 179;
            this.text_Addresses.Text = "Address";
            // 
            // HSeperator2
            // 
            this.HSeperator2.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator2.LineThickness = 1;
            this.HSeperator2.Location = new System.Drawing.Point(99, 183);
            this.HSeperator2.Margin = new System.Windows.Forms.Padding(8);
            this.HSeperator2.Name = "HSeperator2";
            this.HSeperator2.Size = new System.Drawing.Size(667, 28);
            this.HSeperator2.TabIndex = 178;
            this.HSeperator2.Transparency = 255;
            this.HSeperator2.Vertical = false;
            // 
            // text_BackToFields
            // 
            this.text_BackToFields.AutoSize = true;
            this.text_BackToFields.Font = new System.Drawing.Font("Poppins", 10.85F);
            this.text_BackToFields.Location = new System.Drawing.Point(73, 487);
            this.text_BackToFields.Name = "text_BackToFields";
            this.text_BackToFields.Size = new System.Drawing.Size(149, 26);
            this.text_BackToFields.TabIndex = 130;
            this.text_BackToFields.Text = "Back to First Fields";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AutoScroll = true;
            this.txtSupplierName.AutoSize = true;
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtSupplierName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtSupplierName.BorderThickness = 2;
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtSupplierName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupplierName.isPassword = false;
            this.txtSupplierName.Location = new System.Drawing.Point(168, 115);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(303, 40);
            this.txtSupplierName.TabIndex = 109;
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSupplierName.OnValueChanged += new System.EventHandler(this.TxtSupplierName_OnValueChanged);
            // 
            // pnlSecondFields
            // 
            this.pnlSecondFields.BackColor = System.Drawing.Color.White;
            this.pnlSecondFields.Controls.Add(this.cbbCountry);
            this.pnlSecondFields.Controls.Add(this.dpdCountry);
            this.pnlSecondFields.Controls.Add(this.text_Email);
            this.pnlSecondFields.Controls.Add(this.text_Country);
            this.pnlSecondFields.Controls.Add(this.txtEmailAddress);
            this.pnlSecondFields.Controls.Add(this.text_City);
            this.pnlSecondFields.Controls.Add(this.text_Company);
            this.pnlSecondFields.Controls.Add(this.txtCompany);
            this.pnlSecondFields.Controls.Add(this.txtCity);
            this.pnlSecondFields.Controls.Add(this.text_PostCode);
            this.pnlSecondFields.Controls.Add(this.txtPostCode);
            this.pnlSecondFields.Controls.Add(this.text_Street);
            this.pnlSecondFields.Controls.Add(this.txtStreet);
            this.pnlSecondFields.Controls.Add(this.text_Website);
            this.pnlSecondFields.Controls.Add(this.txtWebsite);
            this.pnlSecondFields.Controls.Add(this.text_PhoneN);
            this.pnlSecondFields.Controls.Add(this.txtPhoneNumber);
            this.pnlSecondFields.Controls.Add(this.text_Addresses);
            this.pnlSecondFields.Controls.Add(this.HSeperator2);
            this.pnlSecondFields.Controls.Add(this.btnDelete);
            this.pnlSecondFields.Controls.Add(this.btnSave);
            this.pnlSecondFields.Controls.Add(this.text_BackToFields);
            this.pnlSecondFields.Controls.Add(this.imgbtnGoFirstFields);
            this.pnlSecondFields.Location = new System.Drawing.Point(12, 556);
            this.pnlSecondFields.Name = "pnlSecondFields";
            this.pnlSecondFields.Size = new System.Drawing.Size(864, 526);
            this.pnlSecondFields.TabIndex = 134;
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(717, 424);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(115, 21);
            this.cbbCountry.TabIndex = 209;
            this.cbbCountry.SelectedIndexChanged += new System.EventHandler(this.CountrySelectedIndexChanged);
            // 
            // dpdCountry
            // 
            this.dpdCountry.BackColor = System.Drawing.Color.Transparent;
            this.dpdCountry.BorderRadius = 3;
            this.dpdCountry.DisabledColor = System.Drawing.Color.Gray;
            this.dpdCountry.ForeColor = System.Drawing.Color.DimGray;
            this.dpdCountry.Items = new string[0];
            this.dpdCountry.Location = new System.Drawing.Point(534, 382);
            this.dpdCountry.Margin = new System.Windows.Forms.Padding(4);
            this.dpdCountry.Name = "dpdCountry";
            this.dpdCountry.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCountry.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCountry.selectedIndex = -1;
            this.dpdCountry.Size = new System.Drawing.Size(300, 35);
            this.dpdCountry.TabIndex = 201;
            this.dpdCountry.onItemSelected += new System.EventHandler(this.CountrySelectedIndexChanged);
            // 
            // text_Email
            // 
            this.text_Email.AutoSize = true;
            this.text_Email.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Email.Location = new System.Drawing.Point(500, 22);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(115, 26);
            this.text_Email.TabIndex = 188;
            this.text_Email.Text = "Email Address";
            // 
            // text_Country
            // 
            this.text_Country.AutoSize = true;
            this.text_Country.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Country.Location = new System.Drawing.Point(526, 349);
            this.text_Country.Name = "text_Country";
            this.text_Country.Size = new System.Drawing.Size(70, 26);
            this.text_Country.TabIndex = 200;
            this.text_Country.Text = "Country";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AutoScroll = true;
            this.txtEmailAddress.AutoSize = true;
            this.txtEmailAddress.BackColor = System.Drawing.Color.White;
            this.txtEmailAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtEmailAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtEmailAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtEmailAddress.BorderThickness = 2;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtEmailAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmailAddress.isPassword = false;
            this.txtEmailAddress.Location = new System.Drawing.Point(501, 54);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(303, 40);
            this.txtEmailAddress.TabIndex = 187;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_City
            // 
            this.text_City.AutoSize = true;
            this.text_City.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_City.Location = new System.Drawing.Point(127, 349);
            this.text_City.Name = "text_City";
            this.text_City.Size = new System.Drawing.Size(40, 26);
            this.text_City.TabIndex = 198;
            this.text_City.Text = "City";
            // 
            // text_Company
            // 
            this.text_Company.AutoSize = true;
            this.text_Company.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Company.Location = new System.Drawing.Point(125, 22);
            this.text_Company.Name = "text_Company";
            this.text_Company.Size = new System.Drawing.Size(86, 26);
            this.text_Company.TabIndex = 186;
            this.text_Company.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoScroll = true;
            this.txtCompany.AutoSize = true;
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtCompany.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtCompany.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtCompany.BorderThickness = 2;
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtCompany.ForeColor = System.Drawing.Color.DimGray;
            this.txtCompany.isPassword = false;
            this.txtCompany.Location = new System.Drawing.Point(130, 54);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(303, 40);
            this.txtCompany.TabIndex = 185;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCity
            // 
            this.txtCity.AutoScroll = true;
            this.txtCity.AutoSize = true;
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtCity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtCity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtCity.BorderThickness = 2;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtCity.ForeColor = System.Drawing.Color.DimGray;
            this.txtCity.isPassword = false;
            this.txtCity.Location = new System.Drawing.Point(132, 381);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(303, 40);
            this.txtCity.TabIndex = 197;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_PostCode
            // 
            this.text_PostCode.AutoSize = true;
            this.text_PostCode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_PostCode.Location = new System.Drawing.Point(524, 252);
            this.text_PostCode.Name = "text_PostCode";
            this.text_PostCode.Size = new System.Drawing.Size(88, 26);
            this.text_PostCode.TabIndex = 196;
            this.text_PostCode.Text = "Post Code";
            // 
            // txtPostCode
            // 
            this.txtPostCode.AutoScroll = true;
            this.txtPostCode.AutoSize = true;
            this.txtPostCode.BackColor = System.Drawing.Color.White;
            this.txtPostCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtPostCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPostCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtPostCode.BorderThickness = 2;
            this.txtPostCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostCode.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtPostCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPostCode.isPassword = false;
            this.txtPostCode.Location = new System.Drawing.Point(529, 284);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(303, 40);
            this.txtPostCode.TabIndex = 195;
            this.txtPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_Street
            // 
            this.text_Street.AutoSize = true;
            this.text_Street.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Street.Location = new System.Drawing.Point(125, 252);
            this.text_Street.Name = "text_Street";
            this.text_Street.Size = new System.Drawing.Size(58, 26);
            this.text_Street.TabIndex = 194;
            this.text_Street.Text = "Street ";
            // 
            // txtStreet
            // 
            this.txtStreet.AutoScroll = true;
            this.txtStreet.AutoSize = true;
            this.txtStreet.BackColor = System.Drawing.Color.White;
            this.txtStreet.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStreet.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStreet.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStreet.BorderThickness = 2;
            this.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStreet.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStreet.ForeColor = System.Drawing.Color.DimGray;
            this.txtStreet.isPassword = false;
            this.txtStreet.Location = new System.Drawing.Point(130, 284);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(303, 40);
            this.txtStreet.TabIndex = 193;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_Website
            // 
            this.text_Website.AutoSize = true;
            this.text_Website.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Website.Location = new System.Drawing.Point(496, 109);
            this.text_Website.Name = "text_Website";
            this.text_Website.Size = new System.Drawing.Size(70, 26);
            this.text_Website.TabIndex = 192;
            this.text_Website.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.AutoScroll = true;
            this.txtWebsite.AutoSize = true;
            this.txtWebsite.BackColor = System.Drawing.Color.White;
            this.txtWebsite.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtWebsite.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtWebsite.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtWebsite.BorderThickness = 2;
            this.txtWebsite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebsite.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtWebsite.ForeColor = System.Drawing.Color.DimGray;
            this.txtWebsite.isPassword = false;
            this.txtWebsite.Location = new System.Drawing.Point(501, 141);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(303, 40);
            this.txtWebsite.TabIndex = 191;
            this.txtWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_PhoneN
            // 
            this.text_PhoneN.AutoSize = true;
            this.text_PhoneN.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_PhoneN.Location = new System.Drawing.Point(125, 109);
            this.text_PhoneN.Name = "text_PhoneN";
            this.text_PhoneN.Size = new System.Drawing.Size(119, 26);
            this.text_PhoneN.TabIndex = 190;
            this.text_PhoneN.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoScroll = true;
            this.txtPhoneNumber.AutoSize = true;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtPhoneNumber.BorderThickness = 2;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(130, 141);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(303, 40);
            this.txtPhoneNumber.TabIndex = 189;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "Delete";
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
            this.btnDelete.IconZoom = 45D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(594, 476);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(126, 40);
            this.btnDelete.TabIndex = 134;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 45D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(729, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnSave.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // imgbtnGoFirstFields
            // 
            this.imgbtnGoFirstFields.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnGoFirstFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnGoFirstFields.Image = global::Vendstor.Properties.Resources.go_back_pay_w;
            this.imgbtnGoFirstFields.ImageActive = null;
            this.imgbtnGoFirstFields.Location = new System.Drawing.Point(12, 487);
            this.imgbtnGoFirstFields.Name = "imgbtnGoFirstFields";
            this.imgbtnGoFirstFields.Size = new System.Drawing.Size(47, 21);
            this.imgbtnGoFirstFields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnGoFirstFields.TabIndex = 129;
            this.imgbtnGoFirstFields.TabStop = false;
            this.imgbtnGoFirstFields.Zoom = 10;
            this.imgbtnGoFirstFields.Click += new System.EventHandler(this.ImgbtnGoFirstFields_Click);
            // 
            // pnlFirstFields
            // 
            this.pnlFirstFields.BackColor = System.Drawing.Color.White;
            this.pnlFirstFields.Controls.Add(this.imgFirstNameValid);
            this.pnlFirstFields.Controls.Add(this.lblContactInfo_Hint);
            this.pnlFirstFields.Controls.Add(this.text_LastN);
            this.pnlFirstFields.Controls.Add(this.txtLastName);
            this.pnlFirstFields.Controls.Add(this.bunifuMetroTextbox14);
            this.pnlFirstFields.Controls.Add(this.text_FirstN);
            this.pnlFirstFields.Controls.Add(this.txtFirstName);
            this.pnlFirstFields.Controls.Add(this.text_ContactInfo);
            this.pnlFirstFields.Controls.Add(this.bunifuMetroTextbox13);
            this.pnlFirstFields.Controls.Add(this.HSeperator1);
            this.pnlFirstFields.Controls.Add(this.txtMarkup);
            this.pnlFirstFields.Controls.Add(this.lblDetails_Hint);
            this.pnlFirstFields.Controls.Add(this.rtxtSupplierDescription);
            this.pnlFirstFields.Controls.Add(this.text_Details);
            this.pnlFirstFields.Controls.Add(this.imgbtnGoSecondFields);
            this.pnlFirstFields.Controls.Add(this.bunifuMetroTextbox12);
            this.pnlFirstFields.Controls.Add(this.lblTitle);
            this.pnlFirstFields.Controls.Add(this.text_SupplierName);
            this.pnlFirstFields.Controls.Add(this.bunifuMetroTextbox10);
            this.pnlFirstFields.Controls.Add(this.text_Markup);
            this.pnlFirstFields.Controls.Add(this.text_Description);
            this.pnlFirstFields.Controls.Add(this.txtSupplierName);
            this.pnlFirstFields.Location = new System.Drawing.Point(12, 12);
            this.pnlFirstFields.Name = "pnlFirstFields";
            this.pnlFirstFields.Size = new System.Drawing.Size(864, 526);
            this.pnlFirstFields.TabIndex = 133;
            // 
            // imgFirstNameValid
            // 
            this.imgFirstNameValid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgFirstNameValid.Location = new System.Drawing.Point(478, 120);
            this.imgFirstNameValid.Name = "imgFirstNameValid";
            this.imgFirstNameValid.Size = new System.Drawing.Size(21, 31);
            this.imgFirstNameValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFirstNameValid.TabIndex = 216;
            this.imgFirstNameValid.TabStop = false;
            // 
            // lblContactInfo_Hint
            // 
            this.lblContactInfo_Hint.AutoSize = true;
            this.lblContactInfo_Hint.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.lblContactInfo_Hint.Location = new System.Drawing.Point(15, 375);
            this.lblContactInfo_Hint.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblContactInfo_Hint.Name = "lblContactInfo_Hint";
            this.lblContactInfo_Hint.Size = new System.Drawing.Size(150, 63);
            this.lblContactInfo_Hint.TabIndex = 189;
            this.lblContactInfo_Hint.Text = "The official name and contact details for your supplier";
            // 
            // text_LastN
            // 
            this.text_LastN.AutoSize = true;
            this.text_LastN.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_LastN.Location = new System.Drawing.Point(542, 371);
            this.text_LastN.Name = "text_LastN";
            this.text_LastN.Size = new System.Drawing.Size(89, 26);
            this.text_LastN.TabIndex = 184;
            this.text_LastN.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.AutoScroll = true;
            this.txtLastName.AutoSize = true;
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtLastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderThickness = 2;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.isPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(547, 403);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(303, 40);
            this.txtLastName.TabIndex = 183;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox14
            // 
            this.bunifuMetroTextbox14.AutoScroll = true;
            this.bunifuMetroTextbox14.AutoSize = true;
            this.bunifuMetroTextbox14.BackColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox14.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox14.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuMetroTextbox14.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox14.BorderThickness = 2;
            this.bunifuMetroTextbox14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox14.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.bunifuMetroTextbox14.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuMetroTextbox14.isPassword = false;
            this.bunifuMetroTextbox14.Location = new System.Drawing.Point(501, 602);
            this.bunifuMetroTextbox14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuMetroTextbox14.Name = "bunifuMetroTextbox14";
            this.bunifuMetroTextbox14.Size = new System.Drawing.Size(303, 36);
            this.bunifuMetroTextbox14.TabIndex = 187;
            this.bunifuMetroTextbox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_FirstN
            // 
            this.text_FirstN.AutoSize = true;
            this.text_FirstN.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_FirstN.Location = new System.Drawing.Point(172, 371);
            this.text_FirstN.Name = "text_FirstN";
            this.text_FirstN.Size = new System.Drawing.Size(88, 26);
            this.text_FirstN.TabIndex = 182;
            this.text_FirstN.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoScroll = true;
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtFirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtFirstName.BorderThickness = 2;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.isPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(177, 403);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(303, 40);
            this.txtFirstName.TabIndex = 181;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_ContactInfo
            // 
            this.text_ContactInfo.AutoSize = true;
            this.text_ContactInfo.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_ContactInfo.Location = new System.Drawing.Point(38, 338);
            this.text_ContactInfo.Name = "text_ContactInfo";
            this.text_ContactInfo.Size = new System.Drawing.Size(110, 28);
            this.text_ContactInfo.TabIndex = 180;
            this.text_ContactInfo.Text = "Contact Info";
            // 
            // bunifuMetroTextbox13
            // 
            this.bunifuMetroTextbox13.AutoScroll = true;
            this.bunifuMetroTextbox13.AutoSize = true;
            this.bunifuMetroTextbox13.BackColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox13.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox13.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuMetroTextbox13.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox13.BorderThickness = 2;
            this.bunifuMetroTextbox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox13.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.bunifuMetroTextbox13.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuMetroTextbox13.isPassword = false;
            this.bunifuMetroTextbox13.Location = new System.Drawing.Point(132, 601);
            this.bunifuMetroTextbox13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuMetroTextbox13.Name = "bunifuMetroTextbox13";
            this.bunifuMetroTextbox13.Size = new System.Drawing.Size(303, 40);
            this.bunifuMetroTextbox13.TabIndex = 185;
            this.bunifuMetroTextbox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HSeperator1
            // 
            this.HSeperator1.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator1.LineThickness = 1;
            this.HSeperator1.Location = new System.Drawing.Point(99, 302);
            this.HSeperator1.Margin = new System.Windows.Forms.Padding(8);
            this.HSeperator1.Name = "HSeperator1";
            this.HSeperator1.Size = new System.Drawing.Size(667, 28);
            this.HSeperator1.TabIndex = 179;
            this.HSeperator1.Transparency = 255;
            this.HSeperator1.Vertical = false;
            // 
            // txtMarkup
            // 
            this.txtMarkup.AutoScroll = true;
            this.txtMarkup.AutoSize = true;
            this.txtMarkup.BackColor = System.Drawing.Color.White;
            this.txtMarkup.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtMarkup.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtMarkup.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtMarkup.BorderThickness = 2;
            this.txtMarkup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarkup.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtMarkup.ForeColor = System.Drawing.Color.DimGray;
            this.txtMarkup.isPassword = false;
            this.txtMarkup.Location = new System.Drawing.Point(533, 115);
            this.txtMarkup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(303, 40);
            this.txtMarkup.TabIndex = 139;
            this.txtMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // imgbtnGoSecondFields
            // 
            this.imgbtnGoSecondFields.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnGoSecondFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnGoSecondFields.Image = global::Vendstor.Properties.Resources.next_filled_w;
            this.imgbtnGoSecondFields.ImageActive = null;
            this.imgbtnGoSecondFields.Location = new System.Drawing.Point(814, 502);
            this.imgbtnGoSecondFields.Name = "imgbtnGoSecondFields";
            this.imgbtnGoSecondFields.Size = new System.Drawing.Size(47, 21);
            this.imgbtnGoSecondFields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnGoSecondFields.TabIndex = 130;
            this.imgbtnGoSecondFields.TabStop = false;
            this.imgbtnGoSecondFields.Zoom = 10;
            this.imgbtnGoSecondFields.Click += new System.EventHandler(this.ImgbtnGoSecondFields_Click);
            // 
            // bunifuMetroTextbox12
            // 
            this.bunifuMetroTextbox12.AutoScroll = true;
            this.bunifuMetroTextbox12.AutoSize = true;
            this.bunifuMetroTextbox12.BackColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox12.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox12.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuMetroTextbox12.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox12.BorderThickness = 2;
            this.bunifuMetroTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox12.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.bunifuMetroTextbox12.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuMetroTextbox12.isPassword = false;
            this.bunifuMetroTextbox12.Location = new System.Drawing.Point(529, 673);
            this.bunifuMetroTextbox12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuMetroTextbox12.Name = "bunifuMetroTextbox12";
            this.bunifuMetroTextbox12.Size = new System.Drawing.Size(303, 36);
            this.bunifuMetroTextbox12.TabIndex = 191;
            this.bunifuMetroTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox10
            // 
            this.bunifuMetroTextbox10.AutoScroll = true;
            this.bunifuMetroTextbox10.AutoSize = true;
            this.bunifuMetroTextbox10.BackColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox10.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox10.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuMetroTextbox10.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.bunifuMetroTextbox10.BorderThickness = 2;
            this.bunifuMetroTextbox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox10.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.bunifuMetroTextbox10.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuMetroTextbox10.isPassword = false;
            this.bunifuMetroTextbox10.Location = new System.Drawing.Point(130, 673);
            this.bunifuMetroTextbox10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuMetroTextbox10.Name = "bunifuMetroTextbox10";
            this.bunifuMetroTextbox10.Size = new System.Drawing.Size(303, 36);
            this.bunifuMetroTextbox10.TabIndex = 189;
            this.bunifuMetroTextbox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imgbtn_Exit
            // 
            this.imgbtn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn_Exit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtn_Exit.ImageActive = null;
            this.imgbtn_Exit.Location = new System.Drawing.Point(870, 1);
            this.imgbtn_Exit.Name = "imgbtn_Exit";
            this.imgbtn_Exit.Size = new System.Drawing.Size(18, 17);
            this.imgbtn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtn_Exit.TabIndex = 135;
            this.imgbtn_Exit.TabStop = false;
            this.imgbtn_Exit.Zoom = 10;
            this.imgbtn_Exit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 1100);
            this.Controls.Add(this.imgbtn_Exit);
            this.Controls.Add(this.pnlSecondFields);
            this.Controls.Add(this.pnlFirstFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Supplier";
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlSecondFields.ResumeLayout(false);
            this.pnlSecondFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoFirstFields)).EndInit();
            this.pnlFirstFields.ResumeLayout(false);
            this.pnlFirstFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirstNameValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnGoSecondFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtn_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuImageButton imgbtn_Exit;
        private System.Windows.Forms.Panel pnlSecondFields;
        private System.Windows.Forms.Label text_Addresses;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label text_BackToFields;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnGoFirstFields;
        private System.Windows.Forms.Panel pnlFirstFields;
        private System.Windows.Forms.Label lblDetails_Hint;
        private System.Windows.Forms.RichTextBox rtxtSupplierDescription;
        private System.Windows.Forms.Label text_Details;
        internal Bunifu.Framework.UI.BunifuImageButton imgbtnGoSecondFields;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label text_SupplierName;
        private System.Windows.Forms.Label text_Markup;
        private System.Windows.Forms.Label text_Description;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSupplierName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMarkup;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator1;
        private System.Windows.Forms.Label text_ContactInfo;
        private System.Windows.Forms.Label text_LastN;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLastName;
        private System.Windows.Forms.Label text_FirstN;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFirstName;
        private System.Windows.Forms.Label text_Email;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmailAddress;
        private System.Windows.Forms.Label text_Company;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCompany;
        private System.Windows.Forms.Label text_Website;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtWebsite;
        private System.Windows.Forms.Label text_PhoneN;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
        private System.Windows.Forms.Label lblContactInfo_Hint;
        private System.Windows.Forms.Label text_Country;
        private System.Windows.Forms.Label text_City;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCity;
        private System.Windows.Forms.Label text_PostCode;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPostCode;
        private System.Windows.Forms.Label text_Street;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStreet;
        private Bunifu.Framework.UI.BunifuDropdown dpdCountry;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox14;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox13;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox12;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox10;
        private System.Windows.Forms.PictureBox imgFirstNameValid;
        private System.Windows.Forms.ComboBox cbbCountry;
    }
}