using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Forms.Customers;

using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Customers
{
    public partial class CustomerModel : UserControl
    {
        #region Variables

        public Backend.Objects.Customer Customer { get; set; }
        public Backend.Objects.User User { get; set; }
        public string Currency { get; set; }
        public EventHandler OnDelete;

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public CustomerModel()
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
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            //Open Customer Details
            CustomerDetails customerDetailsForm = new CustomerDetails
            {
                Customer = Customer,
                Currency = Currency,
                Task = Enums.Task.Get,
                TopMost = true,
                User = User,
            };

            // Update If Updated
            var formResponse = customerDetailsForm.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Customer = (Backend.Objects.Customer)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }

            blur.Close();
        }

        #endregion

        #region Control - Event Handler

        private void ImgbtnEdit_Click(object sender, EventArgs e)
        {
            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Customers.Customer customerForm = new Forms.Customers.Customer
            {
                CurrentCustomer = Customer,
                Task = Enums.Task.Update,
                TopMost = true
            };

            // Update If Updated
            var formResponse = customerForm.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Customer = (Backend.Objects.Customer)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }

            //Remove Blur 
            blur.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            TruncateInput();

            //Get 
            if (Customer is object)
            {
                lblCustomerNames.Text = $"{ Customer.FirstName }, { Customer.LastName }";
                lblCustomerTokenWithEmail.Text = $"{ Customer.Code }, { Customer.Email }";
                lblCustomerAddress.Text = $"{ Customer.Address }, { Customer.PostCode }, { Customer.City }, { Customer.Country } ";
                lblCustomerAddress.Text = (lblCustomerAddress.Text.Contains(",,,")) ? "" : lblCustomerAddress.Text;
            }

            //Get Group
            if (Customer.Group is object)
                if (!string.IsNullOrEmpty(Customer.Group.Name))
                    CustomerGroup.Text = Customer.Group.Name;
                else
                    CustomerGroup.Visible = false;
            else
                CustomerGroup.Visible = false;
            
            GetInsights();
        }

        void GetInsights()
        {
            lblStoreCreditAmount.Text = Currency + " " + Customer.StoreCredit.ToString();
            UserControlUtil.Func.ColorStoreCredit(lblStoreCreditAmount, Customer.StoreCredit);
        }

        public void InitializeUI()
        {        
            SoftColor = UserInterface.SoftColor;
            imgbtnEdit.Image = ImageUtil.ColorImage(imgbtnEdit.Image, ColorGray);
            CustomerGroup.BackColor = CustomerGroup.Activecolor = CustomerGroup.Normalcolor = CustomerGroup.OnHovercolor = SoftColor;
        }

        void TruncateInput()
        {
            lblCustomerNames.Text = lblCustomerAddress.Text = lblCustomerTokenWithEmail.Text = lblStoreCreditAmount.Text = "";
        }

        #endregion

        #region OnClose


        #endregion
    }
}
