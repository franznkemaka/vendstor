using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Globalization;


//Vendstor
using Vendstor.Modals;
using Vendstor.Forms.Auth;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Hardwares;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

using Extensions = Vendstor.Backend.Utils.Extensions;

namespace Vendstor.Forms
{
    // PR: Done *: Check For Updates
    // PR: Done *: Update Software Using Vendstor Installer

    public partial class SplashScreen : Form
    {
        #region Variables  

        Color SoftColor;
        Image backgroundImage;

        //Status    
        string[] SplashStatus = { "Initializing", "Loading", "Creating Resources", "Downloading User Settings",
            "Connecting To Server", "Synchronizing Soft","Checking For Updates", "Udpating", "Error Occurred While Loading","Exiting" };

        List<string> SplashStatusList = new List<string>();
        public JObject App { get; set; }

        bool IsAppUpToDate
        {
            get
            {
                var isUpTodate = Util.IsUpToDate(Constants.SoftwareId, ProductVersion, out JObject app);
                App = app;
                return isUpTodate;
            }
        }

        #endregion

        #region  Constructors

        public SplashScreen()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsNewUser == true)
            {
                // Detect language
                CultureInfo cultureInfo = CultureInfo.CurrentUICulture;
                var locale = cultureInfo.TwoLetterISOLanguageName;
                Properties.Settings.Default.SoftLocale = locale;

                // Set to old User
                Properties.Settings.Default.IsNewUser = false;
                Properties.Settings.Default.Save();
            }

            new Sound
            {
                SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.StartUp)
            }.Play();

            Translate();

            timSplash.Start();
        }

        #endregion

        #region  Splash - Timer Tick

        private void TimSplash_Tick(object sender, EventArgs e)
        {
            int SplashValue = cpgbSplash.Value;

            if (cpgbSplash.Value != 100)
            {
                cpgbSplash.Value++;

                switch (SplashValue)
                {
                    case 3:
                        lblStatus.Text = SplashStatusList[0] + "...";
                        break;
                    case 4:
                        lblStatus.Text = SplashStatusList[1] + "...";
                        break;
                    case 10:
                        lblStatus.Text = SplashStatusList[2] + "...";
                        break;
                    case 25:
                        lblStatus.Text = SplashStatusList[3] + "...";
                        break;
                    case 50:
                        lblStatus.Text = SplashStatusList[4] + "...";
                        break;
                    case 60:
                        //Synchronize 
                        lblStatus.Text = SplashStatusList[5] + "...";
                        Util.Data.SynchronizeStore();
                        Util.Data.SynchronizeUser();
                        break;
                    case 80:
                        //Checking For Updates
                        lblStatus.Text = SplashStatusList[6] + "...";
                        CheckUpdates();
                        break;

                    case 95:
                        lblStatus.Text = SplashStatusList[9] + "...";
                        break;
                }
            }
            else
            {
                timSplash.Stop();
                SplashTask();
            }
        }

        #endregion

        #region Methods 

        void SplashTask()
        {
            if (ServerUtil.ReportStatus())
            {
                if (QueryController.Store.IsIdValid(Properties.Settings.Default.StoreId))
                {
                    UserLogin userLogin = new UserLogin();
                    Extensions.RunApplication(userLogin);
                }
                else
                {
                    // Store Login 
                    StoreAuth storeLogin = new StoreAuth();
                    Extensions.RunApplication(storeLogin);
                }

                this.Hide();
            }
            else
            {
                // Close Software
                timExit = new Timer();
                timExit.Tick += new EventHandler(TimExit_Tick);
                timExit.Interval = 1000; // 1 second
                timExit.Start();
            }
        }

        void CheckUpdates()
        {
            if (IsAppUpToDate)
                return;
            else
            {
                if (Util.IsUpdateRequired(App))
                {
                    Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
                    blur.Show();

                    MessageDialog messageDialog = new MessageDialog
                    {
                        DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                        DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                        SecondBtnText = "Yes",
                        ThirdBtnText = "No",
                        ThirdBtnColor = Color.Tomato,
                        Title = "A new version is available and it's required",
                        Message = $"A new version is available and it is required, you must update to use this app " +
                        $"again since in each release lot's of errors are fixed & some Backend endpoints are removed. " +
                        $"Should the update start ?",
                        TopMost = true,
                    };

                    var dialogResult = messageDialog.ShowWithEvent();
                    if (dialogResult == MessageDialog.OnClickEvent.SecondButton) // yes
                    {
                        Util.Func.StartInstaller(this);
                    }
                    else // no
                    {
                        Extensions.ExitApplication();
                    }
                    blur.Close();
                }
                else
                {
                    Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
                    blur.Show();

                    MessageDialog messageDialog = new MessageDialog
                    {
                        DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                        DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                        SecondBtnText = "Yes",
                        ThirdBtnText = "No",
                        ThirdBtnColor = Color.Tomato,
                        Title = "A new version is available",
                        Message = $"A new version is available, it's very important to get the latest " +
                        $"update since in each release lots of errors are fixed & some Backend endpoints are removed. " +
                        $"Do you want to update ?",
                        TopMost = true,
                    };

                    var dialogResult = messageDialog.ShowWithEvent();
                    if (dialogResult == MessageDialog.OnClickEvent.SecondButton) // yes
                    {
                        Util.Func.StartInstaller(this);
                    }
                    else // no
                    {
                        // Continue
                        return;
                    }
                    blur.Close();
                }

            }
        }

        private int counter = 15;
        private Timer timExit;
        private void TimExit_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timExit.Stop();
                Application.Exit();
            }
        }

        void InitializeUI()
        {
            //Get 
            SoftColor = UserInterface.SoftColor;
            backgroundImage = ImageUtil.ColorImage(Properties.Resources.SplashScreen, SoftColor);

            //Set 
            lblStatus.ForeColor = cpgbSplash.ProgressColor = SoftColor;
            this.BackgroundImage = backgroundImage;
        }

        #endregion

        #region Translate

        void Translate()
        {
            Translation.ForceUpdate();
            if (Translation.IsPossible())
            {
                //Translate String [Status]
                foreach (var status in SplashStatus)
                    SplashStatusList.Add(Translation.Translate(status));
            }
            else
            {
                foreach (var status in SplashStatus)
                    SplashStatusList.Add(status);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
