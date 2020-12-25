using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Drawing.Printing;


namespace Vendstor.Backend.Hardwares
{
    public class Printer
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string PrinterName);

        PrinterSettings printerSettings = new PrinterSettings();
        PrintDocument printDocument = new PrintDocument();
        PrintDialog printDialog = new PrintDialog();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public Printer()
        {
            //set printDocument Settings
            printDocument.PrinterSettings.PrinterName = printerSettings.PrinterName;
            printDialog.Document = printDocument;
            printDialog.Document = printDocument;
        }
    }

}
