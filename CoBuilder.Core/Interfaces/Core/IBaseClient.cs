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

        Task<ISession> AuthenticateAsync();
        Task<ISession> AuthenticateAsync(string username, string password);
        Task SignOutAsync();
    }
}