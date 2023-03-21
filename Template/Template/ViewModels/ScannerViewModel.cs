using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace Template.ViewModels
{
    public class ScannerViewModel : ViewModelBase
    {
        public ScannerViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService,
            IDeviceService deviceService)
            : base(navigationService, pageDialogService, deviceService)
        {
            ScanResultCommand = new DelegateCommand<ZXing.Result>(ScanResultCommandExecute);
        }

        /// <summary>
        /// バーコードスキャン結果
        /// </summary>
        public string ScannedResult { get; private set; }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand<ZXing.Result> ScanResultCommand { get; }

        private void ScanResultCommandExecute(ZXing.Result result)
        {
            DeviceService.BeginInvokeOnMainThread(() =>
            {
                ScannedResult = result.Text;

                var param = new NavigationParameters
                {
                    {nameof(ScannedResult), ScannedResult }
                };

                NavigationService.GoBackAsync(param);
                PageDialogService.DisplayAlertAsync("スキャン完了", ScannedResult, "OK");
            });
        }
        #endregion
    }
}
