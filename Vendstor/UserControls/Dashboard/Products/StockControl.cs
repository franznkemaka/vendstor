using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class StockControl : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();

        Color SoftColor;
        Point SelectBtnDefaultLocation = new Point(678, 132);

        //bool IsProductRendered = false;

        #endregion

        #region Constructors

        public StockControl()
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

        public void OnAddProduct(object sender, EventArgs e)
        {
            var product = (Backend.Objects.Product)sender;
            Product = product;
            GetProduct(product);

            // Render Product in Cards
            RenderCards(true);
        }

        #endregion

        #region Control - Event Handler

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.MinBlurOpacity);
            blur.Show();

            // Search Items
            new SearchItems
            {
                ItemTypeIndex = SearchItems.ItemType.Product,
                User = User,
                Store = Store,
                OnAdd = OnAddProduct,
            }.ShowDialog();

            blur.Close();
        }

        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtStock.Text, out decimal productStock))
                return;
            // It makes no point to do 0 - 0 or 5 - 0
            if (productStock == 0)
                return;

            Product.Stock -= productStock;

            //Update Stock
            UpdateStock();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtStock.Text, out decimal productStock))
                return;
            // It makes no point to do 0 +0 or 5 + 0
            if (productStock == 0)
                return;

            Product.Stock += productStock;

            //Update Stock
            UpdateStock();
        }       

        #endregion

        #region  Methods
        
        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            if (!Util.Func.IsUserAllowed(User))
                btnSelectProduct.Visible = false;

            // 
            RenderCards(false);

            Translate();
        }

        void GetProduct(Backend.Objects.Product product = null)
        {
            product = product ?? Product;

            //Get 
            if (product is object && User is object && Store is object)
            {
                lblProductName.Text = product.Name;
                lblProductId.Text = product.Id;
                lblProductPrice.Text = string.Format("{0} {1}", Store.CurrencySign, product.RetailPrice.ToString());
                lblProductBarcode.Text = product.Barcode;
                lblCurrentStock.Text = product.Stock.ToString();

                // If is from Search Item then Get Supplier .. Since the couldn't be fetched in another query
                if (product.IsSearchItem)
                {
                    product.Supplier = ProductSupplier.GetSupplier(product.Supplier.Id);
                    product.Image = Backend.Database.Queries.Product.GetImage(product.ImageBlobId, product.Name, product.Color);
                    //Update
                    Product = product;
                }

                imgProductImage.Image = product.Image;
                lblProductSupplier.Text = product.Supplier.Name;
                lblProductSupplyPrice.Text = product.SupplyPrice.ToString();
                lblProductPrice.Text = product.RetailPrice.ToString();
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);
        }

        void UpdateStock()
        {
            var response = QueryController.Products.Product.UpdateStock(Product);
            if(response.StatusCode == 204)
            {
                Alert.Show("Product Stock Updated", $"Product stock updated successfully", Alert.AlertType.Success);
            }
            else
                Alert.Show("Error", $"Something went wrong", Alert.AlertType.Error);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnSelectProduct, SoftColor);
            UserInterface.SetFlatButtonColor(btnAddStock, SoftColor);
        }

        void RenderCards(bool isProductRendered)
        {
            cardProductImage.Visible = cardStock.Visible = isProductRendered;
            pnlHideProductDetails.Visible = !isProductRendered;

            if (isProductRendered)
                btnSelectProduct.Location = SelectBtnDefaultLocation;
            else
                Util.Methods.AlignToParent(btnSelectProduct, cardProduct, Util.Methods.AlignIndex.HCenter);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                foreach (Control control in cardStock.Controls)
                    if (control is Label && control.Name.Contains("text_"))
                        Translation.TranslateControl(control);

                Translation.TranslateControl(text_SelectProduct);
                Translation.TranslateControl(text_CurrentStock);
                Translation.TranslateControl(btnSelectProduct, "Add Product");
                Translation.TranslateControl(btnAddStock);
                Translation.TranslateControl(btnRemoveStock);
            }

            RecenterControls();
        }

        void RecenterControls()
        {
            UserControlUtil.Func.MoveControlTo(btnAddStock, new Point(246, 245), new Size(107, 37),
                new Point(226, 245), new Size(151, 37));

            UserControlUtil.Func.MoveControlTo(btnSelectProduct, btnSelectProduct.Location, new Size(162, 37),
                new Point(640, 132), new Size(199, 37));
        }


        #endregion

        #region OnClose


        #endregion

    }
}
