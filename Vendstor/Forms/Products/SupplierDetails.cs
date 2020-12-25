using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Products
{
    public partial class SupplierDetails : Form
    {
        #region Variables

        public Backend.Objects.ProductSupplier Supplier { get; set; }
        Backend.Objects.User user = new Backend.Objects.User();

        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public SupplierDetails()
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
                Data = Supplier
            };
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            //Edit Supplier
            Supplier supplierForm = new Supplier
            {
                ProductSupplier = Supplier,
                TopMost = true,
                Task = Enums.Task.Update,
            };

            // Update If Updated
            var formResponse = supplierForm.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                Supplier = (Backend.Objects.ProductSupplier)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Close -> Nothing to show
                ActionDialog = Enums.ActionDialog.Deleted;
                this.Close();
            }
            
            blur.Close();
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
                Message = $"Are you sure you want to permanently delete { Supplier.Name }, this supplier will be deleted immediately. You can't undo this action.",
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

        private void LblSupplierDescription_SizeChanged(object sender, EventArgs e)
        {
            //Align To Center
            lblSupplierDescription.Left = (this.ClientSize.Width - lblSupplierDescription.Size.Width) / 2;
        }

        private void LblWebsite_Click(object sender, EventArgs e)
        {
            // PR : Open Website
        }

        private void LblEmailAddress_Click(object sender, EventArgs e)
        {
            // PR : Email directly
        }

        #endregion

        #region  Methods


        void Initialize()
        {
            user = Util.Data.GetUser();

            //Get
            GetSupplier();

            Translate();
        }

        void GetSupplier()
        {
            if (QueryController.Products.Supplier.IsValid(Supplier))
            {
                lblSupplierName.Text = Supplier.Name;
                lblMarkupPtg.Text = Supplier.Markup.ToString();
                lblCompany.Text = Supplier.Company;
                lblContact.Text = string.Format("{0} {1}", Supplier.FirstName, Supplier.LastName);
                lblPhoneNumber.Text = Supplier.PhoneNumber;
                lblEmailAddress.Text = Supplier.Email;
                lblWebsite.Text = Supplier.Website;
                lblAddress_Street.Text = Supplier.Address;
                lblAddress_PostCode.Text = Supplier.PostCode;
                lblAddress_City.Text = Supplier.City;
                lblAddress_Country.Text = Supplier.Country;
                lblSupplierDescription.Text = Supplier.Description;
            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.NotFound);
        }

        void DeleteSupplier()
        {

            if (QueryController.Products.Supplier.IsValid(Supplier))
            {
                var response = QueryController.Products.Supplier.Delete(Supplier);
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

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);

            btnEdit.BackColor = btnEdit.Activecolor = btnEdit.Normalcolor = SoftColor;

            btnEdit.OnHovercolor =  HoverColor;
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);

            Bunifu.Framework.UI.BunifuElipse Elipse = new Bunifu.Framework.UI.BunifuElipse
            {
                ElipseRadius = 7,
                TargetControl = pnlToolBox
            };
        }

        #endregion
        
        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in this.Controls)
                    if (control is Label && !control.Name.Contains("lbl"))
                        Translation.TranslateControl(control);

                Translation.TranslateControl(lblHint);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
