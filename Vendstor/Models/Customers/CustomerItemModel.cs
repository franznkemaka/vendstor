using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Customers
{
    public partial class CustomerItemModel : UserControl
    {
        #region Variables

        public Backend.Objects.Customer Customer { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public EventHandler OnAdd;
        Color SoftColor;

        #endregion

        #region Constructors

        public CustomerItemModel()
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
            // Emit Parent to Add
            this.OnAdd(Customer, null);
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Customer is object)
            {
                lblCustomerNames.Text = $"{ Customer.FirstName }, { Customer.LastName }";
                lblCustomerTokenWithEmail.Text = $"{ Customer.Code }, { Customer.Email }";
                lblStoreCredit.Text = string.Format("{0} {1}", Store.CurrencySign, Customer.StoreCredit.ToString());

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

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(CustomerGroup, SoftColor);
        }

        #endregion

        #region OnClose

        #endregion

    }
}
