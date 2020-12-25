using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
namespace Vendstor.Backend.Objects
{
    public class Product
    {
        public virtual string Id { get; set; }
        public virtual string Barcode { get; set; }
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
        public virtual decimal Stock { get; set; }

        public virtual decimal SupplyPrice { get; set; }
        public virtual decimal RetailPrice { get; set; }
        public virtual decimal Markup { get; set; }

        public virtual decimal Price
        {
            get { return RetailPrice; }
        }

        public virtual decimal StockValue
        {
            get { return Price * Stock; }
        }
        
        public virtual bool IsBalanceRequired { get; set; }
        public virtual bool IsDiscounted { get; set; }

        public virtual Color Color { get; set; }
        public virtual string ImageBlobId { get; set; }
        public virtual Image Image { get; set; }

        public virtual DiscountProduct Discount { get; set; }
        public virtual Tax Tax { get; set; }
        public virtual ProductType Type { get; set; }
        public virtual ProductBrand Brand { get; set; }
        public virtual ProductSupplier Supplier { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }

        public virtual bool IsSearchItem { get; set; }
    }
}
