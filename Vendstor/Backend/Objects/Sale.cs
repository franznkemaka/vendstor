using System;
using System.Collections.Generic;
using Vendstor.Backend.Data;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Sale
    {
        public virtual string Id { get; set; }
        public virtual string Token { get; set; }

        public virtual string Note { get; set; }

        public virtual string DiscountName { get; set; }
        public virtual decimal DiscountPercentage { get; set; }
        public virtual decimal DiscountAmount { get; set; }

        public virtual int ItemsCount { get; set; }
        public virtual bool IsScannerActivated { get; set; }
        public virtual bool IsDiscounted { get; set; }
        public virtual bool IsReturnItems { get; set; }
        public virtual bool IsGuest { get; set; }
        public virtual bool IsFetchItem { get; set; }

        public virtual decimal SupplyPrice { get; set; }
        public virtual decimal SubTotalPrice { get; set; }
        public virtual decimal DiscountPrice { get; set; }
        public virtual decimal TaxAmount { get; set; }
        public virtual decimal TotalPrice { get; set; }

        public virtual string PaymentMethod { get; set; }
        public virtual decimal Paid { get; set; }
        public virtual decimal Balance { get; set; }

        public virtual List<object> Items { get; set; }

        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime SoldAt { get; set; }

        public virtual List<SaleItemReceipt> ItemsReceipt
        {
            get
            {
                try
                {
                    var items = new List<SaleItemReceipt>();
                    foreach (SaleItem item in Items)
                    {
                        var taxCode = (item.Product.Tax is object) ? item.Product.Tax.Code : "";
                        items.Add(new SaleItemReceipt
                        {
                            Name = item.Product.Name.ToUpper(),
                            Note = item.Note,
                            Quantity = item.Quantity,
                            // CHANGED :  It's already tax inclusive so TotalPrice / Quantity
                            Price = item.TotalPrice / item.Quantity, // Removed :  - item.TaxAmount
                            TaxCode = taxCode,
                        });
                    }
                    return items;
                }
                catch { return null; }
            }
        }

        public virtual decimal TaxAAmount { get; set; }
        public virtual decimal TaxBAmount { get; set; }
        public virtual decimal TaxARevenue { get; set; }
        public virtual decimal TaxBRevenue { get; set; }
     
        public virtual decimal TaxANetPrice
        {
            get { return TaxARevenue - TaxAAmount; }
        }
        public virtual decimal TaxBNetPrice
        {
            get { return TaxBRevenue - TaxBAmount; }
        }
        public virtual decimal TaxRevenue
        {
            get { return TaxARevenue + TaxBRevenue; }
        }
        public virtual decimal TaxNetPrice
        {
            get { return TaxANetPrice + TaxBNetPrice; }
        }

    }

}
