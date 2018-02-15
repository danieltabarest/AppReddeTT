//using AppReddeTT.Services;
using Microsoft.Practices.Unity;
using AppReddeTT.Navigation;
using AppReddeTT.Services;
using AppReddeTT.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace AppReddeTT
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await
                NavigationService.NavigateAsync(
                    $"{PageTokens.RootMasterDetailPage}/{PageTokens.RootNavigationPage}/{PageTokens.PostsPage}",
                    animated: false);
            //NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IRedditApiSource, RedditApiSource>();

            Container.RegisterTypeForNavigation<RootMasterDetailPage>();
            Container.RegisterTypeForNavigation<RootMasterDetailPage>();
            Container.RegisterTypeForNavigation<RootNavigationPage>();
            Container.RegisterTypeForNavigation<SubredditsMenuPage>();
            Container.RegisterTypeForNavigation<PostsPage>();
            Container.RegisterTypeForNavigation<PostDetailPage>();
        }
    }
}