using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Models.Customers;
using Vendstor.Models.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms
{
    public partial class SearchItems : Form
    {
        #region Variables

        public Backend.Objects.User User = new Backend.Objects.User();
        public Backend.Objects.Store Store = new Backend.Objects.Store();
        List<object> Results = new List<object>();

        public EventHandler OnAdd;

        public Enums.Task Task = Enums.Task.Get;
        public ItemType ItemTypeIndex { get; set; }
        public enum ItemType { Product, Customer }
        public string RootForm { get; set; }

       // Enums.SearchQueryType SearchQueryType = Enums.SearchQueryType.Query;
        Enums.ActionDialog ActionDialog { get; set; }
        Color SoftColor;

        #endregion

        #region Constructors

        public SearchItems()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);

            this.TopMost = true;
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        public void OnCreateCustomer(object sender, EventArgs e)
        {
            var customer = (Backend.Objects.Customer)sender;
            AddItemToGrid(customer);

            // Update Controls 
            RenderCard(false);
        }

        public void OnAddItem(object item, EventArgs e)
        {
            // Emit Method & Close
            this.OnAdd(item, e);
            this.Close();
        }

        #endregion

        #region Control - Event Handler

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Show Customer Form 
            Extensions.ShowDialogWithBlur(this, new Customers.Customer
            {
                OnCreate = OnCreateCustomer,
                Task = Enums.Task.Create,
                TopMost = true
            });
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        void Initialize()
        {
            if (Task == Enums.Task.Create)
                btnAdd.Visible = true;

            // Preload 3 Latest Items
            GetItems(3);

            //Translate
            Translate();
        }

        void GetItems(int limit = 0)
        {
            switch (ItemTypeIndex)
            {
                case ItemType.Product:

                    lblTitle.Text = "Add Product";

                    var productQuery = new Backend.Objects.ProductSearchQuery { Type = Enums.SearchQueryType.None };
                    var response = QueryController.Products.Product.GetProducts(productQuery, limit);
                    if (response.StatusCode == 200)
                    {
                        ItemsGrid.Controls.Clear();
                        // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                        RenderCard(response.DataArray.Count == 0);
                        Results = response.DataArray;
                        foreach (Backend.Objects.Product product in response.DataArray)
                            AddItemToGrid(product);
                    }
                    // No Content
                    else if (response.StatusCode == 204)
                        RenderCard(response.DataArray.Count == 0);
                    break;

                case ItemType.Customer:

                    lblTitle.Text = "Add Customer";

                    var customerQuery = new Backend.Objects.CustomerSearchQuery { Type = Enums.SearchQueryType.None };
                    var customerResponse = QueryController.Customers.Customer.GetCustomers(customerQuery, limit);
                    if (customerResponse.StatusCode == 200)
                    {
                        ItemsGrid.Controls.Clear();
                        // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                        RenderCard(customerResponse.DataArray.Count == 0);
                        Results = customerResponse.DataArray;
                        foreach (Backend.Objects.Customer customer in customerResponse.DataArray)
                            AddItemToGrid(customer);
                    }
                    // No Content
                    else if (customerResponse.StatusCode == 204)
                        RenderCard(customerResponse.DataArray.Count == 0);
                    break;
            }
        }

        void Search()
        {
            switch (ItemTypeIndex)
            {
                case ItemType.Product:

                    var query = new Backend.Objects.ProductSearchQuery { Query = txtSearch.Text, Type = Enums.SearchQueryType.Query };
                    var response = QueryController.Products.Product.GetProducts(query);                  
                    if (response.StatusCode == 200)
                    {
                        ItemsGrid.Controls.Clear();
                        // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                        RenderCard(response.DataArray.Count == 0);
                        Results = response.DataArray;
                        foreach (Backend.Objects.Product product in response.DataArray)
                            AddItemToGrid(product);
                    }
                    // No Content
                    else if (response.StatusCode == 204)
                        RenderCard(response.DataArray.Count == 0);
                    break;

                case ItemType.Customer:

                    var customerQuery = new Backend.Objects.CustomerSearchQuery { Query = txtSearch.Text, Type = Enums.SearchQueryType.Query };
                    var customerResponse = QueryController.Customers.Customer.GetCustomers(customerQuery);
                    if (customerResponse.StatusCode == 200)
                    {
                        ItemsGrid.Controls.Clear();
                        // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                        RenderCard(customerResponse.DataArray.Count == 0);
                        Results = customerResponse.DataArray;
                        foreach (Backend.Objects.Customer customer in customerResponse.DataArray)
                            AddItemToGrid(customer);
                    }
                    // No Content
                    else if (customerResponse.StatusCode == 204)
                        RenderCard(customerResponse.DataArray.Count == 0);
                    break;

            }
        }

        void AddItemToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ ItemsGrid ] With Rows
            ProductItemModel productItemModel = new ProductItemModel
            {
                OnAdd = OnAddItem,
                Product = product,
                User = User,
                Store = Store,
                IsSearchItem = true,
            };
            //Add To Grid
            ItemsGrid.Controls.Add(productItemModel);
        }

        void AddItemToGrid(Backend.Objects.Customer customer)
        {
            //Fill Grid [ ItemsGrid ] With Rows
            CustomerItemModel customerItemModel = new CustomerItemModel
            {
                OnAdd = OnAddItem,
                Customer = customer,
                User = User,
                Store = Store,
            };
            //Add To Grid
            ItemsGrid.Controls.Add(customerItemModel);
        }     

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnSearch, SoftColor);
            UserInterface.SetFlatButtonColor(btnAdd, SoftColor);
            ImageUtil.ColorImageButton(btnExit, UserInterface.ColorGray);
        }

        void RenderCard(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            ItemsGrid.Visible = !isEmpty;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(lblTitle);
                Translation.TranslateControl(btnSearch);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
