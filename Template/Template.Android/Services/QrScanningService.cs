using Android.App;
using Android.Content;
using Android.Nfc.Tech;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Template.Services;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency(typeof(Template.Droid.Services.QrScanningService))]
namespace Template.Droid.Services
{
    internal class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var options = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "QR Code Scan ",
                BottomText = "Please Wait…..",
            };
            var result = await scanner.Scan(options);
            return result.Text;
        }
    }
}