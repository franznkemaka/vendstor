using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls.Dashboard
{
    public partial class Reporting : UserControl
    {
        #region Variables

        public string TabName = "Dashboard";

        Reports.Dashboard Dashboard = new Reports.Dashboard();
        Reports.Sales SalesReports = new Reports.Sales();
        Reports.Inventory InventoryReports = new Reports.Inventory();
        Reports.Payment PaymentReports = new Reports.Payment();
        Reports.StoreCredit StoreCreditReports = new Reports.StoreCredit();
        Reports.Tax TaxReports = new Reports.Tax();


        Color SoftColor;

        #endregion

        #region Constructors

        public Reporting()
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

        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            UserControlUtil.Func.ResizeControl(this);
        }

        #endregion

        #region Control - Event Handler

        private void TabLabel_Click(object sender, EventArgs e)
        {
            TabName = (string)((Control)sender).Tag;
            AddTab();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            Translate();

            AddTab();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            TabIndicator.LineColor = SoftColor;
        }

        void AddTab()
        {
            // Search UserControl  To Add & Control To Add Indicator
            Control control = null;
            UserControl userControl = null;

            if (TabName.Contains("Dashboard"))
                userControl = Dashboard;

            else if (TabName.Contains("Sales"))
                userControl = SalesReports;

            else if (TabName.Contains("Inventory"))
                userControl = InventoryReports;

            else if (TabName.Contains("Payment"))
                userControl = PaymentReports;

            else if (TabName.Contains("StoreCredit"))
                userControl = StoreCreditReports;

            else if (TabName.Contains("Tax"))
                userControl = TaxReports;

            //Find Control by ControlName
            var controlName = "Tab" + TabName;

            var x = controlName;
            var test = Tabs.Controls.Find(x, true);

            control = ((Label)Tabs.Controls.Find(controlName, true)[0]);

            UserControlUtil.Func.AddTabToControl(userControl, ReportsControl, Tabs);
            UserControlUtil.Func.IndicateControl(control, TabIndicator);
        }
        
        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                foreach (Control control in Tabs.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);
            }
        }

        #endregion

        #region OnClose

        #endregion     
    }
}
