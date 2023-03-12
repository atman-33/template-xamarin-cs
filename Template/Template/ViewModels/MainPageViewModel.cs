﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Conditions;
using Template.Objects;
using Template.Views;
using Xamarin.Forms;

namespace Template.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IPageDialogService _pageDialogService;

        public MainPageViewModel(INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _pageDialogService = pageDialogService;

            ButtonC = new DelegateCommand(SetText);
            NextCommand = new DelegateCommand(PageBShow);
            MessageCommand = new DelegateCommand(MessageCommandShow);

            Title = "Main Page";

            LabelC = "DDD";
        }

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 1. Property Data Binding
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        private string _labelC = string.Empty;
        public string LabelC
        {
            get { return _labelC; }
            set { SetProperty(ref _labelC, value); }
        }

        #endregion

        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 
        #region //// 2. Event Binding (DelegateCommand)
        //// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- 

        public DelegateCommand ButtonC { get; set; }
        private void SetText()
        {
            LabelC = "EEE";
        }

        public DelegateCommand NextCommand { get; set; }
        private void PageBShow()
        {
            var param = new NavigationParameters
            {
                {nameof(PageBCondition),new PageBCondition("XXXX") }
            };

            base.NavigationService.NavigateAsync(nameof(PageBView), param);
        }

        public DelegateCommand MessageCommand { get; set; }
        private void MessageCommandShow()
        {
            _pageDialogService.DisplayAlertAsync("タイトル", "メッセージ", "OK");

            Title = DependencyService.Get<IDevice>().GetDeviceName();
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
