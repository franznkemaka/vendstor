using System;
using System.Globalization;

namespace Vendstor.Backend.Utils
{
    public static class DateUtil
    {
        public static double _GetWeekNumber(DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear((DateTime)dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public static double GetWeekNumber(DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            return ((DateTime)dateTime).DayOfYear / 7;
        }
        
        public static double GetMonthNumber(DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            return double.Parse(((DateTime)dateTime).ToString("MM"));
        }

        public static double GetYearAndMonth(DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            return double.Parse(((DateTime)dateTime).ToString("yyyyM"));
        }

        public static double GetYear(DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            return double.Parse(((DateTime)dateTime).ToString("yyyy"));
        }
    }
}
