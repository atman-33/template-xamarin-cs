using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Template.Conditions;
using Template.Objects;
using Template.Views;
using Xamarin.Forms;

namespace Template.ViewModels
{
	public class Page001ViewModel : ViewModelBase
	{
        public Page001ViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            ButtonC = new DelegateCommand(SetText);
            NextCommand = new DelegateCommand(PageBShow);
            MessageCommand = new DelegateCommand(MessageCommandShow);

            Title = "Page1";

            LabelC = "DDD";
        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Screen transition
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion


        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _labelC = string.Empty;
        public string LabelC
        {
            get { return _labelC; }
            set { SetProperty(ref _labelC, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand ButtonC { get; set; }
        private void SetText()
        {
            LabelC = "EEE";
        }

        public DelegateCommand NextCommand { get; set; }
        private void PageBShow()
        {
            /// 画面遷移用パラメータはConditionsで管理
            var param = new NavigationParameters
            {
                {nameof(PageBCondition),new PageBCondition("XXXX") }
            };

            base.NavigationService.NavigateAsync(nameof(PageBView), param);
        }

        public DelegateCommand MessageCommand { get; set; }
        private void MessageCommandShow()
        {
            PageDialogService.DisplayAlertAsync("タイトル", "メッセージ", "OK");

            Title = DependencyService.Get<IDevice>().GetDeviceName();
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
