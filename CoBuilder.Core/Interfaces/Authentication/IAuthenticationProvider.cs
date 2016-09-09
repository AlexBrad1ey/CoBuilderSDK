using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    public interface IAuthenticationProvider
    {
        ISession CurrentSession { get; set; }


        Task SignOutAsync();
        Task<ISession> AuthenticateAsync(IServiceInfo serviceInfo, bool NoUi);
        Task<ISession> AuthenticateAsync(IServiceInfo serviceInfo, string username, string password);
        IAuthenticator GetAuthenticator();
    }
}