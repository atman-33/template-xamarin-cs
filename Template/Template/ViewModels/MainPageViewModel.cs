using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Views;

namespace Template.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            ButtonC = new DelegateCommand(SetText);
            NextCommand = new DelegateCommand(PageBShow);

            Title = "Main Page";

            LabelC = "DDD";
        }

        private string _labelC = string.Empty;
        public string LabelC
        {
            get { return _labelC; }
            set { SetProperty(ref _labelC, value); }
        }

        public DelegateCommand ButtonC { get; set; }
        private void SetText()
        {
            LabelC = "EEE";
        }

        public DelegateCommand NextCommand { get; set; }
        private void PageBShow()
        {
            base.NavigationService.NavigateAsync(nameof(PageBView));
        }
    }
}
