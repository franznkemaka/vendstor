using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Vendstor
using Vendstor.UI;
using Vendstor.Lib;
using Vendstor.Forms;
using Vendstor.Forms.Auth;
using Vendstor.Forms.PointOfSale;

using Vendstor.UserControls;
using Vendstor.UserControls.Dashboard;
using Vendstor.Models;


namespace Vendstor.UserControls.Dashboard
{
    public partial class Products : UserControl
    {
        #region Variables

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Enum
        enum UserControl { Hide, Close, Exit };


        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.FromArgb(136, 144, 157);
        //Color AltSoftColor;

        #endregion

        #region InitializeComponent

        public Products()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region UserControl Load


        #endregion

        #region UserControl - Event Handler


        #endregion


        #region Control - Event Handler


        #endregion


        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
        }
        void BackEnd()
        {

        }



        #endregion


        #region UserControl Close

        public void CloseUserControl(int _CloseFormIndex)
        {
            switch (_CloseFormIndex)
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
