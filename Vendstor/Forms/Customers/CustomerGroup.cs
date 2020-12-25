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

namespace Vendstor.Forms.Customers
{
    public partial class CustomerGroup : Form
    {
        #region Variables

        public Backend.Objects.CustomerGroup Group { get; set; }
        Backend.Objects.User user = new Backend.Objects.User();

        public EventHandler OnCreate;
        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        Image imageAdd = Properties.Resources.group_filled_w;
        Image imageEdit = Properties.Resources.edit_filled_w;

        #endregion

        #region Constructors

        public CustomerGroup()
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
                Data = Group,
                ActionDialog = ActionDialog,
            };
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateGroup();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateGroup();
                this.OnCreate(Group, e);
            }

            this.Close();
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        #endregion

        #region Methods

        void Initialize()
        {
            user = Util.Data.GetUser();

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetGroup();
                lblTitle.Text = Group.Name;
                btnAction.Text = "Edit" + " Group";
                btnAction.Iconimage = imageEdit;
                UserControlUtil.Func.MoveControlTo(btnAction, new Point(289, 202), new Size(155, 40),
               new Point(234, 202), new Size(210, 40));
            }
            else if (Task == Enums.Task.Create)
            {
                Group = new Backend.Objects.CustomerGroup();

                lblTitle.Text = "New Group";
                btnAction.Text = "Add" + " Group";
                btnAction.Iconimage = imageAdd;
                UserControlUtil.Func.MoveControlTo(btnAction, new Point(289, 202), new Size(155, 40),
               new Point(234, 202), new Size(210, 40));
            }

            Translate();
        }

        void GetGroup()
        {
            if (QueryController.Customers.Group.IsValid(Group))
                txtGroupName.Text = Group.Name;
            else
                Util.MessageParser.Alert("Group", Util.AlertParserType.NotFound);
        }

        void UpdateGroup()
        {
            if (!IsInputValid())
                return;

            Group.Name = txtGroupName.Text;
            if (QueryController.Customers.Group.IsValid(Group))
            {
                var response = QueryController.Customers.Group.Update(Group);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    Util.MessageParser.Alert("Group", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Group", Util.AlertParserType.ErrorUpdating);
            }
            else
                Util.MessageParser.Alert("Group", Util.AlertParserType.NotFound);
        }

        void CreateGroup()
        {
            if (!IsInputValid())
                return;

            Group.Name = txtGroupName.Text;
            var response = QueryController.Customers.Group.Create(Group);
            if (response.StatusCode == 201)
            {
                ActionDialog = Enums.ActionDialog.Created;
                Util.MessageParser.Alert("Group", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Group", Util.AlertParserType.ErrorCreating);
        }
        
        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtGroupName.Text, 2, 50))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            txtGroupName.BorderColorFocused = txtGroupName.BorderColorMouseHover =
                btnAction.Activecolor = btnAction.Normalcolor = btnAction.BackColor = SoftColor;
            //HoverColor
            btnAction.OnHovercolor = Color.FromArgb(200, SoftColor);
            //Color Image
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_GroupName);
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
