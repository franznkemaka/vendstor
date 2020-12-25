using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models
{
    public partial class SaleLedgerModel : UserControl
    {
        #region Variables

        public Backend.Objects.Sale Sale { get; set; }
        public string Currency { get; set; }
        public bool IsExpanded { get; set; }

        public EventHandler OnToggle;

        Color SoftColor;
        Image imgExpand = Properties.Resources.expand_checkout_w;
        Image imgCollapse = Properties.Resources.collapse_arrow_w;

        readonly int ExpandSizeHeight = 426;
        readonly int DefaultSizeHeigt = 61;        

        #endregion

        #region Constructors

        public SaleLedgerModel()
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
            // Emit Parent to Hide Collapse other items
            this.OnToggle(this, e);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Control - Event Handler

        private void BtnReturnItems_Click(object sender, EventArgs e)
        {
            // PR : Return Items
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
            //Get 
            if (Sale is object)
            {
                lblDate.Text = Sale.SoldAt.ToString();
                lblSaleId.Text = Sale.Id;
                lblNote.Text = lblNote_Header.Text =  Sale.Note;
                lblSaleTotal.Text = Sale.TotalPrice.ToString();

                if (Sale.IsFetchItem)
                {
                    Sale.User = (Backend.Objects.User)QueryController.User.Get(Sale.User).Data;
                    Sale.Customer = (Backend.Objects.Customer)QueryController.Customers.Customer.Get(Sale.Customer).Data;
                }
                lblUserName.Text = Sale.User.Username;
                try
                {
                    lblCustomerName.Text = string.Format("{0} {1}", Sale.Customer.FirstName, Sale.Customer.LastName);
                }
                catch { return; }

                // Statistics
                RenderStatistics();

                // Get Items In Sale
                GetSaleItems();
            }
        }

        void GetSaleItems()
        {
            ProductsCheckoutGrid.Controls.Clear();

            var response = QueryController.Sale.GetSaleItems(Sale);
            if (response.StatusCode == 200)
            {
                Sale.Items = response.DataArray;
                foreach (Backend.Objects.SaleItem item in response.DataArray)                
                    AddItemToGrid(item);
            }
        }

        void AddItemToGrid(Backend.Objects.SaleItem item)
        {
            //Fill Grid [ ProductsCheckoutGrid ] With Rows
            SaleLedgerProductModel productModel = new SaleLedgerProductModel
            {
                Item = item,
                Currency = Currency,
            };
            //Add To Grid
            ProductsCheckoutGrid.Controls.Add(productModel);
        }

        void RenderStatistics()
        {
            var currencyAppend = Currency + " ";
            lblSubtotal.Text = currencyAppend + Sale.SubTotalPrice.ToString();
            lblAdditionalDiscount.Text = currencyAppend + Sale.DiscountPrice.ToString();
            lblTotalTax.Text = currencyAppend + Sale.TaxAmount.ToString();

            lblTotal.Text = currencyAppend + Sale.TotalPrice.ToString();

            var payment = UserControls.Dashboard.Reports.Payment.SetAmounts(new Backend.Objects.Payment
            {
                Method = Sale.PaymentMethod,
                PaidAmount = Sale.Paid,
            });

            lblCashAmount.Text = currencyAppend + payment.CashAmount.ToString();
            lblCreditCardAmount.Text = currencyAppend + payment.CreditCardAmount.ToString();
            lblStoreCreditAmount.Text = currencyAppend + payment.StoreCreditAmount.ToString();

            lblBalanceAmount.Text = currencyAppend + Sale.Balance.ToString();
        }

        public void ToggleSize(bool isExpand = false)
        {
            IsExpanded = isExpand;
            if (isExpand)
            {
                this.BackColor = Color.White;
                this.Size = new Size(this.Size.Width, ExpandSizeHeight);
                btnToggle.Image = imgCollapse;
                GridSeperator_Collapse.LineColor = Seperator.LineColor = Color.FromArgb(241, 242, 246);
            }
            else
            {
                this.BackColor = Color.FromArgb(241, 242, 246);
                btnToggle.Image = imgExpand;
                this.Size = new Size(this.Size.Width, DefaultSizeHeigt);
                GridSeperator_Collapse.LineColor = Seperator.LineColor = UserInterface.ColorGray;
            }
            Indicator.Visible = isExpand;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            Indicator.BackColor = SoftColor;
            imgExpand = ImageUtil.ColorImage(imgExpand, Color.DimGray);
            imgCollapse = ImageUtil.ColorImage(imgCollapse, Color.DimGray);
            btnPrintReceipt.Iconimage = ImageUtil.ColorImage(btnPrintReceipt.Iconimage, UserInterface.ColorGray);
            GridSeperator_Collapse.LineColor = Seperator.LineColor = UserInterface.ColorGray;

            this.ToggleSize(IsExpanded);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                foreach (Control control in SaleSummaryPanel.Controls)
                    if (control is Label && control.Name.Contains("text_"))
                        Translation.TranslateControl(control);
                Translation.TranslateControl(btnPrintReceipt);
            }
        }

        #endregion

        #region OnClose

        #endregion

       
    }
}
