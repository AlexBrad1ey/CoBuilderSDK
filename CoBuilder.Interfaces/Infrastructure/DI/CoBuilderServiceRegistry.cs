using CoBuilder.Core.Interfaces;
using CoBuilder.Service.GUI;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Logic;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class CoBuilderServiceRegistry : CoBuilderCoreRegistry
    {
        public CoBuilderServiceRegistry()
        {
            //Add Required DI for Service Level Objects
            For<IAuthenticationUi>().Use<CoBuilderAuthenticationUi>();
            For<IWorkplaceSelectionUi>().Use<WorkplaceDialog>();
            For<IProductSelectionUi>().Use<ProductDialog>();
            For<IConfigSelectionUi>().Use<ConfigDialog>();

            For<ICoBuilderContext>().Use<CoBuilderContext>();
            For(typeof(IInterrogator<>)).Use(typeof(ModelInterrogator<>));
            For(typeof(IAttacher<>)).Use(typeof(AttachmentManager<>));
            For(typeof(IConnector<>)).Use(typeof(ConnectionManager<>));
            For<IServiceSession>().Use(() => CoBuilderService.CurrentService.Session);

        }
    }
}