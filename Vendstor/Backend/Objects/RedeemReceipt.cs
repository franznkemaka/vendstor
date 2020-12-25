using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class RedeemReceipt
    {
        public virtual decimal RedeemedAmount { get; set; }
        public virtual decimal AccountBalance { get; set; }       

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
