using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Vendstor.Forms;
using Vendstor.Backend.Utils;
using Vendstor.Modals;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Server;
using BarcodeLib;
using Vendstor.Backend.Hardwares;
using Vendstor.Backend;

namespace Vendstor
{
    public partial class Dev : Form
    {
        public Dev()
        {
            InitializeComponent();
        }

        private void Dev_Load(object sender, EventArgs e)
        {
            Backend.Objects.RedeemReceipt redeemReceipt = new Backend.Objects.RedeemReceipt
            {
                Store = Util.Data.GetStore(),
                User = Util.Data.GetUser(),
                Customer = new Backend.Objects.Customer
                {
                    Id = "FRANZID",
                    FirstName = "Franz",
                    LastName = "Nkemaka",
                },

                RedeemedAmount = (decimal) 15.00,
                AccountBalance = (decimal) 30.00,
            };

            Printing printing = new Printing
            {
                TopMost = true,
                RedeemReceipt = redeemReceipt,
                ReportViewerType = Printing.PintingItems.RedeemReceipt,
            };
            printing.ShowDialog();
        }
    }
}