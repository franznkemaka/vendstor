using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Bunifu.Framework.UI;

namespace Vendstor.Backend.Utils
{
    public static class ImageUtil
    {
        /// <summary>
        /// Colors an Image
        /// </summary>
        /// <param name="originalImage"> Original Image before coloring, this has be transparent (i.e .png) for Better Results </param>
        /// <param name="newImageColor"> Color to Color Image to </param>
        /// <returns></returns>
        public static Image ColorImage(Image originalImage, Color? newImageColor = null)
        {
            /** Code SRC : Yusuf Shakeel */


            Color softColor = UserInterface.SoftColor;
            Color imageColor = newImageColor ?? softColor;

            //Read Img
            Bitmap bmp = new Bitmap(originalImage);

            //Get Image Dimensions
            int imgWidth = bmp.Width;
            int imgHeight = bmp.Height;

            //Colored Image
            Bitmap cbmp = new Bitmap(bmp);

            //Change Image Color => Colored Image
            for (int bmpY = 0; bmpY < imgHeight; bmpY++)
            {
                for (int bmpX = 0; bmpX < imgWidth; bmpX++)
                {
                    //Get Pixel Value
                    Color pixelColor = bmp.GetPixel(bmpX, bmpY);

                    //Extract A value from pixelColor
                    int A = pixelColor.A;

                    //Set New Color i.e => SoftColor
                    cbmp.SetPixel(bmpX, bmpY, Color.FromArgb(A, imageColor));
                }
            }

            return cbmp;
        }

        public static void ColorPictureBox(PictureBox pic, Color? newImageColor = null)
        {
            pic.Image = ColorImage(pic.Image, newImageColor);
        }
        public static void ColorImageButton(BunifuImageButton imgBtn, Color? newImageColor = null)
        {
            imgBtn.Image = ColorImage(imgBtn.Image, newImageColor);
        }
        public static void ColorTitleButton(BunifuTileButton btn, Color? newImageColor = null)
        {
            btn.Image = ColorImage(btn.Image, newImageColor);
        }

        /// <summary>
        ///  Draw a Rectangle With Percentage
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="pnl"></param>
        /// <param name="picBox"></param>
        /// <returns></returns>
        public static Image GeneratePImage(double percentage, Control pnl, Control pictureBox)
        {
            double pnlWith = double.Parse(pnl.Width.ToString());

            double x = (percentage * pnlWith) / 100;

            pictureBox.Width = (int)-Math.Round(x, 0);

            var imageBmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(imageBmp, new Rectangle(0, 0, imageBmp.Width, imageBmp.Height));

            return imageBmp;
        }

        /// <summary>
        /// Add Elispe To Image With Custom Radius
        /// </summary>
        /// <param name="originalImage">  Original Image Before Rendring</param>
        /// <param name="borderRadius"> int, Border Raduis </param>
        /// <returns></returns>
        public static Image RoundCorners(Image originalImage, int borderRadius)
        {
            borderRadius *= 2;
            Bitmap roundedImage = new Bitmap(originalImage.Width, originalImage.Height);
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            gp.AddArc(0 + roundedImage.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            gp.AddArc(0 + roundedImage.Width - borderRadius, 0 + roundedImage.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            gp.AddArc(0, 0 + roundedImage.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.SetClip(gp);
                g.DrawImage(originalImage, Point.Empty);
            }
            return roundedImage;
        }

        /// <summary>
        /// Add Elipse To Image
        /// </summary>
        /// <param name="originalImage"> Original Image before rendring</param>
        /// <returns></returns>
        public static Image OvalImage(Image originalImage)
        {
            Bitmap roundedImage = new Bitmap(originalImage.Width, originalImage.Height);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, originalImage.Width, originalImage.Height);
                using (Graphics gr = Graphics.FromImage(roundedImage))
                {
                    gr.SetClip(gp);
                    gr.DrawImage(originalImage, Point.Empty);
                }
            }
            return roundedImage;
        }

        /// <summary>
        /// Draw An Image With arg[BackgroundColor] And Draw String arg[Letters] With ForeColor arg[ForeColor] By Default White
        /// </summary>
        /// <param name="letters"> String To Draw On Image</param>
        /// <param name="backgroundColor"> Image Background Color</param>
        /// <param name="foreColor"> Color Of Strings On the Image</param>
        /// <param name="customFont"> Custom Font  By Default NULL</param>
        /// <param name="isLogo"> Bool, Indicates if Font is bigger or use CustomFont By Default ["Product Sans", 40]</param>
        /// <param name="elipseCorners"> Bool, Add Elipse To Image Or NOT By Default True</param>
        /// <returns></returns>
        public static Image DrawLetter(string letters, Color? backgroundColor = null, Color? foreColor = null, Font customFont = null, bool firstLetterOnly = true, bool elipseCorners = true)
        {
            //Props
            Color _backgroundColor = backgroundColor ?? Color.White;
            Color _foreColor = foreColor ?? Color.White;

            //Create Image
            Bitmap bitmap = new Bitmap(150, 150);

            Graphics g = Graphics.FromImage(bitmap);

            //Add BackgroundColor = arg[BackgroundColor]
            g.Clear(_backgroundColor);

            Rectangle rectangle = new Rectangle(10, 10, 130, 140);

            // Create a StringFormat obj with the Each Line of text, and the block
            // of text centered on the page.

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Font font;

            //Substring 1 Letter If Logo
            if (letters.Length >= 1)
                letters = (firstLetterOnly) ? letters.Substring(0, 1) : letters;
            
            //Create Font
            if (customFont != null)
                font = customFont;
            else if (!firstLetterOnly)
                font = new Font("Product Sans", 40);
            else
                font = new Font("Product Sans", 80);

            //Brush, Pen
            Brush brush = new SolidBrush(_foreColor);
            Pen pen = new Pen(_backgroundColor);

            //Quality 
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //Draw The Text And The Surrounding Rectangle
            g.DrawString(letters, font, brush, rectangle, stringFormat);
            g.DrawRectangle(pen, rectangle);

            g.Dispose();

            if (elipseCorners)
                //Add Elispe Image [Ex.If Profile]
                return (Bitmap)OvalImage(originalImage: (Image)bitmap);

            return bitmap;
        }
    }
}
