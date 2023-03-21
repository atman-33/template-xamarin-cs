using System;
using Template.ExtendedEventArgs;
using ZXing.Net.Mobile.Forms;

namespace Template.Views
{
    public partial class ScannerView : ZXingScannerPage
    {
        public ScannerView()
        {
            InitializeComponent();

            DefaultOverlayTopText = "バーコードを読み取ります";
            DefaultOverlayBottomText = "";

            this.OnScanResult += (result) =>
            {
                this.ScanFinished?.Invoke(this, new ScanFinishedEventArgs(result));
                this.IsScanning = false;
            };
        }
        public event EventHandler<ScanFinishedEventArgs> ScanFinished;
    }
}
