using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls.Dashboard
{
    public partial class ProductsTab : UserControl
    {
        #region Variables

        public string TabName = "Main";

        //UserControls
        Products.Main Main = new Products.Main();
        Products.StockControl StockControl = new Products.StockControl();
        Products.Discounts Discounts = new Products.Discounts();
        Products.Types ProductTypes = new Products.Types();
        Products.Suppliers ProductSuppliers = new Products.Suppliers();
        Products.Brands ProductBrands = new Products.Brands();
        Products.Tags ProductTags = new Products.Tags();
        ComingSoon ComingSoon = new ComingSoon();

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.DarkGray;

        #endregion

        #region Constructors

        public ProductsTab()
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

        //Main Menu Button Click
        private void TabLabel_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            TabName = control.Name;

            // Remove Tab in Control name for switch 
            TabName = TabName.Replace("Tab", "");
            AddTab();
        }

        #endregion

        #region  Methods
        
        void Initialize()
        {
            Translate();
            //Add Default Control (General)
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

            if (TabName.Contains("Main"))
                userControl = Main;

            else if (TabName.Contains("StockControl"))
                userControl = StockControl;

            else if (TabName.Contains("Discounts"))
                userControl = Discounts;

            else if (TabName.Contains("Types"))
                userControl = ProductTypes;

            else if (TabName.Contains("Suppliers"))
                userControl = ProductSuppliers;

            else if (TabName.Contains("Brands"))
                userControl = ProductBrands;

            else if (TabName.Contains("Tags"))
                //userControl = ProductTags;
                userControl = ComingSoon;


            //Find Control by ControlName
            var controlName = "Tab" + TabName;
            try
            {
                control = ((Label)Tabs.Controls.Find(controlName, true)[0]);

                UserControlUtil.Func.AddTabToControl(userControl, ProductsControl, Tabs);
                UserControlUtil.Func.IndicateControl(control, TabIndicator);
            }
            catch { return; }
        }

        #endregion

        #region Translate

        void Translate()
        {
            Translation.ForceUpdate();
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in Tabs.Controls)
                    if (control is Label)
                        control.Text = Translation.Translate(control.Text);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
