using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using Template.ViewModels;
using Template.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Template
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PageBView, PageBViewModel>();
            containerRegistry.RegisterForNavigation<Page001View, Page001ViewModel>();
            containerRegistry.RegisterForNavigation<Page002View, Page002ViewModel>();
            containerRegistry.RegisterForNavigation<Page003View, Page003ViewModel>();
        }
    }
}
