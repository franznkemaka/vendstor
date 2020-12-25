using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

using Vendstor.Forms;
using Vendstor.Backend.Constants;

namespace Vendstor.Backend.Utils
{
    public static class Extensions
    {     
        public static string AppendLine(string original, string otherLine)
        {
            return original + Environment.NewLine + otherLine;
        }

        public static void HideAndShow(Form currentForm, Form formToShow)
        {
            currentForm.Hide();
            formToShow.Show();
        }

        public static void HideAndStart(Form currentForm, Form formToShow)
        {
            currentForm.Hide();
            formToShow.ShowDialog();
            currentForm.Show();
        }

        public static void RunApplication(Form frm)
        {
            frm.Show();
        }

       
        public static void ExitApplication()
        {
            Application.Exit();
        }

        public static void ShowWithBlur(Form parentForm, Form form, double opacity = 0.60)
        {
            parentForm.TopMost = false;
            Blur blur = new Blur(parentForm, opacity);
            //Add Blur 
            blur.Show();
            form.TopMost = true;
            form.Show();
            //Remove Blur 
            form.Close();
            parentForm.TopMost = true;
        }

        public static void ShowDialogWithBlur(Form parentForm, Form form, double opacity = 0.60)
        {
            parentForm.TopMost = false;
            Blur blur = new Blur(parentForm, opacity);
            //Add Blur 
            blur.Show();
            form.TopMost = true;
            form.ShowDialog();
            //Remove Blur 
            blur.Close();
            parentForm.TopMost = true;
        }

        public static void CloseOrHide(Form form, string parentFormName)
        {
            try
            {
                foreach (Form frm in Application.OpenForms)
                    if (frm.Name == parentFormName)
                        form.Hide();
                    else
                        form.Close();
            }
            catch { form.Close(); }
        }


        public static void RunInAnotherApplication(this Form form)
        {
            RunInAnotherThread(() => Application.Run(form));
        }

        public static void RunInAnotherApplicationAndJoin(this Form form)
        {
            RunInAnotherThread(() => Application.Run(form), true);
        }


        public static void RunInAnotherApplication<T>(bool join = true, params object[] constructorArgs) where T : Form
        {
            RunInAnotherThread(() => Application.Run((Form)Activator.CreateInstance(typeof(T), constructorArgs)),
                join);
        }

        public static void HideAndRunInAnotherApplication<T>(this Form form, bool join = true,
            params object[] constructorArgs) where T : Form
        {
            form.InvokeIfRequired(form.Hide);
            RunInAnotherThread(() =>
            {
                Application.Run((Form)Activator.CreateInstance(typeof(T), constructorArgs));
                form.InvokeIfRequired(form.Show);
            }, join);
        }

        public static void RunInAnotherThread(MethodInvoker inv, bool join = false)
        {
            var th = new Thread(() => inv?.Invoke());
            th.Start();
            if (join)
                th.Join();
        }

        /// <summary>  
        /// method for changing the opacity of an image  
        /// </summary>  
        /// <param name="image">image to set opacity on</param>  
        /// <param name="opacity">percentage of opacity</param>  
        /// <returns></returns>  
        public static Bitmap SetImageOpacity(this Bitmap image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                var bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (var gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    var matrix = new ColorMatrix { Matrix33 = opacity };

                    //create image attributes  
                    var attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception)
            {
                return image;
            }
        }


        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            if (!control.IsDisposed && !control.Disposing && control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

        private static int CountDownDuration { get; set; }
        private static System.Windows.Forms.Timer TimCountDown { get; set; }

        public static void CountDown(int duration,  EventHandler callback)
        {
            TimCountDown = new System.Windows.Forms.Timer();
            //TimCountDown.Tick += new EventHandler(TimExit_Tick(callback, null));
            TimCountDown.Interval = 1; // 1 millisecond
            TimCountDown.Start();
        }

        private static void TimExit_Tick(object sender, EventArgs e)
        {
            CountDownDuration--;
            if (CountDownDuration == 0)
            {
                var callBack = (EventHandler)sender;
                TimCountDown.Stop();
                callBack(null, null);
            }
        }
    }
}