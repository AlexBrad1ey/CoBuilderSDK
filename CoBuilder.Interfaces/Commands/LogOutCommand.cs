using System;
using System.Reflection;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.Commands
{

    public class LogOutCommand : ICommand
    {
        public bool Execute()
        {
            try
            {
                CoBuilderService.CurrentService.Close();
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