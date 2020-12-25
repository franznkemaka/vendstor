using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.Customers
{
    public partial class CustomerDetails : Form
    {
        #region Variables

        public Backend.Objects.Customer Customer { get; set; }
        public Backend.Objects.User User { get; set; }
        public string Currency { get; set; }

        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public CustomerDetails()
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

        public Enums.ActionDialog ShowWithResult()
        {
            this.ShowDialog();
            return ActionDialog;
        }

        public FormResponse ShowWithResponse()
        {
            this.ShowDialog();
            return new FormResponse
            {
                ActionDialog = ActionDialog,
                Data = Customer
            };
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            //Edit Customer
            Customer editCustomerForm = new Customer
            {
                CurrentCustomer = Customer,
                TopMost = true,
                Task = Enums.Task.Update,
            };

            // Update If Updated
            var formResponse = editCustomerForm.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                Customer = (Backend.Objects.Customer)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Close -> Nothing to show
                ActionDialog = Enums.ActionDialog.Deleted;
                this.Close();
            }

            blur.Close();
        }


        private void BtnRedeem_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this))
                return;

            Blur blur = new Blur(this, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            //Edit Customer
            RedeemCustomer redeemCustomer = new RedeemCustomer
            {
                Customer = Customer,
                Currency = Currency,
                TopMost = true,
            };

            // Update If Updated
            var formResponse = redeemCustomer.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Redeem)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                Customer = (Backend.Objects.Customer)formResponse.Data;

                //Force Update
                this.Initialize();
            }

            blur.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();

            MessageDialog messageDialog = new MessageDialog
            {
                DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                SecondBtnText = "No",
                ThirdBtnText = "Yes",
                ThirdBtnColor = Color.Tomato,
                Title = "Are you sure ?",
                Message = $"Are you sure you want to permanently delete { Customer.FirstName }, this customer will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                ActionDialog = Enums.ActionDialog.Deleted;
                //Delete
                DeleteCustomer();
            }

            blur.Close();
        }


        private void LblWebsite_Click(object sender, EventArgs e)
        {
            // PR : Open Website
        }

        private void LblEmailAddress_Click(object sender, EventArgs e)
        {
            // PR : Open Email To Write directly
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            TruncateInput();

            if (!Util.Func.IsUserAllowed(User))
                btnDelete.Visible = false;

            //Get
            GetCustomer();

            Translate();
        }

        void GetCustomer()
        {
            if (QueryController.Customers.Customer.IsValid(Customer))
            {
                lblTitle.Text = $" {Customer.FirstName }, { Customer.LastName } | { Customer.StoreCredit } { Currency }";

                lblSex.Text = Translation.Translate(Customer.Sex);
                lblDateOfBirth.Text = Customer.DateOfBirth.ToShortDateString();
                lblPhoneNumber.Text = Customer.PhoneNumber;
                lblEmail.Text = Customer.Email;
                lblCode.Text = Customer.Code;
                lblWebsite.Text = Customer.Website;

                lblAddress.Text = string.Format("{0}, {1}, {2}, {3}", Customer.Address, Customer.PostCode, Customer.City,
                    Customer.Country);

                GetCustomerInsights();
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.NotFound);
        }

        void GetCustomerInsights()
        {
            lblStoreCreditAmount.Text = lblStoreCreditIssued.Text
                = lblStoreCreditRedeemed.Text = Currency + " " + Customer.StoreCredit.ToString();
            UserControlUtil.Func.ColorStoreCredit(lblStoreCreditAmount, Customer.StoreCredit);
            lblStoreCreditRedeemed.ForeColor = lblStoreCreditIssued.ForeColor = lblStoreCreditAmount.ForeColor;
        }

        void DeleteCustomer()
        {
            if (QueryController.Customers.Customer.IsValid(Customer))
            {
                var response = QueryController.Customers.Customer.Delete(Customer);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Deleted;
                    this.Close();
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.NotFound);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            UserInterface.SetFlatButtonColor(btnEdit, SoftColor);
            UserInterface.SetFlatButtonColor(btnRedeem, SoftColor);
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);

            //Elipse
            new Bunifu.Framework.UI.BunifuElipse
            {
                ElipseRadius = 7,
                TargetControl = pnlToolBox
            };           
        }

        void TruncateInput()
        {
            lblSex.Text = lblDateOfBirth.Text = lblPhoneNumber.Text = 
                lblEmail.Text = lblCode.Text = lblWebsite.Text = lblAddress.Text = "";
        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in this.Controls)
                    if (control is Label && !control.Name.Contains("lbl"))
                        Translation.TranslateControl(control);

                foreach (Control control in cardBalance.Controls)
                    if (control is Label && !control.Name.Contains("lbl"))
                        Translation.TranslateControl(control);

                Translation.TranslateControl(lblHint);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
