using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Models;
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Hardwares;

namespace Vendstor.UserControls
{
    public partial class UserTab : UserControl
    {
        #region Variables

        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.User User = new Backend.Objects.User();

        public enum RootForm { Main, MainDashBoard };
        public int RootFormIndex;
        Color SoftColor;

        string Currency
        {
            get { return Store.CurrencySign;  }
        }


        #endregion

        #region Constructors

        public UserTab()
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

        private void LblSignOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        #endregion

        #region  Methods
               
        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            CheckUser();

            lblUserName.Text = $"{ User.FirstName } { User.LastName }";
            lblUserEmail.Text = User.Email;
            lblUserRole.Text = User.Role;
            imgUserImage.Image = User.ProfileOvalImage;

            // Get & Synchronize Insights
            GetInsights();
            
            Translate();
        }

        void GetInsights()
        {
            var response = QueryController.User.GetInsights(User);

            if (response.StatusCode == 200)
            {
                //Synchronize & Save User 
                Util.Data.SynchronizeUser(User.Id);

                AddInsight("Today", User.DailyRevenue, User.DailySalesCount, true);
                AddInsight("This Week", User.WeeklyRevenue, User.WeeklySalesCount, true);
                AddInsight("This Month", User.MonthlyRevenue, User.MonthlySalesCount, true);
                AddInsight("This Year", User.YearlyRevenue, User.YearlySalesCount, true);
                AddInsight("Total", User.TotalRevenue, User.TotalSalesCount, false);
            }
            else
                Alert.Show("Error", "An error occured while getting User Insights ", Alert.AlertType.Error, isMini: false);
        }

        void AddInsight(string type, decimal revenue, double salesCount, bool addSeperator)
        {
            type = (Translation.IsPossible())
                ? Translation.Translate(type)
                : type;

            UserInsightModel userInsightModel = new UserInsightModel
            {
                Type = type,
                Revenue = revenue,
                SalesCount = salesCount,
                AddSeperator = addSeperator,
                BackgroundColor = Color.White,
                StringSales = StringSales,
                Currency = Currency,
            };
            //Add Control
            InsightsGrid.Controls.Add(userInsightModel);
        }

        void CheckUser()
        {
            if (!QueryController.User.IsIdValid(User.Id))
                Logout();
        }

        void Logout()
        {
            try
            {
                new Sound
                {
                    SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.LogOff)
                }.Play();

                //Reset UserId 
                Properties.Settings.Default.UserId = null;
                Properties.Settings.Default.User = null;

                //Form Login
                Forms.Auth.UserLogin userLogin = new Forms.Auth.UserLogin
                {
                    //Props
                    TopMost = true,
                    WindowState = ParentForm.WindowState
                };

                Main main = (Main)Application.OpenForms["Main"];
                DashboardForm mainDashboard = (DashboardForm)Application.OpenForms["DashboardForm"];

                //Show userLogin Form
                userLogin.ShowDialog();

                //Update ParentForm With Void .Initialize(); 
                if (RootFormIndex == (int)RootForm.Main)
                    main.Initialize();
                else if (RootFormIndex == (int)RootForm.MainDashBoard)
                    mainDashboard.Initialize();

                //Initialize this
                Initialize();
            }
            catch (Exception e)
            {
                Logger.Error(e, 500, "UserTab", "Closing");
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            lblSignOut.ForeColor = SoftColor;
        }

        #endregion

        #region Translate

        string StringSales = "Sales";
        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                lblUserRole.Text = Translation.Translate(lblUserRole.Text);
                lblSignOut.Text = Translation.Translate(lblSignOut.Text);
                StringSales = Translation.Translate(StringSales);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}


