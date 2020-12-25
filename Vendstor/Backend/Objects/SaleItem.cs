using System;
using System.Collections.Generic;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class SaleItem
    {
        public virtual string Id { get; set; }
        public virtual string SaleId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Discount Discount { get; set; }

        public virtual string Note { get; set; }
        public virtual string Status { get; set; }

        public virtual decimal Quantity { get; set; }
        public virtual decimal DiscountValue { get; set; }
        public virtual decimal DiscountPrice { get; set; }

        public virtual decimal SupplyPrice
        {
            get { return Product.SupplyPrice * Quantity; }
        }

        public virtual decimal Price { get; set; }
        public virtual decimal TaxAmount { get; set; }
        public virtual decimal TotalPrice { get; set; }

        public virtual bool IsDiscounted { get; set; }
        public virtual bool IsBalanceRequired
        {
            get { return Product.IsBalanceRequired; }
        }


        public virtual bool IsFetchItem { get; set; }

        public virtual DateTime SoldAt { get; set; }
    }
}
