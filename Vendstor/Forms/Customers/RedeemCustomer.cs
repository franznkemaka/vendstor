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
    public partial class RedeemCustomer : Form
    {
        #region Variables

        public Backend.Objects.Customer Customer { get; set; }
        public string Currency { get; set; }

        public Enums.Task Task { get; set; }
        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public RedeemCustomer()
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

        private void OnClick(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnRedeem_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtStoreCredit.Text, out decimal amount))
                return;
            // It makes no point to do 0 +0 or 5 + 0
            if (amount == 0)
                return;

            //Redeem
            Redeem(amount);
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            //Get
            if (QueryController.Customers.Customer.IsValid(Customer))
            {
                lblCurrentStoreCredit.Text = Currency + " " + Customer.StoreCredit.ToString();
            }
            else
               Util.MessageParser.Alert("Error", Util.AlertParserType.BadHappened);
            Translate();
        }

        void Redeem(decimal amount)
        {
            var response = QueryController.Customers.Customer.Redeem(Customer, amount);
            if(response.StatusCode == 204)
            {
                ActionDialog = Enums.ActionDialog.Redeem;
                Customer = (Backend.Objects.Customer)response.Data;

                // Print Receipt
                PrintReceipt(amount, Customer.StoreCredit);
                this.Close();
            }
            else
               Util.MessageParser.Alert("Error", Util.AlertParserType.RedeemFailed);
        }

        void PrintReceipt(decimal redeemedAmount, decimal accountBalance)
        {
            Backend.Objects.RedeemReceipt redeemReceipt = new Backend.Objects.RedeemReceipt
            {
                Store = Util.Data.GetStore(),
                User = Util.Data.GetUser(),
                Customer = Customer,                
                RedeemedAmount = redeemedAmount,
                AccountBalance = accountBalance,
            };

            Printing printing = new Printing
            {
                TopMost = true,
                RedeemReceipt = redeemReceipt,
                ReportViewerType = Printing.PintingItems.RedeemReceipt,
            };
            printing.ShowDialog();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnRedeem, SoftColor);
        }

        #endregion

        #region Translate 

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_CurrentStoreCredit);
                Translation.TranslateControl(btnRedeem);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
