using System;
using NW.AL.ViewModel;
using Prism.Navigation;

namespace NW.AL.ViewModel
{
    public class TabsMainPageViewModel : BaseViewModel, INavigationAware, IConfirmNavigation
    {

        public TabsMainPageViewModel()
        {
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
