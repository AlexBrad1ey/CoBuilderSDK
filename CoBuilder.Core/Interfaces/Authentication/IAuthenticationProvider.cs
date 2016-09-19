using System.Threading.Tasks;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Interfaces
{
    public interface IAuthenticationProvider
    {
        ISession CurrentSession { get; set; }


        Task SignOutAsync();
        Task<ISession> AuthenticateAsync();
        Task<ISession> AuthenticateAsync(string username, string password);
        IAuthenticator GetAuthenticator();
    }
}