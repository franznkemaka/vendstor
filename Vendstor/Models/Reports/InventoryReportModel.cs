using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Reports
{
    public partial class InventoryReportModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public string Currency { get; set; }
        decimal StockValue
        {
            get
            {
                return (Product.Stock > 0)
                    ? Product.Price - Product.Stock
                    // Remove Negative Sign
                    : Product.Price - Product.Stock / -1;
            }
        }

        #endregion

        #region Constructors

        public InventoryReportModel()
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
            if (Product is object )
            {
                lblProductName.Text = Product.Name;
                lblProductBarcode.Text = Product.Barcode;
                lblCurrentStock.Text = StringUtil.ToRoundedString(Product.Stock);
                lblStockValue.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Product.StockValue));
                lblItemValue.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Product.Price));

                if (Product.Stock > 5)
                    lblCurrentStock.ForeColor = Color.FromArgb(0, 206, 104);
                else if (Product.Stock <= 5 && Product.Stock > 0)
                    lblCurrentStock.ForeColor = Color.FromArgb(255, 175, 0);
                else
                    lblCurrentStock.ForeColor = Color.Tomato;
            }
        }

        void InitializeUI()
        {
        }

        #endregion

        #region OnClose

        #endregion
    }
}
