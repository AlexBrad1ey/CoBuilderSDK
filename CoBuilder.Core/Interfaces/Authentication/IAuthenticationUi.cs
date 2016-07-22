using System;
using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Authentication
{
    public interface IAuthenticationUi
    {
        Task<ISession> AuthenticateAsync(IHttpProvider httpProvider);
    }

    public class CoBuilderAuthenticationUi : IAuthenticationUi
    {
        public Task<ISession> AuthenticateAsync(IHttpProvider httpProvider)
        {
            throw new NotImplementedException();
        }
    }
}