using NW.AL.ViewModel;
using Prism.Unity;
using Prism;
using Prism.Ioc;
using NW.AL.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using NW.AL.Common.Interfaces;
using NW.AL.Common;
using NW.AL.Interfaces;
using NW.AL.Database;
using Xamarin.Forms;

namespace NW.AL
{
    public partial class App : PrismApplication
	{
        private IAppFlow _appFlow;

        public App (IPlatformInitializer initializer = null) : base(initializer)
        {
            AppCenter.Start("ios=eec63e93-cc7c-46cd-9b25-ed0ae3ccacf0;" + "android=ac45a737-7deb-42d6-baab-3e21c359f594", typeof(Analytics), typeof(Crashes));

            MainPage = new MainPage();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //View Model Registeration 
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabsMainPage,TabsMainPageViewModel>();
            containerRegistry.RegisterForNavigation<DirectionsPage,DirectionsPageViewModel>();
            containerRegistry.RegisterForNavigation<EditPage,EditPageViewModel>();
            containerRegistry.RegisterForNavigation<TutorialPage, TutorialPageViewModel>();

            //Class Registeration
            containerRegistry.Register<IBotCommunication, BotCommunication>();
            containerRegistry.Register<IALDatabase, ALDatabase>();
            containerRegistry.Register<IAppFlow, AppFlow>();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
