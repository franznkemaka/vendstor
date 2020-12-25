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

namespace Vendstor.Forms.Customers
{
    public partial class Customer : Form
    {
        #region Variables

        public Backend.Objects.Customer CurrentCustomer { get; set; }
        Backend.Objects.Customer customer = new Backend.Objects.Customer();
        Backend.Objects.User user = new Backend.Objects.User();

        public EventHandler OnCreate;
        public EventHandler OnDelete;
        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        enum PanelOrder { First, Second }
        Enums.ActionDialog ActionDialog { get; set; }

        Size ControlDefaultSize = new Size(746, 461);
        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 455);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Customer()
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
                Data = customer
            };
        }

        void SetCustomerGroup()
        {
            //Update customer.Group ... 
            if (dpdCustomerGroup.selectedValue.ToLower() == "(none)")
                return;
            else if (dpdCustomerGroup.selectedIndex == 0)
                return;
            else
            {
                customer.Group = customer.Group ?? new Backend.Objects.CustomerGroup();
                customer.Group.Id = QueryController.Customers.Group.GetGroupId(dpdCustomerGroup.selectedValue);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SetCustomerGroup();

            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateCustomer();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateCustomer();
                this.OnCreate(customer, e);
            }
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(user, Util.PermissionAlertType.Message, this))
                return;

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
                Message = $"Are you sure you want to permanently delete { customer.FirstName }, this customer will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                ActionDialog = Enums.ActionDialog.Deleted;
                //Delete
                DeleteCustomer();
            }

            blur.Close();
        }

        private void GroupSelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex
            Control control = (Control)sender;
            if (control.Name.Contains("dpd"))
                cbbCustomerGroup.SelectedIndex = dpdCustomerGroup.selectedIndex;
            else if (control.Name.Contains("cbb"))
                dpdCustomerGroup.selectedIndex = cbbCustomerGroup.SelectedIndex;
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

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelOrder.Second);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelOrder.First);
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;

            if (txt.Name.Contains("FirstName"))
                imgFirstNameValid.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 2, 25));

            else if (txt.Name.Contains("LastName"))
                imgLastNameValid.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 2, 25));

            else
                return;
        }
        private void CkbFemale_OnChange(object sender, EventArgs e)
        {
            ckbMale.Checked = !ckbMale.Checked;
        }

        private void CkbMale_OnChange(object sender, EventArgs e)
        {
            ckbFemale.Checked = !ckbFemale.Checked;
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            user = Util.Data.GetUser();
            customer = CurrentCustomer;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetCustomer();
                txtCustomerCode.Enabled = false;

                if (!Util.Func.IsUserAllowed(user))
                    btnDelete.Visible = false;
            }
            else if (Task == Enums.Task.Create)
            {
                customer = new Backend.Objects.Customer();
                txtCustomerCode.Text = ServerUtil.GenerateToken(TokenLengths.CustomerCodeLength);
                btnDelete.Visible = false;
            }

            // Add DropDown Items
            Util.Func.AddCountriesToDropDowns(cbbCountry, dpdCountry);
            GetCustomerGroups();

            Translate();
        }

        void GetCustomerGroups()
        {
            var response = QueryController.Customers.Group.GetGroups();
            if (response.StatusCode == 200)
            {
                foreach (Backend.Objects.CustomerGroup group in response.DataArray)
                {
                    cbbCustomerGroup.Items.Add(group.Name);
                    dpdCustomerGroup.AddItem(group.Name);
                }
            }
            // Default (none)
            cbbCustomerGroup.SelectedIndex = 0;
        }

        void GetCustomer()
        {
            if (QueryController.Customers.Customer.IsValid(customer))
            {
                var customerDisplayName = $" {customer.FirstName }, { customer.LastName } ";
                lblTitle.Text = (Task == Enums.Task.Get) ? customerDisplayName : $"Edit  { customerDisplayName }";

                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtCustomerCode.Text = customer.Code;
                txtEmail.Text = customer.Email;
                txtPhoneNumber.Text = customer.PhoneNumber;
                txtWebsite.Text = customer.Website;
                txtStreet.Text = customer.Address;
                txtCity.Text = customer.City;
                txtPostCode.Text = customer.PostCode;

                dpDateOfBirth.Value = customer.DateOfBirth;

                cbbCountry.SelectedIndex = cbbCountry.FindStringExact(customer.Country);
                if (customer.Group is object)
                {
                    cbbCustomerGroup.SelectedIndex = cbbCustomerGroup.FindStringExact(customer.Group.Name);
                    cbbCustomerGroup.SelectedItem = customer.Group.Name;
                }

                ckbMale.Checked = (customer.Sex.ToLower() == "male");
                ckbFemale.Checked = (customer.Sex.ToLower() == "female");
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.NotFound);
        }

        void UpdateCustomer()
        {
            if (!IsInputValid())
                return;

            if (QueryController.Customers.Customer.IsValid(customer))
            {
                SetCustomerProperties();
                var response = QueryController.Customers.Customer.Update(customer);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    this.Close();
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.Updated);
                }
                else
                {
                    ActionDialog = Enums.ActionDialog.Error;
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.ErrorUpdating);
                }
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.ErrorDeleting);
        }

        void CreateCustomer()
        {
            if (!IsInputValid())
                return;

            SetCustomerProperties();
            var response = QueryController.Customers.Customer.Create(customer);
            if (response.StatusCode == 201)
            {
                ActionDialog = Enums.ActionDialog.Error;
                this.Close();
                Util.MessageParser.Alert("Customer", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.ErrorCreating);
        }

        void SetCustomerProperties()
        {
            try
            {
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Code = txtCustomerCode.Text;
                customer.Email = txtEmail.Text;
                customer.DateOfBirth = dpDateOfBirth.Value;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.Website = txtWebsite.Text;
                customer.Address = txtStreet.Text;
                customer.City = txtCity.Text;
                customer.PostCode = txtPostCode.Text;

                customer.Sex = ckbFemale.Checked ? "Female" : "Male";
                customer.Sex = ckbMale.Checked ? "Male" : "Female";

                customer.Country = cbbCountry.SelectedValue.ToString();
            }
            catch { return; }
        }

        void DeleteCustomer()
        {
            if (QueryController.Customers.Customer.IsValid(customer))
            {
                var response = QueryController.Customers.Customer.Delete(customer);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Deleted;
                    this.Close();
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Customer", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Customer", Util.AlertParserType.NotFound);
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtFirstName.Text, 2, 20))
                return false;
            else if (!Validation.IsStringValid(txtLastName.Text, 2, 20))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            //Change Color
            dpDateOfBirth.BackColor = dpdCountry.NomalColor = SoftColor;
            txtFirstName.BorderColorFocused = txtLastName.BorderColorFocused = txtCustomerCode.BorderColorFocused =
                txtEmail.BorderColorFocused = txtPhoneNumber.BorderColorFocused = txtWebsite.BorderColorFocused = txtStreet.BorderColorFocused = txtCity.BorderColorFocused = txtPostCode.BorderColorFocused = SoftColor;

            btnSave.Activecolor = btnSave.Normalcolor = btnSave.BackColor = SoftColor;
            ckbFemale.CheckedOnColor = ckbFemale.CheckedOnColor = SwitchMarkettingQuery.OnColor = SoftColor;
            //HoverColor
            btnSave.OnHovercolor = HoverColor;
            txtFirstName.BorderColorMouseHover = txtLastName.BorderColorMouseHover = txtCustomerCode.BorderColorMouseHover =
             txtEmail.BorderColorMouseHover = txtPhoneNumber.BorderColorMouseHover = txtWebsite.BorderColorMouseHover = txtStreet.BorderColorMouseHover = txtCity.BorderColorMouseHover = txtPostCode.BorderColorMouseHover = SoftColor;
            //Color Images
            imgbtnGoFirstFields.Image = ImageUtil.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtn_Exit.Image = ImageUtil.ColorImage(imgbtn_Exit.Image, ColorGray);
            imgbtnGoSecondFields.Image = ImageUtil.ColorImage(imgbtnGoSecondFields.Image, ColorGray);

            //Size
            this.Size = ControlDefaultSize;
        }

        void ToPanel(PanelOrder panelOrderIndex)
        {
            if (panelOrderIndex == PanelOrder.First)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveField;
                pnlSecondFields.Location = InActiveField;
            }
            else if (panelOrderIndex == PanelOrder.Second)
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
