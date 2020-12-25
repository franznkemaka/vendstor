using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class DiscountProduct
    {
        public virtual string Id { get; set; }
        public virtual string ProductId { get; set; }
        public virtual string DiscountId { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
