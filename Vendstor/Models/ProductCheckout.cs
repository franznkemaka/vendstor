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

namespace Vendstor.Models
{
    public partial class ProductCheckout : UserControl
    {
        #region Variables

        public Backend.Objects.SaleItem Item { get; set; }
        public Backend.Objects.Sale Sale { get; set; }

        public EventHandler OnUpdate;
        public EventHandler OnRemove;
        public EventHandler OnToggle;

        public bool IsReturnItem { get; set; }
        public bool IsDiscounted { get; set; }
        public bool IsExpanded = false;

        int MaxDecimalPlaces = 2;

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ImageColor = Color.DimGray;
        Color RefundColor = Color.FromArgb(233, 122, 87);

        Image imgExpand = Properties.Resources.expand_checkout_w;
        Image imgCollapse = Properties.Resources.collapse_arrow_w;

        string Currency
        {
            get { return Sale.Store.CurrencySign; }
        }

        #endregion

        #region Constructors

        public ProductCheckout()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region Properties

        public decimal SubTotalPrice
        {
            get
            {
                var productPrice = Item.Quantity * Item.Product.Price;
                decimal totalPrice = 0;
                decimal discountAmount = 0;

                if (Item.IsDiscounted || Item.Discount is object)
                    discountAmount = Item.DiscountPrice = Item.Discount.Value * productPrice / 100;
                totalPrice = productPrice - discountAmount;
                return totalPrice;
            }
        }

        public decimal Tax
        {
            get
            {
                var taxAmount = Item.Product.Tax.Rate * SubTotalPrice / 100;
                return Math.Round(taxAmount, MaxDecimalPlaces);
            }
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

        }

        private void OnClick(object sender, EventArgs e)
        {
            // Emit Parent to Hide Collapse other items
            this.OnToggle(this, e);
        }


        public new void Update()
        {
            base.Update();
            UpdateProperties();
            this.OnUpdate(this, null);
        }

        #endregion

        #region Control - Event Handler

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!IsReturnItem)
                this.OnRemove(this, null);
            else
                //Add Product To UnReturnedProductsList [Product that ain't returned (Sold)]
                AddUnReturnedProducts();
        }

        private void BtnAddQuantity_Click(object sender, EventArgs e)
        {
            //Increase Quantity & Update
            Item.Quantity++;
            OnQuantityUpdated();
        }

        private void BtnReduceQuantity_Click(object sender, EventArgs e)
        {
            //Decrease Quantity &  Update
            Item.Quantity--;

            if (Item.Quantity == 0)
                // Remove Item since a product can't have a quantity of 0
                this.OnRemove(this, null);
            else
                OnQuantityUpdated();
        }

        private void TxtDiscountValue_KeyDown(object sender, KeyEventArgs e)
        {
            //Update if KeyPress is Enter
            if (e.KeyCode == Keys.Enter && txtDiscountValue.Text != "")
            {
                var isDecimal = decimal.TryParse(txtDiscountValue.Text, out decimal discountValue);
                if (isDecimal)
                {
                    Item.DiscountValue = discountValue;

                    // Update Current & Parent Total Amount
                    OnDiscountUpdated();
                }
            }
        }

        private void TxtNote_KeyDown(object sender, KeyEventArgs e)
        {
            // Update if KeyPress is Enter
            if (e.KeyCode == Keys.Enter)
                Item.Note = (txtNote.Text.Length > 1) ? txtNote.Text : Item.Note;
        }

        private void LblShowProductDetails_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            ProductDetails productDetails = new ProductDetails
            {
                Product = Item.Product,
                Task = Enums.Task.ReadOnly,
                TopMost = true
            };

            var formResponse = productDetails.ShowDialog();
            blur.Close();
        }

        private void BtnToggleControl_Click(object sender, EventArgs e)
        {
            // Emit Parent to Hide Collapse other items
            this.OnToggle(this, e);
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            if (IsReturnItem)
                InitializeUI();

            // Get tax
            Item.Product.Tax = Backend.Database.Queries.Tax.GetTax(Item.Product.Tax.Id);

            var product = Item.Product;
            Item.IsDiscounted = product.IsDiscounted;

            IsExpanded = true;
            ToggleSize();

            //Get
            if (product is object && Sale.User is object && Sale.Store is object)
            {
                Get(product);

                var productPrice = (product.Price * Item.Quantity);
                var totalAmount = productPrice;
                decimal discountAmout = 0;
                if (product.IsDiscounted)
                {
                    var response = QueryController.Products.Discount.Get(new Backend.Objects.Discount { Id = product.Discount.DiscountId });
                    if (response.StatusCode == 200)
                        Item.Discount = (Backend.Objects.Discount)response.Data;
                    var discount = Item.Discount;

                    discountAmout = (discount.Type == "Cash") ? discount.Value : productPrice * discount.Value / 100;
                    totalAmount -= discountAmout;

                    ConvertToPercentage();

                    var discountValuePercentage = Math.Round(discount.Value / productPrice * 100, MaxDecimalPlaces);
                    txtDiscountValue.Text = (discount.Type == "Percentage") ? discount.Value.ToString()
                        : (discountValuePercentage).ToString();
                    lblDiscountPrice.Text = string.Format("{0} {1}", Currency, ToRoundedString(totalAmount));
                }
                lblProductPrice.Text = lblProductPrice_Sub.Text = Currency + " " + ToRoundedString(productPrice);

                UpdateProperties();
            }
            else
                Alert.Show("Error", "An error occured", Alert.AlertType.Error, isMini: false);
        }

        // Convert Discount Value To Percentage  IF Cash
        void ConvertToPercentage()
        {
            var type = Item.Discount.Type;
            if (type.ToLower() == "percentage")
                return;
            else
            {
                Item.Discount.Type = "Percentage";
                Item.Discount.Value = Math.Round(Item.Discount.Value / (Item.Product.Price * Item.Quantity) * 100,
                    MaxDecimalPlaces);
            }
        }

        void Get(Backend.Objects.Product product)
        {
            lblProductName.Text = product.Name;
            lblProductBarcode.Text = product.Barcode;
            lblProductQuantity.Text = lblProductQuantity_Card.Text = Item.Quantity.ToString();
            lblProductPrice.Text = lblProductPrice_Sub.Text = string.Format("{0} {1}", Currency,
               ToRoundedString(product.Price));

            imgProductImage.Image = product.Image;
            lblDiscountPrice.Visible = product.IsDiscounted;
            Indicator.BackColor = cardProductQuantity.BackColor = cardProductQuantity.color = lblShowProductDetails.ForeColor = product.Color;
        }

        public void OnDiscountUpdated()
        {
            // If Is Discounted Increment Value
            if (Item.Product.IsDiscounted)
                Item.Discount.Value = Item.DiscountValue;
            else
            {
                Item.IsDiscounted = true;
                // Create a new Discount with Value
                Item.Discount = new Backend.Objects.Discount
                {
                    Type = "Custom",
                    Value = Item.DiscountValue,
                };
            }

            // Show or Hide DiscountPrice Label
            RenderDiscount(Item.Discount.Value != 0);

            // Total Price
            GetTotalPrice();
        }

        public void OnQuantityUpdated()
        {
            lblProductQuantity.Text = lblProductQuantity_Card.Text = ToRoundedString(Item.Quantity).ToString();

            // Total Price
            GetTotalPrice();
        }

        void GetTotalPrice()
        {
            var productPrice = Item.Quantity * Item.Product.Price;
            var totalPrice = SubTotalPrice;
            lblDiscountPrice.Text = string.Format("{0} {1}", Currency, totalPrice);
            lblProductPrice.Text = lblProductPrice_Sub.Text = Currency + " " + ToRoundedString(productPrice);

            // Emit Update :  this, Parent
            this.Update();
        }

        void UpdateProperties()
        {
            Item.TaxAmount = Tax;
            Item.Price = Item.Quantity * Item.Product.Price;
            Item.TotalPrice = SubTotalPrice;
        }

        void AddUnReturnedProducts()
        {
            /* PR : Return Items
            //Add Product To flpnlUnReturnedProductsList [Product That Ain't Returned (Sold)]
            ProductCheckout pc = new ProductCheckout();
            pc.ProductName = this.ProductName;
            frmSell.flpnlUnReturnedProductsList.Controls.Add(pc);

            //Then Remove From Checkout List
            frmSell.CheckoutGrid.Controls.Remove(this);
            Update();*/
        }

        void RenderDiscount(bool isDiscounted)
        {
            lblDiscountPrice.Visible = isDiscounted;
        }

        public void ToggleSize(bool isExpand = false)
        {
            IsExpanded = isExpand;
            if (isExpand)
            {
                this.Size = new Size(this.Size.Width, 255);
                Seperator.Location = new Point(Seperator.Location.X, 246);
                btnToggleControl.Image = imgCollapse;
            }
            else
            {
                this.Size = new Size(this.Size.Width, 75);
                Seperator.Location = new Point(Seperator.Location.X, 66);
                btnToggleControl.Image = imgExpand;
            }
            Indicator.Visible = isExpand;
        }

        decimal ToRoundedDecimal(decimal dec)
        {
            return Math.Round(dec, MaxDecimalPlaces);
        }
        string ToRoundedString(decimal dec)
        {
            return StringUtil.ToString(ToRoundedDecimal(dec));
        }

        void InitializeUI()
        {
            SoftColor = (IsReturnItem) ? RefundColor : UserInterface.SoftColor;

            imgExpand = ImageUtil.ColorImage(imgExpand, ImageColor);
            imgCollapse = ImageUtil.ColorImage(imgCollapse, ImageColor);
            btnAddQuantity.Image = ImageUtil.ColorImage(btnAddQuantity.Image, ImageColor);
            btnReduceQuantity.Image = ImageUtil.ColorImage(btnReduceQuantity.Image, ImageColor);
            txtNote.BorderColorFocused = txtNote.BorderColorMouseHover = txtDiscountValue.BorderColorFocused
                = txtDiscountValue.BorderColorMouseHover = SoftColor;

            this.Size = new Size(this.Size.Width, 75);
            btnToggleControl.Image = imgExpand;
        }

        #endregion

        #region OnClose


        #endregion
    }
}
