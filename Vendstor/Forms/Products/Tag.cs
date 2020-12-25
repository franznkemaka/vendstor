using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Products
{
    public partial class Tag : Form
    {
        #region Variables
        //Props
        public string TagToken { get; set; }
        public string Title { get; set; }
        public string Task { get; set; }
        public string RootForm { get; set; }
        
        //Class

        //Enum
        enum Form { Hide, Close, Exit };

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        //Image
        Image imgAdd = Properties.Resources.addTag_filled_w;
        Image imgEdit = Properties.Resources.edit_filled_w;


        //Color AltSoftColor;

        #endregion

        #region Constructors

        public Tag()
        {
            InitializeComponent();

            //Void
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

        private void BtnAction_Click(object sender, EventArgs e)
        {
            //sender obj => Control
            Control control = (Control)sender;

            if (control.Text.Contains("Add"))
                AddTag();
            else if (control.Text.Contains("Edit"))
                EditTag();
        }
        
        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //Close
           this.Close();
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;

            //Change Color
            txtTagName.BorderColorFocused = txtTagName.BorderColorMouseHover =
                btnAction.Activecolor = btnAction.Normalcolor = btnAction.BackColor = SoftColor;

            //HoverColor
            btnAction.OnHovercolor = Color.FromArgb(200, SoftColor);

            //Color Image
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
        }

        void Initialize()
        {
            //Set Title 
            lblTitle.Text = (Title == null) ? (((Task == "Edit") ? "Edit " : "New ") + lblTitle.Text) : Title;

            btnAction.Text = lblTitle.Text;
            btnAction.Iconimage = (Task == "Edit") ? imgEdit : imgAdd;
        }

        void GetTag()
        {

            //Fill Text
        }

        void EditTag()
        {

            //Close
           this.Close();
        }
        void AddTag()
        {

            //Close
           this.Close();
        }



        #endregion

        #region OnClose
                

        #endregion

    }
}
