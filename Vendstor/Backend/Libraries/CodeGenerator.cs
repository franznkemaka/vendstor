using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using BarcodeLib;
using System.Drawing.Imaging;
using System.Net;
using System.IO;

namespace Vendstor.Backend.Libraries
{
    public static class CodeGenerator
    {
        public static QRCodeGenerator.ECCLevel QrCodeECCLevel = QRCodeGenerator.ECCLevel.Q;
        public static BarcodeLib.TYPE BarcodeType = BarcodeLib.TYPE.CODE128;
        public static Color BarcodeForeColor = Color.Black;
        public static Color BarcodeBackColor = Color.White;

        public static Image GenerateQrCode(string code, int size = 20)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(code, QrCodeECCLevel);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(size);
            return qrCodeImage;
        }

        public static Image GenerateBarcode(string code, TYPE barcodeType = TYPE.CODE128, int width = 290, int height = 120, Color? backColor = null, Color? foreColor = null)
        {
            Image barcodeImage = null;
            
            try { barcodeImage = GetBarcodeFromAPI(code); }

            // Use Local Generator
            catch {

                backColor = backColor ?? BarcodeBackColor;
                foreColor = foreColor ?? BarcodeForeColor;
                Barcode barcode = new Barcode();
                barcodeImage = barcode.Encode(barcodeType, code, BarcodeForeColor, BarcodeBackColor, width, height);
                //var barcodeWithLabel = DrawLabel(barcodeImage, code, foreColor);
            }          
            return barcodeImage;
        }

        public static Image DrawLabel(Image image, string code, Color? foreColor = null)
        {
            Color color = foreColor ?? Color.White;
            PointF bottomLocation = new PointF(10f, 50f);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                Font arialFont = new Font("Arial", 10);
                SolidBrush colorBrush = new SolidBrush(color);
                graphics.DrawString(code, arialFont, colorBrush, bottomLocation);

                return image;
            }
        }

        public static Image GetBarcodeFromAPI(string code, string type = "Code128")
        {
            var uri = string.Format("https://barcode.tec-it.com/barcode.ashx?data={0}&code={1}&dpi=96", code, type);

            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(uri);
            Bitmap bitmap = new Bitmap(stream);

            stream.Flush();
            stream.Close();
            webClient.Dispose();

            return bitmap;
        }
    }
}
