using System;
using System.Drawing;
using System.Windows.Forms;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls.Dashboard.Reports
{
    public partial class Dashboard : UserControl
    {
        #region Variables
        Color SoftColor;

        #endregion

        #region Constructors

        public Dashboard()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region OnLoad


        #endregion

        #region  Methods

        void InitializeUI()
        {     
            SoftColor = UserInterface.SoftColor;
        }

        void Initialize()
        {

        }

        #endregion

        #region OnClose

        #endregion
    }
}
