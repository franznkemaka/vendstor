using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Customers;
using Vendstor.Models.Customers;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.Customers
{
    public partial class CustomerGroups : Form
    {
        #region Variables

        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        List<object> groups = new List<object>();

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public CustomerGroups()
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

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            CustomerGroup customerGroupForm = new CustomerGroup
            {
                OnCreate = OnCreateGroup,
                Task = Enums.Task.Create,
                TopMost = true
            };

            //Update
            customerGroupForm.ShowWithResult();      

            blur.Close();
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods

        public void Initialize()
        {
            // Get User
            user = Util.Data.GetUser();

            // Get Groups
            GetGroups();

            Translate();
        }

        void GetGroups()
        {
            if (QueryController.User.IsIdValid(user.Id))
            {
                var response = QueryController.Customers.Group.GetGroups();
                if (response.StatusCode == 200)
                {
                    GroupsGrid.Controls.Clear();

                    // Show Empty Data Card if Count == 0
                    RenderEmptyData(response.DataArray.Count == 0);

                    groups = response.DataArray;
                    foreach (Backend.Objects.CustomerGroup group in response.DataArray)
                        AddGroupToGrid(group);
                }
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void AddGroupToGrid(Backend.Objects.CustomerGroup customerGroup)
        {
            //Fill Grid [ GroupsGrid ] With Group
            CustomerGroupModel customerGroupModel = new CustomerGroupModel
            {
                OnDelete = OnDeleteGroup,
                Group = customerGroup
            };
            //Add To Grid
            GroupsGrid.Controls.Add(customerGroupModel);
        }

        public void OnCreateGroup(object sender, EventArgs e)
        {
            var newGroup = (Backend.Objects.CustomerGroup)sender;
            AddGroupToGrid(newGroup);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteGroup(object sender, EventArgs e)
        {
            GroupsGrid.Controls.Remove((CustomerGroupModel)sender);
            // Update Controls 
            RenderEmptyData(GroupsGrid.Controls.Count == 0);
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            GroupsGrid.Visible = !isEmpty;
        }

        public void InitializeUI()
        {     
            SoftColor = UserInterface.SoftColor;

            btnAddGroup.Activecolor = btnAddGroup.BackColor = btnAddGroup.Normalcolor = btnAddGroup_Alert.Activecolor = btnAddGroup_Alert.BackColor = btnAddGroup_Alert.Normalcolor = SoftColor;
            //HoverColor
            btnAddGroup.OnHovercolor = btnAddGroup_Alert.OnHovercolor =  Color.FromArgb(200, SoftColor);
            //Color Images
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {               
                Translation.TranslateControl(lblTitle);
                Translation.TranslateControl(lblHint);
                Translation.TranslateControl(lblGroupName);
                Translation.TranslateControl(lblCustomersCount);
                Translation.TranslateControl(btnAddGroup);

                UserControlUtil.Func.MoveControlTo(btnAddGroup, new Point(932, 45), new Size(155, 40),
                  new Point(882, 45), new Size(205, 40));
            }
        }
        #endregion

        #region OnClose

        #endregion
    }
}
