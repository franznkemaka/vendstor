namespace Vendstor.Forms.Customers
{
    partial class CustomerDetails
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
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCode = new System.Windows.Forms.Label();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.text_Address = new System.Windows.Forms.Label();
            this.text_Token = new System.Windows.Forms.Label();
            this.text_EmailAddress = new System.Windows.Forms.Label();
            this.text_PhoneNumber = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.text_sex = new System.Windows.Forms.Label();
            this.HSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.btnRedeem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Profile = new System.Windows.Forms.Label();
            this.cardBalance = new Bunifu.Framework.UI.BunifuCards();
            this.lblStoreCreditRedeemed = new System.Windows.Forms.Label();
            this.lblStoreCreditIssued = new System.Windows.Forms.Label();
            this.lblStoreCreditAmount = new System.Windows.Forms.Label();
            this.beta3 = new System.Windows.Forms.Label();
            this.beta2 = new System.Windows.Forms.Label();
            this.beta1 = new System.Windows.Forms.Label();
            this.text_totalredeemed = new System.Windows.Forms.Label();
            this.text_totalissued = new System.Windows.Forms.Label();
            this.text_StoreCredit = new System.Windows.Forms.Label();
            this.text_last12months = new System.Windows.Forms.Label();
            this.text_TotalSpent = new System.Windows.Forms.Label();
            this.HSeperator_Card = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Account = new System.Windows.Forms.Label();
            this.imgBalance = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_Balance = new System.Windows.Forms.Label();
            this.text_DOB = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.text_ContactInfo = new System.Windows.Forms.Label();
            this.text_Website = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.pnlToolBox.SuspendLayout();
            this.cardBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBalance)).BeginInit();
            this.SuspendLayout();
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
            this.btnEdit.Location = new System.Drawing.Point(755, 8);
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
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(817, 19);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 236;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblCode.Location = new System.Drawing.Point(186, 360);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 26);
            this.lblCode.TabIndex = 226;
            this.lblCode.Text = "_Code";
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblAddress.Location = new System.Drawing.Point(186, 435);
            this.lblAddress.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(208, 26);
            this.lblAddress.TabIndex = 225;
            this.lblAddress.Text = "_Street && _City && _Country";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblEmail.Location = new System.Drawing.Point(186, 324);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(170, 26);
            this.lblEmail.TabIndex = 224;
            this.lblEmail.Text = "_email@website.com";
            this.lblEmail.Click += new System.EventHandler(this.LblEmailAddress_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(186, 284);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(125, 26);
            this.lblPhoneNumber.TabIndex = 223;
            this.lblPhoneNumber.Text = "_PhoneNumber";
            // 
            // text_Address
            // 
            this.text_Address.AutoSize = true;
            this.text_Address.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Address.Location = new System.Drawing.Point(31, 435);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(77, 28);
            this.text_Address.TabIndex = 221;
            this.text_Address.Text = "Address";
            // 
            // text_Token
            // 
            this.text_Token.AutoSize = true;
            this.text_Token.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Token.Location = new System.Drawing.Point(31, 360);
            this.text_Token.Name = "text_Token";
            this.text_Token.Size = new System.Drawing.Size(55, 28);
            this.text_Token.TabIndex = 220;
            this.text_Token.Text = "Code";
            // 
            // text_EmailAddress
            // 
            this.text_EmailAddress.AutoSize = true;
            this.text_EmailAddress.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_EmailAddress.Location = new System.Drawing.Point(31, 323);
            this.text_EmailAddress.Name = "text_EmailAddress";
            this.text_EmailAddress.Size = new System.Drawing.Size(124, 28);
            this.text_EmailAddress.TabIndex = 219;
            this.text_EmailAddress.Text = "Email Address";
            // 
            // text_PhoneNumber
            // 
            this.text_PhoneNumber.AccessibleDescription = "Test";
            this.text_PhoneNumber.AutoSize = true;
            this.text_PhoneNumber.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_PhoneNumber.Location = new System.Drawing.Point(31, 282);
            this.text_PhoneNumber.Name = "text_PhoneNumber";
            this.text_PhoneNumber.Size = new System.Drawing.Size(133, 28);
            this.text_PhoneNumber.TabIndex = 218;
            this.text_PhoneNumber.Text = "Phone Number ";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblSex.Location = new System.Drawing.Point(164, 155);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(130, 26);
            this.lblSex.TabIndex = 217;
            this.lblSex.Text = "_Customer_Sex";
            // 
            // text_sex
            // 
            this.text_sex.AutoSize = true;
            this.text_sex.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_sex.Location = new System.Drawing.Point(31, 155);
            this.text_sex.Name = "text_sex";
            this.text_sex.Size = new System.Drawing.Size(39, 28);
            this.text_sex.TabIndex = 216;
            this.text_sex.Text = "Sex";
            // 
            // HSeperator
            // 
            this.HSeperator.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator.LineThickness = 1;
            this.HSeperator.Location = new System.Drawing.Point(28, 264);
            this.HSeperator.Margin = new System.Windows.Forms.Padding(8);
            this.HSeperator.Name = "HSeperator";
            this.HSeperator.Size = new System.Drawing.Size(361, 10);
            this.HSeperator.TabIndex = 211;
            this.HSeperator.Transparency = 255;
            this.HSeperator.Vertical = false;
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.AllowDrop = true;
            this.pnlToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlToolBox.Controls.Add(this.btnRedeem);
            this.pnlToolBox.Controls.Add(this.lblHint);
            this.pnlToolBox.Controls.Add(this.btnDelete);
            this.pnlToolBox.Controls.Add(this.btnEdit);
            this.pnlToolBox.Location = new System.Drawing.Point(12, 51);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(827, 42);
            this.pnlToolBox.TabIndex = 214;
            // 
            // btnRedeem
            // 
            this.btnRedeem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRedeem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedeem.BorderRadius = 5;
            this.btnRedeem.ButtonText = "";
            this.btnRedeem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedeem.DisabledColor = System.Drawing.Color.Gray;
            this.btnRedeem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRedeem.Iconimage = global::Vendstor.Properties.Resources.cash_discount_w;
            this.btnRedeem.Iconimage_right = null;
            this.btnRedeem.Iconimage_right_Selected = null;
            this.btnRedeem.Iconimage_Selected = null;
            this.btnRedeem.IconMarginLeft = 0;
            this.btnRedeem.IconMarginRight = 0;
            this.btnRedeem.IconRightVisible = true;
            this.btnRedeem.IconRightZoom = 0D;
            this.btnRedeem.IconVisible = true;
            this.btnRedeem.IconZoom = 37D;
            this.btnRedeem.IsTab = false;
            this.btnRedeem.Location = new System.Drawing.Point(717, 8);
            this.btnRedeem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRedeem.selected = false;
            this.btnRedeem.Size = new System.Drawing.Size(30, 26);
            this.btnRedeem.TabIndex = 194;
            this.btnRedeem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRedeem.Textcolor = System.Drawing.Color.White;
            this.btnRedeem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedeem.Click += new System.EventHandler(this.BtnRedeem_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(16, 9);
            this.lblHint.MaximumSize = new System.Drawing.Size(700, 120);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(213, 25);
            this.lblHint.TabIndex = 193;
            this.lblHint.Text = "View and edit your Customer";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 14F);
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(473, 33);
            this.lblTitle.TabIndex = 213;
            this.lblTitle.Text = "_FirstName, _LastName | _StoreCredit_Amount";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(35, 137);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(292, 10);
            this.bunifuSeparator1.TabIndex = 237;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // text_Profile
            // 
            this.text_Profile.AutoSize = true;
            this.text_Profile.Font = new System.Drawing.Font("Poppins", 13F);
            this.text_Profile.Location = new System.Drawing.Point(30, 101);
            this.text_Profile.Name = "text_Profile";
            this.text_Profile.Size = new System.Drawing.Size(69, 32);
            this.text_Profile.TabIndex = 238;
            this.text_Profile.Text = "Profile";
            // 
            // cardBalance
            // 
            this.cardBalance.BackColor = System.Drawing.Color.White;
            this.cardBalance.BorderRadius = 5;
            this.cardBalance.BottomSahddow = true;
            this.cardBalance.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardBalance.Controls.Add(this.lblStoreCreditRedeemed);
            this.cardBalance.Controls.Add(this.lblStoreCreditIssued);
            this.cardBalance.Controls.Add(this.lblStoreCreditAmount);
            this.cardBalance.Controls.Add(this.beta3);
            this.cardBalance.Controls.Add(this.beta2);
            this.cardBalance.Controls.Add(this.beta1);
            this.cardBalance.Controls.Add(this.text_totalredeemed);
            this.cardBalance.Controls.Add(this.text_totalissued);
            this.cardBalance.Controls.Add(this.text_StoreCredit);
            this.cardBalance.Controls.Add(this.text_last12months);
            this.cardBalance.Controls.Add(this.text_TotalSpent);
            this.cardBalance.Controls.Add(this.HSeperator_Card);
            this.cardBalance.Controls.Add(this.text_Account);
            this.cardBalance.Controls.Add(this.imgBalance);
            this.cardBalance.Controls.Add(this.text_Balance);
            this.cardBalance.LeftSahddow = true;
            this.cardBalance.Location = new System.Drawing.Point(479, 129);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.RightSahddow = true;
            this.cardBalance.ShadowDepth = 20;
            this.cardBalance.Size = new System.Drawing.Size(354, 296);
            this.cardBalance.TabIndex = 239;
            // 
            // lblStoreCreditRedeemed
            // 
            this.lblStoreCreditRedeemed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCreditRedeemed.AutoSize = true;
            this.lblStoreCreditRedeemed.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblStoreCreditRedeemed.Location = new System.Drawing.Point(277, 234);
            this.lblStoreCreditRedeemed.Name = "lblStoreCreditRedeemed";
            this.lblStoreCreditRedeemed.Size = new System.Drawing.Size(63, 25);
            this.lblStoreCreditRedeemed.TabIndex = 192;
            this.lblStoreCreditRedeemed.Text = "€ _000";
            // 
            // lblStoreCreditIssued
            // 
            this.lblStoreCreditIssued.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCreditIssued.AutoSize = true;
            this.lblStoreCreditIssued.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblStoreCreditIssued.Location = new System.Drawing.Point(277, 195);
            this.lblStoreCreditIssued.Name = "lblStoreCreditIssued";
            this.lblStoreCreditIssued.Size = new System.Drawing.Size(63, 25);
            this.lblStoreCreditIssued.TabIndex = 191;
            this.lblStoreCreditIssued.Text = "€ _000";
            // 
            // lblStoreCreditAmount
            // 
            this.lblStoreCreditAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStoreCreditAmount.AutoSize = true;
            this.lblStoreCreditAmount.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblStoreCreditAmount.Location = new System.Drawing.Point(277, 160);
            this.lblStoreCreditAmount.Name = "lblStoreCreditAmount";
            this.lblStoreCreditAmount.Size = new System.Drawing.Size(64, 25);
            this.lblStoreCreditAmount.TabIndex = 190;
            this.lblStoreCreditAmount.Text = "€ _000";
            // 
            // beta3
            // 
            this.beta3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beta3.AutoSize = true;
            this.beta3.Font = new System.Drawing.Font("Poppins", 10F);
            this.beta3.Location = new System.Drawing.Point(283, 119);
            this.beta3.Name = "beta3";
            this.beta3.Size = new System.Drawing.Size(58, 25);
            this.beta3.TabIndex = 189;
            this.beta3.Text = "@Beta";
            // 
            // beta2
            // 
            this.beta2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beta2.AutoSize = true;
            this.beta2.Font = new System.Drawing.Font("Poppins", 10F);
            this.beta2.Location = new System.Drawing.Point(283, 87);
            this.beta2.Name = "beta2";
            this.beta2.Size = new System.Drawing.Size(58, 25);
            this.beta2.TabIndex = 188;
            this.beta2.Text = "@Beta";
            // 
            // beta1
            // 
            this.beta1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beta1.AutoSize = true;
            this.beta1.Font = new System.Drawing.Font("Poppins", 10F);
            this.beta1.Location = new System.Drawing.Point(283, 62);
            this.beta1.Name = "beta1";
            this.beta1.Size = new System.Drawing.Size(58, 25);
            this.beta1.TabIndex = 188;
            this.beta1.Text = "@Beta";
            // 
            // text_totalredeemed
            // 
            this.text_totalredeemed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_totalredeemed.AutoSize = true;
            this.text_totalredeemed.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_totalredeemed.Location = new System.Drawing.Point(39, 232);
            this.text_totalredeemed.Name = "text_totalredeemed";
            this.text_totalredeemed.Size = new System.Drawing.Size(132, 26);
            this.text_totalredeemed.TabIndex = 187;
            this.text_totalredeemed.Text = "Total Redeemed";
            // 
            // text_totalissued
            // 
            this.text_totalissued.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_totalissued.AutoSize = true;
            this.text_totalissued.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_totalissued.Location = new System.Drawing.Point(39, 196);
            this.text_totalissued.Name = "text_totalissued";
            this.text_totalissued.Size = new System.Drawing.Size(99, 26);
            this.text_totalissued.TabIndex = 186;
            this.text_totalissued.Text = "Total Issued";
            // 
            // text_StoreCredit
            // 
            this.text_StoreCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_StoreCredit.AutoSize = true;
            this.text_StoreCredit.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_StoreCredit.Location = new System.Drawing.Point(24, 157);
            this.text_StoreCredit.Name = "text_StoreCredit";
            this.text_StoreCredit.Size = new System.Drawing.Size(106, 28);
            this.text_StoreCredit.TabIndex = 185;
            this.text_StoreCredit.Text = "Store Credit";
            // 
            // text_last12months
            // 
            this.text_last12months.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_last12months.AutoSize = true;
            this.text_last12months.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_last12months.Location = new System.Drawing.Point(39, 119);
            this.text_last12months.Name = "text_last12months";
            this.text_last12months.Size = new System.Drawing.Size(107, 26);
            this.text_last12months.TabIndex = 184;
            this.text_last12months.Text = "Last 12 Moths";
            // 
            // text_TotalSpent
            // 
            this.text_TotalSpent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_TotalSpent.AutoSize = true;
            this.text_TotalSpent.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_TotalSpent.Location = new System.Drawing.Point(39, 85);
            this.text_TotalSpent.Name = "text_TotalSpent";
            this.text_TotalSpent.Size = new System.Drawing.Size(94, 26);
            this.text_TotalSpent.TabIndex = 183;
            this.text_TotalSpent.Text = "Total Spent";
            // 
            // HSeperator_Card
            // 
            this.HSeperator_Card.BackColor = System.Drawing.Color.Transparent;
            this.HSeperator_Card.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.HSeperator_Card.LineThickness = 1;
            this.HSeperator_Card.Location = new System.Drawing.Point(13, 46);
            this.HSeperator_Card.Name = "HSeperator_Card";
            this.HSeperator_Card.Size = new System.Drawing.Size(328, 10);
            this.HSeperator_Card.TabIndex = 182;
            this.HSeperator_Card.Transparency = 255;
            this.HSeperator_Card.Vertical = false;
            // 
            // text_Account
            // 
            this.text_Account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Account.AutoSize = true;
            this.text_Account.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Account.Location = new System.Drawing.Point(26, 59);
            this.text_Account.Name = "text_Account";
            this.text_Account.Size = new System.Drawing.Size(79, 28);
            this.text_Account.TabIndex = 180;
            this.text_Account.Text = "Account";
            // 
            // imgBalance
            // 
            this.imgBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBalance.BackColor = System.Drawing.Color.Transparent;
            this.imgBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBalance.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgBalance.ImageActive = null;
            this.imgBalance.Location = new System.Drawing.Point(29, 23);
            this.imgBalance.Name = "imgBalance";
            this.imgBalance.Size = new System.Drawing.Size(18, 17);
            this.imgBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBalance.TabIndex = 136;
            this.imgBalance.TabStop = false;
            this.imgBalance.Zoom = 10;
            // 
            // text_Balance
            // 
            this.text_Balance.AutoSize = true;
            this.text_Balance.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Balance.Location = new System.Drawing.Point(53, 18);
            this.text_Balance.Name = "text_Balance";
            this.text_Balance.Size = new System.Drawing.Size(78, 28);
            this.text_Balance.TabIndex = 140;
            this.text_Balance.Text = "Balance";
            // 
            // text_DOB
            // 
            this.text_DOB.AutoSize = true;
            this.text_DOB.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_DOB.Location = new System.Drawing.Point(31, 183);
            this.text_DOB.Name = "text_DOB";
            this.text_DOB.Size = new System.Drawing.Size(112, 28);
            this.text_DOB.TabIndex = 240;
            this.text_DOB.Text = "Date Of Birth";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(164, 181);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(188, 26);
            this.lblDateOfBirth.TabIndex = 241;
            this.lblDateOfBirth.Text = "_Customer_DateOfBirth";
            // 
            // text_ContactInfo
            // 
            this.text_ContactInfo.AutoSize = true;
            this.text_ContactInfo.Font = new System.Drawing.Font("Poppins", 13F);
            this.text_ContactInfo.Location = new System.Drawing.Point(27, 230);
            this.text_ContactInfo.Name = "text_ContactInfo";
            this.text_ContactInfo.Size = new System.Drawing.Size(129, 32);
            this.text_ContactInfo.TabIndex = 242;
            this.text_ContactInfo.Text = "Contact Info";
            // 
            // text_Website
            // 
            this.text_Website.AutoSize = true;
            this.text_Website.Font = new System.Drawing.Font("Poppins", 12F);
            this.text_Website.Location = new System.Drawing.Point(30, 397);
            this.text_Website.Name = "text_Website";
            this.text_Website.Size = new System.Drawing.Size(77, 28);
            this.text_Website.TabIndex = 243;
            this.text_Website.Text = "Website";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblWebsite.Location = new System.Drawing.Point(186, 397);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(115, 26);
            this.lblWebsite.TabIndex = 244;
            this.lblWebsite.Text = "_website.com";
            this.lblWebsite.Click += new System.EventHandler(this.LblWebsite_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.text_Website);
            this.Controls.Add(this.text_ContactInfo);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.text_DOB);
            this.Controls.Add(this.cardBalance);
            this.Controls.Add(this.text_Profile);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.text_Token);
            this.Controls.Add(this.text_EmailAddress);
            this.Controls.Add(this.text_PhoneNumber);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.text_sex);
            this.Controls.Add(this.HSeperator);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Customer  Details";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            this.cardBalance.ResumeLayout(false);
            this.cardBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Label lblCode;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label text_Address;
        private System.Windows.Forms.Label text_Token;
        private System.Windows.Forms.Label text_EmailAddress;
        private System.Windows.Forms.Label text_PhoneNumber;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label text_sex;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label text_Profile;
        private Bunifu.Framework.UI.BunifuCards cardBalance;
        private System.Windows.Forms.Label text_Balance;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label text_Website;
        private System.Windows.Forms.Label text_ContactInfo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label text_DOB;
        private Bunifu.Framework.UI.BunifuSeparator HSeperator_Card;
        private System.Windows.Forms.Label text_Account;
        private System.Windows.Forms.Label text_totalredeemed;
        private System.Windows.Forms.Label text_totalissued;
        private System.Windows.Forms.Label text_StoreCredit;
        private System.Windows.Forms.Label text_last12months;
        private System.Windows.Forms.Label text_TotalSpent;
        private System.Windows.Forms.Label beta3;
        private System.Windows.Forms.Label beta2;
        private System.Windows.Forms.Label beta1;
        private System.Windows.Forms.Label lblStoreCreditRedeemed;
        private System.Windows.Forms.Label lblStoreCreditIssued;
        private System.Windows.Forms.Label lblStoreCreditAmount;
        private Bunifu.Framework.UI.BunifuImageButton imgBalance;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuFlatButton btnRedeem;
    }
}