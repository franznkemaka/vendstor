using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Vendstor.Backend.Utils
{
    public static class UserControlUtil
    {
        public static bool IsLargeScreen
        {
            get
            {
                return Screen.PrimaryScreen.Bounds.Width > 1300;
            }
        }

        public static class Func
        {
            public static void AddTabToControl(Control control, Control parentControl, Control tabs, bool ActiveColor = true)
            {
                //Add Controls
                control.Size = parentControl.Size;
                parentControl.Controls.Clear();
                parentControl.Controls.Add(control);

                if (ActiveColor)
                {
                    //Change ForeColor Of Other Tabs
                    foreach (Control _control in tabs.Controls)
                    {
                        if (_control != control)
                            _control.ForeColor = UserInterface.ColorTextGray;
                        else
                            _control.ForeColor = Color.Black;
                    }
                }
            }

            public static void IndicateControl(Control control, Control indicator)
            {
                //Point Indicator to Control
                indicator.Location = new Point(control.Location.X, indicator.Location.Y);
                indicator.Size = new Size(control.Size.Width, indicator.Size.Height);
            }

            public static void ResizeControl(Control control, Size actualSize, int extraHeight = 0, int mediumScreenHeight = 100, int largeScreenHeight = 150)
            {
                int halfScreenHeight = actualSize.Height / 2;

                if (actualSize.Height < 1000 && actualSize.Height > 600)
                {
                    //If Screen Size.Height Is Between 1000 and 600 => 1280p Screen => Divide By 2 => Add 100
                    control.Size = new Size(control.Size.Width, halfScreenHeight + mediumScreenHeight);
                }

                else if (actualSize.Height > 1000)
                    // If Screen Size.Height Is Greater Than 1000 => 1920 Screen => Divide By 2 => Add 150
                    control.Size = new Size(control.Size.Width, halfScreenHeight + largeScreenHeight);

                else if (actualSize.Height < 700)
                    // Normal Size => Smaller Than 700 Divide By 2 => Add extraHeight
                    control.Size = new Size(control.Size.Width, halfScreenHeight + extraHeight);
            }

            public static void MoveControlTo(Control control, Point enPoint, Size enSize, Point otherPoint, Size otherSize)
            {
                if (Properties.Settings.Default.SoftLocale == "en")
                {
                    control.Location = enPoint;
                    control.Size = enSize;
                }
                else
                {
                    control.Location = otherPoint;
                    control.Size = otherSize;
                }

            }
            
            public static void ColorStoreCredit(Control control, decimal amount)
            {
                if (amount >= 0)
                    control.ForeColor = Color.FromArgb(0, 206, 104); // Green
                else
                    control.ForeColor = Color.Tomato; // Red
            }

            public static void ResizeControl(Control control, int width = 1144)
            {
                if (!IsLargeScreen)
                    control.Size = new Size(width, control.Size.Height);
            }
        }
    }
}
