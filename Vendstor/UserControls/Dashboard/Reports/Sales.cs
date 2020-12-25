using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Reports;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Reports
{
    public partial class Sales : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        List<object> SalesObject = new List<object>();

        Backend.Objects.Pagination Pagination = new Backend.Objects.Pagination
        {
            MaxResults = 6,
            CurrentPage = 0,
        };
        Backend.Objects.SaleSearchQuery SearchQuery = new Backend.Objects.SaleSearchQuery
        {
            Type = Enums.SearchQueryType.None
        };


        Color SoftColor;
        bool IsFilterApply = false;

        decimal TotalRevenue { get; set; }
        decimal SupplyPrice { get; set; }
        decimal Profit { get; set; }
        decimal TaxAmount { get; set; }

        string Currency
        {
            get { return Store.CurrencySign; }
        }

        #endregion

        #region Constructors

        public Sales()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region Properties

        decimal GetProfit(Backend.Objects.Sale sale)
        {
            return sale.TotalPrice - sale.SupplyPrice;
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

        private void OnClick(object sender, EventArgs e)
        {
            // Update
            //GetSales();
        }

        #endregion

        #region Control - Event Handler

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            GetDropDownValues();
            SetQueryType();

            //Search
            GetSales();
        }

        private void SwitchFilterApply_Click(object sender, EventArgs e)
        {
            IsFilterApply = switchFilterApply.Value;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Previous);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Next);
        }

        private void SalesGrid_Click(object sender, EventArgs e)
        {
            // Update
            GetSales();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetSales();

            SetDropDownItems();

            Translate();
        }

        void GetSales()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                SalesGrid.Controls.Clear();
                TotalRevenue = SupplyPrice = Profit = TaxAmount = 0;

                var response = QueryController.Sale.GetSales(SearchQuery, Pagination);
                if (response.StatusCode == 200)
                {
                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    SalesObject = response.DataArray;
                    foreach (Backend.Objects.Sale sale in response.DataArray)
                    {
                        AddSaleToGrid(sale);

                        // Sum
                        TotalRevenue += sale.TotalPrice;
                        SupplyPrice += sale.SupplyPrice;
                        Profit += GetProfit(sale);
                        TaxAmount += sale.TaxAmount;
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

        void AddSaleToGrid(Backend.Objects.Sale sale)
        {
            //Fill Grid [ SalesGrid ] With Rows
            SaleReportModel saleReportModel = new SaleReportModel
            {
                Sale = sale,
                Currency = Store.CurrencySign,
            };
            //Add To Grid
            SalesGrid.Controls.Add(saleReportModel);
        }

        void ToPagination(Enums.Pagination pagination)
        {
            if (pagination == Enums.Pagination.Previous)
                Pagination.CurrentPage = Pagination.PreviousPage;
            else
                Pagination.CurrentPage = Pagination.NextPage;

            // Get  
            GetSales();
        }

        void RenderStatistics()
        {
            var currenyAppend = Currency + " ";
            lblRevenueAmount.Text = currenyAppend + StringUtil.ToRoundedString(TotalRevenue);
            lblCostAmount.Text = currenyAppend + StringUtil.ToRoundedString(SupplyPrice);
            lblProfitAmount.Text = currenyAppend + StringUtil.ToRoundedString(Profit);
            lblTaxAmount.Text = currenyAppend + StringUtil.ToRoundedString(TaxAmount);
        }

        void GetDropDownValues()
        {
            SearchQuery.UserId = (dpdUsers.selectedIndex == 0)
                ? ""
                : Backend.Database.Queries.User.GetIdByName(dpdUsers.selectedValue);

            SearchQuery.DateFrom = dpDateFrom.Value;
            SearchQuery.DateTo = dpDateTo.Value;
        }

        void SetQueryType()
        {
            if (!IsFilterApply)
            {
                SearchQuery.Type = Enums.SearchQueryType.None;
                return;
            }

            if (dpdUsers.selectedIndex != 0)
                SearchQuery.Type = Enums.SearchQueryType.Id;
            else
                SearchQuery.Type = Enums.SearchQueryType.DateRange;
        }

        void SetDropDownItems()
        {
            // Users
            var response = QueryController.User.GetUsers(Store);
            if (response.StatusCode == 200)
                foreach (Backend.Objects.User user in response.DataArray)
                    dpdUsers.AddItem(user.Username);

            // Last week
            dpDateFrom.Value = DateTime.Today.AddDays(-7);
            dpDateTo.Value = DateTime.Today;

            // Default (none)
            dpdUsers.selectedIndex = 0;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnFilter, SoftColor);
            UserInterface.SetFlatButtonColor(btnNext, SoftColor);
            UserInterface.SetFlatButtonColor(btnPrevious, SoftColor);
            imgpnl_Profit.BackColor = SoftColor;
            switchFilterApply.OnColor = SoftColor;

        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            SalesGrid.Visible = !isEmpty;
        }

        void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(SalesGrid, this.Size, 3, 100 + 100, 150 + 100);
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
                Translation.TranslateControl(lblNothing_Card);
                Translation.TranslateControl(text_TotalRevenue_Card);
                Translation.TranslateControl(text_Cost_Card);
                Translation.TranslateControl(text_Profit_Card);
                Translation.TranslateControl(text_Tax_Card);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
