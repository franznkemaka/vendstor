using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Products
{
    public partial class Supplier : Form
    {
        #region Variables

        public Backend.Objects.ProductSupplier ProductSupplier { get; set; }
        Backend.Objects.ProductSupplier supplier = new Backend.Objects.ProductSupplier();
        Backend.Objects.User user = new Backend.Objects.User();

        public EventHandler OnCreate;
        public EventHandler OnDelete;
        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        enum PanelIndex { First, Second }
        Enums.ActionDialog ActionDialog { get; set; }

        Size ControlDefaultSize = new Size(888, 550);
        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 556);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Supplier()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Control - Event Handler

        public Enums.ActionDialog ShowWithResult()
        {
            this.ShowDialog();
            return ActionDialog;
        }

        public FormResponse ShowWithResponse()
        {
            this.ShowDialog();
            return new FormResponse
            {
                ActionDialog = ActionDialog,
                Data = supplier
            };
        }


        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateSupplier();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateSupplier();
                this.OnCreate(supplier, e);
            }

            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();

            MessageDialog messageDialog = new MessageDialog
            {
                DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                SecondBtnText = "No",
                ThirdBtnText = "Yes",
                ThirdBtnColor = Color.Tomato,
                Title = "Are you sure ?",
                Message = $"Are you sure you want to permanently delete { supplier.Name }, this supplier will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                ActionDialog = Enums.ActionDialog.Deleted;
                //Delete
                DeleteSupplier();
            }

            blur.Close();
        }

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.Second);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.First);
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
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

        private void TxtSupplierName_OnValueChanged(object sender, EventArgs e)
        {
            imgFirstNameValid.Image = Validation.GetValidityImage(Validation.IsStringValid(txtSupplierName.Text, 2, 100));
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            user = Util.Data.GetUser();
            supplier = ProductSupplier;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetSupplier();
            }
            else if (Task == Enums.Task.Create)
            {
                supplier = new Backend.Objects.ProductSupplier();
                txtMarkup.Text = "0";
                btnDelete.Visible = false;
            }
            // Add DropDown Items
            Util.Func.AddCountriesToDropDowns(cbbCountry, dpdCountry);

            Translate();
        }

        void GetSupplier()
        {
            if (QueryController.Products.Supplier.IsValid(supplier))
            {
                txtSupplierName.Text = supplier.Name;
                txtMarkup.Text = supplier.Markup.ToString();
                rtxtSupplierDescription.Text = supplier.Description;
                txtFirstName.Text = supplier.FirstName;
                txtLastName.Text = supplier.LastName;
                txtCompany.Text = supplier.Company;
                txtPhoneNumber.Text = supplier.PhoneNumber;
                txtEmailAddress.Text = supplier.Email;
                txtWebsite.Text = supplier.Website;
                txtStreet.Text = supplier.Address;
                txtPostCode.Text = supplier.PostCode;
                txtCity.Text = supplier.City;
                cbbCountry.SelectedIndex = cbbCountry.Items.IndexOf(supplier.Country);
            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.NotFound);
        }

        void UpdateSupplier()
        {
            if (!IsInputValid())
                return;

            if (QueryController.Products.Supplier.IsValid(supplier))
            {
                SetSupplierProperties();
                var response = QueryController.Products.Supplier.Update(supplier);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    this.Close();
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.ErrorUpdating);

            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.NotFound);
        }

        void CreateSupplier()
        {
            if (!IsInputValid())
                return;

            SetSupplierProperties();
            var response = QueryController.Products.Supplier.Create(supplier);
            if (response.StatusCode == 201)
            {
                ActionDialog = Enums.ActionDialog.Error;
                this.Close();
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.ErrorCreating);
        }

        void SetSupplierProperties()
        {
            try
            {
                supplier.Name = txtSupplierName.Text;
                supplier.Markup = !string.IsNullOrEmpty(txtMarkup.Text) ? decimal.Parse(txtMarkup.Text) : 0;
                supplier.Description = rtxtSupplierDescription.Text;
                supplier.FirstName = txtFirstName.Text;
                supplier.LastName = txtLastName.Text;
                supplier.Company = txtCompany.Text;
                supplier.PhoneNumber = txtPhoneNumber.Text;
                supplier.Email = txtEmailAddress.Text;
                supplier.Website = txtWebsite.Text;
                supplier.Address = txtStreet.Text;
                supplier.PostCode = txtPostCode.Text;
                supplier.City = txtCity.Text;
                supplier.Country = dpdCountry.selectedValue;
            }
            catch { return; }
        }

        void DeleteSupplier()
        {
            if (QueryController.Products.Supplier.IsValid(supplier))
            {
                var response = QueryController.Products.Supplier.Delete(supplier);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Deleted;
                    this.Close();
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.NotFound);
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtSupplierName.Text, 2, 100))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            //Change Color
            btnSave.Activecolor = btnSave.Normalcolor = btnSave.BackColor = SoftColor;
            //HoverColor
            btnSave.OnHovercolor = HoverColor;
            //Color Images
            imgbtn_Exit.Image = ImageUtil.ColorImage(imgbtn_Exit.Image, ColorGray);
            imgbtnGoFirstFields.Image = ImageUtil.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtnGoSecondFields.Image = ImageUtil.ColorImage(imgbtnGoSecondFields.Image, ColorGray);
            //Size
            this.Size = ControlDefaultSize;
            //Default Location
            imgbtn_Exit.Location = new Point(833, 9);
        }

        void ToPanel(PanelIndex panelIndex)
        {
            if (panelIndex == PanelIndex.First)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveField;
                pnlSecondFields.Location = InActiveField;
            }
            else if (panelIndex == PanelIndex.Second)
            {
                //Change Panel Location
                pnlFirstFields.Location = InActiveField;
                pnlSecondFields.Location = ActiveField;
            }

        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlFirstFields.Controls)
                    if (control is Label && !control.Name.Contains("lblTitle"))
                        Translation.TranslateControl(control);

                foreach (Control control in pnlSecondFields.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(btnDelete);
                Translation.TranslateControl(btnSave);
                Translation.TranslateControl(text_BackToFields);

                if (Task == Enums.Task.Create)
                    lblTitle.Text = Translation.Translate("Create New Customer");
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
