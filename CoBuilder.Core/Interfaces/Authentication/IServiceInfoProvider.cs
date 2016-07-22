using System.Threading.Tasks;
using CoBuilder.Core.Authentication;

namespace CoBuilder.Core.Interfaces
{
    public interface IServiceInfoProvider
    {
        IAuthenticationProvider AuthenticationProvider { get; }

        Task<IServiceInfo> GetServiceInfoAsync(IAppConfig appConfig, IHttpProvider httpProvider);

    }
}