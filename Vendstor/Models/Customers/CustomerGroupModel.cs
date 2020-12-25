using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Customers
{
    public partial class CustomerGroupModel : UserControl
    {
        #region Variables

        public Backend.Objects.CustomerGroup Group { get; set; }
        public Backend.Objects.User User { get; set; }

        public EventHandler OnDelete;

        Color SoftColor;

        #endregion

        #region Constructors

        public CustomerGroupModel()
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

        private void OnClick(object sender, EventArgs e)
        {
            DisplayCustomerGroup(Enums.Task.Update);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {

        }

        void DisplayCustomerGroup(Enums.Task task)
        {
            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Customers.CustomerGroup customerGroup = new Forms.Customers.CustomerGroup
            {
                Group = Group,
                Task = task,
                TopMost = true
            };

            // Update If Updated
            var formResponse = customerGroup.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Group = (Backend.Objects.CustomerGroup)formResponse.Data;

                //Force Update
                this.Initialize();
            }

            //Remove Blur 
            blur.Close();
        }

        #endregion

        #region Control - Event Handler

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DisplayCustomerGroup(Enums.Task.Update);
        }

        private void BtnViewCustomers_Click(object sender, EventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Alert))
                return;

            Blur blur = new Blur(this.ParentForm, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            MessageDialog messageDialog = new MessageDialog
            {
                DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                SecondBtnText = "No",
                ThirdBtnText = "Yes",
                ThirdBtnColor = Color.Tomato,
                Title = "Are you sure ?",
                Message = $"Are you sure you want to permanently delete { Group.Name }, this group will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                //Delete
                DeleteGroup();
            }

            blur.Close();
        }

        #endregion

        #region  Methods      

        void Initialize()
        {
            //Get 
            if (Group is object)
            {
                lblGroupName.Text = Group.Name;
                lblCustomersCount.Text = Group.CustomersCount.ToString();
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);
        }

        void DeleteGroup()
        {
            if (QueryController.Customers.Group.IsValid(Group))
            {
                var response = QueryController.Customers.Group.Delete(Group);
                if (response.StatusCode == 204)
                {
                    // Delete -> Nothing to show
                    this.OnDelete(this, null);
                    this.Hide();
                    Util.MessageParser.Alert("Group", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Group", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Group", Util.AlertParserType.NotFound);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnViewCustomers.BackColor = btnViewCustomers.Activecolor = btnViewCustomers.Normalcolor = btnEdit.BackColor = btnEdit.Activecolor =
               btnEdit.Normalcolor = SoftColor;
            btnViewCustomers.OnHovercolor = btnEdit.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        #endregion

        #region OnClose


        #endregion
    }
}
