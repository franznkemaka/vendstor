using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Hardwares;

namespace Vendstor.Forms.Auth
{
    public partial class UserLogin : Form
    {
        #region Variables

        //User Controls
        UserControls.Auth.UserLogin UserLoginControl;
        UserControls.Auth.CodeLogin CodeLogin;
        UserControls.Auth.PinLogin PinLogin;

        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.User User = new Backend.Objects.User();

        Color SoftColor;

        #endregion

        #region Constuctors

        public UserLogin()
        {
            InitializeComponent();

            UserLoginControl = new UserControls.Auth.UserLogin { OnLogin = OnLogin };
            CodeLogin = new UserControls.Auth.CodeLogin { OnLogin = OnLogin };
            PinLogin = new UserControls.Auth.PinLogin { OnLogin = OnLogin };

            InitializeUI();
            Util.Methods.SetIcon(this);
            if (!Properties.Settings.Default.MaximizeSoftware)
                WindowState = FormWindowState.Normal;          
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();

            //Splash Before Login Form  : 1 = set Splash Visible
            LoadingSplash(true);

            timTime.Start();
        }

        #endregion

        #region Event Handler 

        public void OnLogin(object sender, EventArgs e)
        {
            var user = (Backend.Objects.User)sender;
            //Sync User & Info
            Util.Data.SynchronizeUser(user.Id);

            // Close
            Exit(UserInterface.IsLoginDialog());
        }

        #endregion


        #region Control - Event Handler

        private void ImgbtnPinLogin_Click(object sender, EventArgs e)
        {
            //Change Current LoginOption  
            SwitchLoginOptions(PinLogin);
        }

        private void ImgbtnCodeLogin_Click(object sender, EventArgs e)
        {
            //Change Current LoginOption  
            SwitchLoginOptions(CodeLogin);
        }

        private void ImgbtnUserLogin_Click(object sender, EventArgs e)
        {
            //Change Current LoginOption  
            SwitchLoginOptions(UserLoginControl);
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            //Force Update
            Initialize();
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            Extensions.ExitApplication();
        }

        private void ImgbtnLogoutStore_Click(object sender, EventArgs e)
        {
            LogoutStore();
        }

        private void ImgbtnMaximize_Click(object sender, EventArgs e)
        {
            //Maximize Form
            WindowState = FormWindowState.Maximized;
        }

        private void ImgbtnNormalize_Click(object sender, EventArgs e)
        {
            //Normalize Form
            WindowState = FormWindowState.Normal;
        }

        private void ImgbtnMinimize_Click(object sender, EventArgs e)
        {
            //Minimize Form
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region  Methods 
              
        void Initialize()
        {
            Store = Util.Data.GetStore();
            lblStoreName.Text = Store.Name;

            Translate();
        }
        
        void LoginBackend()
        {

        }

        void LogoutStore()
        {
            // Reset StoreId and navigate to Login
            Properties.Settings.Default.StoreId = null;
            Properties.Settings.Default.Save();

            StoreAuth storeLogin = new StoreAuth();
            Extensions.HideAndShow(this, storeLogin);
        }

        void Exit(bool isDialog = false)
        {
            new Sound
            {
                SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.LogOn)
            }.Play();

            if (isDialog)
            {
                //Close Current Form
                Application.OpenForms["UserLogin"].Close();
                try { Application.OpenForms["UserLogin"].Close(); }
                catch { }                
            }
            else
            {
                Main MainForm = new Main
                {
                    //Props
                    WindowState = WindowState
                };

                Extensions.HideAndShow(this, MainForm);
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            BackColor = pnlLoginOptions.BackColor = SoftColor;
            pnlTaskbar.BackColor = SoftColor;
        }

        //Splash Before Login Form
        public void LoadingSplash(bool isLoading)
        {
            timLoadingSplash.Interval = 1000;  // 1s       

            if (!UserInterface.IsLoginDialog())
                if (Properties.Settings.Default.MaximizeSoftware)
                    WindowState = FormWindowState.Maximized;
            // WindowState = FormWindowState.Maximized;

            if (isLoading)
            {
                timLoadingSplash.Start();

                // visible = false
                pnlSoftName.Visible = pnlSoftView.Visible = lblStoreName.Visible = imgStoreImage.Visible =
                    pnlLoginOptions.Visible = pnlTaskbar.Visible = false;
                pnlVendstorSplash.Visible = lblSoft_Copyright.Visible = true;
            }
            else
            {
                //hide Loading Screen
                pnlSoftName.Visible = pnlSoftView.Visible = lblStoreName.Visible = imgStoreImage.Visible = pnlLoginOptions.Visible = pnlTaskbar.Visible = true;
                pnlVendstorSplash.Visible = lblSoft_Copyright.Visible = false;
                //Show first Login Option
                SwitchLoginOptions(UserLoginControl);
            }
        }
        //Show, Enable, Hide or Disable Button and Images
        void CheckLoginOptionButtons()
        {
            //LoginOptionsButtons : To Avoid Reloading the same Option on Button Click => Disable Button
            if (pnlLoginOptions.Contains(UserLoginControl))
                imgbtnUserLogin.Enabled = false;
            else
                imgbtnUserLogin.Enabled = true;

            if (pnlLoginOptions.Contains(PinLogin))
                imgbtnPinLogin.Enabled = false;
            else
                imgbtnPinLogin.Enabled = true;

            if (pnlLoginOptions.Contains(CodeLogin))
                imgbtnCodeLogin.Enabled = false;
            else
                imgbtnCodeLogin.Enabled = true;
        }

        //Switch Login User Control on BTN Click or frmLoad
        public void SwitchLoginOptions(UserControl uc)
        {
            //To Avoid To Clear or Add Same Login Controls on Timer Tick => Check if it isn't this Control[UserControl]
            if (!pnlLoginOptions.Controls.Contains(uc))
            {
                pnlLoginOptions.Controls.Clear();
                pnlLoginOptions.Controls.Add(uc);
            }

            CheckLoginOptionButtons();

            //Get Current Day 
            lblCurrentTime.Text = $"{StringUtil.ToDateString(DateTime.Now)} :: { DateTime.Now.ToString("HH:mm") }";

            //Center To Parent
            Util.Methods.AlignToParent(lblCurrentTime, pnlTaskbar);

        }

        #endregion

        #region Timer - Tick

        private int splashCounter = 3;

        //Splash Stop after Counter_Splash = 0 
        private void TimVendstorSplash_Tick(object sender, EventArgs e)
        {
            cpgb_VendstorSplash.Value += 15;

            splashCounter--;

            if (splashCounter == 0)
            {
                timLoadingSplash.Stop();
                LoadingSplash(false);                
            }
        }

        private void TimTime_Tick(object sender, EventArgs e)
        {
            //Get Current Day 
            lblCurrentTime.Text = $"{StringUtil.ToDateString(DateTime.Now)} :: { DateTime.Now.ToString("HH:mm") }";
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                lblSlogan.Text = Translation.Translate(lblSlogan.Text);
            }

            //Align Controls
            RefreshControls();
        }

        void RefreshControls()
        {
            Util.Methods.AlignToParent(lblSlogan, pnlVendstorSplash);
            Util.Methods.AlignToParent(lblCurrentTime, pnlTaskbar);
            Util.Methods.AlignToParent(lblStoreName, this);
        }

        #endregion

        #region OnClose

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            timTime.Stop();
            timLoadingSplash.Stop();
        }       

        #endregion

    }
}
