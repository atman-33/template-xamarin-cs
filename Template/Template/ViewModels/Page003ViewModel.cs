using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace Template.ViewModels
{
    //// 手順メモ
    //// 1:ソリューション > NuGetから、以下のパッケージをインストール
    ////    - ZXing.Net.Mobile
    ////    - ZXing.Net.Mobile.Forms
    //// 2:https://takataka430.hatenablog.com/entry/2019/03/21/184259を参考にコード実装

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

            OnScan = new DelegateCommand(OnScanExecute);

        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 1. Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _scanLabel = string.Empty;
        public string ScanLabel
        {
            get { return _scanLabel; }
            set { SetProperty(ref _scanLabel, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 2. Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand OnScan { get; }

        private async void OnScanExecute()
        {
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
