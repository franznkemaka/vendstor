using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Insights
    {
        public virtual decimal TotalRevenue { get; set; }

        public virtual double TotalProductsCount { get; set; }
        public virtual double WeeklySalesCount { get; set; }
        public virtual double TotalCustomersCount { get; set; }

        public virtual decimal DailyRevenue { get; set; }
        public virtual decimal WeeklyRevenue { get; set; }
        public virtual decimal MonthlyRevenue { get; set; }
        public virtual decimal YearlyRevenue { get; set; }

        public virtual double DailySalesCount { get; set; }
        public virtual double MonthlySalesCount { get; set; }
        public virtual double YearlySalesCount { get; set; }

        public virtual List<object> ChartData { get; set; }
        public virtual List<object> TopSoldProducts { get; set; }

        public virtual DateTime UpdatedAt { get; set; }

    }
}
