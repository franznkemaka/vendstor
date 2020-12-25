using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Modals;
using Vendstor.Models.Discounts;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.Discounts
{
    public partial class DiscountProducts : Form
    {

        #region Variables

        public Backend.Objects.Discount Discount { get; set; }
        List<object> Products = new List<object>();
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        Color SoftColor;

        #endregion

        #region Constructors

        public DiscountProducts()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Control - Event Handler
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods
        
        void Initialize()
        {
            //Truncate
            lblDiscountDescription.Text = lblDiscountName.Text = "";

            // Get
            GetDiscount();

            Translate();
        }

        void GetDiscount()
        {
            if (QueryController.Products.Discount.IsValid(Discount))
            {
                var response = QueryController.Products.Discount.Get(Discount);
                if(response.StatusCode == 200)
                {
                    Discount = (Backend.Objects.Discount)response.Data;

                    lblDiscountName.Text = Discount.Name;
                    lblDiscountDescription.Text = Discount.Description;

                    if (Discount.Type.ToLower() == "cash")
                        lblDiscountAmount.Text = Store.CurrencySign + " " + Discount.Value.ToString();
                    else
                        lblDiscountPtg.Text = Discount.Value.ToString() + " %";

                    lblDiscountDuration.Text = Discount.StartDate.ToShortDateString() + " - " + Discount.EndDate.ToShortDateString();
                }

                // Get Products
                GetDiscountProducts();

            }
            else
            {
                Alert.Show("Unknown Discount", $"The Discount you're trying to Get doesn't exist ", Alert.AlertType.Warning, isMini: false);
            }
        }

        void GetDiscountProducts()
        {
            var response = QueryController.Products.Discount.GetDiscountProducts(Discount);
            if (response.StatusCode == 200)
            {
                ProductsGrid.Controls.Clear();
                Products = response.DataArray;
                foreach (Backend.Objects.DiscountProduct productDiscount in response.DataArray)
                {
                    //Get Product Self
                    var productResponse = QueryController.Products.Product.Get(new Backend.Objects.Product { Id = productDiscount.ProductId });
                    if (productResponse.StatusCode == 200)
                        AddProductToGrid((Backend.Objects.Product)productResponse.Data);
                }
            }
        }

        void AddProductToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ ProductsGrid ] With Rows
            DiscountProductModel productModel = new DiscountProductModel
            {
                Product = product,
                Currency = Store.CurrencySign,
                DiscountValue = Discount.Value,
                DiscountType = Discount.Type,
            };
            //Add To Grid
            ProductsGrid.Controls.Add(productModel);
        }
        
        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorImageButton(btnExit, UserInterface.ColorGray);

        }

        #endregion
        
        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_Amount);
                Translation.TranslateControl(text_RetailPrice);
                Translation.TranslateControl(text_Products);
                Translation.TranslateControl(text_Duration);
                Translation.TranslateControl(text_Ptg);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
