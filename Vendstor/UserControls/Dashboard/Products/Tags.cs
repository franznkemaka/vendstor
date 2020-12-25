using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.Forms;
using Vendstor.Models;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Tags : UserControl
    {
        #region Variables

        //Class







        //Enum
        enum UserControl { Hide, Close, Exit };

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.FromArgb(136, 144, 157);
        //Color AltSoftColor;


        //Size
        Size NormalSize = new Size(1128, 597);
        int MediumScreenHeight = 100 + 70;
        int LargeScreenHeight = 150 + 70;

        #endregion

        #region Constructors

        public Tags()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        private void OnSizeChanged(object sender, EventArgs e)
        {
            ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void BtnAddTag_Click(object sender, EventArgs e)
        {
            //Add Blur
            Blur blur = new Blur(this.ParentForm, 0.60);
            blur.Show();

            //Add Tag
            Forms.Products.Tag AddTag = new Forms.Products.Tag();

            //Props
            AddTag.TopMost = true;
            AddTag.Task = "Add";
            AddTag.ShowDialog();

            //Remove Blur
            blur.Close();
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;

            //Change Color
            btnAddTag.Activecolor = btnAddTag.BackColor = btnAddTag.Normalcolor = SoftColor;

            //HoverColor
            btnAddTag.OnHovercolor = Color.FromArgb(200, SoftColor);

        }

        void Initialize()
        {
            for (int i = 0; i < 5; i++)
            {
                //Fill Grid [ flpnlProductGrid ] With Rows
                Models.Products.ProductTagModel rowProductTags = new Models.Products.ProductTagModel();
                flpnlTagsGrid.Controls.Add(rowProductTags);
            }
        }
        public void RootSizeChanged() //@ Call When Root (Parent) Form Sizes Change
        {

        }

        void ResizeControl()
        {
            //Get ActualSize
            Size ActualSize = this.Size;
            int HalfScreenHeight = ActualSize.Height / 2;

            if (ActualSize.Height < 1000 && ActualSize.Height > 600)
            {
                //If Screen Size.Height Is Between 1000 and 600 => 1280p Screen => Divide By 2 => Add 100
                flpnlTagsGrid.Size = new Size(flpnlTagsGrid.Size.Width, HalfScreenHeight + MediumScreenHeight);
            }

            else if (ActualSize.Height > 1000)
                // If Screen Size.Height Is Greater Than 1000 => 1920 Screen => Divide By 2 => Add 150
                flpnlTagsGrid.Size = new Size(flpnlTagsGrid.Size.Width, HalfScreenHeight + LargeScreenHeight);

            else if (ActualSize.Height < 700)
                // Normal Size => Smaller Than 700 Divide By 2 => Add 3
                flpnlTagsGrid.Size = new Size(flpnlTagsGrid.Size.Width, HalfScreenHeight + 3);

            // 356
            if (ActualSize.Height < 600)
                flpnlTagsGrid.Size = new Size(1106, 356);
        }


        #endregion

        #region OnClose

        public void CloseUserControl(int _OnCloseIndex)
        {
            switch (_OnCloseIndex)
            {


                case (int)UserControl.Exit:
                    Application.Exit();
                    break;

                case (int)UserControl.Hide:
                    //Hide
                    this.Hide();
                    break;
            }
        }



        #endregion

    }
}
