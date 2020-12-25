using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vendstor.Backend.Utils;
namespace Vendstor.Modals
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            Util.Methods.SetIcon(this);
        }
    }
}
