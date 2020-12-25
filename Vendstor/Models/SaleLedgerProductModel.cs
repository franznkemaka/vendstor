using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models
{
    public partial class SaleLedgerProductModel : UserControl
    {
        #region Variables

        public Backend.Objects.SaleItem Item { get; set; }
        public string Currency { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorDimGray = Color.FromArgb(241, 242, 246);
        Color ImageColor = Color.DimGray;

        Image imgExpand = Properties.Resources.expand_checkout_w;
        Image imgCollapse = Properties.Resources.collapse_arrow_w;

        #endregion         

        #region Constructors

        public SaleLedgerProductModel()
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
            if (Item is object)
            {
                if (Item.IsFetchItem)                
                    Item.Product = (Backend.Objects.Product)QueryController.Products.Product.Get(Item.Product).Data;

                var product = Item.Product;
                lblProductName.Text = product.Name;
                lblProductId.Text = product.Id;
                lblSubtotal.Text = string.Format("@ {0} {1}", Currency, Item.TotalPrice - Item.TaxAmount);
                lblTaxAmount.Text = string.Format(" + {0} {1} Tax (MwSt) ", Currency, Item.TaxAmount);
                lblTotal.Text = string.Format("{0} {1}", Currency, Item.TotalPrice);

                //var discountPtg = Item.DiscountPrice / (Item.TotalPrice - Item.DiscountPrice)  * 100;
                lblDiscountView.Text = string.Format("Was : {0} {1} ; Disc : {2} % / {3} {4} ",
                    Currency, Item.Price, 0, Currency, Item.DiscountPrice);
                         
                lblProductQuantity.Text = StringUtil.ToRoundedString(Item.Quantity);
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            card_ProductQuantity.BackColor = card_ProductQuantity.color = SoftColor;
        }

        #endregion

        #region OnClose


        #endregion

    }
}

