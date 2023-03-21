using System;

namespace Template.ExtendedEventArgs
{
    public class ScanFinishedEventArgs :EventArgs
    {
        public ScanFinishedEventArgs(ZXing.Result result)
        {
            Result = result;
        }

        public ZXing.Result Result { get; private set; }
    }
}
