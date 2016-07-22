using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Authentication
{
    public class ServiceInfo : IServiceInfo
    {
        public IAuthenticationProvider AuthenticationProvider { get; set; }
        public string BaseUrl { get; set; }
        public PluginApp AppId { get; set; }
        public CredentialCache CredentialCache { get; set; }
        public IHttpProvider HttpProvider { get; set; }

        public string UserId
        {
            get { return CurrentSession?.UserId; }
        }

        public string ServiceEndpointVersion { get; set; }
        public IAuthenticationUi AuthenticationUi { get; set; }

        public ISession CurrentSession
        {
            get { return AuthenticationProvider?.CurrentSession; }
        }
    }
}