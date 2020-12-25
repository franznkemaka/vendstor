using System;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Hardwares;

namespace Vendstor.UserControls.Auth
{
    public partial class UserLogin : UserControl
    {
        #region Variables

        public EventHandler OnLogin;

        Color SoftColor;
        bool IsPwdChar = true;

        #endregion

        #region Constructors

        public UserLogin()
        {
            InitializeComponent();

            InitializeUI();
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
            ToggleLoginBtnPgb(true);
            Login();
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            //Send Password & PIN At Email => Notify User
            SendUserCredentials();
        }

        private void ImgbtnPwdChar_Click(object sender, EventArgs e)
        {
            //Change Bool [Char Visible] true = false vice versa           
            txtPassword.isPassword = !txtPassword.isPassword;
            IsPwdChar = !IsPwdChar;
            imgbtnTogglePwdChar.Image = (IsPwdChar) ? Properties.Resources.show_w : Properties.Resources.hide_w;

        }

        private void InputValueChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            Translate();
        }

        void Login()
        {
            var user = new Backend.Objects.User
            {
                Username = txtUserName.Text,
                Email = txtUserName.Text,
                Password = txtPassword.Text,
            };

            var response = QueryController.User.Login(user);
            if (response.StatusCode == 200)
            {
                user = (Backend.Objects.User)response.Data;
                this.OnLogin(user, null);
            }
            else
                new Sound { SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Error) }.Play();
            ToggleLoginBtnPgb();
        }

        void SendUserCredentials()
        {
            // PR : Send User Credentails

        }
        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            BackColor = txtPassword.BackColor = txtUserName.BackColor = btnLogin.ActiveFillColor = btnLogin.IdleFillColor = btnLogin.BackColor = SoftColor;
            txtPassword.LineFocusedColor = txtPassword.LineMouseHoverColor = txtUserName.LineMouseHoverColor =
                txtPassword.LineMouseHoverColor = Color.LightGray;
            btnLogin.IdleFillColor = Color.FromArgb(200, SoftColor);
            txtPassword.isPassword = true;
        }

        void ToggleLoginBtnPgb(bool isLoading = false)
        {
            btnLogin.Visible = (isLoading) ? false : true;
            cpgbLoginBtn.Visible = !btnLogin.Visible;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(lblForgotPassword);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
