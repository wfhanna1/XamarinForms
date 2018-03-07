using NW.AL.ViewModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NW.AL.ViewModel
{
    public class TutorialPageViewModel : BaseViewModel, INavigationAware, IConfirmNavigation
    {
        public TutorialPageViewModel()
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
