using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Authentication
{
    public class CoBuilderServiceInfoProvider : ServiceInfoProvider, IServiceInfoProvider
    {
        public CoBuilderServiceInfoProvider(IAuthenticationProvider authenticationProvider, IAuthenticationUi authenticationUi = null) : base(authenticationProvider, authenticationUi)
        {
        }

        protected override CoBuilderServiceInfo ServiceBuilder(IAppConfig appConfig, IHttpProvider httpProvider)
        {
            return new CoBuilderServiceInfo
            {
                AppId = appConfig.AppId,
                HttpProvider = httpProvider,
                AuthenticationUi = AuthenticationUi,
                AuthenticationProvider = AuthenticationProvider
            };
        }


    }
}