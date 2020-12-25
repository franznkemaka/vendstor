using System;
using System.Linq;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Tax
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }

        public virtual decimal Rate { get; set; }

        public virtual string StoreShortName { get; set; }
        public virtual string Description { get; set; }

        public virtual string Code
        {
            get
            {
                return  StoreShortName.First().ToString();
            }
        }
        public virtual Store Store { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }
    }
}
