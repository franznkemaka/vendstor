using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendstor.Backend.Database
{
    public class Response
    {
        public virtual int StatusCode { get; set; }
        public virtual object Data { get; set; }
        public virtual string StringData { get; set; }
        public virtual int IntegerData { get; set; }
        public virtual object Errors { get; set; }
        public virtual object SubData { get; set; }
        public virtual List<object> DataArray { get; set; }
        public virtual Objects.Pagination Pagination { get; set; }
    }
}
