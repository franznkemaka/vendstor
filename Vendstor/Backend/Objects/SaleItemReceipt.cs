using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class SaleItemReceipt
    {
        public virtual string Name { get; set; }
        public virtual string Note { get; set; }

        public virtual decimal Quantity { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string TaxCode { get; set; }
    }
}
