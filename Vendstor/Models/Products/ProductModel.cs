using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Products;

using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Products
{
    public partial class ProductModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public EventHandler OnDelete;

        Color SoftColor;

        #endregion

        #region Constructors

        public ProductModel()
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

        private void OnClick(object sender, EventArgs e)
        {            
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            ProductDetails productDetails = new ProductDetails
            {
                Product = Product,
                Task = Enums.Task.Get,
                TopMost = true
            };

            //Update If Updated
            var formResponse = productDetails.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Product = (Backend.Objects.Product)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }

            blur.Close();
            
        }


        #endregion

        #region Control - Event Handler

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Products.Product product = new Forms.Products.Product
            {
                ProductObject = Product,
                Task = Enums.Task.Update,
                TopMost = true
            };

            // Update If Updated
            var formResponse = product.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Product = (Backend.Objects.Product)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }

            blur.Close();
        }

        #endregion

        #region  Methods
        
        void Initialize()
        {
            //Get 
            if (Product is object && User is object && Store is object)
            {
                if (!Util.Func.IsUserAllowed(User))
                    btnEdit.Visible = false;

                lblProductName.Text = Product.Name;
                lblProductId.Text = Product.Id;
                lblRetailPrice.Text = string.Format("{0} {1}", Store.CurrencySign, Product.RetailPrice.ToString());
                lblStock.Text = Product.Stock.ToString();

                lblCreatedDate.Text = Product.CreatedAt.ToShortDateString();

                // If is from Search Item then Get Brand .. Since the couldn't be fetched in another query
                if (Product.IsSearchItem)
                { 
                    Product.Tax = Tax.GetTax(Product.Tax.Id);
                    Product.Brand = ProductBrand.GetBrand(Product.Brand.Id);
                    Product.Supplier = ProductSupplier.GetSupplier(Product.Supplier.Id);
                    Product.Type = ProductType.GetTypeById(Product.Type.Id);
                    Product.Image = Backend.Database.Queries.Product.GetImage(Product.ImageBlobId, Product.Name, Product.Color);
                }

                pnlProductColor.BackColor = Product.Color;
                imgProductImage.Image = Product.Image;
                lblBrandName.Text = Product.Brand.Name;
                lblSupplierName.Text = Product.Supplier.Name;
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

          
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnEdit, SoftColor);
        }

        #endregion

        #region OnClose

        #endregion

    }
}
