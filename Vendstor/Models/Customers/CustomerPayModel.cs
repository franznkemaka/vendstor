using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;
using Vendstor.Forms.Customers;
using Vendstor.Backend.Data;

namespace Vendstor.Models.Customers
{
    public partial class CustomerPayModel : UserControl
    {
        #region Variables

        public Backend.Objects.Customer Customer { get; set; }
        public string Currency { get; set; }

        public bool IsGuest = true;

        Color SoftColor;

        #endregion

        #region Constructors

        public CustomerPayModel()
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
            if (IsGuest)
                return;
            
            //Open Customer Details
            Extensions.ShowDialogWithBlur(this.ParentForm, new CustomerDetails
            {
                Customer = Customer,
                Task = Enums.Task.Get,
                TopMost = true
            }, UIConstants.MinBlurOpacity);
        }

        #endregion

        #region  Methods

        public void Initialize()
        {
            if (IsGuest)
            {
                lblCustomerName.Text = StringGuest;
                lblCustomerId.Text = "GUEST-gUdcpTObQp";
                CustomerGroup.Text = StringGuest;
            }
            else
            {
                //Get 
                if (Customer is object)
                {
                    lblCustomerName.Text = $"{ Customer.FirstName }, { Customer.LastName }";
                    lblCustomerId.Text = $"{ Customer.Code }";
                    lblStoreCredit.Text = string.Format("{0} {1}", Currency, Customer.StoreCredit.ToString());

                    if (Customer.Group is object)
                        if (!string.IsNullOrEmpty(Customer.Group.Name))
                            CustomerGroup.Text = Customer.Group.Name;
                        else
                            CustomerGroup.Visible = false;
                    else
                        CustomerGroup.Visible = false;

                    UserControlUtil.Func.ColorStoreCredit(lblStoreCredit, Customer.StoreCredit);
                }
                else
                    Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);
            }

            Translate();
        }
        
        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(CustomerGroup, SoftColor);
            Indicator.BackColor = SoftColor;
        }

        #endregion

        #region Translate

        string StringGuest = "Guest";
        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_AccountBalance);
                Translation.TranslateControl(text_StoreCredit);
                StringGuest = Translation.Translate(StringGuest);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
