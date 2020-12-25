using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;

//Vendstor
using Vendstor.Modals;
using Vendstor.Models;

using Vendstor.UserControls;
using Vendstor.Forms.Products;
using Vendstor.Forms.Customers;
using Vendstor.Forms.PointOfSale;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Hardwares;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms
{
    public partial class Sell : Form
    {
        #region Variables

        // Web Scocket
        public Socket Socket { get; set; }

        public Backend.Objects.Sale Sale = new Backend.Objects.Sale();
        public Backend.Objects.Product SelectedProduct { get; set; }

        List<object> Products = new List<object>();

        Color SoftColor;
        Color RefundColor = Color.FromArgb(233, 122, 87);

        readonly int CheckoutDetailsPnl_DefaultHeight = 39;
        readonly int CheckoutDetailsPnl_ExpandHeight = 114;
        readonly int MaxDecimalPlaces = 2;

        UserTab ucUserTab = new UserTab();

        bool IsCustomerAdded = false;
        bool IsProductsGridEmpty = true;
        bool IsCheckoutGridEmpty = true;

        string CurrencySign
        {
            get { return Sale.Store.CurrencySign; }
        }

        #endregion

        #region Constructor

        public Sell()
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

        #region Event Handler

        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Pay
            if (e.KeyCode == Keys.F3)
                this.Pay_Click(null, null);

            // Discard Sale
            if (e.KeyCode == Keys.Escape)
                this.BtnDiscardSale_Click(null, null);

            base.OnKeyDown(e);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            RenderCheckout(IsCheckoutGridEmpty);
            RenderProducts(IsProductsGridEmpty);
        }

        public void OnAddCustomer(object sender, EventArgs e)
        {
            Sale.Customer = (Backend.Objects.Customer)sender;
            IsCustomerAdded = true;

            // Update Customer
            UpdateCustomer();
        }

        public void OnSelectProduct(object sender, EventArgs e)
        {
            SelectedProduct = ((ProductSellModel)sender).Product;
        }

        public void OnAddProductToCheckout(object sender, EventArgs e)
        {
            var product = (Backend.Objects.Product)sender;
            AddProductToCheckout(product);
                                   
            // Update
            UpdateCheckout();
            PlayBeep();
        }

        public void OnRemoveCheckoutProduct(object sender, EventArgs e)
        {
            var productModel = (ProductCheckout)sender;
            CheckoutGrid.Controls.Remove(productModel);

            // Update
            UpdateCheckout();
        }

        public void OnToggleCheckoutItem(object sender, EventArgs e)
        {
            var productModel = (ProductCheckout)sender;

            // Expand sender if Collapsed and Collapse other controls 
            foreach (ProductCheckout productCheckout in CheckoutGrid.Controls)
                if (productCheckout == productModel)
                    if (!productModel.IsExpanded)
                        productCheckout.ToggleSize(true);
                    else
                        productCheckout.ToggleSize(false);
                else
                    productCheckout.ToggleSize(false);
        }

        public void OnUpdateCheckoutItem(object sender, EventArgs e)
        {
            // Update
            UpdateCheckout();
        }

        public void OnPaymentCompled(object sender, EventArgs e)
        {
            //Reset & Update
            Sale = new Backend.Objects.Sale();
            IsCustomerAdded = false;

            InitializeSale();
            CheckoutGrid.Controls.Clear();
            UpdateCheckout();
            UpdateCustomer();
        }

        #endregion

        #region Control - Event Handler

        #region Search Panel

        //ImageUtil.ColorImageButton(btnSearchProduct, SoftColor);

        private void TxtSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            //Update if KeyPress is Enter
            if (e.KeyCode == Keys.Enter && txtSearchProduct.Text != "")
            {
                // Search for query
                Search(txtSearchProduct.Text);
            }
        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            // Search for query
            Search(txtSearchProduct.Text);
        }

        #endregion

        #region Main - Header 

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            UnListenScanner();
            this.Close();
        }

        private void ImgbtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void ImgbtnNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ImgbtnSwitchDesk_Click(object sender, EventArgs e)
        {
            SwitchUser();
        }

        private void ImgbtnSwitchUser_Click(object sender, EventArgs e)
        {
            SwitchUser();
        }

        private void SwitchPanelDock(object sender, EventArgs e)
        {
            //Check Panel Dock => Inverse Dock On Click
            if (pnlRightSlider.Dock == DockStyle.Left)
            {
                pnlRightSlider.Dock = DockStyle.Right;
                pnlCheckout.Dock = DockStyle.Left;
            }
            else
            {
                pnlRightSlider.Dock = DockStyle.Left;
                pnlCheckout.Dock = DockStyle.Right;
            }
        }

        private void TimTime_Tick(object sender, EventArgs e)
        {
            //Change Time
            lblDateTime.Text = DateTime.Now.ToString("HH:mm");
        }
        #endregion

        #region Products

        private void ProductsGrid_MouseEnter(object sender, EventArgs e)
        {
        }

        private void ProductsGrid_MouseLeave(object sender, EventArgs e)
        {
        }

        private void ProductsGrid_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void ProductsGrid_DoubleClick(object sender, EventArgs e)
        {
            // Force Update
            GetProducts();
        }

        #endregion

        #region Checkout

        private void Pay_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();
            this.TopMost = false;

            UnListenScanner();

            // Show Pay Form
            Sale.IsGuest = !IsCustomerAdded;
            Pay Pay = new Pay
            {
                Sale = Sale,
                OnComplete = OnPaymentCompled,
                TopMost = true,
            };
            Pay.ShowDialog();
            this.TopMost = true;
            blur.Close();
        }

        private void CheckoutCustomerPanel_Click(object sender, EventArgs e)
        {
            //Open Customer Details
            CustomerDetails customerDetailsForm = new CustomerDetails
            {
                Customer = Sale.Customer,
                Task = Enums.Task.Get,
            };

            Extensions.ShowDialogWithBlur(this, customerDetailsForm);

            // Update If Updated
            var formResponse = customerDetailsForm.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                // Update
                IsCustomerAdded = true;
                UpdateCustomer();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Remove & Update
                IsCustomerAdded = false;
                UpdateCustomer();
            }
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            // Remove & Update
            IsCustomerAdded = false;
            UpdateCustomer();
        }

        #endregion

        #region  ToolBox 

        private void BtnDiscardSale_Click(object sender, EventArgs e)
        {
            //Reset & Update
            InitializeSale();
            CheckoutGrid.Controls.Clear();
            UpdateCheckout();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.FormBlurOpacity);
            blur.Show();

            new SearchItems
            {
                ItemTypeIndex = SearchItems.ItemType.Customer,
                User = Sale.User,
                Store = Sale.Store,
                OnAdd = OnAddCustomer,
                Task = Enums.Task.Create,
            }.ShowDialog();

            blur.Close();
        }

        private void BtnProductDetails_Click(object sender, EventArgs e)
        {
            // Show SelectedProduct Details if is set
            if (SelectedProduct is object)
            {
                Blur blur = new Blur(this, UIConstants.FormBlurOpacity);
                blur.Show();

                ProductDetails productDetails = new ProductDetails
                {
                    Product = SelectedProduct,
                    Task = Enums.Task.ReadOnly,
                    TopMost = true
                };

                var formResponse = productDetails.ShowDialog();
                blur.Close();
            }
        }

        private void BtnBarcodeScanner_Click(object sender, EventArgs e)
        {
            if (Sale.IsScannerActivated)
                UnListenScanner();
            else
                ListenScanner();
        }

        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            PointOfSale.Discount discount = new PointOfSale.Discount
            {
                DiscountAmount = Sale.DiscountAmount,
                DiscountPercentage = Sale.DiscountPercentage,
                DiscountName = Sale.DiscountName,
                Store = Sale.Store,
                User = Sale.User,
                TopMost = true
            };

            Extensions.ShowDialogWithBlur(this, discount);

            Sale.DiscountAmount = discount.DiscountAmount;
            Sale.DiscountPercentage = discount.DiscountPercentage;
            Sale.DiscountName = discount.DiscountName;

            //Update 
            UpdateCheckout();
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            Note note = new Note
            {
                NoteMessage = Sale.Note,
                TopMost = true,
            };

            Extensions.ShowDialogWithBlur(this, note);

            // Update
            Sale.Note = note.NoteMessage;
        }

        private void BtnReceiptPreview_Click(object sender, EventArgs e)
        {
            Printing printing = new Printing
            {
                TopMost = true,
                Sale = Sale,
                ReportViewerType = Printing.PintingItems.SaleReceipt,
            };
            printing.ShowDialog();
        }

        private void ToolBoxButton(object sender, EventArgs e)
        {
            // Get Tag and show ToolBox
            var tag = (string)((Control)sender).Tag;
            ToggleToolBox(tag);
        }

        #endregion

        #endregion

        #region  Methods

        #region Backend

        void Initialize()
        {
            InitializeSale();

            serverStatus.Start();

            // Get User
            var user = Sale.User;
            lblUserName.Text = string.Format("{0} {1}", user.FirstName, user.LastName);
            imgUserProfile.Image = user.ProfileOvalImage;

            timTime.Start();
            lblDateDay.Text = StringUtil.ToDateString(DateTime.Now);
            lblDateTime.Text = DateTime.Now.ToString("HH:mm");

            GetProducts();

            this.Update();

            Translate();
        }

        void InitializeSale()
        { 
            // Connect To Scanner
            ListenScanner();

            Sale = new Backend.Objects.Sale
            {
                User = Util.Data.GetUser(),
                Store = Util.Data.GetStore(),

                Id = ServerUtil.GenerateToken(15),
                Token = ServerUtil.GenerateToken(15),
                Items = new List<object>()
            };
        }

        void SwitchUser()
        {
            try
            {
                //Reset User 
                Properties.Settings.Default.UserId = null;
                Properties.Settings.Default.User = null;

                Auth.UserLogin userLogin = new Auth.UserLogin
                {
                    TopMost = true,
                    WindowState = FormWindowState.Normal
                };

                userLogin.ShowDialog();

                // Update with new user
                Sale.User = Util.Data.GetUser();
                var user = Sale.User;
                lblUserName.Text = string.Format("{0} {1}", user.FirstName, user.LastName);
                imgUserProfile.Image = user.ProfileOvalImage;
            }
            catch (Exception e)
            {
                Logger.Error(e, 500, "Sell Register", "Logging-Out");
            }
        }

        #region  Scanner

        void ListenScanner()
        {
            Sale.IsScannerActivated = true;

            // Connect to WebSocket
            Socket = IO.Socket(ServerConstants.ScannerWebSocketUrl);
            Socket.On(Socket.EVENT_CONNECT, () =>
            {

            });
            Socket.On(SocketConstants.EventScan, (token) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    OnScan(token);
                });
            });

            RenderScanner();
        }

        void OnScan(object token)
        {
            Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(JsonConvert.SerializeObject(token));
            var barcode = (string)obj["data"];

            if (QueryController.User.IsIdValid(Sale.User.Id))
            {
                var response = QueryController.Products.Product.Get(new Backend.Objects.Product { Barcode = barcode }, true);
                if (response.StatusCode == 200)
                {
                    this.OnAddProductToCheckout(response.Data, null);
                }
                else
                    // Wrong Barcode Or Id
                    Util.MessageParser.Alert("Product", Util.AlertParserType.NotFound);
            }
            else
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
        }

        void UnListenScanner()
        {
            Sale.IsScannerActivated = false;

            // Disconnect Socket if set
            if (Socket is object)
                Socket.Disconnect();
            RenderScanner();
        }

        #endregion

        #region Products

        void GetProducts(Backend.Objects.ProductSearchQuery query = null)
        {
            if (QueryController.User.IsIdValid(Sale.User.Id))
            {
                query = query ?? new Backend.Objects.ProductSearchQuery { Type = Enums.SearchQueryType.None };
                var response = QueryController.Products.Product.GetSellProducts(query);
                if (response.StatusCode == 200)
                {
                    ProductsGrid.Controls.Clear();

                    IsProductsGridEmpty = (response.DataArray.Count == 0);
                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderProducts(IsProductsGridEmpty);

                    Products = response.DataArray;
                    foreach (Backend.Objects.Product product in response.DataArray)
                        AddProductToGrid(product);
                }
                // No Content
                else if (response.StatusCode == 204)
                {
                    IsProductsGridEmpty = (response.DataArray.Count == 0);
                    RenderProducts(IsProductsGridEmpty);
                }
            }
            else
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
        }

        void Search(string query)
        {
            var searchQuery = new Backend.Objects.ProductSearchQuery
            {
                Query = query,
                Type = Enums.SearchQueryType.Query,
            };

            // Search Products with query
            GetProducts(searchQuery);
        }

        void AddProductToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ ProductsGrid ] With Rows
            ProductSellModel productModel = new ProductSellModel
            {
                OnAdd = OnAddProductToCheckout,
                OnSelect = OnSelectProduct,
                Product = product,
                User = Sale.User,
                Store = Sale.Store,
            };
            //Add To Grid
            ProductsGrid.Controls.Add(productModel);
        }

        #endregion

        #region Checkout 

        decimal GetBalanceValue()
        {
            decimal quantity = 1;
            Weight weight = new Weight
            {
                Quantity = quantity,
                TopMost = true
            };
            Extensions.ShowDialogWithBlur(this, weight);

            // Update 
            quantity = weight.Quantity;
            return quantity;
        }

        void AddProductToCheckout(Backend.Objects.Product product)
        {
            // Increment to 1 Since OnClick adds 1 
            decimal quantity = 1;

            // Get Balance Value if Required else add 1
            if (product.IsBalanceRequired)
                quantity = GetBalanceValue();

            /** Add Product To Checkout only if it doesn't contains it else, update Quantity * */
            foreach (ProductCheckout productCheckout in CheckoutGrid.Controls)
                if (productCheckout.Item.Product.Id == product.Id)
                {
                    productCheckout.Item.Quantity += quantity;
                    //Update
                    productCheckout.OnQuantityUpdated();
                    return;
                }

            var saleItem = ToSaleItem(product);
            saleItem.Quantity += quantity;

            // Add a new Item to Checkout
            AddProductToCheckoutGrid(saleItem);

            // Update 
            UpdateCheckout();
        }

        void AddProductToCheckoutGrid(Backend.Objects.SaleItem item)
        {
            //Fill Grid [ CheckoutGrid ] With Rows
            ProductCheckout productModel = new ProductCheckout
            {
                Item = item,
                Sale = Sale,
                OnRemove = OnRemoveCheckoutProduct,
                OnToggle = OnToggleCheckoutItem,
                OnUpdate = OnUpdateCheckoutItem,
            };
            //Add To Grid
            CheckoutGrid.Controls.Add(productModel);
        }

        public int CheckoutProductsCount()
        {
            return CheckoutGrid.Controls.Count;
        }

        public bool IsProductInCheckout(Backend.Objects.Product product)
        {
            foreach (ProductCheckout productCheckout in CheckoutGrid.Controls)
                if (productCheckout.Item.Product.Id == product.Id)
                    return true;
                else
                    return false;

            return false;
        }

        Backend.Objects.SaleItem ToSaleItem(Backend.Objects.Product product)
        {
            return new Backend.Objects.SaleItem
            {
                Product = product,
            };
        }

        #endregion

        #region Customer

        void RemoveCustomer()
        {
            // Reset
            Sale.Customer = null;
            lblCustomerName.Text = lblCustomerId.Text = CustomerGroup.Text = lblCustomerStoreCredit.Text = null;

            //Change Panel Size To Default
            CheckoutDetailsPanel.Size = new Size(CheckoutDetailsPanel.Size.Width, CheckoutDetailsPnl_DefaultHeight);
            HSeperatorTop_Customer.Visible = false;
        }

        #endregion

        #region Update 

        public new void Update()
        {
            base.Update();
            UpdateCustomer();
            UpdateCheckout();
        }

        void UpdateCheckout()
        {
            Sale.IsDiscounted = (Sale.DiscountAmount != 0 || Sale.DiscountPercentage != 0);

            decimal productsSubTotalPrice = 0;
            decimal productsTaxAmount = 0;

            // Reset To Avoid Duplicate
            Sale.ItemsCount = 0;
            if (Sale.Items is List<object>)
                Sale.Items.Clear();
            Sale.SupplyPrice = 0;

            foreach (ProductCheckout productCheckout in CheckoutGrid.Controls)
            {
                // Add TotalPice && ProductCount
                productsSubTotalPrice += productCheckout.SubTotalPrice;
                productsTaxAmount += productCheckout.Tax;
                Sale.ItemsCount++;
                Sale.SupplyPrice += productCheckout.Item.SupplyPrice;

                // Add Products To Sale
                Sale.Items.Add(productCheckout.Item);
            }

            Sale.SubTotalPrice = (decimal)Math.Round(productsSubTotalPrice, MaxDecimalPlaces);

            /** Add Discount Percentage with Amount. If Percentage is 0 and Amount is not then the is the amount & Vice Versa */
            Sale.DiscountPrice = (Sale.DiscountPercentage / 100 * Sale.SubTotalPrice) + Sale.DiscountAmount;
            Sale.TaxAmount = productsTaxAmount;

            /** Calculate Total : 
             *  *With Discount : Total = SubTotalPrice - DiscountPrice + TaxAmount
             *  *Without Discount : Total = SubTotalPrice + TaxAmount
             */

            // CHANGED : On each product, taxes are already included so there is no need to add them again
            // PR : Tax Inclusive / Tax Exclusive : Allow User to choose if the taxes are included or not

            Sale.SubTotalPrice -= Sale.TaxAmount; // Added : - Sale.TaxAmount since they are already inclusive so make them exclusive 
            Sale.TotalPrice = (Sale.IsDiscounted)
               ? (Sale.SubTotalPrice - Sale.DiscountPrice + Sale.TaxAmount) 
               : (Sale.SubTotalPrice + Sale.TaxAmount); 

            RenderCheckoutSummary();

            IsCheckoutGridEmpty = Sale.ItemsCount == 0;
            RenderCheckout(IsCheckoutGridEmpty);
        }

        public void UpdateCustomer()
        {
            if (IsCustomerAdded)
                RenderCustomer();
            else
                RemoveCustomer();
            HSeperatorTop_Customer.Visible = IsCustomerAdded;
        }

        #endregion

        #region Render

        void RenderCheckoutSummary()
        {
            //var curreny = CurrencySign;
            var curreny = "€";
            var labelItemsCount = (Sale.ItemsCount < 2) ? StringItem : StringItems;
            var emptyPrice = $"{ curreny } 00,00";

            lblSaleId.Text = Sale.Id;
            lblSaleToken.Text = Sale.Token;

            lblSubTotalAmount.Text = (Sale.SubTotalPrice != 0) ? Sale.SubTotalPrice.ToString() : emptyPrice;

            /** If DiscountAmount is greater than SubTotalPrice change color 
             * to indicate a Negative Sale (Client won't need to Pay instead will receive sth.)*/
            lblDiscountAmount.ForeColor = (Sale.DiscountAmount > Sale.SubTotalPrice) ? Color.FromArgb(230, 82, 81) : Color.Black;
            PayPanel.BackColor = (Sale.DiscountAmount > Sale.SubTotalPrice) ? Color.FromArgb(230, 82, 81) : SoftColor;

            lblTextDiscount.Text = $" { Sale.DiscountName } { StringDiscount } :";

            //Show Discount or Tax Amount if Present
            lblDiscountAmount.Text = (Sale.DiscountPrice != 0) ? $" - { curreny } {StringUtil.ToString(Sale.DiscountPrice) } " : emptyPrice;
            lblTaxAmount.Text = (Sale.TaxAmount != 0) ? $"{ curreny } { StringUtil.ToString(Sale.TaxAmount) }" : emptyPrice;
            lblTotalAmount.Text = (Sale.TotalPrice != 0) ? $"{ curreny } { StringUtil.ToString(Sale.TotalPrice) }" : emptyPrice;

            //Items Count
            lblItemsCount.Text = $"{ Sale.ItemsCount } { labelItemsCount }";
        }

        void RenderCheckout(bool isEmpty = true)
        {
            if (isEmpty)
            {
                CheckoutGrid.Dock = DockStyle.None;
                cardEmptyCart.Dock = DockStyle.Fill;

                Util.Methods.AlignToParent(imgVectorEmptyCart, cardEmptyCart);
                PayPanel.Enabled = false;
                PayPanel.BackColor = Color.FromArgb(216, 216, 216);
            }
            else
            {
                CheckoutGrid.Dock = DockStyle.Fill;
                cardEmptyCart.Dock = DockStyle.None;
                PayPanel.Enabled = true;
            }
            cardEmptyCart.Visible = isEmpty;
            CheckoutGrid.Visible = !isEmpty;
        }

        void RenderProducts(bool isEmpty = true)
        {
            cardNoProducts.Visible = isEmpty;
            ProductsGrid.Visible = !isEmpty;

            if (isEmpty)
            {
                ProductsGrid.Dock = DockStyle.None;
                Util.Methods.AlignToParent(cardNoProducts, pnlMain, Util.Methods.AlignIndex.HCenter);
                Util.Methods.AlignToParent(cardNoProducts, pnlMain, Util.Methods.AlignIndex.VCenter);

                if (this.WindowState == FormWindowState.Maximized)
                    cardNoProducts.Location = new Point(cardNoProducts.Location.X, 179);

            }
            else
                ProductsGrid.Dock = DockStyle.Fill;
        }

        void RenderCustomer()
        {
            var customer = Sale.Customer;
            lblCustomerName.Text = string.Format("{0} {1}", customer.FirstName, customer.LastName);
            lblCustomerId.Text = customer.Id;
            lblCustomerStoreCredit.Text = string.Format("{0} {1}", CurrencySign, customer.StoreCredit);

            if (customer.Group is object)
                if (!string.IsNullOrEmpty(customer.Group.Name))
                    CustomerGroup.Text = customer.Group.Name;
                else
                    CustomerGroup.Visible = false;
            else
                CustomerGroup.Visible = false;

            UserControlUtil.Func.ColorStoreCredit(lblCustomerStoreCredit, Sale.Customer.StoreCredit);

            //Change Panel Size
            CheckoutDetailsPanel.Size = new Size(CheckoutDetailsPanel.Size.Width, CheckoutDetailsPnl_ExpandHeight);
            HSeperatorTop_Customer.Visible = true;
        }

        void RenderScanner()
        {
            UserInterface.SetFlatButtonColor(btnBarcodeScanner, (Sale.IsScannerActivated) ? SoftColor : Color.Tomato);
        }

        void PlayBeep()
        {
            new Sound
            {
                SoundToPlay = Sound.GetSoundEffect(Sound.SoundEffects.Beep)
            }.Play();
        }
        #endregion

        #endregion

        #region Frontend

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color colorGray = Color.FromArgb(209, 212, 221);

            ImageUtil.ColorImageButton(btnSearchProduct, Color.DarkGray);
            pnlHeader.BackColor = PayPanel.BackColor = lblSaleId.ForeColor = lblSaleToken.ForeColor = SoftColor;

            UserInterface.SetFlatButtonColor(btnCalculator, SoftColor);
            UserInterface.SetFlatButtonColor(btnCalendar, SoftColor);
            UserInterface.SetFlatButtonColor(btnAddCustomer, SoftColor);
            UserInterface.SetFlatButtonColor(btnProductDetails, SoftColor);
            UserInterface.SetFlatButtonColor(btnDiscount, SoftColor);
            UserInterface.SetFlatButtonColor(btnAddNote, SoftColor);
            UserInterface.SetFlatButtonColor(btnReceiptPreview, SoftColor);

            ImageUtil.ColorImageButton(btnMinimize, colorGray);
            ImageUtil.ColorImageButton(btnNormalize, colorGray);
            ImageUtil.ColorImageButton(btnMaximize, colorGray);
            ImageUtil.ColorImageButton(btnExit, colorGray);

            // Elipse
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = CheckoutGrid;
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = ProductsGrid;
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = txtSearchProduct;
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = PayPanel;

            //Change Texts, Amount, Products ...
            //this.UpdateCheckout();
        }

        void ToggleToolBox(string tag)
        {
            Form frm = null;
            switch (tag)
            {
                case "Calculator":
                    frm = new Calculator();
                    break;
                case "Calendar":
                    frm = new Calendar();
                    break;
                case "ReceiptPreview":
                    frm = new Printing();
                    break;
            }
            if (frm is Form)
                Extensions.ShowDialogWithBlur(this, frm, UIConstants.MinBlurOpacity);
        }

        #endregion

        #endregion

        #region Translate

        string StringItem = "Item";
        string StringItems = "Items";
        string StringPay = "Pay";
        string StringRefund = "Refund";
        string StringDiscount = "Discount";

        // PR : In BackgroundWorker for performances

        void Translate()
        {
            Translation.ForceUpdate();
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_SearchProducts);
                Translation.TranslateControl(text_SubTotal);
                Translation.TranslateControl(text_Tax);
                Translation.TranslateControl(text_Pay);

                Translation.TranslateControl(lblNoProducts_Card);
                Translation.TranslateControl(lblAddProductToCart_Card);

                StringItem = Translation.Translate("Item");
                StringItems = Translation.Translate("Items");
                StringPay = Translation.Translate("Pay");
                StringRefund = Translation.Translate("Refund");
                StringDiscount = Translation.Translate("Discount");
            }
        }



        #endregion

        #region OnClose

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            serverStatus.Stop();
            timTime.Stop();
        }

        #endregion
    }
}

