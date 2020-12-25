using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;
using Vendstor.Forms.Products;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Discounts
{
    public partial class DiscountProductModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public string Currency { get; set; }
        public decimal DiscountValue { get; set; }
        public string DiscountType { get; set; }

        public bool IsSearchItem = false;

        decimal DiscountPrice
        {
            get
            {
                var amount = (DiscountType.ToLower() == "cash") ? DiscountValue : Product.Price * DiscountValue / 100;
                return Product.Price - amount;
            }
        }

        #endregion

        #region Constructors

        public DiscountProductModel()
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

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Product is object)
            {
                lblProductName.Text = Product.Name;
                lblProductId.Text = Product.Id;
                lblRetailPrice.Text = string.Format("{0} {1}", Currency, Product.RetailPrice.ToString());
                lblDiscountPrice.Text = string.Format("{0} {1}", Currency, DiscountPrice.ToString());
                imgpnlProductImage.BackColor = Product.Color;

                if (IsSearchItem)
                    Product.Image = Backend.Database.Queries.Product.GetImage(Product.ImageBlobId, Product.Name, Product.Color);
                imgProductImage.Image = Product.Image;
            }
            else
                Alert.Show("Error", $"Something Wrong Occured", Alert.AlertType.Error);
        }

        void InitializeUI()
        {
        }

        #endregion

        #region OnClose

        #endregion
    }
}
