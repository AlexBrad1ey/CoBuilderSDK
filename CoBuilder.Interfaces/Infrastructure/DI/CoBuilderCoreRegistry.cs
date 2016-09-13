

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
            For<IHttpProvider>().Use<RestSharpHttpProvider>().Ctor<string>().Is(Core.Constants.Authentication.CoBuilderBaseUrl);
            For<IAuthenticationProvider>().Use<CoBuilderAuthenticationProvider>();
            For<ISession>().Use<Session>().Singleton().SelectConstructor(() => new Session()); ;
        }
    }
}