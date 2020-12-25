using System.Linq;
using System.Drawing;

namespace Vendstor.Backend.Utils
{
    public static class ColorUtil
    {
        /// <summary>
        /// Convert String RGB Color => Color 
        /// </summary>
        /// <param name="colorString"> RGB String To Convert</param>
        /// <returns></returns>
        public static Color RGBToColor(string colorString)
        {
            var arrColorFragments = colorString?.Split(',').Select(sFragment => { int.TryParse(sFragment, out int fragment); return fragment; }).ToArray();

            switch (arrColorFragments?.Length)
            {
                case 3:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2]);
                case 4:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2], arrColorFragments[3]);
                default:
                    return Color.White;
            }
        }

        public static string ToRGBColor(Color color)
        {
            return  color.R.ToString() + "," + color.G.ToString() + "," + color.B.ToString() ;
        }

        /// <summary>
        /// Converts A HTML HEX Color => System.Drawing.Color
        /// </summary>
        /// <param name="HEXColorToConvert"> HEX Color To Convert To System.Drawing.Color</param>
        /// <returns></returns>
        public static Color HEXToColor(string HEXColorToConvert)
        {
            /** Code SRC : Oded, 21 Jan 2010 : StackOverflow */
            return ColorTranslator.FromHtml(HEXColorToConvert);
        }

        /// <summary>
        /// Convert A System.Drawing.Color To HEX Color
        /// </summary>
        /// <param name="colorToConvert"> (System.Drawing.Color) Color To Convert To HEX Color</param>
        /// <returns></returns>
        public static string ToHEXColor(Color colorToConvert)
        {
            /** Code SRC : Ari Roth, 7 March 2010 : StackOverflow */
            return "#" + colorToConvert.R.ToString("X2") + colorToConvert.G.ToString("X2") + colorToConvert.B.ToString("X2");
        }
    }
}
