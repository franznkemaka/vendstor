using System;
using System.Drawing;
using System.Windows.Forms;
//Vendstor

using Vendstor.Forms;
using Vendstor.Models;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Setup
{
    public partial class Users : UserControl
    {
        #region Variables

        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        private int UsersCount { get; set; }

        //Color
        Color SoftColor;

        #endregion

        #region Constructors

        public Users()
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

        #region Event Handler



        #endregion

        #region Control - Event Handler

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(user, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            Blur blur = new Blur(this.ParentForm, 0.60);
            blur.Show();
            
            Forms.User createUserForm = new Forms.User
            {
                Task = Enums.Task.Create,
                TopMost = true
            };

            //Update
            var dialogResult = createUserForm.ShowWithDialog();
            if (dialogResult == Enums.ActionDialog.Created)
            {
                //Delete To Avoid Duplicate
                UsersGrid.Controls.Clear();
                GetUsers();
            }
            blur.Close();
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            UsersGrid.Controls.Clear();
            //Force Update 
            Initialize();
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnAddUser.BackColor = btnAddUser.Activecolor = btnAddUser.Normalcolor = SoftColor;
            btnAddUser.OnHovercolor = Color.FromArgb(200, SoftColor);
            btnAddUser.Size = new Size((Properties.Settings.Default.SoftLocale.Contains("de")) ? 233 : 147, btnAddUser.Size.Height);
            imgbtnForceUpdate.Image = ImageUtil.ColorImage(imgbtnForceUpdate.Image, Color.FromArgb(241, 242, 246));
        }

        void Initialize()
        {
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();

            GetUsers();

            Translate();
        }

        void GetUsers()
        {
            if (QueryController.Store.IsIdValid(store.Id))
            {
                var response = QueryController.User.GetUsers(store);
                if (response.StatusCode == 200)
                {
                    //Show Others Profile If Admin
                    if (Util.Func.IsUserAllowed(user))
                    {
                        foreach (Backend.Objects.User user in response.DataArray)
                        {
                            UserModel userModel = new UserModel
                            {
                                User = user,
                                Currency = store.CurrencySign,
                            };

                            UsersGrid.Controls.Add(userModel);
                        }
                    }
                    else
                    {
                        lblHint.Text = "Manage your account and your sales.";
                        // Show user's profile only
                        UserModel userModel = new UserModel
                        {
                            User = user,
                            Currency = store.CurrencySign,
                        };
                        UsersGrid.Controls.Add(userModel);

                    }
                }
            }
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlHeader.Controls)
                    Translation.TranslateControl(control);
            }
        }

        #endregion

        #region OnClose


        #endregion    
    }
}
