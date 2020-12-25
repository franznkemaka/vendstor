using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;


namespace Vendstor.Modals
{
    public partial class MessageDialog : Form
    {
        #region Variables

        //Props
        public string Message { get; set; }
        public string Title { get; set; }

        public string FirstBtnText { get; set; }
        public string SecondBtnText { get; set; }
        public string ThirdBtnText { get; set; }

        public Color FirstBtnColor = Color.Tomato;
        public Color SecondBtnColor { get; set; }
        public Color ThirdBtnColor { get; set; }

        public DialogButtons DialogButtonsIndex { get; set; }
        public DialogIcon DialogIconIndex { get; set; }
        public DialogTye DialogTyeIndex { get; set; }

        public enum DialogTye { Yes, YesNo, YesNoCancel }
        public enum DialogButtons { One, Two, All }
        public enum DialogIcon { Success, Info, Warning, Error, Custom, Tick, VectorError, HappyMan, Happy, Sorry }

        public Image CustomIcon { get; set; }

        public Image SuccessIcon = Properties.Resources.winner_vector;
        public Image WarningIcon = Properties.Resources.warning_yellow_triangle;
        public Image InfoIcon = Properties.Resources.info_filled_xl_black;
        public Image ErrorIcon = Properties.Resources.warning_yellow_triangle;
        public Image TickIcon = Properties.Resources.tick;

        public Image DefaultIcon = Properties.Resources.n_a;

        public bool AutoSizeControl = false;
        public bool TranslateStrings = true;
        public bool UseDefault = false;

        private OnClickEvent OnClickEventIndex { get; set; }
        public enum OnClickEvent { FirstButton, SecondButton, ThirdButton, Closed }

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public MessageDialog()
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
        
        private void ThirdDialogBtn_Click(object sender, EventArgs e)
        {
            OnClickEventIndex = OnClickEvent.ThirdButton;
            this.Hide();
        }

        private void SecondDialogBtn_Click(object sender, EventArgs e)
        {
            OnClickEventIndex = OnClickEvent.SecondButton;
            this.Hide();
        }

        private void FirstDialogBtn_Click(object sender, EventArgs e)
        {
            OnClickEventIndex = OnClickEvent.FirstButton;
            this.Hide();
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            OnClickEventIndex = OnClickEvent.Closed;
            this.Hide();
        }

        #endregion

        #region  Methods
        
        public OnClickEvent ShowWithEvent()
        {
            this.ShowDialog();
            return OnClickEventIndex;
        }

        void Initialize()
        {
            // Change Location & Sizes+
            //MakeResponsive();

            if (UseDefault)
                //GetDefault Type
                SetType();

            lblMessage.Text = Message;
            lblTitle.Text = Title;
            FirstDialogBtn.Text = FirstBtnText;
            SecondDialogBtn.Text = SecondBtnText;
            ThirdDialogBtn.Text = ThirdBtnText;

            // Icons 
            SetDialogIcon();

            // Buttons  & Colors
            SetDialogButtons();
            SetButtonColors();

            
            //Translate if Stated
            if (TranslateStrings)
                Translate();

            //Locations
            SetPositions();

        }

        void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;
            //Color Images
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
            ThirdBtnColor = SecondBtnColor = SoftColor;
        }

        void SetType()
        {
            //Set Icon, Type   
            switch (DialogTyeIndex)
            {
                case DialogTye.Yes:
                    DialogButtonsIndex = DialogButtons.One;
                    ThirdBtnText = "Yes";
                    ThirdBtnColor = SoftColor;
                    break;

                case DialogTye.YesNo:
                    DialogButtonsIndex = DialogButtons.Two;
                    ThirdBtnColor = SoftColor;
                    ThirdBtnText = "Yes";
                    SecondBtnText = "No";
                    break;

                case DialogTye.YesNoCancel:
                    DialogButtonsIndex = DialogButtons.All;

                    FirstBtnText = "Cancel";
                    SecondBtnText = "No";
                    ThirdBtnText = "Yes";

                    ThirdBtnColor = SoftColor;
                    break;
            }
        }

        void SetDialogButtons()
        {
            //Buttons 
            switch (DialogButtonsIndex)
            {
                case DialogButtons.All:
                    //Show All
                    FirstDialogBtn.Visible = SecondDialogBtn.Visible = ThirdDialogBtn.Visible = true;
                    //Location [Custom]
                    FirstDialogBtn.Location = new Point(371, FirstDialogBtn.Location.Y);
                    SecondDialogBtn.Location = new Point(223, SecondDialogBtn.Location.Y);
                    ThirdDialogBtn.Location = new Point(75, ThirdDialogBtn.Location.Y);
                    break;

                case DialogButtons.One:
                    //Show FirstDialogBtn Only     
                    ThirdDialogBtn.Visible = true;
                    SecondDialogBtn.Visible = FirstDialogBtn.Visible = false;

                    //Location [Center]
                    Util.Methods.AlignToParent(ThirdDialogBtn, pnlBottom);
                    break;

                case DialogButtons.Two:

                    //Show SecondDialogBtn & ThirdDialogBtn Only
                    ThirdDialogBtn.Visible = SecondDialogBtn.Visible = true;
                    FirstDialogBtn.Visible = false; 

                    //Location [Right] [Move X Only]
                    SecondDialogBtn.Location = new Point(311, SecondDialogBtn.Location.Y);
                    ThirdDialogBtn.Location = new Point(163, ThirdDialogBtn.Location.Y);
                    break;
            }
        }

        void SetButtonColors()
        {
            //Change Button Color
            FirstDialogBtn.BackColor = FirstDialogBtn.Activecolor = FirstDialogBtn.Normalcolor = (FirstBtnColor != Color.Transparent) ? FirstBtnColor : SoftColor;
            SecondDialogBtn.BackColor = SecondDialogBtn.Activecolor = SecondDialogBtn.Normalcolor = SecondBtnColor;
            ThirdDialogBtn.BackColor = ThirdDialogBtn.Activecolor = ThirdDialogBtn.Normalcolor = ThirdBtnColor;

            //Hover Color                          
            //Use Default Color If Undefined 
            FirstDialogBtn.OnHovercolor = (FirstBtnColor != Color.Transparent) ? Color.FromArgb(200, FirstBtnColor) : Color.FromArgb(200, SoftColor);
            SecondDialogBtn.OnHovercolor = Color.FromArgb(200, SecondBtnColor);
            ThirdDialogBtn.OnHovercolor = Color.FromArgb(200, ThirdBtnColor);
        }

        void SetPositions()
        {
            //Props
            this.AutoSize = this.AutoSizeControl;

            //Align Controls
            Util.Methods.AlignToParent(lblTitle, pnlMain);
            Util.Methods.AlignToParent(lblMessage, pnlMain);

            if (this.ParentForm != null)
                this.CenterToParent();
            else
                this.CenterToScreen();
        }

        void SetDialogIcon()
        {
            Image dialogIcon = null;
            switch (DialogIconIndex)
            {
                case DialogIcon.Success:
                    dialogIcon = SuccessIcon;
                    break;
                case DialogIcon.Info:
                    dialogIcon = InfoIcon;
                    break;
                case DialogIcon.Warning:
                    dialogIcon = WarningIcon;
                    break;
                case DialogIcon.Error:
                    dialogIcon = ErrorIcon;
                    break;
                case DialogIcon.Tick:
                    dialogIcon = TickIcon;
                    break;

                case DialogIcon.VectorError:
                    dialogIcon = Properties.Resources.error_icon4;
                    break;

                case DialogIcon.HappyMan:
                    dialogIcon = Properties.Resources.happyman_vector;
                    break;

                case DialogIcon.Happy:
                    dialogIcon = Properties.Resources.fisher_vector;
                    break;

                case DialogIcon.Sorry:
                    dialogIcon = Properties.Resources.vector_sorrygirl;
                    break;

            }
            imgDialogIcon.Image = dialogIcon;
        }


        /*
        public static void Show(string title, string message, DialogTye dialogTye = DialogTye.Yes,  DialogIcon dialogIcon = DialogIcon.Info, DialogButtons dialogButtons = DialogButtons.All,
             bool translate = true, bool autoSize = true, bool useDefault = false)
        {
            new MessageDialog
            {
                Title = title,
                Message = message,
                DialogButtonsIndex = dialogButtons,
                DialogTyeIndex = dialogTye,
                DialogIconIndex = dialogIcon,
                TranslateStrings = translate,
                UseDefault = useDefault,
                AutoSizeControl = autoSize,

            }.Show();
        }*/

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings
                foreach (Control control in pnlBottom.Controls)
                    Translation.TranslateControl(control);

                Translation.TranslateControl(lblMessage);
                Translation.TranslateControl(lblTitle);
            }
        }

        #endregion

        #region OnClose


        #endregion
    }
}
