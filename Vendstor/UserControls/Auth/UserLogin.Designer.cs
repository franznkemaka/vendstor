namespace Vendstor.UserControls.Auth
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.imgbtnTogglePwdChar = new Bunifu.Framework.UI.BunifuImageButton();
            this.cpgbLoginBtn = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTogglePwdChar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.HintForeColor = System.Drawing.Color.Snow;
            this.txtUserName.HintText = "Username or Email :";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.LightGray;
            this.txtUserName.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.txtUserName.LineThickness = 2;
            this.txtUserName.Location = new System.Drawing.Point(113, 61);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(316, 44);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Poppins ExtraLight", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.Snow;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.LightGray;
            this.txtPassword.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(113, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(316, 46);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Product Sans", 12F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(204, 298);
            this.lblForgotPassword.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(135, 20);
            this.lblForgotPassword.TabIndex = 45;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForgotPassword.Click += new System.EventHandler(this.LblForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 15;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Product Sans", 14F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 15;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(193, 203);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.Image = global::Vendstor.Properties.Resources.password_login;
            this.picPassword.Location = new System.Drawing.Point(85, 136);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(21, 35);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 42;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = global::Vendstor.Properties.Resources.user_login;
            this.picUser.Location = new System.Drawing.Point(85, 70);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(21, 35);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 43;
            this.picUser.TabStop = false;
            // 
            // imgbtnTogglePwdChar
            // 
            this.imgbtnTogglePwdChar.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTogglePwdChar.Image = global::Vendstor.Properties.Resources.show_w;
            this.imgbtnTogglePwdChar.ImageActive = null;
            this.imgbtnTogglePwdChar.Location = new System.Drawing.Point(436, 135);
            this.imgbtnTogglePwdChar.Name = "imgbtnTogglePwdChar";
            this.imgbtnTogglePwdChar.Size = new System.Drawing.Size(28, 36);
            this.imgbtnTogglePwdChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTogglePwdChar.TabIndex = 0;
            this.imgbtnTogglePwdChar.TabStop = false;
            this.imgbtnTogglePwdChar.Zoom = 10;
            this.imgbtnTogglePwdChar.Click += new System.EventHandler(this.ImgbtnPwdChar_Click);
            // 
            // cpgbLoginBtn
            // 
            this.cpgbLoginBtn.animated = true;
            this.cpgbLoginBtn.animationIterval = 5;
            this.cpgbLoginBtn.animationSpeed = 3;
            this.cpgbLoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.cpgbLoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgbLoginBtn.BackgroundImage")));
            this.cpgbLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgbLoginBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpgbLoginBtn.LabelVisible = false;
            this.cpgbLoginBtn.LineProgressThickness = 2;
            this.cpgbLoginBtn.LineThickness = 2;
            this.cpgbLoginBtn.Location = new System.Drawing.Point(241, 199);
            this.cpgbLoginBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgbLoginBtn.MaxValue = 100;
            this.cpgbLoginBtn.Name = "cpgbLoginBtn";
            this.cpgbLoginBtn.ProgressBackColor = System.Drawing.Color.Transparent;
            this.cpgbLoginBtn.ProgressColor = System.Drawing.Color.White;
            this.cpgbLoginBtn.Size = new System.Drawing.Size(61, 61);
            this.cpgbLoginBtn.TabIndex = 87;
            this.cpgbLoginBtn.Value = 50;
            this.cpgbLoginBtn.Visible = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.cpgbLoginBtn);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.imgbtnTogglePwdChar);
            this.Name = "UserLogin";
            this.Size = new System.Drawing.Size(543, 378);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTogglePwdChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTogglePwdChar;
        private System.Windows.Forms.Label lblForgotPassword;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgbLoginBtn;
    }
}
