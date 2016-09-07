using System.Windows.Forms;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;
using CoBuilder.Service.Logic;

namespace CoBuilder.Service.Commands
{
    /// <summary>
    /// Class AttachCommand. a Command Class for attaching Products to Elements.
    /// </summary>
    /// <typeparam name="TElement">The type of the t element.</typeparam>
    /// <seealso cref="ICommand" />
    public class RefreshCommand<TElement> : ICommand where TElement : class
    {
        public bool CanExecute()
        {
            return true;
        }

        public bool Execute()
        {
            var attacher = CoBuilderService.CurrentService.ServiceFactory<IAttacher<TElement>>();
            attacher.RefreshAllAttachments();

            MessageBox.Show("Process Complete");

            return true;
        }
    }
}