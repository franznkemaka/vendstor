using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendstor.Backend.Constants
{
    public static class TokenLengths
    {
        public static readonly int UserIdLength = 20;
        public static readonly int StoreIdLength = 25;
        public static readonly int CustomerIdLength = 21;
        public static readonly int CustomerCodeLength = 10;
        public static  readonly int VerificationTokenLength = 36;
        public static readonly int UserTokenLength = 10;
        public static readonly int BlobIdLength = 36;
        public static readonly int TokensLength = 15;

        public static readonly int ProductIdLength = 15;
        //Barcode Type : Code 128
        public static readonly int BarcodeLength = 15;
    }

    public static class ReportConstants
    {
        public static readonly int OnStockValue = 5;
        public static readonly int LowStockValue = 4;
        public static readonly int NoStockValue = 0;
    }

    public static class UIConstants
    {
        public static readonly double FormBlurOpacity = 0.60;
        public static readonly double MinBlurOpacity = 0.30;
        public static readonly double ThirdFormBlurOpacity = 0.15;
    }
}
