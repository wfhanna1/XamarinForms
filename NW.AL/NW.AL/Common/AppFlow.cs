using System;
using NW.AL.Interfaces;
using System.Threading.Tasks;
using Prism.Navigation;
using NW.AL.Models;

namespace NW.AL.Common
{
    public class AppFlow : IAppFlow
    {
        IALDatabase _dbContext;
        INavigationService _navigationService;

        public AppFlow(IALDatabase dbContext, INavigationService navigationService)
        {
            if (NullChecker.IsObjectInitialized(dbContext))
            {
                _dbContext = dbContext;
            }
            if (NullChecker.IsObjectInitialized(navigationService))
            {
                _navigationService = navigationService;
            }
        }

        public void DetermineAppPathAsync()
        {
            try
            {
                //Check if the skip tutorial flag is on then Navigate to TabsMainPage, else show tutorial material
                var skipTutorial = _dbContext?.GetConnection()?.Table<Tutorial>()?.FirstOrDefault();
                if (skipTutorial != null && skipTutorial.SkipTutorialFlag)
                {
                    //Navigate to directions page
                    Task.Run(async() => await _navigationService.NavigateAsync("DirectionsPage"));
                }
                else
                {
                    if (skipTutorial == null)
                    {
                        skipTutorial = new Tutorial();
                        _dbContext?.GetConnection()?.Insert(skipTutorial);
                    }
                    skipTutorial.SkipTutorialFlag = true;
                    _dbContext.GetConnection().Update(skipTutorial);

                    //Navigate to tutorial screens 
                    Task.Run(async () => await _navigationService.NavigateAsync("TutorialPage"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
