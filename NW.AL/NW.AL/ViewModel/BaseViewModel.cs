using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace NW.AL.ViewModel
{
    public class BaseViewModel : BindableBase , INavigationAware, IConfirmNavigation
    {
        bool _isBusy;
        string _title;

        public bool IsBusy
        {
            get => _isBusy; 
            set => SetProperty(ref _isBusy, value);
        }


        public string Title 
        { 
            get => _title; 
            set => SetProperty(ref _title, value); 
        }

        public virtual bool CanNavigate(NavigationParameters parameters)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
