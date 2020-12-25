using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.UI;
using Vendstor.Lib;
using Vendstor.Forms;
using Vendstor.Forms.Auth;
using Vendstor.Forms.PointOfSale;

using Vendstor.UserControls;
using Vendstor.UserControls.Dashboard;
using Vendstor.Models;

namespace Vendstor.Forms
{
    public partial class CreateProduct : Form
    {

        #region Variables
        //Props
        public string ProductToken { get; set; }
        public string Title { get; set; }
        public string RootForm { get; set; }

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Enum
        enum Form { Hide, Close, Exit };
        enum FieldOrder { First, Second }

        //Size
        Size ControlDefaultSize = new Size(888, 550);

        //Point
        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 556);

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        //Color AltSoftColor;


        Image DefaultImage = Properties.Resources.delete_w;

        #endregion

        #region InitializeComponent

        public CreateProduct()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region Form Load


        private void CreateProduct_Load_1(object sender, EventArgs e)
        {
            BackEnd();
                     
        }

        #endregion

        #region Control - Event Handler

        private void imgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            //Set _FieldIndex = 1 => Second Panel
            OrderFields((int)FieldOrder.Second);
        }

        private void imgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            //Set _FieldIndex = 0 => First Panel
            OrderFields((int)FieldOrder.First);
        }

        private void imgbtn_Exit_Click(object sender, EventArgs e)
        {
            this.CloseForm((int)Form.Close);
        }

        private void pnlDragDropImage_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void pnlDragDropImage_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void UploadImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void UploadImage_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string ImagePath in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image ProductImage = Image.FromFile(ImagePath);

                //Sender Obj => Control
                var imgbtn = (BunifuImageButton)sender;


                if (imgbtn.Image != ProductImage)
                {

                    imgbtn.Image = ProductImage;
                }

            }
        }

        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
            Color HoverColor = Color.FromArgb(200, SoftColor);

            //Change Color
           

            //HoverColor

            //Color Images
            imgbtn_Exit.Image = Lib.ColorImage(imgbtn_Exit.Image, ColorGray);
            imgbtnGoFirstFields.Image = Lib.ColorImage(imgbtnGoFirstFields.Image, ColorGray);           
            imgbtnGoSecondFields.Image = Lib.ColorImage(imgbtnGoSecondFields.Image, ColorGray);

            //Size
            this.Size = ControlDefaultSize;


            UploadImage_img1.AllowDrop = true;
            UploadImage_img2.AllowDrop = true;
            UploadImage_img3.AllowDrop = true;

            imgbtn_Exit.Location = new Point(833, 9);
            UploadImage_img1.Image = UploadImage_img2.Image = UploadImage_img3.Image = DefaultImage;
        }

        void BackEnd()
        {
            //Set Title 
            lblTitle.Text = (Title != null) ? Title : lblTitle.Text;

            //EditProduct

        }
        void EditProduct()
        {
            //Display Product Data By Token From DB
        }

        void GoRootForm()
        {
            this.Hide();
        }


        void OrderFields(int _FieldIndex)
        {
            //Know Field Index  (First = 0, Second = 1)        
            if (_FieldIndex == (int)FieldOrder.First)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveField;
                pnlSecondFields.Location = InActiveField;
            }
            else if (_FieldIndex == (int)FieldOrder.Second)
            {
                //Change Panel Location
                pnlFirstFields.Location = InActiveField;
                pnlSecondFields.Location = ActiveField;
            }

        }


        #endregion

        #region Form Close

        public void CloseForm(int _CloseFormIndex)
        {
            switch (_CloseFormIndex)
            {
                case (int)Form.Close:
                    this.Close();
                    break;

                case (int)Form.Exit:
                    Application.Exit();
                    break;

                case (int)Form.Hide:
                    //Hide
                    this.Hide();
                    break;
            }
        }




        #endregion

      
    }
}
