using System;
using System.Reflection;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Commands
{
    /// <summary>
    /// Class ChangeWorkplaceCommand. Command for managing the change of Workplaces
    /// </summary>
    /// <seealso cref="ICommand" />
    public class ChangeWorkplaceCommand : ICommand
    {
        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Execute()
        {
            try
            {
                var workplaceSelector = CoBuilderService.CurrentService.ServiceFactory<IWorkplaceSelectionUi>();
                var workplace = workplaceSelector.SelectWorkplace();
                if (workplace == null) return false;
                CoBuilderService.CurrentService.SetWorkplace(workplace);

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