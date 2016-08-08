using System;
using System.Threading.Tasks;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Service.GUI
{
    public class CoBuilderAuthenticationUi : IAuthenticationUi
    {
        public Task<ISession> AuthenticateAsync(IHttpProvider httpProvider)
        {
            throw new NotImplementedException();
        }
    }
}