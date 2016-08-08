using CoBuilder.Core;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Interfaces;
using StructureMap;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class CoBuilderCoreRegistry : Registry
    {
        public CoBuilderCoreRegistry()
        {
            For<ICoBuilderClient>().Use<CoBuilderClient>();
                For<IAppConfig>().Use<AppConfig>().Singleton();
                For<IHttpProvider>().Use<RestSharpHttpProvider>();
                For<IServiceInfoProvider>().Use<CoBuilderServiceInfoProvider>();
                    For<IAuthenticationProvider>().Use<CoBuilderAuthenticationProvider>();
                        For<CredentialCache>().Singleton();

        }
}