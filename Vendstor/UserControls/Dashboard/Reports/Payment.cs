using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Reports;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Reports
{
    public partial class Payment : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        List<object> Payments = new List<object>();

        Backend.Objects.Pagination Pagination = new Backend.Objects.Pagination
        {
            MaxResults = 6,
            CurrentPage = 0,
        };
        Backend.Objects.SaleSearchQuery SearchQuery = new Backend.Objects.SaleSearchQuery();

        Color SoftColor;
        bool IsFilterApply = false;

        #endregion

        #region Constructors

        public Payment()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region Properties

        decimal CashAmount { get; set; }
        decimal CreditCardAmount { get; set; }
        decimal StoreCreditAmount { get; set; }

        decimal TotalAmount
        {
            get { return CashAmount + CreditCardAmount + StoreCreditAmount; }
            set { TotalAmount = value; }
        }

        string Currency
        {
            get { return Store.CurrencySign; }
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        private void OnSizeChanged(object sender, EventArgs e)
        {
            this.ResizeControl();
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
            GetPayments();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Previous);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Next);
        }

        private void SwitchFilterApply_Click(object sender, EventArgs e)
        {
            IsFilterApply = switchFilterApply.Value;
        }
        
        private void PaymentsGrid_Click(object sender, EventArgs e)
        {
            // Update
            GetPayments();
        }
        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetPayments();

            // Last week
            dpDateFrom.Value = DateTime.Today.AddDays(-7);
            dpDateTo.Value = DateTime.Today;

            Translate();
        }

        void GetPayments()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                PaymentsGrid.Controls.Clear();
                CashAmount = StoreCreditAmount = CreditCardAmount = 0;

                var response = QueryController.Sale.GetPayments(SearchQuery, Pagination);
                if (response.StatusCode == 200)
                {                   
                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    Payments = response.DataArray;
                    foreach (Backend.Objects.Payment payment in response.DataArray)
                    {                       
                        // Get & Sum
                        var _payment = SetAmounts(payment);
                        CashAmount += _payment.CashAmount;
                        StoreCreditAmount += _payment.StoreCreditAmount;
                        CreditCardAmount += _payment.CreditCardAmount;

                        AddPaymentToGrid(_payment);
                    }
                    Pagination = response.Pagination;
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);

                // Render Totals .. 
                RenderStatistics();
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void AddPaymentToGrid(Backend.Objects.Payment payment)
        {
            //Fill Grid [ PaymentsGrid ] With Rows
            PaymentReportModel paymentReportModel = new PaymentReportModel
            {
                Payment = payment,
                Currency = Store.CurrencySign,
            };
            //Add To Grid
            PaymentsGrid.Controls.Add(paymentReportModel);
        }

        void ToPagination(Enums.Pagination pagination)
        {
            if (pagination == Enums.Pagination.Previous)
                Pagination.CurrentPage = Pagination.PreviousPage;
            else
                Pagination.CurrentPage = Pagination.NextPage;

            // Get  
            GetPayments();
        }

        public static Backend.Objects.Payment SetAmounts(Backend.Objects.Payment payment)
        {
            switch (payment.Method)
            {
                case "Cash":
                    payment.CashAmount = payment.PaidAmount;
                    break;
                case "CreditCard":
                    payment.CreditCardAmount = payment.PaidAmount;
                    break;
                case "StoreCredit":
                    payment.StoreCreditAmount = payment.PaidAmount;
                    break;
            }
            return payment;
        }

        void RenderStatistics()
        {
            var currenyAppend = Currency + " ";
            lblCreditCardAmount.Text = currenyAppend + StringUtil.ToRoundedString(CreditCardAmount);
            lblCashAmount.Text = currenyAppend + StringUtil.ToRoundedString(CashAmount);
            lblStoreCreditAmount.Text = currenyAppend + StringUtil.ToRoundedString(StoreCreditAmount);
            lblTotalAmount.Text = currenyAppend + StringUtil.ToRoundedString(TotalAmount);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnFilter, SoftColor);
            UserInterface.SetFlatButtonColor(btnPrevious, SoftColor);
            UserInterface.SetFlatButtonColor(btnNext, SoftColor);
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            PaymentsGrid.Visible = !isEmpty;
        }

        void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(PaymentsGrid, this.Size, 3, 100 + 100, 150 + 100);
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

                foreach (Control control in pnlGridHeader.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);
                Translation.TranslateControl(btnFilter);
                Translation.TranslateControl(text_Cash_Card);
                Translation.TranslateControl(text_CreditCard);
                Translation.TranslateControl(text_StoreCredit);
                Translation.TranslateControl(text_Total);
            }
        }




        #endregion

        #region OnClose

        #endregion
    }
}
