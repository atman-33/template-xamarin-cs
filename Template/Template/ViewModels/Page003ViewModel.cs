using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Template.Services;
using Xamarin.Forms;

namespace Template.ViewModels
{
    /// 手順メモ
    /// 1:ソリューション > NuGetから、以下のパッケージをインストール
    ///    - ZXing.Net.Mobile
    ///    - ZXing.Net.Mobile.Forms

    /// <summary>
    /// QRコードを読み込み
    /// </summary>
    public class Page003ViewModel : ViewModelBase
	{
        /// <summary>
        /// ダイアログサービス
        /// </summary>
        private IPageDialogService _pageDialogService;

        public Page003ViewModel(INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _pageDialogService = pageDialogService;

            ScanButton = new DelegateCommand(ScanButtonExecute);

        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 1. Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _scanLabel;
        public string ScanLabel
        {
            get { return _scanLabel; }
            set { SetProperty(ref _scanLabel, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 2. Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand ScanButton { get; }

        private async void ScanButtonExecute()
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    ScanLabel = result;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 3. Others
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Screen transition
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Timer
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion
    }
}
