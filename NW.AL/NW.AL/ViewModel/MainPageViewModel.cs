using System;
using System.Configuration;
using NW.AL.Common;
using NW.AL.Interfaces;
using NW.AL.Models;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Mvvm;

namespace NW.AL.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        IAppFlow _appFlow;

        public MainPageViewModel(IAppFlow appFlow)
        {
            if (NullChecker.IsObjectInitialized(appFlow))
            {
                _appFlow = appFlow;
            }

            IsBusy = true;
            _appFlow.DetermineAppPathAsync();
            IsBusy = false;

        }
    }
}
