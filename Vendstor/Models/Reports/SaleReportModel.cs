using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Reports
{
    public partial class SaleReportModel : UserControl
    {
        #region Variables

        public Backend.Objects.Sale Sale { get; set; }
        public string Currency { get; set; }

        decimal Profit
        {
            get { return Sale.TotalPrice - Sale.SupplyPrice;  }
        }
        decimal ProfitMargin
        {
            get { return Profit / Sale.TotalPrice * 100; }
        }

        //Color SoftColor;

        #endregion

        #region Constructors

        public SaleReportModel()
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
        
        #region  Methods
               
        void Initialize()
        {
            //Get 
            if (Sale is object )
            {
                lblDate.Text = Sale.SoldAt.ToShortDateString();
                lblRevenue.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Sale.TotalPrice));
                lblCost.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Sale.SupplyPrice));
                lblProfit.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Profit));
                lblMargin.Text = string.Format("{0} {1}", "%", StringUtil.ToRoundedString(ProfitMargin));
                lblTax.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Sale.TaxAmount));
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
