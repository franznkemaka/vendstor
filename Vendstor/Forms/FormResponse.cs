using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vendstor.Backend.Data;
namespace Vendstor.Forms
{
    public class FormResponse
    {
        public virtual Enums.ActionDialog ActionDialog { get; set; }
        public virtual object Data { get; set; }
    }
}
