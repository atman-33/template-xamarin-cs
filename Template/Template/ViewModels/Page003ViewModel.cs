using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Template.Views;

namespace Template.ViewModels
{
    //// 手順メモ
    //// 1:ソリューション > NuGetから、以下のパッケージをインストール
    ////    - ZXing.Net.Mobile
    ////    - ZXing.Net.Mobile.Forms
    //// 2:https://takataka430.hatenablog.com/entry/2019/03/21/184259　を参考にコード実装
    //// 3:https://johnny06r.hatenablog.com/entry/2018/08/29/012710 を参考にMVVMパターンで実装

    /// <summary>
    /// QRコードを読み込み
    /// </summary>
    public class Page003ViewModel : ViewModelBase
	{
        public Page003ViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            ScannerViewButton = new DelegateCommand(ScannerViewButtonExecute);
        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Screen transition
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var scannedResult = parameters[nameof(ScannerViewModel.ScannedResult)] as string;
            if (scannedResult == null)
            {
                ScannedResultLabel = string.Empty;
            }

            ScannedResultLabel = scannedResult;
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _scannedResultLabel = string.Empty;
        public string ScannedResultLabel
        {
            get { return _scannedResultLabel; }
            set { SetProperty(ref _scannedResultLabel, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand ScannerViewButton { get; }

        private void ScannerViewButtonExecute()
        {
            base.NavigationService.NavigateAsync(nameof(ScannerView));
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Timer
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Others
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion
    }
}
