using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Store
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public virtual string Email { get; set; }
        public virtual string Password { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string PhoneNumber { get; set; }

        public virtual string Type { get; set; }
        public virtual string Locale { get; set; }
        public virtual string Currency { get; set; }

        public virtual string Address { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }

        public virtual string Status { get; set; }
        public virtual string VerificationToken { get; set; }
        public virtual bool IsEmailVerified { get; set; }
        public virtual bool IsVerified { get; set; }

        public virtual string TaxID
        {
            get { return Properties.Settings.Default.StoreTaxID; }
            set
            {
                Properties.Settings.Default.StoreTaxID = value;
                Properties.Settings.Default.Save();
            }
        }

        public virtual string LogoBlobId { get; set; }
        public virtual Image Logo { get; set; }

        public virtual DateTime UpdatedAt { get; set; }
        public virtual DateTime RegisteredAt { get; set; }

        public virtual PaymentTypes PaymentTypes { get; set; }

        public virtual string CurrencySign
        {
            get
            {
                try { return Currency.Split(',')[1]; }
                catch { return "€"; }
            }
        }
        public virtual string CurrencyName
        {
            get
            {
                try { return Currency.Split(',')[0]; }
                catch { return "Euro"; }
            }
        }
    }
}
