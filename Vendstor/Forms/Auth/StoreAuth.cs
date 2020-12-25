using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Auth
{
    public partial class StoreAuth : Form
    {
        #region Variables

        Backend.Objects.Store store = new Backend.Objects.Store();
        Backend.Objects.User user = new Backend.Objects.User();

        public enum AuthPanels { Login, Register, EmailVerification }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ErrorColor = Color.FromArgb(230, 82, 81);

        bool IsPwdChar = true;
        bool IsPwdCharRegister = true;

        Size FormDefaultSize = new Size(873, 529);
        Point ActiveFieldLocation = new Point(404, 0);
        Point InActiveFieldLocation = new Point(404, 1000);

        #endregion

        #region Constructors

        public StoreAuth()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Control - Event Handler

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void LoginInputValueChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Name.Contains("Email"))
                imgValidEmail.Image = Validation.GetValidityImage(Validation.IsEmailValid(control.Text));
            else if (control.Name.Contains("Password"))
                imgValidPassword.Image = Validation.GetValidityImage(Validation.IsPasswordValid(control.Text));
        }

        private void RegisterInputValueChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            if (txt.Name.Contains("StoreName"))
                imgValidStoreName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 5, 20));

            else if (txt.Name.Contains("FirstName"))
                imgValidFirstName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 10));

            else if (txt.Name.Contains("LastName"))
                imgValidLastName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 15));

            else if (txt.Name.Contains("Email"))
                imgValidEmail.Image = Validation.GetValidityImage(Validation.IsEmailValid(txt.Text));

            else if (txt.Name.Contains("Password"))
                imgValidPassword.Image = Validation.GetValidityImage(Validation.IsPasswordValid(txt.Text));

            else if (txt.Name.Contains("Location"))
                imgValidLocation.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 5, 150)
                    && StringUtil.CountOccurence(',', txt.Text) == 3);
            else
                return;
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            ToPanel(AuthPanels.EmailVerification);
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            Initialize();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Extensions.ExitApplication();
        }

        private void PicTogglePwd_Click(object sender, EventArgs e)
        {
            txtPassword.isPassword = !txtPassword.isPassword;
            IsPwdChar = !IsPwdChar;
            imgbtnTogglePwdChar.Image = (IsPwdChar) ? ImageUtil.ColorImage(Properties.Resources.show_w, ColorGray)
                : ImageUtil.ColorImage(Properties.Resources.hide_w, ColorGray);
        }
        private void PicTogglePwdRegister_Click(object sender, EventArgs e)
        {
            txtPassword_Register.isPassword = !txtPassword_Register.isPassword;
            IsPwdCharRegister = !IsPwdCharRegister;
            imgbtnTogglePwdChar_Register.Image = (IsPwdCharRegister) ? ImageUtil.ColorImage(Properties.Resources.show_w, ColorGray)
                : ImageUtil.ColorImage(Properties.Resources.hide_w, ColorGray);
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterStore();
        }
        private void LblLogin_Click(object sender, EventArgs e)
        {
            ToPanel(AuthPanels.Login);
        }
        private void LblRegister_Click(object sender, EventArgs e)
        {
            ToPanel(AuthPanels.Register);
        }
        private void BtnLogin_EmailVerification_Click(object sender, EventArgs e)
        {
            ToPanel(AuthPanels.Login);
        }
        #endregion

        #region Methods - 

        #region Backend

        void Initialize()
        {
            store = Util.Data.GetStore();
            GetLoginInfo();
            Translate();

            ToPanel(AuthPanels.Login);
        }

        void Login()
        {
            bool isSuccess = false;

            if (IsLoginInputValid())
            {
                store.Email = txtEmail.Text;
                store.Password = txtPassword.Text;

                var response = QueryController.Store.Login(store);
                if (response.StatusCode == 200)
                {
                    var _store = (Backend.Objects.Store)response.Data;
                    Util.Data.SynchronizeStore(_store.Id);

                    UserLogin userLogin = new UserLogin();
                    Extensions.HideAndShow(this, userLogin);
                }
                else
                    isSuccess = false;
            }
            else
                return;

            imgValidEmail.Image = imgValidPassword.Image = Validation.GetValidityImage(isSuccess);
        }

        void GetLoginInfo()
        {
            txtEmail.Text = store.Email;
            txtStoreName.Text = store.Name;
        }

        void RegisterStore()
        {
            /* PR : Send Email User With Full Link To Activate Account
             * [Example : "https://vendstor.website.domain/account/activate/[TokenHERE]"] */
            bool isSuccess = false;

            if (IsRegisterInputValid())
            {
                store.Name = txtStoreName_Register.Text;
                store.Email = txtEmail_Register.Text;
                store.Password = txtPassword_Register.Text;
                store.FirstName = txtFirstName.Text;
                store.LastName = txtLastName.Text;
                store.Type = txtStoreName_Register.Text;
                store.Locale = Properties.Settings.Default.SoftLocale;
                store.Address = txtLocation.Text.Split(',')[0];
                store.PostCode = txtLocation.Text.Split(',')[1];
                store.City = txtLocation.Text.Split(',')[2];
                store.Country = txtLocation.Text.Split(',')[3];
                store.PhoneNumber = txtPhoneNumber.Text;

                var response = QueryController.Store.Register(store);
                if (response.StatusCode == 201)
                {
                    var _store = (Backend.Objects.Store)response.Data;
                    store.Id = _store.Id;
                    Properties.Settings.Default.StoreId = _store.Id;

                    QueryController.Tax.Create(_store);

                    RegisterUser();

                    ToPanel(AuthPanels.EmailVerification);
                }
                else if (response.StatusCode == 409)
                    //Email is Invalid since it is already used
                    imgValidEmail_Register.Image = Validation.GetValidityImage(false);

                else
                    isSuccess = false;
            }
            imgValidEmail_Register.Image = imgValidStoreName.Image = imgValidFirstName.Image = imgValidLastName.Image = imgValidPassword_Register.Image
                = imgValidLocation.Image = imgValidPhoneNumber.Image = Validation.GetValidityImage(isSuccess);
        }

        void RegisterUser()
        {
            //Create a new user default Admin  
            user.Email = user.Username = txtEmail_Register.Text;
            user.Password = txtPassword_Register.Text;
            user.Role = "Admin";
            user.FirstName = store.FirstName;
            user.LastName = store.LastName;
            user.Locale = store.Locale;
            user.Color = Properties.Settings.Default.SoftColor;
            user.ImageBlobId = "";

            var response = QueryController.User.Register(user, store);
            if (response.StatusCode == 200)
            {
                var _user = (Backend.Objects.User)response.Data;
                Properties.Settings.Default.UserId = _user.Id;
                Properties.Settings.Default.Save();
            }
        }

        bool IsLoginInputValid()
        {
            if (!Validation.IsEmailValid(txtEmail.Text))
                return false;
            else if (string.IsNullOrEmpty(txtPassword.Text))
                return false;
            else if (string.IsNullOrEmpty(txtEmail.Text))
                return false;
            else if (!Validation.IsPasswordValid(txtPassword.Text))
                return false;
            else
                return true;
        }

        bool IsRegisterInputValid()
        {
            if (!Validation.IsEmailValid(txtEmail_Register.Text))
                return false;
            else if (!Validation.IsPasswordValid(txtPassword_Register.Text))
                return false;
            else if (!Validation.IsStringValid(txtStoreName_Register.Text, 5, 20))
                return false;
            else if (!Validation.IsStringValid(txtFirstName.Text, 3, 10))
                return false;
            else if (!Validation.IsStringValid(txtLastName.Text, 3, 15))
                return false;
            else if (!Validation.IsStringValid(txtLocation.Text, 5, 50))
                return false;
            else if (StringUtil.CountOccurence(',', txtLocation.Text) != 3)
                return false;
            else if (!ckbAcceptTAC.Checked)
                return false;
            else
                return true;
        }

        #endregion

        #region UI 

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorPictureBox(picEmail, ColorGray);
            ImageUtil.ColorPictureBox(picUser, ColorGray);
            ImageUtil.ColorPictureBox(picEmail_Register, ColorGray);
            ImageUtil.ColorPictureBox(picPass, ColorGray);
            ImageUtil.ColorPictureBox(picPassword, ColorGray);
            ImageUtil.ColorPictureBox(picCity, ColorGray);
            ImageUtil.ColorPictureBox(picPhoneNumber, ColorGray);
            ImageUtil.ColorPictureBox(picStoreName, ColorGray);
            ImageUtil.ColorPictureBox(picStoreName_Register, ColorGray);
            ImageUtil.ColorPictureBox(imgbtnTogglePwdChar, ColorGray);
            ImageUtil.ColorPictureBox(imgbtnTogglePwdChar_Register, ColorGray);

            imgbtnForceUpdate.Image = ImageUtil.ColorImage(imgbtnForceUpdate.Image, ColorGray);
            imgbtnClose_Register.Image = imgbtnClose.Image = ImageUtil.ColorImage(imgbtnClose.Image, ColorGray);
            btnLogin.ActiveLineColor = btnLogin.IdleLineColor = btnLogin.IdleFillColor = SoftColor;
            // txtEmail.ForeColor = txtStoreName.ForeColor = txtPassword.ForeColor = txtStoreName.ForeColor =  
            text_Login.ForeColor = lblRegister.ForeColor = lblForgotPassword.ForeColor = txtStoreName.LineFocusedColor = txtStoreName.LineMouseHoverColor = txtPassword.LineMouseHoverColor = txtPassword.LineFocusedColor = txtEmail.LineMouseHoverColor = txtEmail.LineFocusedColor = SoftColor;

            txtPassword_Register.LineMouseHoverColor = txtPassword_Register.LineFocusedColor =  txtLocation.LineFocusedColor = txtLocation.LineMouseHoverColor =
                txtStoreName_Register.LineFocusedColor = txtStoreName_Register.LineMouseHoverColor =
                text_almostdone.ForeColor = text_Register.ForeColor = lblLogin.ForeColor = 
                //= txtPhoneNumber.ForeColor = txtStoreName_Register.ForeColor = txtLocation.ForeColor =  txtEmail_Register.ForeColor = txtPassword_Register.ForeColor =
                txtEmail_Register.LineFocusedColor = txtPhoneNumber.LineFocusedColor = txtPhoneNumber.LineMouseHoverColor = txtStoreName_Register.LineFocusedColor = txtStoreName_Register.LineMouseHoverColor
                = txtEmail_Register.LineMouseHoverColor = txtFirstName.LineFocusedColor = txtFirstName.LineMouseHoverColor = txtPhoneNumber.LineFocusedColor = txtPhoneNumber.LineMouseHoverColor
                = txtLastName.LineFocusedColor = txtLastName.LineMouseHoverColor = SoftColor;
            //txtPhoneNumber.ForeColor  = txtFirstName.ForeColor = txtLastName.ForeColor
            btnLogin_EmailVerification.ActiveFillColor = btnLogin_EmailVerification.ActiveLineColor = btnRegister.ActiveFillColor = btnRegister.ActiveLineColor = btnRegister.ActiveLineColor = btnRegister.ActiveFillColor = Color.FromArgb(200, SoftColor);
            ckbAcceptTAC.CheckedOnColor = ckbAcceptTAC.BackColor = SoftColor;
            btnLogin_EmailVerification.IdleFillColor = btnLogin_EmailVerification.IdleLineColor = btnRegister.IdleLineColor = btnRegister.IdleFillColor = btnRegister.IdleFillColor = btnRegister.IdleLineColor = SoftColor;

            btnLogin.ActiveFillColor = Color.FromArgb(200, SoftColor);

            pnlSideBar.GradientBottomLeft = Color.FromArgb(10, SoftColor);
            pnlSideBar.GradientBottomRight = Color.FromArgb(90, SoftColor);
            pnlSideBar.GradientTopLeft = Color.FromArgb(160, SoftColor);
            pnlSideBar.GradientTopRight = Color.FromArgb(240, SoftColor);

            /*
            foreach (Control c in Controls)
                if (c is BunifuMaterialTextbox)
                    c.ForeColor = SoftColor;
            */
            Size = FormDefaultSize;
        }

        void ToPanel(AuthPanels panel)
        {
            switch (panel)
            {
                case AuthPanels.Login:
                    OrderPanels(pnlLogin, pnlRegister, pnlEmailVerification);
                    break;

                case AuthPanels.Register:
                    OrderPanels(pnlRegister, pnlLogin, pnlEmailVerification);
                    break;

                case AuthPanels.EmailVerification:
                    OrderPanels(pnlEmailVerification, pnlLogin, pnlRegister);
                    break;
            }
        }

        void OrderPanels(Control activeControl, Control inActiveControl1, Control inActiveControl2)
        {
            activeControl.Location = ActiveFieldLocation;
            inActiveControl1.Location = inActiveControl2.Location = InActiveFieldLocation;
        }


        #endregion

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings   
                foreach (Control ctrl in pnlLogin.Controls)
                    if (!String.IsNullOrEmpty(ctrl.Text) && !String.IsNullOrWhiteSpace(ctrl.Text) && ctrl is Label)
                        ctrl.Text = Translation.Translate(ctrl.Text);

                foreach (Control control in pnlRegister.Controls)
                    if (!String.IsNullOrEmpty(control.Text) && !String.IsNullOrWhiteSpace(control.Text) && control is Label)
                        Translation.TranslateControl(control);

                foreach (Control control in pnlEmailVerification.Controls)
                    if (!String.IsNullOrEmpty(control.Text) && !String.IsNullOrWhiteSpace(control.Text) && control is Label)
                        Translation.TranslateControl(control);

                txtEmail.HintText = Translation.Translate(txtEmail.HintText);
                txtStoreName.HintText = Translation.Translate(txtStoreName.HintText);
                btnLogin.ButtonText = Translation.Translate(btnLogin.ButtonText);

                txtEmail_Register.HintText = Translation.Translate(txtEmail_Register.HintText);
                txtStoreName_Register.HintText = Translation.Translate(txtStoreName_Register.HintText);
                txtFirstName.HintText = Translation.Translate(txtFirstName.HintText);
                txtLastName.HintText = Translation.Translate(txtLastName.HintText);
                txtLocation.HintText = Translation.Translate(txtLocation.HintText);
                txtPhoneNumber.HintText = Translation.Translate(txtPhoneNumber.HintText);

                btnRegister.ButtonText = Translation.Translate(btnRegister.ButtonText);
                btnLogin_EmailVerification.ButtonText = Translation.Translate(btnLogin_EmailVerification.ButtonText);

                Translation.TranslateControl(text_soft_Descript_1);
                Translation.TranslateControl(text_soft_Descript_2);
                Translation.TranslateControl(text_tostart);
                Translation.TranslateControl(text_Register);
                Translation.TranslateControl(text_almostdone);
                Translation.TranslateControl(text_check_urmail);
            }

            RecenterControls();
        }

        void RecenterControls()
        {
            Util.Methods.AlignToParent(text_welcomeback, pnlLogin);
            Util.Methods.AlignToParent(text_Login, pnlLogin);
            Util.Methods.AlignToParent(btnLogin, pnlLogin);

            Util.Methods.AlignToParent(btnLogin_EmailVerification, pnlEmailVerification);
            Util.Methods.AlignToParent(text_almostdone, pnlEmailVerification);
            Util.Methods.AlignToParent(text_check_urmail, pnlEmailVerification);

            Util.Methods.AlignToParent(btnRegister, pnlRegister);
            Util.Methods.AlignToParent(text_Register, pnlRegister);
            Util.Methods.AlignToParent(text_tostart, pnlRegister);
        }

        #endregion

        #region OnClose


        #endregion     
    }
}
