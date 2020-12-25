using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.Modals
{
    public partial class Alert : Form
    {
        #region Variables

        public string Message { get; set; }
        public string Title { get; set; }

        public AlertType AlertTypeIndex { get; set; }
        public AlertPosition AlertPositionIndex { get; set; }

        public enum AlertType { Success, Info, Warning, Error, Custom }
        public enum AlertPosition { TopLeft, TopRight, BottomLeft, BottomRight, Custom }
        public enum AlertSize { Mini, Normal, Large}

        public Color SuccessColor = Color.FromArgb(0, 206, 104);
        public Color WarningColor = Color.FromArgb(244, 139, 36);
        public Color InfoColor = Color.Gray;
        public Color ErrorColor = Color.FromArgb(216, 42, 59);

        public Color ActiveColor { get; set; }

        public Image SuccessIcon = Properties.Resources.ok_filled_w_xl;
        public Image WarningIcon = Properties.Resources.warning_w_xl_black;
        public Image InfoIcon = Properties.Resources.info_filled_xl_black;
        public Image ErrorIcon = Properties.Resources.error_filled_black_xl;

        public Color CustomColor { get; set; }
        public Point CustomPoint { get; set; }
        public Image CustomIcon { get; set; }

        public int ExtraPoint = 5;
        public int AnimationOffSetPoint = 40;
        public int AnimationSpeed = 3;
        public int TimeOutInterval = 5000; // 5s

        readonly Size MiniSize = new Size(383, 80);
        readonly Size IconMiniSize = new Size(50, 31);
        readonly Point TitleMiniLocation = new Point(65, 9);
        readonly Point MessageMiniLocation = new Point(66, 47);

        public bool IsMini { get; set; }
        public bool TranslateTitle = true;
        public bool TranslateMessage = true;

        #endregion

        #region Constructors

        public Alert()
        {
            InitializeComponent();
            Util.Methods.SetIcon(this);
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

        #region Control Event Handler

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            timAutoClose.Start();
        }

        int interval = 0;
        private void TimShow_Tick(object sender, EventArgs e)
        {
            if (this.Top < AnimationOffSetPoint)
            {
                //Drop the Alert
                this.Top += interval;

                //Double the speed
                interval += AnimationSpeed;
            }
            else
            {
                timShow.Stop();
            }
        }

        private void TimAutoClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }

        private void TimTimeOut_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        public static void Show(string title, string message, AlertType alertType, AlertPosition alertPosition = AlertPosition.BottomRight, bool isMini = true, bool translateTitle = true, bool translateMessage = true)
        {
            new Alert
            {
                Title = title,
                Message = message,
                AlertTypeIndex = alertType,
                AlertPositionIndex = alertPosition,
                IsMini = isMini,
                TranslateTitle = translateTitle,
                TranslateMessage = translateMessage,

            }.Show();
        }

        void InitializeUI()
        {
            switch (AlertTypeIndex)
            {
                case AlertType.Success:
                    ActiveColor = SuccessColor;
                    imgIcon.Image = SuccessIcon;
                    break;

                case AlertType.Info:
                    ActiveColor = InfoColor;
                    imgIcon.Image = ImageUtil.ColorImage(InfoIcon, Color.White);
                    TimeOutInterval = 7500;
                    break;

                case AlertType.Warning:
                    ActiveColor = WarningColor;
                    imgIcon.Image = ImageUtil.ColorImage(WarningIcon, Color.White);
                    TimeOutInterval = 10000;
                    break;

                case AlertType.Error:
                    ActiveColor = ErrorColor;
                    imgIcon.Image = ImageUtil.ColorImage(ErrorIcon, Color.White);
                    TimeOutInterval = 20000;
                    break;

                case AlertType.Custom:
                    ActiveColor = CustomColor;
                    imgIcon.Image = CustomIcon;
                    break;
            }
            this.BackColor = ActiveColor;
        }

        void Initialize()
        {
            // Change Location & Sizes+
            MakeResponsive();

            //Color & Icon
            InitializeUI();

            timTimeOut.Interval = TimeOutInterval;

            //Change Prosition
            SetPosition();

            lblMessage.Text = Message;
            lblTitle.Text = Title;
            
            Translate();
        }

        void MakeResponsive()
        {
            if (IsMini)
            {
                this.Size = MiniSize;
                imgIcon.Size = IconMiniSize;
                imgIcon.Location = new Point(12, 24);
                lblTitle.Location = TitleMiniLocation;
                lblMessage.Location = MessageMiniLocation;
                lblTitle.Font = new Font("Poppins", 13, FontStyle.Regular);
            }
        }
        void SetPosition()
        {
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;

            Rectangle workingArea = Screen.GetWorkingArea(this);
            switch (AlertPositionIndex)
            {
                case AlertPosition.TopLeft:
                    this.Location = new Point(ExtraPoint, ExtraPoint);
                    break;

                case AlertPosition.TopRight:
                    this.Location = new Point(workingArea.Width - Size.Width - ExtraPoint, ExtraPoint);
                    break;

                case AlertPosition.BottomLeft:
                    this.Location = new Point(0 + ExtraPoint, workingArea.Bottom - this.Height - ExtraPoint);
                    break;

                case AlertPosition.BottomRight:
                    this.Location = new Point(workingArea.Right - Size.Width - ExtraPoint,
                                              workingArea.Bottom - Size.Height - ExtraPoint);
                    break;

                case AlertPosition.Custom:
                    break;

            }
        }

        #endregion

        #region Translate 

        void Translate()
        {
            if (Translation.IsPossible())
            {             
                if(TranslateTitle)
                    Translation.TranslateControl(lblTitle);
                
                // Performances etc..
                if(TranslateMessage)
                    Translation.TranslateControl(lblMessage);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
