namespace Vendstor.UserControls.Dashboard.Setup
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.cardBasicSettings = new Bunifu.Framework.UI.BunifuCards();
            this.cbbCurrency = new System.Windows.Forms.ComboBox();
            this.imgValidPassword = new System.Windows.Forms.PictureBox();
            this.imgValidStoreName = new System.Windows.Forms.PictureBox();
            this.txtStorePassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Password = new System.Windows.Forms.Label();
            this.dpdCurrency = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_Currency = new System.Windows.Forms.Label();
            this.text_StoreName = new System.Windows.Forms.Label();
            this.txtStoreName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_StoreSettings = new System.Windows.Forms.Label();
            this.cardStoreInfo = new Bunifu.Framework.UI.BunifuCards();
            this.txtTaxID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_TaxID = new System.Windows.Forms.Label();
            this.imgValidFirstName = new System.Windows.Forms.PictureBox();
            this.imgValidLastName = new System.Windows.Forms.PictureBox();
            this.imgValidEmail = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_PhoneNumber = new System.Windows.Forms.Label();
            this.txtStoreWebsite = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_sWebsite = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStoreEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Email = new System.Windows.Forms.Label();
            this.text_Names = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_StoreContactInfo = new System.Windows.Forms.Label();
            this.cardAddress = new Bunifu.Framework.UI.BunifuCards();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.imgValidCity = new System.Windows.Forms.PictureBox();
            this.imgValidPostcode = new System.Windows.Forms.PictureBox();
            this.imgValidStreet = new System.Windows.Forms.PictureBox();
            this.txtCity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPostCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_Postcode = new System.Windows.Forms.Label();
            this.dpdCountry = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_Country = new System.Windows.Forms.Label();
            this.text_City = new System.Windows.Forms.Label();
            this.text_Street = new System.Windows.Forms.Label();
            this.txtStreet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.HINT2 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardBasicSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidStoreName)).BeginInit();
            this.cardStoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidEmail)).BeginInit();
            this.cardAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidPostcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidStreet)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBasicSettings
            // 
            this.cardBasicSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardBasicSettings.BackColor = System.Drawing.Color.White;
            this.cardBasicSettings.BorderRadius = 10;
            this.cardBasicSettings.BottomSahddow = false;
            this.cardBasicSettings.color = System.Drawing.Color.White;
            this.cardBasicSettings.Controls.Add(this.cbbCurrency);
            this.cardBasicSettings.Controls.Add(this.imgValidPassword);
            this.cardBasicSettings.Controls.Add(this.imgValidStoreName);
            this.cardBasicSettings.Controls.Add(this.txtStorePassword);
            this.cardBasicSettings.Controls.Add(this.text_Password);
            this.cardBasicSettings.Controls.Add(this.dpdCurrency);
            this.cardBasicSettings.Controls.Add(this.text_Currency);
            this.cardBasicSettings.Controls.Add(this.text_StoreName);
            this.cardBasicSettings.Controls.Add(this.txtStoreName);
            this.cardBasicSettings.Controls.Add(this.text_StoreSettings);
            this.cardBasicSettings.LeftSahddow = false;
            this.cardBasicSettings.Location = new System.Drawing.Point(30, 13);
            this.cardBasicSettings.Name = "cardBasicSettings";
            this.cardBasicSettings.RightSahddow = false;
            this.cardBasicSettings.ShadowDepth = 20;
            this.cardBasicSettings.Size = new System.Drawing.Size(518, 261);
            this.cardBasicSettings.TabIndex = 0;
            // 
            // cbbCurrency
            // 
            this.cbbCurrency.FormattingEnabled = true;
            this.cbbCurrency.Items.AddRange(new object[] {
            "Dollar, $",
            "Euro, €"});
            this.cbbCurrency.Location = new System.Drawing.Point(264, 219);
            this.cbbCurrency.Name = "cbbCurrency";
            this.cbbCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbbCurrency.TabIndex = 145;
            this.cbbCurrency.Visible = false;
            this.cbbCurrency.SelectedIndexChanged += new System.EventHandler(this.CurrencySelectedIndexChanged);
            // 
            // imgValidPassword
            // 
            this.imgValidPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidPassword.Location = new System.Drawing.Point(419, 113);
            this.imgValidPassword.Name = "imgValidPassword";
            this.imgValidPassword.Size = new System.Drawing.Size(21, 31);
            this.imgValidPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidPassword.TabIndex = 144;
            this.imgValidPassword.TabStop = false;
            // 
            // imgValidStoreName
            // 
            this.imgValidStoreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidStoreName.Location = new System.Drawing.Point(419, 52);
            this.imgValidStoreName.Name = "imgValidStoreName";
            this.imgValidStoreName.Size = new System.Drawing.Size(21, 31);
            this.imgValidStoreName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidStoreName.TabIndex = 143;
            this.imgValidStoreName.TabStop = false;
            // 
            // txtStorePassword
            // 
            this.txtStorePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStorePassword.AutoScroll = true;
            this.txtStorePassword.AutoSize = true;
            this.txtStorePassword.BackColor = System.Drawing.Color.White;
            this.txtStorePassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStorePassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStorePassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStorePassword.BorderThickness = 2;
            this.txtStorePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStorePassword.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStorePassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtStorePassword.isPassword = true;
            this.txtStorePassword.Location = new System.Drawing.Point(139, 113);
            this.txtStorePassword.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtStorePassword.Name = "txtStorePassword";
            this.txtStorePassword.Size = new System.Drawing.Size(273, 34);
            this.txtStorePassword.TabIndex = 142;
            this.txtStorePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStorePassword.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_Password
            // 
            this.text_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Password.AutoSize = true;
            this.text_Password.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Password.Location = new System.Drawing.Point(21, 118);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(83, 26);
            this.text_Password.TabIndex = 141;
            this.text_Password.Text = "Password";
            // 
            // dpdCurrency
            // 
            this.dpdCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdCurrency.BackColor = System.Drawing.Color.Transparent;
            this.dpdCurrency.BorderRadius = 3;
            this.dpdCurrency.DisabledColor = System.Drawing.Color.Gray;
            this.dpdCurrency.ForeColor = System.Drawing.Color.DimGray;
            this.dpdCurrency.Items = new string[] {
        "Dollar, $",
        "Euro, €"};
            this.dpdCurrency.Location = new System.Drawing.Point(139, 173);
            this.dpdCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.dpdCurrency.Name = "dpdCurrency";
            this.dpdCurrency.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCurrency.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCurrency.selectedIndex = 0;
            this.dpdCurrency.Size = new System.Drawing.Size(246, 35);
            this.dpdCurrency.TabIndex = 136;
            this.dpdCurrency.onItemSelected += new System.EventHandler(this.CurrencySelectedIndexChanged);
            // 
            // text_Currency
            // 
            this.text_Currency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Currency.AutoSize = true;
            this.text_Currency.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Currency.Location = new System.Drawing.Point(21, 173);
            this.text_Currency.Name = "text_Currency";
            this.text_Currency.Size = new System.Drawing.Size(78, 26);
            this.text_Currency.TabIndex = 114;
            this.text_Currency.Text = "Currency";
            // 
            // text_StoreName
            // 
            this.text_StoreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_StoreName.AutoSize = true;
            this.text_StoreName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_StoreName.Location = new System.Drawing.Point(21, 57);
            this.text_StoreName.Name = "text_StoreName";
            this.text_StoreName.Size = new System.Drawing.Size(98, 26);
            this.text_StoreName.TabIndex = 110;
            this.text_StoreName.Text = "Store Name";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStoreName.AutoScroll = true;
            this.txtStoreName.AutoSize = true;
            this.txtStoreName.BackColor = System.Drawing.Color.White;
            this.txtStoreName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreName.BorderThickness = 2;
            this.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStoreName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreName.isPassword = false;
            this.txtStoreName.Location = new System.Drawing.Point(139, 52);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(273, 35);
            this.txtStoreName.TabIndex = 111;
            this.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreName.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_StoreSettings
            // 
            this.text_StoreSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_StoreSettings.AutoSize = true;
            this.text_StoreSettings.Font = new System.Drawing.Font("Poppins", 14F);
            this.text_StoreSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_StoreSettings.Location = new System.Drawing.Point(13, 10);
            this.text_StoreSettings.Name = "text_StoreSettings";
            this.text_StoreSettings.Size = new System.Drawing.Size(146, 33);
            this.text_StoreSettings.TabIndex = 3;
            this.text_StoreSettings.Text = "Store Settings";
            // 
            // cardStoreInfo
            // 
            this.cardStoreInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStoreInfo.BackColor = System.Drawing.Color.White;
            this.cardStoreInfo.BorderRadius = 10;
            this.cardStoreInfo.BottomSahddow = false;
            this.cardStoreInfo.color = System.Drawing.Color.White;
            this.cardStoreInfo.Controls.Add(this.txtTaxID);
            this.cardStoreInfo.Controls.Add(this.text_TaxID);
            this.cardStoreInfo.Controls.Add(this.imgValidFirstName);
            this.cardStoreInfo.Controls.Add(this.imgValidLastName);
            this.cardStoreInfo.Controls.Add(this.imgValidEmail);
            this.cardStoreInfo.Controls.Add(this.txtPhoneNumber);
            this.cardStoreInfo.Controls.Add(this.text_PhoneNumber);
            this.cardStoreInfo.Controls.Add(this.txtStoreWebsite);
            this.cardStoreInfo.Controls.Add(this.text_sWebsite);
            this.cardStoreInfo.Controls.Add(this.txtLastName);
            this.cardStoreInfo.Controls.Add(this.txtStoreEmail);
            this.cardStoreInfo.Controls.Add(this.text_Email);
            this.cardStoreInfo.Controls.Add(this.text_Names);
            this.cardStoreInfo.Controls.Add(this.txtFirstName);
            this.cardStoreInfo.Controls.Add(this.text_StoreContactInfo);
            this.cardStoreInfo.LeftSahddow = false;
            this.cardStoreInfo.Location = new System.Drawing.Point(578, 13);
            this.cardStoreInfo.Name = "cardStoreInfo";
            this.cardStoreInfo.RightSahddow = false;
            this.cardStoreInfo.ShadowDepth = 20;
            this.cardStoreInfo.Size = new System.Drawing.Size(518, 310);
            this.cardStoreInfo.TabIndex = 138;
            // 
            // txtTaxID
            // 
            this.txtTaxID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTaxID.AutoScroll = true;
            this.txtTaxID.AutoSize = true;
            this.txtTaxID.BackColor = System.Drawing.Color.White;
            this.txtTaxID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTaxID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtTaxID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTaxID.BorderThickness = 2;
            this.txtTaxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxID.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtTaxID.ForeColor = System.Drawing.Color.DimGray;
            this.txtTaxID.isPassword = false;
            this.txtTaxID.Location = new System.Drawing.Point(186, 259);
            this.txtTaxID.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(273, 34);
            this.txtTaxID.TabIndex = 155;
            this.txtTaxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_TaxID
            // 
            this.text_TaxID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_TaxID.AutoSize = true;
            this.text_TaxID.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_TaxID.Location = new System.Drawing.Point(26, 267);
            this.text_TaxID.Name = "text_TaxID";
            this.text_TaxID.Size = new System.Drawing.Size(59, 26);
            this.text_TaxID.TabIndex = 154;
            this.text_TaxID.Text = "Tax ID ";
            // 
            // imgValidFirstName
            // 
            this.imgValidFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidFirstName.Location = new System.Drawing.Point(299, 54);
            this.imgValidFirstName.Name = "imgValidFirstName";
            this.imgValidFirstName.Size = new System.Drawing.Size(21, 22);
            this.imgValidFirstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidFirstName.TabIndex = 153;
            this.imgValidFirstName.TabStop = false;
            // 
            // imgValidLastName
            // 
            this.imgValidLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidLastName.Location = new System.Drawing.Point(471, 54);
            this.imgValidLastName.Name = "imgValidLastName";
            this.imgValidLastName.Size = new System.Drawing.Size(21, 22);
            this.imgValidLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidLastName.TabIndex = 152;
            this.imgValidLastName.TabStop = false;
            // 
            // imgValidEmail
            // 
            this.imgValidEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidEmail.Location = new System.Drawing.Point(466, 96);
            this.imgValidEmail.Name = "imgValidEmail";
            this.imgValidEmail.Size = new System.Drawing.Size(21, 31);
            this.imgValidEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidEmail.TabIndex = 150;
            this.imgValidEmail.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(186, 151);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(273, 34);
            this.txtPhoneNumber.TabIndex = 142;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_PhoneNumber
            // 
            this.text_PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_PhoneNumber.AutoSize = true;
            this.text_PhoneNumber.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_PhoneNumber.Location = new System.Drawing.Point(26, 151);
            this.text_PhoneNumber.Name = "text_PhoneNumber";
            this.text_PhoneNumber.Size = new System.Drawing.Size(119, 26);
            this.text_PhoneNumber.TabIndex = 141;
            this.text_PhoneNumber.Text = "Phone Number";
            // 
            // txtStoreWebsite
            // 
            this.txtStoreWebsite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStoreWebsite.AutoScroll = true;
            this.txtStoreWebsite.AutoSize = true;
            this.txtStoreWebsite.BackColor = System.Drawing.Color.White;
            this.txtStoreWebsite.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreWebsite.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreWebsite.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreWebsite.BorderThickness = 2;
            this.txtStoreWebsite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreWebsite.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStoreWebsite.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreWebsite.isPassword = false;
            this.txtStoreWebsite.Location = new System.Drawing.Point(186, 206);
            this.txtStoreWebsite.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtStoreWebsite.Name = "txtStoreWebsite";
            this.txtStoreWebsite.Size = new System.Drawing.Size(273, 34);
            this.txtStoreWebsite.TabIndex = 140;
            this.txtStoreWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_sWebsite
            // 
            this.text_sWebsite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_sWebsite.AutoSize = true;
            this.text_sWebsite.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_sWebsite.Location = new System.Drawing.Point(26, 206);
            this.text_sWebsite.Name = "text_sWebsite";
            this.text_sWebsite.Size = new System.Drawing.Size(74, 26);
            this.text_sWebsite.TabIndex = 139;
            this.text_sWebsite.Text = "Website ";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtLastName.Location = new System.Drawing.Point(333, 49);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 35);
            this.txtLastName.TabIndex = 138;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // txtStoreEmail
            // 
            this.txtStoreEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStoreEmail.AutoScroll = true;
            this.txtStoreEmail.AutoSize = true;
            this.txtStoreEmail.BackColor = System.Drawing.Color.White;
            this.txtStoreEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreEmail.BorderThickness = 2;
            this.txtStoreEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreEmail.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtStoreEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreEmail.isPassword = false;
            this.txtStoreEmail.Location = new System.Drawing.Point(186, 96);
            this.txtStoreEmail.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtStoreEmail.Name = "txtStoreEmail";
            this.txtStoreEmail.Size = new System.Drawing.Size(273, 34);
            this.txtStoreEmail.TabIndex = 113;
            this.txtStoreEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreEmail.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_Email
            // 
            this.text_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Email.AutoSize = true;
            this.text_Email.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Email.Location = new System.Drawing.Point(25, 104);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(51, 26);
            this.text_Email.TabIndex = 112;
            this.text_Email.Text = "Email";
            // 
            // text_Names
            // 
            this.text_Names.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Names.AutoSize = true;
            this.text_Names.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Names.Location = new System.Drawing.Point(25, 53);
            this.text_Names.Name = "text_Names";
            this.text_Names.Size = new System.Drawing.Size(120, 26);
            this.text_Names.TabIndex = 110;
            this.text_Names.Text = "Contact Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtFirstName.Location = new System.Drawing.Point(151, 49);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 35);
            this.txtFirstName.TabIndex = 111;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_StoreContactInfo
            // 
            this.text_StoreContactInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_StoreContactInfo.AutoSize = true;
            this.text_StoreContactInfo.Font = new System.Drawing.Font("Poppins", 14F);
            this.text_StoreContactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_StoreContactInfo.Location = new System.Drawing.Point(13, 10);
            this.text_StoreContactInfo.Name = "text_StoreContactInfo";
            this.text_StoreContactInfo.Size = new System.Drawing.Size(263, 33);
            this.text_StoreContactInfo.TabIndex = 3;
            this.text_StoreContactInfo.Text = "Store Contact Information";
            // 
            // cardAddress
            // 
            this.cardAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardAddress.BackColor = System.Drawing.Color.White;
            this.cardAddress.BorderRadius = 10;
            this.cardAddress.BottomSahddow = false;
            this.cardAddress.color = System.Drawing.Color.White;
            this.cardAddress.Controls.Add(this.cbbCountry);
            this.cardAddress.Controls.Add(this.imgValidCity);
            this.cardAddress.Controls.Add(this.imgValidPostcode);
            this.cardAddress.Controls.Add(this.imgValidStreet);
            this.cardAddress.Controls.Add(this.txtCity);
            this.cardAddress.Controls.Add(this.txtPostCode);
            this.cardAddress.Controls.Add(this.text_Postcode);
            this.cardAddress.Controls.Add(this.dpdCountry);
            this.cardAddress.Controls.Add(this.text_Country);
            this.cardAddress.Controls.Add(this.text_City);
            this.cardAddress.Controls.Add(this.text_Street);
            this.cardAddress.Controls.Add(this.txtStreet);
            this.cardAddress.Controls.Add(this.label13);
            this.cardAddress.LeftSahddow = false;
            this.cardAddress.Location = new System.Drawing.Point(30, 280);
            this.cardAddress.Name = "cardAddress";
            this.cardAddress.RightSahddow = false;
            this.cardAddress.ShadowDepth = 20;
            this.cardAddress.Size = new System.Drawing.Size(518, 261);
            this.cardAddress.TabIndex = 139;
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Items.AddRange(new object[] {
            "Deutschland",
            "France",
            "England",
            "Norway",
            "Austria",
            "Scotland"});
            this.cbbCountry.Location = new System.Drawing.Point(278, 237);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbbCountry.TabIndex = 146;
            this.cbbCountry.Visible = false;
            this.cbbCountry.SelectedIndexChanged += new System.EventHandler(this.CountrySelectedIndexChanged);
            // 
            // imgValidCity
            // 
            this.imgValidCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidCity.Location = new System.Drawing.Point(344, 145);
            this.imgValidCity.Name = "imgValidCity";
            this.imgValidCity.Size = new System.Drawing.Size(21, 31);
            this.imgValidCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidCity.TabIndex = 147;
            this.imgValidCity.TabStop = false;
            // 
            // imgValidPostcode
            // 
            this.imgValidPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidPostcode.Location = new System.Drawing.Point(344, 97);
            this.imgValidPostcode.Name = "imgValidPostcode";
            this.imgValidPostcode.Size = new System.Drawing.Size(21, 31);
            this.imgValidPostcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidPostcode.TabIndex = 146;
            this.imgValidPostcode.TabStop = false;
            // 
            // imgValidStreet
            // 
            this.imgValidStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidStreet.Location = new System.Drawing.Point(433, 49);
            this.imgValidStreet.Name = "imgValidStreet";
            this.imgValidStreet.Size = new System.Drawing.Size(21, 31);
            this.imgValidStreet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidStreet.TabIndex = 145;
            this.imgValidStreet.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtCity.Location = new System.Drawing.Point(153, 145);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 34);
            this.txtCity.TabIndex = 143;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCity.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtPostCode.Location = new System.Drawing.Point(153, 97);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(184, 34);
            this.txtPostCode.TabIndex = 142;
            this.txtPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPostCode.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // text_Postcode
            // 
            this.text_Postcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Postcode.AutoSize = true;
            this.text_Postcode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Postcode.Location = new System.Drawing.Point(22, 105);
            this.text_Postcode.Name = "text_Postcode";
            this.text_Postcode.Size = new System.Drawing.Size(84, 26);
            this.text_Postcode.TabIndex = 141;
            this.text_Postcode.Text = "PostCode";
            // 
            // dpdCountry
            // 
            this.dpdCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpdCountry.BackColor = System.Drawing.Color.Transparent;
            this.dpdCountry.BorderRadius = 3;
            this.dpdCountry.DisabledColor = System.Drawing.Color.Gray;
            this.dpdCountry.ForeColor = System.Drawing.Color.DimGray;
            this.dpdCountry.Items = new string[] {
        "Germany",
        "France",
        "England",
        "Norway",
        "Austria",
        "Scotland"};
            this.dpdCountry.Location = new System.Drawing.Point(153, 198);
            this.dpdCountry.Margin = new System.Windows.Forms.Padding(4);
            this.dpdCountry.Name = "dpdCountry";
            this.dpdCountry.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCountry.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpdCountry.selectedIndex = -1;
            this.dpdCountry.Size = new System.Drawing.Size(246, 35);
            this.dpdCountry.TabIndex = 137;
            this.dpdCountry.onItemSelected += new System.EventHandler(this.CountrySelectedIndexChanged);
            // 
            // text_Country
            // 
            this.text_Country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Country.AutoSize = true;
            this.text_Country.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Country.Location = new System.Drawing.Point(22, 198);
            this.text_Country.Name = "text_Country";
            this.text_Country.Size = new System.Drawing.Size(70, 26);
            this.text_Country.TabIndex = 134;
            this.text_Country.Text = "Country";
            // 
            // text_City
            // 
            this.text_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_City.AutoSize = true;
            this.text_City.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_City.Location = new System.Drawing.Point(22, 145);
            this.text_City.Name = "text_City";
            this.text_City.Size = new System.Drawing.Size(40, 26);
            this.text_City.TabIndex = 114;
            this.text_City.Text = "City";
            // 
            // text_Street
            // 
            this.text_Street.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Street.AutoSize = true;
            this.text_Street.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_Street.Location = new System.Drawing.Point(21, 49);
            this.text_Street.Name = "text_Street";
            this.text_Street.Size = new System.Drawing.Size(54, 26);
            this.text_Street.TabIndex = 110;
            this.text_Street.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtStreet.Location = new System.Drawing.Point(153, 49);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(273, 35);
            this.txtStreet.TabIndex = 111;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStreet.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(13, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 33);
            this.label13.TabIndex = 3;
            this.label13.Text = "Address";
            // 
            // HINT2
            // 
            this.HINT2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HINT2.AutoSize = true;
            this.HINT2.Font = new System.Drawing.Font("Poppins Light", 8F);
            this.HINT2.ForeColor = System.Drawing.Color.Silver;
            this.HINT2.Location = new System.Drawing.Point(171, 558);
            this.HINT2.MaximumSize = new System.Drawing.Size(800, 0);
            this.HINT2.Name = "HINT2";
            this.HINT2.Size = new System.Drawing.Size(796, 38);
            this.HINT2.TabIndex = 142;
            this.HINT2.Text = resources.GetString("HINT2.Text");
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 45D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(764, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 141;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnCancel.Click += new System.EventHandler(this.OnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(951, 501);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 140;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnSave.Click += new System.EventHandler(this.OnSave_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.HINT2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cardAddress);
            this.Controls.Add(this.cardStoreInfo);
            this.Controls.Add(this.cardBasicSettings);
            this.Name = "General";
            this.Size = new System.Drawing.Size(1138, 607);
            this.Load += new System.EventHandler(this.OnLoad);
            this.cardBasicSettings.ResumeLayout(false);
            this.cardBasicSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidStoreName)).EndInit();
            this.cardStoreInfo.ResumeLayout(false);
            this.cardStoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidEmail)).EndInit();
            this.cardAddress.ResumeLayout(false);
            this.cardAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidPostcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidStreet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardBasicSettings;
        private System.Windows.Forms.Label text_StoreSettings;
        private System.Windows.Forms.Label text_StoreName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreName;
        private System.Windows.Forms.Label text_Currency;
        private Bunifu.Framework.UI.BunifuDropdown dpdCurrency;
        private Bunifu.Framework.UI.BunifuCards cardStoreInfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreEmail;
        private System.Windows.Forms.Label text_Email;
        private System.Windows.Forms.Label text_Names;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFirstName;
        private System.Windows.Forms.Label text_StoreContactInfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStorePassword;
        private System.Windows.Forms.Label text_Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
        private System.Windows.Forms.Label text_PhoneNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreWebsite;
        private System.Windows.Forms.Label text_sWebsite;
        private Bunifu.Framework.UI.BunifuCards cardAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCity;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPostCode;
        private System.Windows.Forms.Label text_Postcode;
        private Bunifu.Framework.UI.BunifuDropdown dpdCountry;
        private System.Windows.Forms.Label text_Country;
        private System.Windows.Forms.Label text_City;
        private System.Windows.Forms.Label text_Street;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStreet;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label HINT2;
        private System.Windows.Forms.PictureBox imgValidPassword;
        private System.Windows.Forms.PictureBox imgValidStoreName;
        private System.Windows.Forms.PictureBox imgValidFirstName;
        private System.Windows.Forms.PictureBox imgValidLastName;
        private System.Windows.Forms.PictureBox imgValidEmail;
        private System.Windows.Forms.PictureBox imgValidCity;
        private System.Windows.Forms.PictureBox imgValidPostcode;
        private System.Windows.Forms.PictureBox imgValidStreet;
        private System.Windows.Forms.ComboBox cbbCurrency;
        private System.Windows.Forms.ComboBox cbbCountry;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTaxID;
        private System.Windows.Forms.Label text_TaxID;
    }
}
