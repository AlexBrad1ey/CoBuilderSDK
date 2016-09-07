using System;
using System.Reflection;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.Commands
{
    public class LoginCommand : ICommand
    {
        public bool Execute()
        {
            try
            {
                CoBuilderService.CurrentService.LoginAsync();
               return true;
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