using System.Windows.Forms;
using System.Drawing;

namespace Vendstor.Backend.Utils
{
    /* Copyright : © 2018 RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
    ------------------------------------------------------------------------------
   Copyright : © RigleSoft™ -  Rigle™  A Company of  Franz Nkemaka™  -  All rights Reserved 
   UI Date   : 28 March 2018
   Soft Date : N.D   
   Author    : Franz Nkemaka™ @ CEO & Founder Rigle™, RigleSoft™  
   Email     : franznkemaka01@gmail.com, franznkemaka@rigle.co, franznkemaka@riglesoft.com, support@riglesoft.com, vendstor@riglesoft.com 
   License   : Freeware 
   Visit Us at : June : RigleSoft.com , RigleX.com, Rigle
   ------------------------------------------------------------------------------
   */
    public static class UserInterface
    {
        #region Color

        public static Color SoftColor
        {
            get
            {
                Color softColor = Properties.Settings.Default.SoftColor;

                if (softColor == Color.White || softColor == Color.Transparent)
                {
                    Properties.Settings.Default.SoftColor = Color.FromArgb(81, 103, 188);
                    Properties.Settings.Default.Save();
                }

                //Default Color 
                return Properties.Settings.Default.SoftColor;
            }
        }

        public static Color ColorGray = Color.FromArgb(209, 212, 221);
        public static Color ColorTextGray = Color.FromArgb(136, 144, 157);

        public static Color SetFlatButtonColor(Bunifu.Framework.UI.BunifuFlatButton btn, Color color)
        {
            btn.Activecolor = btn.BackColor = btn.Normalcolor = color;
            btn.OnHovercolor = Color.FromArgb(200, color);
            return color;
        }

        #endregion

        #region Methods  

        public static bool IsLoginDialog()
        {
            try
            {
                //Check If one of the two Forms is Open
                Forms.Main Main = (Forms.Main)Application.OpenForms["Main"];
                Forms.DashboardForm MainDashboard = (Forms.DashboardForm)Application.OpenForms["DashboardForm"];

                if (object.Equals(Main, null) && object.Equals(MainDashboard, null))
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
