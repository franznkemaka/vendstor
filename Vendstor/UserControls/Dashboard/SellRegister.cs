using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls.Dashboard
{
    public partial class SellRegister : UserControl
    {
        #region Variables
             
        Color SoftColor;

        #endregion

        #region Constructors

        public SellRegister()
        {
            InitializeComponent();

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

        private void OnClick(object sender, EventArgs e)
        {

        }

        #endregion

        #region  Methods
                
        void Initialize()
        {
            Translate();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
        }
        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_Mobility);
                Translation.TranslateControl(text_Reports);
                Translation.TranslateControl(text_Simplicity);
            }
        }

        #endregion

        #region OnClose

        #endregion     
    }
}