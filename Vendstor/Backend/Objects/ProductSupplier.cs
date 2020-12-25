using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class ProductSupplier
    {
        public virtual string Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual decimal Markup { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Company { get; set; }

        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Website { get; set; }

        public virtual string Address { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }

        public virtual double ProductsCount { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
