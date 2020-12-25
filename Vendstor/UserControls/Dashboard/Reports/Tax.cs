using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Reports
{
    public partial class Tax : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.SaleSearchQuery SearchQuery = new Backend.Objects.SaleSearchQuery { Type = Enums.SearchQueryType.None };

        Color SoftColor;
        bool IsFilterApply = false;

        decimal TotalRevenue { get; set; }
        decimal TaxAmount { get; set; }

        string Currency
        {
            get { return Store.CurrencySign; }
        }

        // Tax Exclusive
        decimal GrossTotalRevenue
        {
            get { return TotalRevenue - TaxAmount; }
        }

        #endregion

        #region Constructors

        public Tax()
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

        #region Control - Event Handler

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            SearchQuery.DateFrom = dpDateFrom.Value;
            SearchQuery.DateTo = dpDateTo.Value;

            if (!IsFilterApply)
                SearchQuery.Type = Enums.SearchQueryType.None;

            else
                SearchQuery.Type = Enums.SearchQueryType.DateRange;

            //Search
            GetTaxes();
        }

        private void SwitchFilterApply_Click(object sender, EventArgs e)
        {
            IsFilterApply = switchFilterApply.Value;
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetTaxes();

            // Last week
            dpDateFrom.Value = DateTime.Today.AddDays(-7);
            dpDateTo.Value = DateTime.Today;

            Translate();
        }

        void GetTaxes()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                var response = QueryController.Sale.SumTaxes(SearchQuery);
                if (response.StatusCode == 200)
                {
                    var data = (IDictionary<string, decimal>)response.Data;
                    TotalRevenue = data["TotalPrice"];
                    TaxAmount = data["TaxAmount"];
                }
                lblTotalRevenue.Text = Currency + " " + GrossTotalRevenue.ToString();
                lblTotalTax.Text = Currency + " " + TaxAmount.ToString();
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnFilter, SoftColor);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlFilter.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);
                foreach (Control control in cardTaxTotal.Controls)
                    if (control is Label && control.Name.Contains("text_"))
                        Translation.TranslateControl(control);
                Translation.TranslateControl(btnFilter);
            }
        }

        #endregion

        #region OnClose
        
        #endregion
    }
}
