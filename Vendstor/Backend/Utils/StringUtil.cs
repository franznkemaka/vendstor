using System;
using System.Globalization;

namespace Vendstor.Backend.Utils
{
    public static class StringUtil
    {
        private static readonly int MaxDecimalPlaces = 2;
        
        /// <summary>
        /// Return TimeAgo from DateTime { Example : [28 Jan 2018, 10:15:10] => 2 minutes ago from now }
        /// </summary>
        /// <param name="dateTime"> DateTime, DateTime tocConvert to Time Ago</param>
        /// <returns></returns>
        public static string ToTimeAgo(DateTime dateTime)
        {
            string result = string.Empty;
            var timeSpan = DateTime.Now.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                result = string.Format("{0} seconds ago", timeSpan.Seconds);
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    String.Format("about {0} minutes ago", timeSpan.Minutes) :
                    "about a minute ago";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    String.Format("about {0} hours ago", timeSpan.Hours) :
                    "about an hour ago";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    String.Format("about {0} days ago", timeSpan.Days) :
                    "yesterday";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    String.Format("about {0} months ago", timeSpan.Days / 30) :
                    "about a month ago";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    String.Format("about {0} years ago", timeSpan.Days / 365) :
                    "about a year ago";
            }

            return result;
        }

        /// <summary>
        ///  Get Day, Month, Year .ToString();
        /// </summary>
        /// <param name="dateTime"> DateTime, Date Time To Convert </param>
        /// <returns></returns>
        public static string ToDateString(DateTime dateTime, bool translate = true)
        {
            var day = dateTime.Day.ToString();
            var dayOfWeek = dateTime.DayOfWeek.ToString();
            string month = dateTime.ToString("MMMMMMMMMM");
            string year = dateTime.Year.ToString();
            var _dayOfWeek = Translation.IsPossible() && translate ? Translation.Translate(dayOfWeek) : dayOfWeek;
            var _month = Translation.IsPossible() && translate ? Translation.Translate(month) : month;
            return $"{ _dayOfWeek } { day }, { _month }  { year }";
        }

        /// <summary>
        /// Convert A Double ToEngineeringNotation Ex: 10 000 => 10k
        /// </summary>
        /// <param name="doubleToConvert"> DoubleToConvert To Convert Ex. 10 000</param>
        /// <returns></returns>
        public static string ToEngineeringNotation(double doubleToConvert)
        {
            /** Code SRC : Marshal, 11 April 2011 : StackOverflow */

            double exponent = Math.Log10(Math.Abs(doubleToConvert));
            if (Math.Abs(doubleToConvert) >= 1)
            {
                switch ((int)Math.Floor(exponent))
                {
                    case 0:
                    case 1:
                    case 2:
                        return doubleToConvert.ToString();
                    case 3:
                    case 4:
                    case 5:
                        return (doubleToConvert / 1e3).ToString() + "k";
                    case 6:
                    case 7:
                    case 8:
                        return (doubleToConvert / 1e6).ToString() + "M";
                    case 9:
                    case 10:
                    case 11:
                        return (doubleToConvert / 1e9).ToString() + "G";
                    case 12:
                    case 13:
                    case 14:
                        return (doubleToConvert / 1e12).ToString() + "T";
                    case 15:
                    case 16:
                    case 17:
                        return (doubleToConvert / 1e15).ToString() + "P";
                    case 18:
                    case 19:
                    case 20:
                        return (doubleToConvert / 1e18).ToString() + "E";
                    case 21:
                    case 22:
                    case 23:
                        return (doubleToConvert / 1e21).ToString() + "Z";
                    default:
                        return (doubleToConvert / 1e24).ToString() + "Y";
                }
            }
            else if (Math.Abs(doubleToConvert) > 0)
            {
                switch ((int)Math.Floor(exponent))
                {
                    case -1:
                    case -2:
                    case -3:
                        return (doubleToConvert * 1e3).ToString() + "m";
                    case -4:
                    case -5:
                    case -6:
                        return (doubleToConvert * 1e6).ToString() + "μ";
                    case -7:
                    case -8:
                    case -9:
                        return (doubleToConvert * 1e9).ToString() + "n";
                    case -10:
                    case -11:
                    case -12:
                        return (doubleToConvert * 1e12).ToString() + "p";
                    case -13:
                    case -14:
                    case -15:
                        return (doubleToConvert * 1e15).ToString() + "f";
                    case -16:
                    case -17:
                    case -18:
                        return (doubleToConvert * 1e18).ToString() + "a";
                    case -19:
                    case -20:
                    case -21:
                        return (doubleToConvert * 1e21).ToString() + "z";
                    default:
                        return (doubleToConvert * 1e24).ToString() + "y";
                }
            }
            else
                return "0";
        }

        /// <summary>
        /// Trims unnecessary 0 from decimal E.g: 2.00 => 2
        /// </summary>
        /// <param name="dec"> Decimal to Convert</param>
        /// <returns></returns>
        public static string ToString(decimal dec)
        {
            string stringDecimal = dec.ToString(CultureInfo.InvariantCulture);
            return stringDecimal.Contains(".") ? stringDecimal.TrimEnd('0').TrimEnd('.') : stringDecimal;
        }

        public static string ToRoundedString(decimal dec)
        {
            return ToString(Math.Round(dec, MaxDecimalPlaces));
        }


        public static int CountOccurence(char needle, string _string)
        {
            return _string.Split(needle).Length - 1;
        }
    }
}
