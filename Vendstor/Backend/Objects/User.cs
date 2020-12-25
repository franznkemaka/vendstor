using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Utils;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class User
    {
        public virtual string Id { get; set; }
        public virtual string Token { get; set; }

        public virtual string Username { get; set; }
        public virtual string Password { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }
        public virtual string PinCode { get; set; }

        public virtual string Role { get; set; }
        public virtual string Locale { get; set; }
        
        public virtual bool IsOnline { get; set; }
        public virtual bool IsVerified { get; set; }
        
        public virtual Color Color { get; set; }
        public virtual string ImageBlobId { get; set; }
        public virtual Image ProfileImage { get; set; }

        public virtual Image ProfileOvalImage {
            get {
                try { return ImageUtil.OvalImage(ProfileImage); }
                catch { return null;  }                  
            }
        }

        public virtual DateTime LastActive { get; set; }
        public virtual DateTime RegisteredAt { get; set; }

        public virtual Store Store { get; set; }

        // Insights
        public virtual decimal DailyRevenue { get; set; }
        public virtual decimal WeeklyRevenue { get; set; }
        public virtual decimal MonthlyRevenue { get; set; }
        public virtual decimal YearlyRevenue { get; set; }
        public virtual decimal TotalRevenue { get; set; }

        public virtual double DailySalesCount { get; set; }
        public virtual double WeeklySalesCount { get; set; }
        public virtual double MonthlySalesCount { get; set; }
        public virtual double YearlySalesCount { get; set; }
        public virtual double TotalSalesCount { get; set; }
    }
}
