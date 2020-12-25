using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendstor.Backend.Data
{
    public static class Enums
    {
        public enum ActionDialog { Created,  Updated, Saved, Closed, Canceled, Deleted, Nothing, Error, Custom, Redeem, Scanned }
        public enum Task { Get, ReadOnly,  Update, Create, Delete }

        public enum SearchQueryType {  None, Id, Query, Barcode, DateRange, Value, Customer, User, UserAndDateRange,  }
        public enum Pagination { Next, Previous }

        public enum TokenType {  Barcode, QrCode, UPCE, EAN8, EAN13, CODE93, CODE39, CODE39Mod43, CODE128, AZTEC , None, Custom}
    }
}
