using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Data;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Customer
    {
        public virtual string Id { get; set; }
        public virtual string Code { get; set; }
        
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }
        public virtual string Sex { get; set; }

        public virtual string PhoneNumber { get; set; }
        public virtual string Website { get; set; }
        public virtual string Address { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }

        public virtual decimal StoreCredit { get; set; }

        public virtual bool IsFavorite { get; set; }
        public virtual bool IsVerified { get; set; }

        public virtual DateTime DateOfBirth { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime RegisteredAt { get; set; }

        public virtual CustomerGroup Group { get; set; }
    }

}
