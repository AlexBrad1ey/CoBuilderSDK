using CoBuilder.Core.Interfaces;
using CoBuilder.Service.GUI;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class CoBuilderServiceRegistry : CoBuilderCoreRegistry
    {
        public CoBuilderServiceRegistry()
        {
            //Add Required DI for Service Level Objects
            For<IAuthenticationUi>().Use<CoBuilderAuthenticationUi>();
            For<ICoBuilderContext>().Use<CoBuilderContext>();
        }
    }
}