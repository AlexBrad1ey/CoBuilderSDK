using System.Threading.Tasks;

namespace CoBuilder.Core.Interfaces
{
    public interface IAuthenticationUi
    {
        Task<ISession> AuthenticateAsync(IHttpProvider httpProvider);
    }
}