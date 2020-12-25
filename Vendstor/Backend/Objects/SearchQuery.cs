using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
namespace Vendstor.Backend.Objects
{
    public class ProductSearchQuery
    {
        public virtual Enums.SearchQueryType Type { get; set; }
        public virtual string Query { get; set; }
        public virtual string Barcode { get; set; }

        public virtual string SupplierId { get; set; }
        public virtual string BrandId { get; set; }
        public virtual string TypeId { get; set; }
        public virtual string Status { get; set; }
    }

    public class InventorySearchQuery
    {
        public virtual Enums.SearchQueryType Type { get; set; }
        public virtual string Query { get; set; }

        public virtual DateTime DateFrom { get; set; }
        public virtual DateTime DateTo { get; set; }
        public virtual decimal Stock { get; set; }
        public virtual string StockQuery { get; set; }
        public virtual string Status { get; set; }
    }

    public class CustomerSearchQuery
    {
        public virtual Enums.SearchQueryType Type { get; set; }
        public virtual string Query { get; set; }
        public virtual string GroupId { get; set; }
    }

    public class SaleSearchQuery
    {
        public virtual Enums.SearchQueryType Type { get; set; }
        public virtual string Query { get; set; }
        public virtual string UserId { get; set; }
        public virtual string CustomerId { get; set; }

        public virtual DateTime DateFrom { get; set; }
        public virtual DateTime DateTo { get; set; }

        public virtual string Status { get; set; }
    }
}
