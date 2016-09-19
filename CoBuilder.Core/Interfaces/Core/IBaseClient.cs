using System.Threading.Tasks;
using CoBuilder.Core.Authentication;

namespace CoBuilder.Core.Interfaces
{
    public interface IBaseClient
    {
        IAuthenticationProvider AuthenticationProvider { get; }
        string BaseUrl { get; }
        IHttpProvider HttpProvider { get; }
        bool IsAuthenticated { get; }

        ISession CurrentSession { get; }
        IServiceInfo ServiceInfo { get; }
        Task<ISession> AuthenticateAsync(bool noUi = false);
        Task<ISession> AuthenticateAsync(string username, string password);
        Task SignOutAsync();
    }
}