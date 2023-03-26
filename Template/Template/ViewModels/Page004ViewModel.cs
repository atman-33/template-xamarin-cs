using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Linq;
using Template.Domain;
using Template.Domain.Entities;
using Template.Domain.Repositories;
using Template2.Infrastructure;

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
    /// <remarks>
    /// 【注意点】
    /// Oracle接続先PCのファイアウォール設定で、受信の規則でポート1521を解放する必要あり
    /// </remarks>
    public class Page004ViewModel : ViewModelBase
    {
        IWorkerGroupMstRepository _workerGroupMstRepository;

        public Page004ViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : this(navigationService, pageDialogService, Factories.CreateWorkerGroupMst())
        {
        }

        public Page004ViewModel(
            INavigationService navigationService, 
            IPageDialogService pageDialogService, 
            IWorkerGroupMstRepository workerGroupMstRepository)
            : base(navigationService, pageDialogService)
        {
            _workerGroupMstRepository = workerGroupMstRepository;

            UpdateSettingsButton = new DelegateCommand(UpdateSettingsButtonExecute);
            OracleOpenButton = new DelegateCommand(OracleOpenButtonExecute);
            GetWorkerGroupMstEntitiesButton = new DelegateCommand(GetWorkerGroupMstEntitiesButtonExecute);
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

        private string _oraclePasswordText = Shared.OraclePassword;
        public string OraclePasswordText
        {
            get { return _oraclePasswordText; }
            set { SetProperty(ref _oraclePasswordText, value); }
        }

        private string _oracleHostText = Shared.OracleHost;
        public string OracleHostText
        {
            get { return _oracleHostText; }
            set { SetProperty(ref _oracleHostText, value); }
        }

        private string _oracleServiceNameText = Shared.OracleServiceName;
        public string OracleServiceNameText
        {
            get { return _oracleServiceNameText; }
            set { SetProperty(ref _oracleServiceNameText, value); }
        }

        private string _oracleDataSourceText = Shared.OracleDataSource;
        public string OracleDataSourceText
        {
            get { return _oracleDataSourceText; }
            set { SetProperty(ref _oracleDataSourceText, value); }
        }

        private ObservableCollection<WorkerGroupMstEntity> _workerGroupMstEntities
            = new ObservableCollection<WorkerGroupMstEntity>();
        public ObservableCollection<WorkerGroupMstEntity> WorkerGroupMstEntities
        {
            get { return _workerGroupMstEntities; }
            set { SetProperty(ref _workerGroupMstEntities, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand UpdateSettingsButton { get; }

        private void UpdateSettingsButtonExecute()
        {
            Shared.OracleUser = OracleUserText;
            Shared.OraclePassword = OraclePasswordText;
            Shared.OracleHost = OracleHostText;
            Shared.OracleServiceName = OracleServiceNameText;

            OracleDataSourceText = Shared.OracleDataSource;

            PageDialogService.DisplayAlertAsync("", "設定ファイルを更新しました。", "OK");
        }

        public DelegateCommand OracleOpenButton { get; }

        private void OracleOpenButtonExecute()
        {
            try
            {
                Factories.Open();
                PageDialogService.DisplayAlertAsync("", "Oracle接続テスト　成功", "OK");
            }
            catch (System.Exception)
            {
                PageDialogService.DisplayAlertAsync("", "Oracle接続テスト　エラー発生！", "OK");
            }
        }

        public DelegateCommand GetWorkerGroupMstEntitiesButton { get; }

        private void GetWorkerGroupMstEntitiesButtonExecute()
        {
            WorkerGroupMstEntities.Clear();
            foreach (var entity in _workerGroupMstRepository.GetData().OrderBy(x => x.WorkerGroupCode.Value))
            {
                WorkerGroupMstEntities.Add(entity);
            }
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
