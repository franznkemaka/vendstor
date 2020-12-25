using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Utils;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Discount
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
        public virtual string Type { get; set; }
        public virtual decimal Value { get; set; }

        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }

        public virtual List<object> ProductDiscounts { get; set; }
    }
}
