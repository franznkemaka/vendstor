using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendstor.Backend.Objects
{
    public class DailyRevenueChart
    {
        public virtual decimal Amount { get; set; }
        public virtual DateTime Date { get; set; }
    }

    public class DailySalesChart
    {
        public virtual decimal Count { get; set; }
        public virtual DateTime Date { get; set; }
    }

    public class WeeklyCustomersChart
    {
        public virtual decimal Count { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
