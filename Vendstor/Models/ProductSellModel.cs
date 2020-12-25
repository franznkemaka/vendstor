using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms.Discounts;
using Vendstor.Forms.Products;

using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models
{
    public partial class ProductSellModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public EventHandler OnAdd;
        public EventHandler OnSelect;

        Color SoftColor;       

        #endregion

        #region Constructors

        public ProductSellModel()
        {
            InitializeComponent();

            InitializeUI();          
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            this.Anchor = AnchorStyles.None;
            this.Margin = new Padding(6, 5, 4, 5);
            Initialize();           
        }

        #endregion

        #region Control - Event Handler
        
        private void OnClick(object sender, EventArgs e)
        {
            // Emit Parent OnAdd Event
            this.OnAdd(Product, e);
        }

        private void ImgBtnDiscount_Click(object sender, EventArgs e)
        {
            // Show Form
            Extensions.ShowDialogWithBlur(this.ParentForm, new DiscountProducts
            {
                Discount = new Backend.Objects.Discount { Id = Product.Discount.DiscountId },
                User = User,
                Store = Store,
                TopMost = true
            }, UIConstants.FormBlurOpacity);
        }

        private void ProductSellModel_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            // Emit Parent OnDoubleClick Event
            this.OnSelect(this, null);
        }
        #endregion

        #region  Methods


        void Initialize()
        {
            //Get
            if (Product is object && User is object && Store is object)
            {
                lblProductName.Text = Product.Name;
                lblProductPrice.Text = string.Format("{0} {1}", Store.CurrencySign, StringUtil.ToString(Product.Price));

                // If is from Search Item then Get Brand .. Since the couldn't be fetched in another query
                if (Product.IsSearchItem)
                    Product.Image = Backend.Database.Queries.Product.GetImage(Product.ImageBlobId, Product.Name, Product.Color);

                imgProductImage.Image = Product.Image;

                imgBtnDiscount.Visible = Product.IsDiscounted;
                imgIsBalanceRequired.Visible = Product.IsBalanceRequired;

                Indicator.BackColor = cardPrice.BackColor = cardPrice.color = Product.Color;
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorImageButton(btnSelectProduct, UserInterface.ColorGray);
        }


        #endregion

        #region OnClose

        #endregion
        
    }
}
