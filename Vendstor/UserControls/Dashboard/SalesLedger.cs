using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard
{
    public partial class SalesLedger : UserControl
    {
        #region Variables

        BackgroundWorker AsyncWorkerInitialize;
        BackgroundWorker AsyncWorkerFetch;

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.Customer Customer { get; set; }

        List<object> SalesLedgers = new List<object>();

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

        #endregion

        #region Constructors

        public SalesLedger()
        {
            InitializeComponent();

            InitializeUI();

            AsyncWorkerInitialize = new BackgroundWorker();
            AsyncWorkerFetch = new BackgroundWorker();

            // Due to performance Reason 
            // Load Tasks
            AsyncWorkerInitialize.DoWork += AsyncInitialize;
            AsyncWorkerInitialize.RunWorkerCompleted += OnAsyncWorkerCompleted;
            AsyncWorkerFetch.DoWork += AsyncFetch;
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        public void OnAddCustomer(object sender, EventArgs e)
        {
            Customer = (Backend.Objects.Customer)sender;
            lblCustomerName.Text = Customer.FirstName + " " + Customer.LastName;
        }

        public void OnToggleItem(object sender, EventArgs e)
        {
            var saleModel = (SaleLedgerModel)sender;

            // Expand sender if Collapsed and Collapse other controls 
            foreach (SaleLedgerModel saleLedgerModel in SalesLedgersGrid.Controls)
                if (saleLedgerModel == saleModel)
                    if (!saleModel.IsExpanded)
                        saleLedgerModel.ToggleSize(true);
                    else
                        saleLedgerModel.ToggleSize(false);
                else
                    saleLedgerModel.ToggleSize(false);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            this.ResizeControl();
            UserControlUtil.Func.ResizeControl(this);
        }

        #endregion

        #region Control - Event Handler

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            // Do Async Work
            AsyncWorkerFetch.RunWorkerAsync();
        }

        private void CardCustomer_Click(object sender, EventArgs e)
        {
            // Add Customer
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            new SearchItems
            {
                ItemTypeIndex = SearchItems.ItemType.Customer,
                User = User,
                Store = Store,
                OnAdd = OnAddCustomer,
                Task = Enums.Task.Create,
            }.ShowDialog();

            blur.Close();
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            // Remove Customer 
            Customer = null;
            lblCustomerName.Text = "(none)";
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

        #endregion

        #region Async 

        private void AsyncInitialize(object sender, DoWorkEventArgs e)
        {
            // Execute the following code on the GUI thread.
            this.Invoke(new MethodInvoker(delegate
            {
                RenderLoading(true);

                GetSaleLedgers();
                SetDropDownItems();
            }));
        }

        private void AsyncFetch(object sender, DoWorkEventArgs e)
        {
            // Execute the following code on the GUI thread.
            this.Invoke(new MethodInvoker(delegate
            {
                GetDropDownValues();
                SetQueryType();

                //Search
                GetSaleLedgers();
            }));
        }

        private void OnAsyncWorkerCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Execute the following code on the GUI thread.
            this.Invoke(new MethodInvoker(delegate
            {
                RenderLoading(false);
            }));
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            // Do Work
            AsyncWorkerInitialize.RunWorkerAsync();

            Translate();
        }
              
        void GetSaleLedgers()
        {

            if (QueryController.User.IsIdValid(User.Id))
            {
                SalesLedgersGrid.Controls.Clear();
                var response = QueryController.Sale.GetSaleLedgers(SearchQuery, Pagination);
                if (response.StatusCode == 200)
                {
                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    SalesLedgers = response.DataArray;
                    foreach (Backend.Objects.Sale sale in response.DataArray)
                        AddSaleLedgerToGrid(sale);
                    Pagination = response.Pagination;
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);
            }
            else
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
        }

        void AddSaleLedgerToGrid(Backend.Objects.Sale sale)
        {
            //Fill Grid [ SalesLedgersGrid ] With Rows
            SaleLedgerModel saleLedgerModel = new SaleLedgerModel
            {
                Sale = sale,
                Currency = Store.CurrencySign,
                OnToggle = OnToggleItem,
            };
            //Add To Grid
            SalesLedgersGrid.Controls.Add(saleLedgerModel);
        }

        void ToPagination(Enums.Pagination pagination)
        {
            if (pagination == Enums.Pagination.Previous)
                Pagination.CurrentPage = Pagination.PreviousPage;
            else
                Pagination.CurrentPage = Pagination.NextPage;

            // Get  
            GetSaleLedgers();
        }

        void GetDropDownValues()
        {
            SearchQuery.CustomerId = (Customer is object)
                ? Customer.Id
                : "";
            SearchQuery.Query = txtToken.Text;
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

            if (!string.IsNullOrEmpty(txtToken.Text))
                SearchQuery.Type = Enums.SearchQueryType.Query;
            else if (Customer is object)
                SearchQuery.Type = Enums.SearchQueryType.Customer;
            else if (dpdUsers.selectedIndex != 0)
                SearchQuery.Type = Enums.SearchQueryType.User;
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
            UserInterface.SetFlatButtonColor(btnPrevious, SoftColor);
            UserInterface.SetFlatButtonColor(btnNext, SoftColor);
            switchFilterApply.OnColor = pgbLoading.ProgressColor = SoftColor;            
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            SalesLedgersGrid.Visible = !isEmpty;
        }

        void RenderLoading(bool isLoading = true)
        {
            pgbLoading.Visible = isLoading;
            SalesLedgersGrid.Visible = cardEmptyData.Visible = !isLoading;
            btnFilter.Enabled = !isLoading;
        }

        void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(SalesLedgersGrid, this.Size, extraHeight: 3);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlHeader.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                foreach (Control control in pnlFilter.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                foreach (Control control in pnlGridHeader.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(btnFilter);
                Translation.TranslateControl(text_Customer);
                Translation.TranslateControl(lblNothing_Card);
            }
        }
        #endregion

        #region OnClose

        #endregion
    }
}
