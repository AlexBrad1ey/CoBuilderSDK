using System.Windows.Forms;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Commands
{
    public class RemoveCommand<TElement> : ICommand where TElement : class
    {
        public RemovalResult RemovalResult { get; protected set; }

        public bool CanExecute()
        {
            return true;
        }

        public bool Execute()
        {
            var selector = CoBuilderService.CurrentService.ServiceFactory<IAppSelector<TElement>>();
            selector.GetSelection();


            var connector = CoBuilderService.CurrentService.ServiceFactory<IConnector<TElement>>();
            connector.Remove(selector.Selection);

            var attacher = CoBuilderService.CurrentService.ServiceFactory<IAttacher<TElement>>();
            attacher.RefreshAttachments();

            return true;
        }
    }
}