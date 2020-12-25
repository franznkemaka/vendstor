using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Hardwares;

namespace Vendstor.Forms
{
    public partial class Main : Form
    {
        #region Variables

        Backend.Objects.Store store = new Backend.Objects.Store();
        Backend.Objects.User user = new Backend.Objects.User();

        //Enums
        public enum TabOrder { UserTab, NotifiicationTab };

        Image imgNotifShow = Properties.Resources.notification_w;
        Image imgNotifHide = Properties.Resources.hide_w;
        Color SoftColor;

        #endregion

        #region Constructors

        public Main()
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

        private void Cards_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            OpenDashboard(control.Tag.ToString());
        }

        private void ImgbtnLogOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Imgbtn_Maximize_Click(object sender, EventArgs e)
        {
            //Maximize Form
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            Extensions.ExitApplication();
        }
        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Imgbtn_Normalize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            CenterToScreen();
            TopMost = false;
        }

        private void Imgbtn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            TopMost = false;
        }

        private void Imgbtn_Notifications_Click(object sender, EventArgs e)
        {
            ToggleSliderTabs(TabOrder.NotifiicationTab);
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            ToggleSliderTabs(TabOrder.UserTab, isVisible: false);
        }

        private void PnlUser_Click(object sender, EventArgs e)
        {
            ToggleSliderTabs(TabOrder.UserTab, isVisible: true);
        }

        private void TimTime_Tick(object sender, EventArgs e)
        {
            //Change Time
            lblDateTime.Text = DateTime.Now.ToString("HH:mm");
        }

        #endregion

        #region  Methods 

        public void Initialize()
        {
            // Get store & user LogOut if an error occurs
            user = Util.Data.HandshakeUser(this);
            store = Util.Data.HandshakeStore(this);

            Translate();

            serverStatus.Start();

            timTime.Start();

            lblUserDisplayName.Text = $"{ user.FirstName } { user.LastName }";
            lblUserRole.Text = user.Role;
            imgUserProfile.Image = user.ProfileOvalImage;

            lblStoreName.Text = store.Name;
            lblDateDay.Text = StringUtil.ToDateString(DateTime.Now);
            lblDateTime.Text = DateTime.Now.ToString("HH:mm");

            //Align Controls
            Util.Methods.AlignToParent(lblStoreName, this);
        }

        void Logout()
        {
            Util.Func.LogUserOut(this);
        }

        /// <summary>
        /// Open Dashboard With UserControl Name
        /// </summary>
        /// <param name="userControlName"></param>
        void OpenDashboard(string userControlName)
        {
            //Add Blur Effect
            Blur blur = new Blur(this, 0.15);
            blur.Show();

            DashboardForm dashboardForm = new DashboardForm
            {
                //Remove "card" from userControlName
                TabName = userControlName,
                TopMost = true,
                WindowState = this.WindowState
            };
            dashboardForm.ShowDialog();

            //Remove Blur
            blur.Close();
        }

        void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;

            //Change Color
            pnlHeader.BackColor = pnlBottom.BackColor = lblUserRole.ForeColor = lblDateDay.ForeColor = SoftColor;
        }

        void ToggleSliderTabs(TabOrder tabIndex, bool isVisible = false)
        {
            if (tabIndex == TabOrder.UserTab)
            {
                ucUserTab.Visible = isVisible;
                ucNotificationTab.Visible = (ucUserTab.Visible) ? false : false;
            }
            else if (tabIndex == TabOrder.NotifiicationTab)
            {
                ucNotificationTab.Visible = !ucNotificationTab.Visible;
                ucUserTab.Visible = (ucUserTab.Visible) ? false : false;
            }
            //Finally
            imgbtnNotification.Image = (ucNotificationTab.Visible) ? imgNotifHide : imgNotifShow;
        }

        #endregion

        #region Translate

        void Translate()
        {
            //Check Translator API 
            if (Translation.IsPossible())
            {
                //Card Texts
                Translation.TranslateControl(lblSell);
                Translation.TranslateControl(lblProducts);
                Translation.TranslateControl(lblReporting);
                Translation.TranslateControl(lblSalesLedger);
                Translation.TranslateControl(lblHome);
                Translation.TranslateControl(lblSettings);
                Translation.TranslateControl(lblCustomers);
            }
        }

        #endregion

        #region OnClose

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            //Stop Time Timer
            timTime.Stop();

            new Sound
            {
                SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Shutdown)
            }.Play();

            serverStatus.Stop();
        }

        #endregion
    }
}
