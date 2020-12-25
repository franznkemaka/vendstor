using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.UserControls.Dashboard.Setup
{
    public partial class General : UserControl
    {
        #region Variables

        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.User User = new Backend.Objects.User();

        Color SoftColor;

        #endregion

        #region Constructors

        public General()
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

        private void OnSave_Click(object sender, EventArgs e)
        {
            if (Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
            {
                UpdateStore();
            }
        }

        private void OnCancel_Click(object sender, EventArgs e)
        {
            // Update Store
            GetStore();
        }

        #endregion

        #region Control - Event Handler

        private void InputValueChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;

            //Change Validity Image According To Control Name
            if (txt.Name.Contains("StoreName"))
                imgValidStoreName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 5, 20));

            else if (txt.Name.Contains("FirstName"))
                imgValidFirstName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 10));

            else if (txt.Name.Contains("LastName"))
                imgValidLastName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 15));

            else if (txt.Name.Contains("Email"))
                imgValidEmail.Image = Validation.GetValidityImage(Validation.IsEmailValid(txt.Text));

            else if (txt.Name.Contains("Password"))
                imgValidPassword.Image = Validation.GetValidityImage(Validation.IsPasswordValid(txt.Text));

            else if (txt.Name.Contains("Street"))
                imgValidStreet.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 5, 50));

            else if (txt.Name.Contains("Postcode"))
                imgValidPostcode.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 4, 10, IsInteger: true));

            else if (txt.Name.Contains("City"))
                imgValidCity.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 4, 20));
            else
                return;
        }

        private void CurrencySelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex
            Control control = (Control)sender;
            if (control.Name.Contains("dpd"))
                cbbCurrency.SelectedIndex = dpdCurrency.selectedIndex;
            else if (control.Name.Contains("cbb"))
                dpdCurrency.selectedIndex = cbbCurrency.SelectedIndex;
        }
        private void CountrySelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex
            Control control = (Control)sender;
            if (control.Name.Contains("dpd"))
                cbbCountry.SelectedIndex = dpdCountry.selectedIndex;
            else if (control.Name.Contains("cbb"))
                dpdCountry.selectedIndex = cbbCountry.SelectedIndex;

        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            //Change Color 
            txtStoreName.BorderColorFocused = txtStorePassword.BorderColorFocused = txtStoreName.BorderColorFocused = txtStreet.BorderColorFocused = txtPostCode.BorderColorFocused = txtCity.BorderColorFocused =
                txtFirstName.BorderColorFocused = txtLastName.BorderColorFocused = txtStoreEmail.BorderColorFocused = txtPhoneNumber.BorderColorFocused = txtStoreWebsite.BorderColorFocused = SoftColor;
            txtStoreName.BorderColorMouseHover = txtStoreName.BorderColorMouseHover = txtStreet.BorderColorMouseHover = txtPostCode.BorderColorMouseHover = txtCity.BorderColorMouseHover =
              txtFirstName.BorderColorMouseHover = txtStorePassword.BorderColorMouseHover = txtLastName.BorderColorMouseHover = txtStoreEmail.BorderColorMouseHover = txtPhoneNumber.BorderColorMouseHover = txtStoreWebsite.BorderColorMouseHover = SoftColor;

            btnCancel.Activecolor = btnCancel.BackColor = btnCancel.Normalcolor = btnSave.Activecolor = btnSave.Normalcolor = btnSave.BackColor = SoftColor;

            //HoverColor
            btnSave.OnHovercolor = btnCancel.OnHovercolor = Color.FromArgb(200, SoftColor);

        }
        public void Initialize()
        {
            User = Util.Data.HandshakeUser(ParentForm);
            Store = Util.Data.HandshakeStore(ParentForm);

            GetStore();

            //Translate 
            Translate();
        }

        void GetStore()
        {
            txtStoreName.Text = Store.Name;
            txtStorePassword.Text = Store.Password;
            txtStreet.Text = Store.Address;
            txtPostCode.Text = Store.PostCode;
            txtCity.Text = Store.City;
            txtFirstName.Text = Store.FirstName;
            txtLastName.Text = Store.LastName;
            txtStoreEmail.Text = Store.Email;
            txtPhoneNumber.Text = Store.PhoneNumber;
            txtTaxID.Text = Store.TaxID;

            cbbCurrency.SelectedItem = Store.Currency;
            cbbCountry.SelectedItem = Store.Country;
        }

        void UpdateStore()
        {
            bool isSuccess = false;

            if (IsInputValid())
            {
                // PR :  Implement Store Type
                isSuccess = true;

                Store.Name = txtStoreName.Text;
                Store.Email = txtStoreEmail.Text;
                Store.Password = txtStorePassword.Text;
                Store.FirstName = txtFirstName.Text;
                Store.LastName = txtLastName.Text;
                Store.Type = "";
                Store.Locale = Properties.Settings.Default.SoftLocale;
                Store.Address = txtStreet.Text;
                Store.PostCode = txtPostCode.Text;
                Store.City = txtCity.Text;
                Store.PhoneNumber = txtPhoneNumber.Text;
                Store.Country = dpdCountry.selectedValue;
                Store.Currency = dpdCurrency.selectedValue;

                Store.TaxID = txtTaxID.Text;

                var response = QueryController.Store.Update(Store);

                // Check response StatusCode
                if (response.StatusCode == 204)
                {
                    var _Store = (Backend.Objects.Store)response.Data;
                    Store.Id = _Store.Id;
                    Properties.Settings.Default.StoreId = _Store.Id;

                    //Save
                    Util.Data.SynchronizeStore(_Store.Id);
                }

                else if (response.StatusCode == 409)
                    imgValidEmail.Image = Validation.GetValidityImage(false);

                else
                    isSuccess = false;
            }

            //Change Validity Image
            imgValidEmail.Image = imgValidStoreName.Image = imgValidFirstName.Image = imgValidLastName.Image = imgValidPassword.Image
                = imgValidCity.Image = imgValidPostcode.Image = imgValidStreet.Image = Validation.GetValidityImage(isSuccess);
        }

        void CheckStore()
        {
            if (!QueryController.Store.IsIdValid(Store.Id))
            {
                Util.Func.LogStoreOut(this.ParentForm);
            }
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtStoreName.Text, 4, 50))
                return false;
            else if (!Validation.IsPasswordValid(txtStorePassword.Text))
                return false;
            else if (!Validation.IsStringValid(txtFirstName.Text, 3, 20))
                return false;
            else if (!Validation.IsStringValid(txtLastName.Text, 3, 15))
                return false;
            else if (!Validation.IsEmailValid(txtStoreEmail.Text))
                return false;
            else if (!Validation.IsStringValid(txtStreet.Text, 5, 50))
                return false;
            else if (!Validation.IsStringValid(txtPostCode.Text, 4, 10, IsInteger: true))
                return false;
            else if (!Validation.IsStringValid(txtCity.Text, 4, 20))
                return false;
            else if (dpdCountry.selectedValue == null)
                return false;
            else if (dpdCurrency.selectedValue == null)
                return false;
            else
                return true;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                foreach (Control control in this.Controls)
                    if (control is Label || control is Bunifu.Framework.UI.BunifuFlatButton)
                        control.Text = Translation.Translate(control.Text);

                foreach (Control control in cardAddress.Controls)
                    if (control is Label)
                        control.Text = Translation.Translate(control.Text);

                foreach (Control control in cardStoreInfo.Controls)
                    if (control is Label)
                        control.Text = Translation.Translate(control.Text);

                foreach (Control control in cardBasicSettings.Controls)
                    if (control is Label)
                        control.Text = Translation.Translate(control.Text);
            }
        }

        #endregion

        #region OnClose


        #endregion      
    }
}
