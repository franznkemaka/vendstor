using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendstor.Backend.Data;

namespace Vendstor.Backend.Objects
{
    public class ScanToken
    {
        public virtual object Token { get; set; }
        public virtual Enums.TokenType Type { get; set; }
    }
}
