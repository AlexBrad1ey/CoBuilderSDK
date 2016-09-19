using System;
using System.Reflection;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Commands
{
    public class ConfigurationCommand : ICommand
    {
        public bool Execute()
        {
            try
            {
                var configSelector = CoBuilderService.CurrentService.ServiceFactory<IConfigSelectionUi>();
                var config = configSelector.SelectConfiguration();
                CoBuilderService.CurrentService.SetConfiguration(config);
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