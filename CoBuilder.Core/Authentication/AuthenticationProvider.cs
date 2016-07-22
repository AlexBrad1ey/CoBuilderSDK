using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    public abstract class AuthenticationProvider : IAuthenticationProvider
    {
        protected CredentialCache CredentialCache;
        protected IAuthenticationUi AuthenticationUi;


        public AuthenticationProvider(CredentialCache credentialCache, IAuthenticationUi authenticationUi)
        {
            this.CredentialCache = credentialCache;
            this.AuthenticationUi = authenticationUi;
        }


        public ISession CurrentSession { get; set; }


        public abstract Task SignOutAsync();
        public abstract IAuthenticator GetAuthenticator();


        public virtual async Task<ISession> AuthenticateAsync(IServiceInfo serviceInfo)
        {
            if (ProcessCachedSession(CurrentSession))
            {
                return CurrentSession;
            }

            var session = GetAuthenticationResultFromCache(serviceInfo.UserId,serviceInfo.AppId);

            if (ProcessCachedSession(session))
            {
                CacheSession(session);
                return session;
            }

            if (session != null)
            {
                DeleteCredentialsFromCache(session);
            }

            session = await GetAuthenticationResultAsync();

            if (string.IsNullOrEmpty(session?.AccessToken))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                        Message = "Failed to retrieve a valid authentication token for the user."
                    });
            }

            CacheSession(session);

            return session;
        }
        public virtual async Task<ISession> AuthenticateAsync(IServiceInfo serviceInfo, string username, string password)
        {
            if (ProcessCachedSession(CurrentSession))
            {
                return CurrentSession;
            }

            var session = GetAuthenticationResultFromCache(serviceInfo.UserId, serviceInfo.AppId);

            if (ProcessCachedSession(session))
            {
                CacheSession(session);
                return session;
            }

            if (session != null)
            {
                DeleteCredentialsFromCache(session);
            }

            session = await GetAuthenticationResultAsync(username, password);

            if (string.IsNullOrEmpty(session?.AccessToken))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                        Message = "Failed to retrieve a valid authentication token for the user."
                    });
            }

            session.AppId = serviceInfo.AppId;
            CacheSession(session);

            return session;
        }

        internal bool ProcessCachedSession(ISession session)
        {
            //If we have a valid session for authentication return it.
            return !string.IsNullOrEmpty(session?.AccessToken);
        }

        protected void CacheSession(ISession session)
        {
            CurrentSession = session;

            CredentialCache?.AddToCache(session);
        }

        protected void DeleteCredentialsFromCache(ISession session)
        {
            CredentialCache?.DeleteFromCache(session);
        }

        protected abstract Task<ISession> GetAuthenticationResultAsync();
        protected abstract Task<ISession> GetAuthenticationResultAsync(string username, string password);

        protected ISession GetAuthenticationResultFromCache(string userId, PluginApp appId)
        {
            var session = CredentialCache?.GetResultFromCache(userId, appId);

            return session;
        }
    }
}