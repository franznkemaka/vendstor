using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls
{
    public partial class ComingSoon : UserControl
    {
        #region Variables


        public ComingSoon()
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

        #region Methods

        void Initialize()
        {
            Translate();
        }


        void InitializeUI()
        {
            btnNextRelease.BackColor = btnNextRelease.Activecolor =
                btnNextRelease.Normalcolor = btnNextRelease.OnHovercolor = UserInterface.SoftColor;
        }

        #endregion

        #region Translate 

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(lblMessage);
            }

            ReArrangeControls();

        }

        void ReArrangeControls()
        {
            Util.Methods.AlignToParent(lblMessage, cardComingSoon, Util.Methods.AlignIndex.HCenter);
        }

        #endregion

        #region OnClose

        #endregion
    }
}
