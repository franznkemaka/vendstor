using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend.Utils;

namespace Vendstor.Models
{
    public partial class UserInsightModel : UserControl
    {
        #region Variables
        
        public string Type { get; set; }
        public double SalesCount { get; set; }
        public decimal Revenue { get; set; }
        public bool AddSeperator { get; set; }
        public Color? BackgroundColor = null;

        public string StringSales { get; set; }
        public string Currency { get; set; }

        Color SoftColor;

        #endregion

        #region Constructors

        public UserInsightModel()
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

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            lblSalesCount.ForeColor = SoftColor;
            this.BackColor = BackgroundColor ?? Color.White;
        }

        void Initialize()
        {
            lblSalesCount.Text = SalesCount.ToString() + " " + StringSales;
            lblType.Text = Type;
            lblAmount.Text = Revenue + " " +  Currency;
            Seperator.Visible = AddSeperator;
        }
        
        #endregion

        #region OnClose

        #endregion
    }
}
