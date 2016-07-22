using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Authentication
{
    public abstract class ServiceInfoProvider
    {
        protected IAuthenticationUi AuthenticationUi;


        protected ServiceInfoProvider(IAuthenticationProvider authenticationProvider, IAuthenticationUi authenticationUi = null)
        {
            AuthenticationUi = authenticationUi;
            AuthenticationProvider = authenticationProvider;
        }


        public IAuthenticationProvider AuthenticationProvider { get; private set; }

        public Task<IServiceInfo> GetServiceInfoAsync(IAppConfig appConfig, IHttpProvider httpProvider)
        {
            var coBuilderServiceInfo = ServiceBuilder(appConfig, httpProvider);

            return Task.FromResult<IServiceInfo>(coBuilderServiceInfo);
        }

        protected abstract CoBuilderServiceInfo ServiceBuilder(IAppConfig appConfig, IHttpProvider httpProvider);
    }
}