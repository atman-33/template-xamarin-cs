using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Template.Views;

namespace Template.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Page001ViewButton = new DelegateCommand(Page001ViewButtonExecute);
            Page002ViewButton = new DelegateCommand(Page002ViewButtonExecute);
            Page003ViewButton = new DelegateCommand(Page003ViewButtonExecute);
            Page004ViewButton = new DelegateCommand(Page004ViewButtonExecute);

            Title = "Main Page";
        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Screen transition
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand Page001ViewButton { get; set; }
        private void Page001ViewButtonExecute()
        {
            base.NavigationService.NavigateAsync(nameof(Page001View));
        }

        public DelegateCommand Page002ViewButton { get; set; }
        private void Page002ViewButtonExecute()
        {
            base.NavigationService.NavigateAsync(nameof(Page002View));
        }

        public DelegateCommand Page003ViewButton { get; set; }
        private void Page003ViewButtonExecute()
        {
            base.NavigationService.NavigateAsync(nameof(Page003View));
        }

        public DelegateCommand Page004ViewButton { get; set; }
        private void Page004ViewButtonExecute()
        {
            base.NavigationService.NavigateAsync(nameof(Page004View));
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
