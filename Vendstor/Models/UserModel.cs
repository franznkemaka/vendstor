using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Data;

namespace Vendstor.Models
{
    public partial class UserModel : UserControl
    {
        #region Variables

        public int UsersCount { get; set; }
        public Backend.Objects.User User = new Backend.Objects.User();
        public string Currency { get; set; }

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.FromArgb(136, 144, 157);

        #endregion

        #region Constructors

        public UserModel()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        private void OnClick(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            // Open User Details
            Forms.User UserDetails = new Forms.User
            {
                //Task = Enums.Task.Get,
                CurrentUser = User,
                TopMost = true
            };
            //UserDetails.ShowDialog();
            var dialogResult = UserDetails.ShowWithDialog();

            if (dialogResult == Enums.ActionDialog.Updated)
            {
                //Update
                var response = QueryController.User.Get(User);
                if (response.StatusCode == 200)
                    User = (Backend.Objects.User)response.Data;

                var c = User;
                Initialize();
            }
            else if (dialogResult == Enums.ActionDialog.Deleted)
            {
                // Remove from Parent
                this.Hide();
            }


            blur.Close();
        }

        #endregion

        #region Control - Event Handler


        #endregion

        #region  Methods
              
        void Initialize()
        {
            //Get 
            if (User is object)
            {
                lblDisplayName.Text = $"{ User.FirstName } { User.LastName }";
                lblUserRole.Text = User.Role;
                lblEmailAddress.Text = User.Email;

                imgProfileImage.Image = User.ProfileImage;

                var timeAgo = StringUtil.ToTimeAgo(User.LastActive);
                lblLastActive.Text = $"Last Active : { timeAgo}";
            }

            GetUserInsights();

            //Translate 
            Translate();
        }

        void GetUserInsights()
        {
            var response = QueryController.User.GetInsights(User);
            if(response.StatusCode == 200)
                // Update User
                User = (Backend.Objects.User)response.Data;     

            lblDailyRevenue.Text = Currency + " " +  User.DailyRevenue.ToString();
            lblTotalRevenue.Text = Currency + " " + User.TotalRevenue.ToString();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            cardProfileImage.color = SoftColor;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_total);
                Translation.TranslateControl(text_Today_cd);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }

}
