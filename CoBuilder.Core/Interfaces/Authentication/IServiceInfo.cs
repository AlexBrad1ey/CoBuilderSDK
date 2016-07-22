using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Authentication
{
    public interface IServiceInfo
    {
        PluginApp AppId { get; }
        IAuthenticationProvider AuthenticationProvider { get; }
        IAuthenticationUi AuthenticationUi { get; }
        string BaseUrl { get; }
        CredentialCache CredentialCache { get; }
        IHttpProvider HttpProvider { get; }
        string ServiceEndpointVersion { get; }
        string UserId { get; }
    }
}