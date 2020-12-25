using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Linq;
using System.Data;
using Microsoft.Reporting.WinForms;

using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms
{
    public partial class Printing : Form
    {
        #region Variables

        public EventHandler OnComplete;

        public Backend.Objects.Sale Sale { get; set; }
        public Backend.Objects.RedeemReceipt RedeemReceipt { get; set; }

        public bool HasCompleteHandler { get; set; }
        public PintingItems ReportViewerType { get; set; }

        public enum PintingItems { SaleReceipt, RedeemReceipt, ProductLabel }

        ReportViewer CurrentReportViewer { get; set; }
        Color SoftColor;

        string ToPaymentMethodString
        {
            get
            {
                 if (Sale.PaymentMethod == null)
                    return "BAR";
                switch (Sale.PaymentMethod.ToLower())
                {
                    case "creditcard":
                        return "KREDIT KARTE";
                    case "storecredit":
                        return "EINKAUFSKREDIT";
                    default:
                        return "BAR";
                }

            }
        }

        #endregion

        #region Constructors

        public Printing()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
            TopMost = true;
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
            // Print
            if (e.KeyCode == Keys.P)
                PrintReceipt();

            // Cancel
            if (e.KeyCode == Keys.Escape)
                this.Close();

            base.OnKeyDown(e);
        }

        #endregion

        #region Control - Event Handler

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Complete();
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void RenderSaleReceipt(Backend.Objects.Sale sale)
        {
            var store = sale.Store;
            var customer = sale.Customer;
            bool hasNote = !string.IsNullOrEmpty(Sale.Note) && !string.IsNullOrWhiteSpace(Sale.Note);
            
            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins.Top = 0;
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;

            double defaultHeight = 198; //mm  + 2 - 2 mm
            defaultHeight -= !hasNote ? 5 : 0;

            foreach (Backend.Objects.SaleItemReceipt item in sale.ItemsReceipt)
                // Add Item height depending on length each 11 char makes a line       
                defaultHeight += item.Name.Length / 11 * ((item.Name.Length > 11) ? 15 : 10);

            // height -> hundreth inch
            int height = (int)Math.Round(defaultHeight * (0.03937) * 100, 1);
            pageSettings.PaperSize = new PaperSize("Custom", 190, height);

            DataTable dtItems = DataUtil.ToDataTable(sale.ItemsReceipt);
            DataSet dsItems = new DataSet();
            dsItems.Tables.Add(dtItems);
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "Item",
                Value = dsItems.Tables[0]
            };
            this.saleReceiptViewer.LocalReport.DataSources.Add(reportDataSource);

            var postCodeCity = string.Format("{0} {1}", store.PostCode, store.City);
            var firstName = sale.User.FirstName.FirstOrDefault().ToString().ToUpper();
            var userDisplayName = string.Format("{0}. {1}", firstName, sale.User.LastName);
            var message = Properties.Settings.Default.ReceiptFooterMessage;

            string customerText = null;
            if (customer is object)
                customerText = !string.IsNullOrEmpty(customer.Id) ? $"KUNDE : {customer.FirstName } {customer.LastName } " : "";
            var note = (!string.IsNullOrEmpty(Sale.Note) && !string.IsNullOrWhiteSpace(Sale.Note)) ? $"MERKE : {Sale.Note } " : "";

            // GetTaxRates
            var taxA = $"A { GetTaxRate(taxCode: "A")} %";
            var taxB = $"B {GetTaxRate(taxCode: "B")} %";

            var paymentMethod = ToPaymentMethodString;

            ReportParameter[] parameters = new ReportParameter[]
            {
                // Header
                new ReportParameter("StoreName", store.Name),
                new ReportParameter("Address",  store.Address),
                new ReportParameter("PostCodeCity", postCodeCity),
                new ReportParameter("PhoneNumber", store.PhoneNumber),

                new ReportParameter("SaleId", sale.Id),
                new ReportParameter("DateTime", DateTime.Now.ToString()),
                                
                // Amounts
                new ReportParameter("TotalAmount", StringUtil.ToRoundedString(sale.TotalPrice)),
                new ReportParameter("PaymentMethod", paymentMethod),
                new ReportParameter("PaidAmount", StringUtil.ToRoundedString(sale.Paid)),
                new ReportParameter("BalanceAmount", StringUtil.ToRoundedString(sale.Balance)),
                new ReportParameter("ItemsCount", sale.ItemsCount.ToString()),

                // Tax
                new ReportParameter("TaxID", store.TaxID),
                new ReportParameter("TaxA", taxA),
                new ReportParameter("TaxB", taxB),

                new ReportParameter("TaxARevenue", StringUtil.ToRoundedString(sale.TaxARevenue)),
                new ReportParameter("TaxBRevenue", StringUtil.ToRoundedString(sale.TaxBRevenue)),
                new ReportParameter("TaxAAmount", StringUtil.ToRoundedString(sale.TaxAAmount)),
                new ReportParameter("TaxBAmount", StringUtil.ToRoundedString(sale.TaxBAmount)),
                new ReportParameter("TaxANetto", StringUtil.ToRoundedString(sale.TaxANetPrice)),
                new ReportParameter("TaxBNetto", StringUtil.ToRoundedString(sale.TaxBNetPrice)),
                new ReportParameter("Revenue", StringUtil.ToRoundedString(sale.TaxRevenue)),
                new ReportParameter("TaxAmount", StringUtil.ToRoundedString(sale.TaxAmount)),
                new ReportParameter("NettoAmount",  StringUtil.ToRoundedString(sale.TaxNetPrice)),

                
                // ...
                new ReportParameter("Currency", store.CurrencySign),
                new ReportParameter("UserDisplayName", userDisplayName),
                new ReportParameter("Message", message),
                new ReportParameter("Customer", customerText),
                new ReportParameter("Note", note),
            };


            try
            {
                this.saleReceiptViewer.SetPageSettings(pageSettings);
                this.saleReceiptViewer.LocalReport.SetParameters(parameters);
                this.saleReceiptViewer.RefreshReport();
            }
            catch
            {
                Alert.Show("Error Printing", "A Fatal Error occured while rendring Receipt", Alert.AlertType.Error, isMini: false);
            }
        }

        public void RenderRedeemReceipt(Backend.Objects.RedeemReceipt redeem)
        {
            var store = redeem.Store;
            var customer = redeem.Customer;
            var user = redeem.User;
            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins.Top = 0;
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;

            double defaultHeight = 117; //mm
            // height -> hundreth inch
            int height = (int)Math.Round(defaultHeight * (0.0393701) * 100, 1);
            pageSettings.PaperSize = new PaperSize("Custom", 190, height);

            var postCodeCity = string.Format("{0} {1}", store.PostCode, store.City);
            var firstName = user.FirstName.FirstOrDefault().ToString().ToUpper();
            var userDisplayName = string.Format("{0}. {1}", firstName, user.LastName);
            var message = Properties.Settings.Default.ReceiptFooterMessage;
            var customerText = customer is object && customer.Id != "" ? $"KUNDE : {customer.FirstName } {customer.LastName } " : "KUNDE : Nicht Eingetragen ";

            ReportParameter[] parameters = new ReportParameter[]
            {
                // Header
                new ReportParameter("StoreName", store.Name),
                new ReportParameter("Address",  store.Address),
                new ReportParameter("PostCodeCity", postCodeCity),
                new ReportParameter("PhoneNumber", store.PhoneNumber),

                new ReportParameter("CustomerId", customer.Id),
                new ReportParameter("DateTime", DateTime.Now.ToString()),

                new ReportParameter("RedeemedAmount", StringUtil.ToRoundedString(redeem.RedeemedAmount)),
                new ReportParameter("AccountBalance",StringUtil.ToRoundedString(redeem.AccountBalance)),

                new ReportParameter("Currency", store.CurrencySign),
                new ReportParameter("UserDisplayName", userDisplayName),
                new ReportParameter("Customer", customerText),
            };


            try
            {
                this.reedemReceiptViewer.SetPageSettings(pageSettings);
                this.reedemReceiptViewer.LocalReport.SetParameters(parameters);
                this.reedemReceiptViewer.RefreshReport();
            }
            catch
            {
                Alert.Show("Error Printing", "A Fatal Error occured while rendring Receipt", Alert.AlertType.Error, isMini: false);
            }
        }

        public void RenderProductLabel()
        {
        }

        #endregion

        #region Methods   

        void Initialize()
        {
            Translate();
            SetReportViewer();
        }

        void PrintReceipt()
        {
            if (CurrentReportViewer is ReportViewer)
            {
                this.CurrentReportViewer.PrintDialog();
                if (HasCompleteHandler)
                    Complete();
            }
        }

        void SetReportViewer()
        {
            switch (ReportViewerType)
            {
                case PintingItems.SaleReceipt:
                    RenderSaleReceipt(Sale);
                    CurrentReportViewer = saleReceiptViewer;
                    break;

                case PintingItems.RedeemReceipt:
                    RenderRedeemReceipt(RedeemReceipt);
                    CurrentReportViewer = reedemReceiptViewer;
                    break;

                case PintingItems.ProductLabel:
                    RenderProductLabel();
                    CurrentReportViewer = productLabelViewer;
                    break;

            }
            CurrentReportViewer.Visible = true;
            CurrentReportViewer.Dock = DockStyle.Fill;
        }

        decimal GetTaxRate(string taxId = null, string taxCode = null)
        {
            Backend.Objects.Tax tax = Tax.GetTax(taxId, taxCode);
            return tax.Rate;
        }

        void Complete()
        {
            this.OnComplete(this, null);
            this.Close();
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
                Translation.TranslateControl(text_Print);
            }
        }

        #endregion

        #region OnClose 

        #endregion
    }
}
