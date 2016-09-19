using System;
using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;
using CoBuilder.Core.RestModels;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    public class CoBuilderAuthenticationProvider : AuthenticationProvider
    {
        protected AuthenticationProviderType AuthenticationProviderType;


        public CoBuilderAuthenticationProvider(IHttpProvider httpProvider) :base(null, null)
        {
            HttpProvider = httpProvider;
            AuthenticationProviderType = AuthenticationProviderType.Basic;
        }
        public CoBuilderAuthenticationProvider(CredentialCache credentialCache, IHttpProvider httpProvider) : base(credentialCache, null)
        {
            HttpProvider = httpProvider;
            AuthenticationProviderType = AuthenticationProviderType.CacheOnly;
        }
        public CoBuilderAuthenticationProvider(IAuthenticationUi authenticationUi, IHttpProvider httpProvider) : base(null, authenticationUi)
        {
            HttpProvider = httpProvider;
            AuthenticationProviderType = AuthenticationProviderType.AuthenticationUI;
        }
        public CoBuilderAuthenticationProvider(CredentialCache credentialCache, IAuthenticationUi authenticationUi, IHttpProvider httpProvider) : base(credentialCache, authenticationUi)
        {
            HttpProvider = httpProvider;
            AuthenticationProviderType = AuthenticationProviderType.CacheWithUI;
        }


        public override IAuthenticator GetAuthenticator()
        {
            return new CoBuilderAuthenticator(CurrentSession.AccessToken);
        }
#pragma warning disable 1998
        public override async Task SignOutAsync()
#pragma warning restore 1998
        {
            if (CurrentSession.CanSignOut)
            {
                DeleteCredentialsFromCache(CurrentSession);
                CurrentSession = null;
            }
        }
        protected override async Task<ISession> GetAuthenticationResultAsync()
        {
            ISession session = null;

            session = await GetAccessTokenAsync();
            
            return session;
        }

        protected override async Task<ISession> GetAuthenticationResultAsync(string username, string password)
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

            var session = new Session(result, username) {CanSignOut = true};

            return session;
        }

        private Task<ISession> GetAccessTokenAsync()
        {
            if (AuthenticationUi != null)
            {
                return AuthenticationUi.AuthenticateAsync(HttpProvider);
            }
            return null;
        }

        public IHttpProvider HttpProvider { get; private set; }
    }

    public enum AuthenticationProviderType
    {
        Basic,
        CacheOnly,
        AuthenticationUI,
        CacheWithUI
    }
}