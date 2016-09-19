using System;
using System.Linq;
using System.Windows.Forms;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Commands
{
    /// <summary>
    /// Class AttachCommand. a Command Class for attaching Products to Elements.
    /// </summary>
    /// <typeparam name="TElement">The type of the t element.</typeparam>
    /// <seealso cref="ICommand" />
    public class ConnectCommand<TElement> : ICommand where TElement : class
    {
        public bool CanExecute()
        {
            return true;
        }

        public bool Execute()
        {
            if (CoBuilderService.CurrentService.Session.CurrentConfiguration ==null)
            {
                MessageBox.Show("Please Set a Configuration First");
            }
            var productSelector = CoBuilderService.CurrentService.ServiceFactory<IProductSelectionUi>();

            var product = productSelector.SelectProduct();
            if (product == null) return false;

            var selector = CoBuilderService.CurrentService.ServiceFactory<IAppSelector<TElement>>();
            var selection = selector.GetSelection();

            var connector = CoBuilderService.CurrentService.ServiceFactory<IConnector<TElement>>();
            var connections = connector.Connect(selection,product);
            if (connections == null || !connections.Any()) return false;

            var attacher = CoBuilderService.CurrentService.ServiceFactory<IAttacher<TElement>>();
            attacher.RefreshAttachments();

            MessageBox.Show("Process Complete");

            return true;
        }
    }
}