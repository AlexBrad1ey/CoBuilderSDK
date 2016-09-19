using System;
using System.Reflection;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Commands
{
    public class LoginCommand<TElement> : ICommand where TElement : class
    {
        public bool Execute()
        {
            try
            {
                var service = CoBuilderService.CurrentService.LoginAsync();
                if (service.Session.LoggedIn)
                {
                    var interrogator = service.ServiceFactory<IInterrogator<TElement>>();
                    interrogator.Interrogate();
                    return true;
                }
                return false;

            }
            catch (Exception exception)
            {
                var commonSettings = new Settings();
                commonSettings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
                return false;
            }
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}