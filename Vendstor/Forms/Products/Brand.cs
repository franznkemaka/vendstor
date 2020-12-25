using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Products
{
    public partial class Brand : Form
    {
        #region Variables

        public Backend.Objects.ProductBrand ProductBrand { get; set; }
        Backend.Objects.ProductBrand brand = new Backend.Objects.ProductBrand();
        Backend.Objects.User user = new Backend.Objects.User();

        public EventHandler OnCreate;
        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        Image imageAdd = Properties.Resources.mark_filled_w;
        Image imageEdit = Properties.Resources.edit_filled_w;

        #endregion

        #region Constructors

        public Brand()
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
                Data = brand,
                ActionDialog = ActionDialog,
            };
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateBrand();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateBrand();
                this.OnCreate(brand, e);
            }
            this.Close();
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        private void BrandNameValueChanged(object sender, EventArgs e)
        {
            //Check Input Validity
            imgValidInput.Image = Validation.GetValidityImage(Validation.IsStringValid(txtBrandName.Text, 2, 100));
        }

        #endregion

        #region  Methods


        void Initialize()
        {
            user = Util.Data.GetUser();
            brand = ProductBrand;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetBrand();
                lblTitle.Text = brand.Name;
                btnAction.Text = "Edit" + " Brand";
                btnAction.Iconimage = imageEdit;
            }
            else if (Task == Enums.Task.Create)
            {
                brand = new Backend.Objects.ProductBrand();

                lblTitle.Text = "New Brand";
                btnAction.Text = "Add" + " Brand";
                btnAction.Iconimage = imageAdd;
            }

            Translate();
        }

        void GetBrand()
        {
            if (QueryController.Products.Brand.IsValid(brand))
            {
                txtBrandName.Text = brand.Name;
                rtxtBrandDescription.Text = brand.Description;
            }                
            else
                Util.MessageParser.Alert("Brand", Util.AlertParserType.NotFound);
        }
        
        void UpdateBrand()
        {
            if (!IsInputValid())
            {
                imgValidInput.Image = Validation.GetValidityImage(false);
                return;
            }

            brand.Name = txtBrandName.Text;
            brand.Description = rtxtBrandDescription.Text;
            if (QueryController.Products.Brand.IsValid(brand))
            {
                var response = QueryController.Products.Brand.Update(brand);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    Util.MessageParser.Alert("Brand", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Brand", Util.AlertParserType.ErrorUpdating);
            }
            else
                Util.MessageParser.Alert("Brand", Util.AlertParserType.NotFound);
        }

        void CreateBrand()
        {
            if (!IsInputValid())
            {
                imgValidInput.Image = Validation.GetValidityImage(false);
                return;
            }

            brand.Name = txtBrandName.Text;
            brand.Description = rtxtBrandDescription.Text;
            var response = QueryController.Products.Brand.Create(brand);
            if (response.StatusCode == 201)
            {
                ActionDialog = Enums.ActionDialog.Created;
                Util.MessageParser.Alert("Brand", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Brand", Util.AlertParserType.ErrorCreating);
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtBrandName.Text, 2, 100))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            txtBrandName.BorderColorFocused = txtBrandName.BorderColorMouseHover =
                btnAction.Activecolor = btnAction.Normalcolor = btnAction.BackColor = SoftColor;
            //HoverColor
            btnAction.OnHovercolor = Color.FromArgb(200, SoftColor);
            //Color Image
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
            //Size
            btnAction.Size = new Size((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 233 : 147, btnAction.Size.Height);
            btnAction.Location = new Point((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 203 : 281, btnAction.Location.Y);
        }

        #endregion

        #region Translate

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_BrandName);
                Translation.TranslateControl(text_Description);
                Translation.TranslateControl(btnAction);

                if (Task == Enums.Task.Get || Task == Enums.Task.Get)
                    lblTitle.Text = Translation.Translate("Edit ") + lblTitle.Text;
                else
                    Translation.TranslateControl(lblTitle);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
