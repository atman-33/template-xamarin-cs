using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Template.Domain;
using Xamarin.Essentials;

namespace Template.ViewModels
{
    //// 手順メモ
    //// <Xamarin.Essentials>
    //// 1. ソリューションのNugetパッケージから Xamarin.Essentials をインストール
    //// 2. Template.Android の MainActivity.cs に Xamarin.Essentials を利用するためのコードを追加
    //// 3. Template.Domain の Shared.cs に設定値を実装

    /// <summary>
    /// DB接続、操作用のViewModel
    /// </summary>
    public class Page004ViewModel : ViewModelBase
    {
        public Page004ViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            UpdateSettingsButton = new DelegateCommand(UpdateSettingsButtonExecute);
        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Screen transition
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _oracleUserText = Shared.OracleUser;
        public string OracleUserText
        {
            get { return _oracleUserText; }
            set { SetProperty(ref _oracleUserText, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand UpdateSettingsButton { get; }

        private void UpdateSettingsButtonExecute()
        {
            Shared.OracleUser = OracleUserText;

            PageDialogService.DisplayAlertAsync("", "Settingsを更新しました。", "OK");
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
