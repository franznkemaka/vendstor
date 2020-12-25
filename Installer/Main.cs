using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Installer
{
    public partial class Main : Form
    {
        #region Variables

        public Manager Manager { get; set; }
        public App App { get; set; }

        bool IsAppUpToDate
        {
            get
            {
                var appCurrentVersion = Util.GetAppVersion(App.KeyName.ToString());
                return Util.IsUpToDate(Constants.VendstorSoftwareId, appCurrentVersion.ToString());
            }
        }

        bool IsAppInstalled
        {
            get
            {
                try
                {
                    return Util.KeyExists(App.KeyName.ToString(), "DisplayName")
                        && Util.PathExists(App.KeyName.ToString(), "InstallLocation");
                }
                catch { return false; }
            }
        }

        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
            InitializeUI();
            Util.SetIcon(this);
        }

        #endregion

        #region Event Handlers

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        private void OnRequestUpdate(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, 0.60);
            blur.Show();
            new UpdateConsent { }.ShowDialog();
            blur.Close();
            Application.Exit();
        }

        private void OnComplete(object sender, EventArgs e)
        {
        }
        private void OnCatchException(object sender, EventArgs e)
        {
            Exception exception = (Exception)sender;
            MessageBox.Show(exception.Message, "An Error Occured");
        }
        private void OnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Control - Event Handler

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            cpgbStatus.Visible = true;
            Manager.InstallOrUpdateApp();
            this.Initialize();
        }

        private void BtnUninstall_Click(object sender, EventArgs e)
        {
            cpgbStatus.Visible = true;
            Manager.UninstallApp();
            this.Initialize();
        }

        private void BtnLaunch_Click(object sender, EventArgs e)
        {
            // Get Install Path + Props
            try
            {
                if (App.ExePath != null)
                    Process.Start(App.ExePath);
            }
            catch
            {
                MessageBox.Show("Error occured while starting the application");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Manager.ChangeLog);
            Manager.InstallOrUpdateApp();
            this.Initialize();
        }

        #endregion

        #region Methods   

        void Initialize()
        {
            Manager = new Manager
            {
                OnCatchException = this.OnCatchException,
                OnComplete = this.OnComplete,
                OnRequestUpdate = this.OnRequestUpdate,
                OnClose = this.OnClose,
                ProductVersion = ProductVersion,
            };

            // Check, Install ...
            Manager.Initialize();

            App = Manager.App;
            SetValues();
            cpgbStatus.Visible = false;

            RenderButtons();
        }

        void RenderButtons()
        {
            Point firstBtnLocation = new Point(206, 350);
            Point secondBtnLocation = new Point(338, 350);
            Point thirdBtnLocation = new Point(470, 350);

            if (IsAppInstalled)
            { // installed

                if (IsAppUpToDate) // uptodate
                {
                    btnLaunch.Visible = btnUninstall.Visible = true;
                    btnLaunch.Location = firstBtnLocation;
                    btnUninstall.Location = secondBtnLocation;

                    btnInstall.Visible = btnUpdate.Visible = false;
                }
                else // no uptodate
                {
                    btnLaunch.Visible = btnUninstall.Visible = btnUpdate.Visible = true;
                    btnLaunch.Location = firstBtnLocation;
                    btnUpdate.Location = secondBtnLocation;
                    btnUninstall.Location = thirdBtnLocation;

                    btnInstall.Visible = false;
                }

                Manager.ImportRegistryProps();
            }
            else // not installed
            {
                btnInstall.Visible = true;
                btnInstall.Location = firstBtnLocation;

                btnUninstall.Visible = btnLaunch.Visible = btnUpdate.Visible = false;
            }
        }

        void SetValues()
        {
            try
            {

                var latestApp = App.Lastest;
                lblSoftwareId.Text = latestApp.Id;
                lblSoftName.Text = latestApp.Name;
                lblDescription.Text = latestApp.Note;
                lblVersion.Text = latestApp.Version;
                lblBuild.Text = latestApp.Build;
                lblReleaseDate.Text = latestApp.ReleasedAt.ToLongDateString();
            }
            catch { MessageBox.Show("Error while fetching Software", "An Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void InitializeUI()
        {
            btnMinimize.Image = Util.ColorImage(btnMinimize.Image, Color.FromArgb(209, 212, 221));
            btnExit.Image = Util.ColorImage(btnExit.Image, Color.FromArgb(209, 212, 221));

            btnInstall.OnHovercolor = btnLaunch.OnHovercolor
                = btnUninstall.OnHovercolor = btnUpdate.OnHovercolor = Color.FromArgb(200, btnInstall.BackColor);

            cpgbStatus.Visible = false;
        }

        #endregion

        #region OnClose 

        #endregion
    }
}
