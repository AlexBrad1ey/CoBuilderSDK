using System.Windows.Forms;
using CoBuilder.Service.Interfaces;

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
            if (CoBuilderService.CurrentService.Session.CurrentConfiguration == null || !CoBuilderService.CurrentService.Session.WorkplaceSet)
            {
                MessageBox.Show("Please Set a Configuration First & Choose a Workplace");
                return false;
            }
            var attacher = CoBuilderService.CurrentService.ServiceFactory<IAttacher<TElement>>();
            attacher.RefreshAllAttachments();

            MessageBox.Show("Process Complete");

            return true;
        }
    }
}