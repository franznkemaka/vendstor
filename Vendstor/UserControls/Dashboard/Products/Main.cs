using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Main : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        List<object> Products = new List<object>();
        Backend.Objects.ProductSearchQuery SearchQuery = new Backend.Objects.ProductSearchQuery();

        Color SoftColor;
        bool IsTextSearchQuery = true;

        #endregion

        #region Constructors

        public Main()
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
            this.ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            SearchQuery.Query = txtFilter.Text;
            GetDropDownValues();
            SetQueryType();

            //Search
            GetProducts();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Products.Product product = new Forms.Products.Product
            {
                OnCreate = OnCreateProduct,
                Task = Enums.Task.Create,
                TopMost = true
            };

            // Update
            var dialogResult = product.ShowWithResult();

            blur.Close();
        }

        private void ProductsGrid_DoubleClick(object sender, EventArgs e)
        {
            // Update
            GetProducts();
        }
        private void SwitchQueryType_OnValueChange(object sender, EventArgs e)
        {

        }

        private void SwitchQueryType_Click(object sender, EventArgs e)
        {
            // Toggle
            ToggleSearchType(!IsTextSearchQuery);
        }
        #endregion

        #region  Methods

        void Initialize()
        {
            // Get 
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            // Get 
            GetProducts();

            // Set
            SetDropDownItems();

            Translate();
        }

        void GetProducts()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                var response = QueryController.Products.Product.GetProducts(SearchQuery);
                if (response.StatusCode == 200)
                {
                    ProductsGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    Products = response.DataArray;
                    foreach (Backend.Objects.Product product in response.DataArray)
                        AddProductToGrid(product);
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }


        void AddProductToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ ProductsGrid ] With Rows
            ProductModel productModel = new ProductModel
            {
                OnDelete = OnDeleteProduct,
                Product = product,
                User = User,
                Store = Store,
            };
            //Add To Grid
            ProductsGrid.Controls.Add(productModel);
        }

        public void OnCreateProduct(object sender, EventArgs e)
        {
            var newProduct = (Backend.Objects.Product)sender;
            AddProductToGrid(newProduct);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteProduct(object sender, EventArgs e)
        {

        }

        void GetDropDownValues()
        {
            // Supplier
            if (dpdSuppliers.selectedValue.ToLower() == "(none)" || dpdSuppliers.selectedIndex == 0)
                SearchQuery.SupplierId = "";
            else
                SearchQuery.SupplierId = ProductSupplier.GetIdByName(dpdSuppliers.selectedValue);

            // Brand 
            if (dpdBrands.selectedValue.ToLower() == "(none)" || dpdBrands.selectedIndex == 0)
                SearchQuery.BrandId = "";
            else
                SearchQuery.BrandId = ProductBrand.GetIdByName(dpdBrands.selectedValue);

            // Type 
            if (dpdTypes.selectedValue.ToLower() == "(none)" || dpdTypes.selectedIndex == 0)
                SearchQuery.TypeId = "";
            else
                SearchQuery.TypeId = ProductType.GetIdByName(dpdTypes.selectedValue);

            // Status
            if (dpdStatus.selectedValue.ToLower() == "(none)" || dpdStatus.selectedIndex == 0)
                SearchQuery.Status = "";
            else
                SearchQuery.Status = dpdStatus.selectedValue;
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
                SearchQuery.Type = Enums.SearchQueryType.Id;
                return;
            }
        }

        void SetDropDownItems()
        {
            // Suppliers
            var suppliersResponse = QueryController.Products.Supplier.GetSuppliers();
            if (suppliersResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductSupplier supplier in suppliersResponse.DataArray)
                    dpdSuppliers.AddItem(supplier.Name);

            // Brands
            var brandsResponse = QueryController.Products.Brand.GetBrands();
            if (brandsResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductBrand brand in brandsResponse.DataArray)
                    dpdBrands.AddItem(brand.Name);

            // Types
            var typesResponse = QueryController.Products.Type.GetTypes();
            if (typesResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductType type in typesResponse.DataArray)
                    dpdTypes.AddItem(type.Name);

            // Default (none)
            dpdSuppliers.selectedIndex = dpdTypes.selectedIndex = dpdBrands.selectedIndex = dpdStatus.selectedIndex = 0;
        }


        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnFilter, SoftColor);
            UserInterface.SetFlatButtonColor(btnAddProduct, SoftColor);
            UserInterface.SetFlatButtonColor(btnAddProduct_Alert, SoftColor);
            txtFilter.BorderColorFocused = txtFilter.BorderColorMouseHover = SoftColor;
            switchQueryType.OnColor = SoftColor;
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            ProductsGrid.Visible = !isEmpty;
        }

        void ToggleSearchType(bool isText)
        {
            pnlCoverDropDowns.Visible = isText;
            IsTextSearchQuery = isText;
        }

        void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(ProductsGrid, this.Size, 3, 100 + 100, 150 + 100);
            // 356
            if (this.Size.Height < 600)
                ProductsGrid.Size = new Size(1106, 356);
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

                Translation.TranslateControl(btnAddProduct);
                Translation.TranslateControl(btnFilter);
                Translation.TranslateControl(btnAddProduct_Alert);

                Translation.TranslateControl(lblSorry_Alert);
                Translation.TranslateControl(lblNoResults_Alert);
                ReCenterCardControls();
            }
        }
        void ReCenterCardControls()
        {
            // ReCenter
            Util.Methods.AlignToParent(lblSorry_Alert, cardEmptyData, Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblNoResults_Alert, cardEmptyData, Util.Methods.AlignIndex.HCenter);
            UserControlUtil.Func.MoveControlTo(btnAddProduct, new Point(920, 10), new Size(171, 40),
                new Point(888, 10), new Size(203, 40));
            btnAddProduct_Alert.Size = btnAddProduct.Size;
            Util.Methods.AlignToParent(btnAddProduct_Alert, cardEmptyData, Util.Methods.AlignIndex.HCenter);
        }


        #endregion

        #region OnClose

        #endregion

    }
}
