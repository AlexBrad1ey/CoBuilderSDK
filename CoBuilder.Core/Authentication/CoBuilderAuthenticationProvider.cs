using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;
using CoBuilder.Core.RestModels;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    public class CoBuilderAuthenticationProvider : IAuthenticationProvider
    {
        protected ISession _session;
        protected IAuthenticationUi AuthenticationUi;

        public CoBuilderAuthenticationProvider(ISession session, IAuthenticationUi authenticationUi, IHttpProvider httpProvider)
        {
            CurrentSession = session;
            HttpProvider = httpProvider;
            AuthenticationUi = authenticationUi;
        }

        public ISession CurrentSession { get; set; }

#pragma warning disable 1998
        public async Task SignOutAsync()
#pragma warning restore 1998
        {
            if (CurrentSession.CanSignOut)
            {
                CurrentSession.Clear();
                CurrentSession = null;
            }
        }

        public virtual async Task<ISession> AuthenticateAsync()
        {

            await GetAuthenticationResultAsync();
                    
            if (string.IsNullOrEmpty(CurrentSession?.AccessToken))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                        Message = "Failed to retrieve a valid authentication token for the user."
                    });
            }

            return CurrentSession;
        }

        public async Task<ISession> AuthenticateAsync(string username, string password)
        {
            await GetAuthenticationResultAsync(username, password);

            if (string.IsNullOrEmpty(CurrentSession?.AccessToken))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                        Message = "Failed to retrieve a valid authentication token for the user."
                    });
            }

            return CurrentSession;
        }

        protected Task<ISession> GetAuthenticationResultAsync()
        {
            if (AuthenticationUi == null)
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                        Message = "No Authentication Ui Set"
                    });
            }
            var session = AuthenticationUi.AuthenticateAsync(HttpProvider);
            if (session != null)
            {
                CurrentSession.Update(session.Result);
            }
            return session;
        }

        protected async Task<ISession> GetAuthenticationResultAsync(string username, string password)
        {
            var request = new LoginRequestBuilder("Login", HttpProvider).Request(username, password);
            LoginResult result = null;
            try
            {
                result = await request.GetAsync();
            }
            catch
            {
                return null;
            }

            CurrentSession.Update(result, username, true);

            return CurrentSession;
        }

        public IHttpProvider HttpProvider { get; set; }

        public IAuthenticator GetAuthenticator()
        {
            return new CoBuilderAuthenticator(CurrentSession.AccessToken);
        }
    }
}