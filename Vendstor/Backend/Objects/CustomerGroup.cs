using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class CustomerGroup
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public virtual double CustomersCount { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
