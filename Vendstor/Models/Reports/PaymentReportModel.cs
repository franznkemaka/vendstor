using System;
using System.Windows.Forms;
//Vendstor
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Reports
{
    public partial class PaymentReportModel : UserControl
    {
        #region Variables

        public Backend.Objects.Payment Payment { get; set; }
        public string Currency { get; set; }

        #endregion

        #region Constructors

        public PaymentReportModel()
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

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Payment is object )
            {
                lblDate.Text = Payment.PaidAt.ToLongDateString();
                lblCash.Text = string.Format("{0} {1}", Currency, Payment.CashAmount.ToString());
                lblCreditCard.Text = string.Format("{0} {1}", Currency, Payment.CreditCardAmount.ToString());
                lblStoreCredit.Text = string.Format("{0} {1}", Currency, Payment.StoreCreditAmount.ToString());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void InitializeUI()
        {
        }

        #endregion

        #region OnClose

        #endregion
    }
}
