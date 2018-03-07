using System;
using Prism.Mvvm;
namespace NW.AL.ViewModel
{
    public class BaseViewModel : BindableBase
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
    }
}
