using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class PaymentTypes
    {
        public virtual bool Cash { get; set; }
        public virtual bool CreditCard { get; set; }
        public virtual bool StoreCredit { get; set; }
    }
}
