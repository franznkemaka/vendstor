using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class ProductType
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public virtual double ProductsCount { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
