using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.Forms.PointOfSale
{
    public partial class Note : Form
    {
        #region Variables

        public string NoteMessage { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Note()
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

        private void OnClick(object sender, EventArgs e)
        {
            SetNote(true);
        }

        private void RtxtNote_TextChanged(object sender, EventArgs e)
        {
            SetNote();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetNote(true);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            rtxtNote.Text = NoteMessage;

            Translate();
        }

        void SetNote(bool close = false)
        {
            // Update if not Empty or Null
            if (!string.IsNullOrEmpty(rtxtNote.Text))
                NoteMessage = rtxtNote.Text;

            if (close)
                this.Close();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorImageButton(btnExit, Color.DarkGray);
            UserInterface.SetFlatButtonColor(btnAdd, SoftColor);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_Note);
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
