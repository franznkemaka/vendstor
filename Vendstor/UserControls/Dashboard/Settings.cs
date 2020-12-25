using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls.Dashboard
{
    public partial class Settings : UserControl
    {
        #region Variables
        public string TabName = "General"; 

        //UserControls
        Setup.General GeneralSettings = new Setup.General();
        Setup.PaymentTypes PaymentTypes = new Setup.PaymentTypes();
        Setup.Taxes SalesTaxes = new Setup.Taxes();
        Setup.Users Users = new Setup.Users();
        Setup.Software SoftwareSettings = new Setup.Software();

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.DarkGray;

        #endregion

        #region Constructors

        public Settings()
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

            if (TabName.Contains("General"))
                userControl = GeneralSettings;

            else if (TabName.Contains("PaymentTypes"))
                userControl = PaymentTypes;

            else if (TabName.Contains("Taxes"))
                userControl = SalesTaxes;

            else if (TabName.Contains("Users"))
                userControl = Users;

            else if (TabName.Contains("Software"))
                userControl = SoftwareSettings;

            //Find Control by ControlName
            var controlName = "Tab" + TabName;
            control = ((Label)Tabs.Controls.Find(controlName, true)[0]);

            UserControlUtil.Func.AddTabToControl(userControl, SettingsControl, Tabs);
            UserControlUtil.Func.IndicateControl(control, TabIndicator);
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
