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
    public partial class Inventory : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        List<object> Products = new List<object>();
        Backend.Objects.Pagination Pagination = new Backend.Objects.Pagination
        {
            MaxResults = 6,
            CurrentPage = 0,
        };
        Backend.Objects.InventorySearchQuery SearchQuery = new Backend.Objects.InventorySearchQuery();

        Color SoftColor;
        bool IsTextSearchQuery = true;

        decimal CurrentStock { get; set; }
        decimal StockValue { get; set; }
        decimal ItemValue { get; set; }

        string Currency
        {
            get { return Store.CurrencySign; }
        }
        
        #endregion

        #region Constructors

        public Inventory()
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
        
        private void OnSizeChanged(object sender, EventArgs e)
        {
            ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            GetDropDownValues();
            SetQueryType();

            //Search
            GetProducts();
        }

        private void SwitchQueryType_Click(object sender, EventArgs e)
        {
            // Toggle
            ToggleSearchType(!IsTextSearchQuery);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Previous);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ToPagination(Enums.Pagination.Next);
        }
        
        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            // Update
            GetProducts();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Get 
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetProducts();

            SetDropDownItems();

            Translate();
        }

        void GetProducts()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                InventoryGrid.Controls.Clear();
                CurrentStock = StockValue = ItemValue = 0;

                var response = QueryController.Products.Product.GetInventoryProducts(SearchQuery, Pagination);
                if (response.StatusCode == 200)
                {
                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    Products = response.DataArray;
                    foreach (Backend.Objects.Product product in response.DataArray)
                    {
                        AddProductToGrid(product);
                        
                        // Sum
                        CurrentStock += product.Stock;
                        StockValue += product.StockValue;
                        ItemValue += product.Price;
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

        void AddProductToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ InventoryGrid ] With Rows
            InventoryReportModel inventoryReportModel = new InventoryReportModel
            {                
                Product = product,
                Currency = Store.CurrencySign,
            };
            //Add To Grid
            InventoryGrid.Controls.Add(inventoryReportModel);
        }

        void ToPagination(Enums.Pagination pagination)
        {
            if (pagination == Enums.Pagination.Previous)
                Pagination.CurrentPage = Pagination.PreviousPage;
            else
                Pagination.CurrentPage = Pagination.NextPage;

            // Get  
            GetProducts();
        }


        void RenderStatistics()
        {
            var currenyAppend = Currency + " ";
            lblCurrentStock.Text = StringUtil.ToRoundedString(CurrentStock);
            lblStockValue.Text = currenyAppend + StringUtil.ToRoundedString(StockValue);
            lblItemValue.Text = currenyAppend + StringUtil.ToRoundedString(ItemValue);
        }

        void GetDropDownValues()
        {
            var stock  = 0;
            // Examples of values
            switch (dpdStock.selectedValue)
            {
                case "On Stock":
                    stock = ReportConstants.OnStockValue;
                    break;

                case "Low Stock":
                    stock = ReportConstants.LowStockValue;
                    break;

                case "No Stock":
                    stock = ReportConstants.NoStockValue;
                    break;
            }

            SearchQuery.Query = txtFilter.Text;
            SearchQuery.Stock = stock;
            SearchQuery.DateFrom = dpDateFrom.Value;
            SearchQuery.DateTo = dpDateTo.Value;
        }

        void SetQueryType()
        {
            if (IsTextSearchQuery)
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                    SearchQuery.Type = Enums.SearchQueryType.None;
                else
                    SearchQuery.Type = Enums.SearchQueryType.Query;
                return;
            }
            else
            {
                if(dpdStock.selectedIndex != 0)
                    SearchQuery.Type = Enums.SearchQueryType.Value;
                else
                    SearchQuery.Type = Enums.SearchQueryType.DateRange;
                return;
            }
        }

        void SetDropDownItems()
        {
            // From Last week To Today
            dpDateFrom.Value = DateTime.Today.AddDays(-7);
            dpDateTo.Value = DateTime.Today;

            // Default (none)
            dpdStock.selectedIndex = 0;
        }

        void InitializeUI()
        {     
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnFilter, SoftColor);
            UserInterface.SetFlatButtonColor(btnPrevious, SoftColor);
            UserInterface.SetFlatButtonColor(btnNext, SoftColor);
            switchQueryType.OnColor = SoftColor;

            UserControlUtil.Func.MoveControlTo(text_CurrentStock, text_CurrentStock.Location, text_CurrentStock.Size,
                new Point(87, 10), text_CurrentStock.Size);
            UserControlUtil.Func.MoveControlTo(text_ItemValue, text_CurrentStock.Location, text_CurrentStock.Size,
                new Point(106, 10), text_ItemValue.Size);
        }
        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            InventoryGrid.Visible = !isEmpty;
        }

        void ToggleSearchType(bool isText)
        {
            pnlCoverDropDowns.Visible = isText;
            IsTextSearchQuery = isText;
        }

        void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(InventoryGrid, this.Size, 3, 100 + 100, 150 + 100);
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
                
                Translation.TranslateControl(text_CurrentStock);
                Translation.TranslateControl(text_StockValue);
                Translation.TranslateControl(text_ItemValue);

            }
        }


        #endregion

        #region OnClose

        #endregion
    }
}
