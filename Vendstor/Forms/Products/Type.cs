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
    public partial class Type : Form
    {
        #region Variables

        public Backend.Objects.ProductType ProductType { get; set; }
        Backend.Objects.ProductType type = new Backend.Objects.ProductType();
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

        public Type()
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
                Data = type,
                ActionDialog = ActionDialog,
            };
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateType();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateType();
                this.OnCreate(type, e);
            }
            this.Close();
        }

        private void TypeNameValueChanged(object sender, EventArgs e)
        {
            //Check Input Validity
            imgValidInput.Image = Validation.GetValidityImage(Validation.IsStringValid(txtTypeName.Text, 2, 100));
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            user = Util.Data.GetUser();
            type = ProductType;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetProductType();
                lblTitle.Text = type.Name;
                btnAction.Text = "Edit" + " Type";
                btnAction.Iconimage = imageEdit;
            }
            else if (Task == Enums.Task.Create)
            {
                type = new Backend.Objects.ProductType();

                lblTitle.Text = "New Type";
                btnAction.Text = "Add" + " Type";
                btnAction.Iconimage = imageAdd;
            }

            Translate();
        }

        void GetProductType()
        {
            if (QueryController.Products.Type.IsValid(type))
            {
                txtTypeName.Text = type.Name;
            }
            else
                Util.MessageParser.Alert("Type", Util.AlertParserType.NotFound);
        }

        void UpdateType()
        {
            if (!IsInputValid())
            {
                imgValidInput.Image = Validation.GetValidityImage(false);
                return;
            }

            type.Name = txtTypeName.Text;
            if (QueryController.Products.Type.IsValid(type))
            {
                var response = QueryController.Products.Type.Update(type);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    Util.MessageParser.Alert("Type", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Type", Util.AlertParserType.ErrorUpdating);
            }
            else
                Util.MessageParser.Alert("Type", Util.AlertParserType.NotFound);
        }

        void CreateType()
        {
            if (!IsInputValid())
            {
                imgValidInput.Image = Validation.GetValidityImage(false);
                return;
            }

            type.Name = txtTypeName.Text;
            var response = QueryController.Products.Type.Create(type);
            if (response.StatusCode == 201)
            {
                ActionDialog = Enums.ActionDialog.Created;
                Util.MessageParser.Alert("Type", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Type", Util.AlertParserType.ErrorCreating);
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtTypeName.Text, maxLength: 100))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;
            txtTypeName.BorderColorFocused = txtTypeName.BorderColorMouseHover =
                btnAction.Activecolor = btnAction.Normalcolor = btnAction.BackColor = SoftColor;
            //HoverColor
            btnAction.OnHovercolor = Color.FromArgb(200, SoftColor);
            //Color Image
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);

            btnAction.Size = new Size((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 233 : 147, btnAction.Size.Height);
            btnAction.Location = new Point((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 211 : 289, btnAction.Location.Y);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                lblTitle.Text = Translation.Translate(lblTitle.Text);
                text_TypeName.Text = Translation.Translate(text_TypeName.Text);
                btnAction.Text = Translation.Translate(btnAction.Text);
            }
        }

        #endregion

        #region OnClose

        #endregion

       
    }
}
