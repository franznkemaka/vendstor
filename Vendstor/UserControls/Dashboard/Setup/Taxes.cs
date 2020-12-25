using System;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Models;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.UserControls.Dashboard.Setup
{
    public partial class Taxes : UserControl
    {
        #region Variables

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();

        Backend.Objects.Tax Tax = new Backend.Objects.Tax();
        Backend.Objects.Tax SubTax = new Backend.Objects.Tax();
        Backend.Objects.Tax EditedTax = new Backend.Objects.Tax();

        //Color
        Color SoftColor;

        TaxModel taxModel;
        TaxModel subTaxModel;

        #endregion

        #region Constructors

        public Taxes()
        {
            InitializeComponent();

            //Void
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

        #endregion

        #region Control - Event Handler

        public void OnTaxModal_CLick(object sender, EventArgs e)
        {
            //Update Indicator
            var _taxModel = (TaxModel)TaxesGrid.Controls.Find("taxModel", true)[0];
            var _subTaxModal = (TaxModel)TaxesGrid.Controls.Find("subTaxModel", true)[0];
            _taxModel.ToggleIndicator(true);
            _subTaxModal.ToggleIndicator(false);

            //Change EditTax
            EditedTax = Tax;
            InitializeTaxEdit(Tax);
        }
        public void OnSubTaxModal_CLick(object sender, EventArgs e)
        {
            //Update Indicator
            var _taxModel = (TaxModel)TaxesGrid.Controls.Find("taxModel", true)[0];
            var _subTaxModal = (TaxModel)TaxesGrid.Controls.Find("subTaxModel", true)[0];
            _taxModel.ToggleIndicator(false);
            _subTaxModal.ToggleIndicator(true);

            //Change EditTax
            EditedTax = SubTax;
            InitializeTaxEdit(SubTax);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
            {
                //Save
                UpdateTax(EditedTax);
            }
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;

            //Change Validity Image According To Control Name
            if (txt.Name.Contains("TaxName"))
                imgValidTaxName.Image = Validation.GetValidityImage(Validation.IsStringValid(txtTaxName.Text));

            else if (txt.Name.Contains("TaxShortName"))
                imgValidTaxShortName.Image = Validation.GetValidityImage(Validation.IsStringValid(txtTaxShortName.Text, 2));

            else if (txt.Name.Contains("TaxStoreShortName"))
                imgValidTaxStoreShortName.Image = Validation.GetValidityImage(Validation.IsStringValid(txtTaxStoreShortName.Text, 1, 10));

            else if (txt.Name.Contains("TaxRate"))
                imgValidTaxRate.Image = Validation.GetValidityImage(Validation.IsStringValid(txtTaxRate.Text, 1, 4, IsInteger: true));

            else if (txt.Name.Contains("Description"))
                imgValidDescription.Image = Validation.GetValidityImage(Validation.IsStringValid(rtxtDescription.Text, 4, 200));

            else
                return;
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;

            //Change Color
            txtTaxName.BorderColorMouseHover = txtTaxShortName.BorderColorMouseHover = txtTaxRate.BorderColorMouseHover =
                txtTaxName.BorderColorFocused = txtTaxShortName.BorderColorFocused = txtTaxRate.BorderColorFocused = SoftColor;

            btnSave.Activecolor = btnSave.BackColor = btnSave.Normalcolor = SoftColor;

            //HoverColor
            btnSave.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        void Initialize(bool updateModels =  false)
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();
            taxModel = new TaxModel();
            subTaxModel = new TaxModel();

            GetTaxes();

            AddModels();

            //Translate 
            Translate();
        }

        void GetTaxes()
        {
            //GetTaxes

            if (QueryController.Store.IsIdValid(Store.Id))
            {
                var response = QueryController.Tax.GetTaxes(Store);
                if (response.StatusCode == 200)
                {
                    Tax = (Backend.Objects.Tax)response.DataArray[0];
                    SubTax = (Backend.Objects.Tax)response.DataArray[1];
                    EditedTax = Tax;
                }
            }
        }
        void UpdateTax(Backend.Objects.Tax tax)
        {
            bool isSuccess = false;

            //Get Response From Query :: If Input Is Correct
            if (IsInputValid())
            {
                isSuccess = true;
                tax.Name = txtTaxName.Text;
                tax.ShortName = txtTaxShortName.Text;
                tax.StoreShortName = txtTaxStoreShortName.Text;
                tax.Rate = decimal.Parse(txtTaxRate.Text);
                tax.Description = rtxtDescription.Text;

                var response = QueryController.Tax.Update(tax);

                if (response.StatusCode == 204)
                {
                    //Update
                    TaxesGrid.Controls.Clear();
                    Initialize(true);
                }
                else
                    isSuccess = false;
            }

            //Change Validity Image
            imgValidDescription.Image = imgValidTaxName.Image = imgValidTaxRate.Image = imgValidTaxStoreShortName.Image =
                imgValidTaxShortName.Image = Validation.GetValidityImage(isSuccess);

        }

        void InitializeTaxEdit(Backend.Objects.Tax tax)
        {
            txtTaxName.Text = tax.Name;
            txtTaxShortName.Text = tax.ShortName;
            txtTaxStoreShortName.Text = tax.StoreShortName;
            txtTaxRate.Text = tax.Rate.ToString();
            rtxtDescription.Text = tax.Description ;
        }

        void AddModels()
        {
            taxModel.Tax = Tax;
            taxModel.OnModelClick += OnTaxModal_CLick;
            taxModel.Name = "taxModel";
            TaxesGrid.Controls.Add(taxModel);

            subTaxModel.Tax = SubTax;
            subTaxModel.OnModelClick += OnSubTaxModal_CLick;
            subTaxModel.Name = "subTaxModel";
            TaxesGrid.Controls.Add(subTaxModel);
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtTaxName.Text))
                return false;
            else if (!Validation.IsStringValid(txtTaxShortName.Text, 2))
                return false;
            else if (!Validation.IsStringValid(txtTaxRate.Text, 2, 4, IsInteger: true))
                return false;
            else if (!Validation.IsStringValid(txtTaxStoreShortName.Text, 1, 10))
                return false;
            else
                return true;
        }

        #endregion

        #region Translate

        void Translate()
        {
            Translation.ForceUpdate();
            if (Translation.IsPossible())
            {                
                Translation.TranslateControl(btnSave);
            }
        }

        #endregion

        #region OnClose


        #endregion
    }
}
