using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.UserControls.Auth
{
    public partial class PinLogin : UserControl
    {
        #region Variables

        public EventHandler OnLogin;

        Color SoftColor;
        bool IsPinChar = false;

        #endregion

        #region Constructors

        public PinLogin()
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

        private void PinButton_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            txtPin.Text += btn.Text;
        }
        private void ImgbtnDEL_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length > 0)
            {
                txtPin.Text = txtPin.Text.Substring(0, (txtPin.Text.Length - 1));
            }
        }

        private void ImgbtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void TxtPIN_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPin.Text.Length >= 6)
                Login();

            //Validate Input
            imgValidPIN.Image = Validation.GetValidityImage(Validation.IsPINValid(txtPin.Text));
        }

        private void ImgbtnPINChar_Click(object sender, EventArgs e)
        {
            //Change Bool [Char Visible] true = false vice versa           
            txtPin.isPassword = !txtPin.isPassword;
            IsPinChar = !IsPinChar;
            imgbtnPINChar.Image = (IsPinChar) ? Properties.Resources.show_w : Properties.Resources.hide_w;
        }

        private void LblForgotPIN_Click(object sender, EventArgs e)
        {
            //Send Password & PIN At Email => Notify User
            SendUserCredentials();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            Translate();
        }

        void Login()
        {
            bool isSuccess = false;

            // Send Request if input is valid
            if (Validation.IsPINValid(txtPin.Text))
            {
                var user = new Backend.Objects.User { PinCode = txtPin.Text };
                var response = QueryController.User.PinLogin(user);
                if (response.StatusCode == 200)
                {
                    user = (Backend.Objects.User)response.Data;
                    this.OnLogin(user, null);
                }                    
                else
                    isSuccess = false;
            }
            //Change Validity Image
            imgValidPIN.Image = Validation.GetValidityImage(isSuccess);
        }

        void SendUserCredentials()
        {
            // PR : Send User Credentails
        }
        
        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            BackColor = txtPin.BackColor = cardKeyPath.color = SoftColor;
            btn0.OnHovercolor = btn1.OnHovercolor = btn2.OnHovercolor = btn3.OnHovercolor = btn4.OnHovercolor = btn5.OnHovercolor = btn6.OnHovercolor =
                btn7.OnHovercolor = btn8.OnHovercolor = btn9.OnHovercolor = Color.Tomato;
        }

        #endregion

        #region Translate

        void Translate()
        {   
            if (Translation.IsPossible())
            {
                lblForgotPIN.Text = Translation.Translate(lblForgotPIN.Text);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
