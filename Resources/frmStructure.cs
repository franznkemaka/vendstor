//Vendstor
using Vendstor.UI;
using Vendstor.Lib;
using Vendstor.Forms;
using Vendstor.Forms.Auth;
using Vendstor.Forms.PointOfSale;
using Vendstor.BackEnd;


using Vendstor.UserControls;
using Vendstor.UserControls.Dashboard;
using Vendstor.Models;



namespace Vendstor
{
    public partial class  : Form
    {
        #region Variables

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();
        Languages Lang = new Languages();
        BackEnd.Lib BackEndLib = new BackEnd.Lib();
        Log Log = new Log();
		
		//Enum
        enum Form { Hide, Close, Exit};

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        //Color AltSoftColor;

        #endregion

        #region InitializeComponent

        public ucHome_TopSoldProduct()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region Form Load

        

        #endregion

        #region Control - Event Handler


        #endregion
		
		#region Button - Event Handler


        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
        }
        void BackEnd()
        {
			//Translate Strings
            TranslateSoft();

        }



        #endregion
		
		#region TranslateSoft

           
		 void TranslateSoft()
        {
            if(Properties.Settings.Default.SoftLocale != "en")
            {
                //Translate String [Status]
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Text = Lang.TranslateString(ctrl.Text);
                }
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