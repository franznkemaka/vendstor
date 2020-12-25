using System;
using System.Collections.Generic;
using Vendstor.Backend.Data;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Payment
    {
        public virtual string Id { get; set; }
        public virtual string Method { get; set; }

        public virtual decimal PaidAmount { get; set; }

        public virtual decimal CashAmount { get; set; }
        public virtual decimal CreditCardAmount { get; set; }
        public virtual decimal StoreCreditAmount { get; set; }

        public virtual decimal Paid { get; set; }
        public virtual decimal Balance { get; set; }

        public virtual  DateTime PaidAt { get; set; }
    }
}
