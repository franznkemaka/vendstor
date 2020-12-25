using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models
{
    public partial class TaxModel : UserControl
    {
        #region Variables

        public Backend.Objects.Tax Tax { get; set; }

        public bool IsIndicatorVisible = false;

        public EventHandler OnModelClick;

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.FromArgb(136, 144, 157);

        #endregion

        #region Constructors

        public TaxModel()
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
            this.OnModelClick(sender, e);
        }

        #endregion

        #region Control - Event Handler


        #endregion

        #region  Methods

        public void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
        }

        public void Initialize()
        {
            if(Tax is object)
            {
                //Set Control Textes
                lblTaxName.Text = Tax.Name;
                lblTaxRate.Text = GetRate(Tax.Rate);
                lblTaxShortName.Text = Tax.ShortName;
                lblTaxStoreShortName.Text = Tax.StoreShortName;
                lblTaxDescription.Text = Tax.Description;
            }          

            //Translate 
            Translate();
        }

        public void UpdateModel(Backend.Objects.Tax tax)
        {
            this.Tax = tax;
            this.Initialize();
        }
        
        string GetRate(decimal rate)
        {
            return $"{rate.ToString()} %";
        }

        public void ToggleIndicator(bool visible = false)
        {

            //IsIndicatorVisible = !IsIndicatorVisible;
            Indicator.Visible = visible;
        }

        #endregion

        #region Translate

        void Translate()
        {
            
        }


        #endregion

        #region OnClose


        #endregion


    }
}
