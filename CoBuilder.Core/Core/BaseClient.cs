using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core
{
    public class BaseClient : IBaseClient
    {
        internal readonly IAppConfig AppConfig;
        internal readonly IAuthenticationProvider _authenticationProvider;
        private string _baseUrl;

        public BaseClient(IAppConfig appConfig, IHttpProvider httpProvider,
            IAuthenticationProvider authenticationProvider)
        {
            if (appConfig == null) throw new ArgumentNullException(nameof(appConfig));
            if (httpProvider == null) throw new ArgumentNullException(nameof(httpProvider));
            if (authenticationProvider == null) throw new ArgumentNullException(nameof(authenticationProvider));

            AppConfig = appConfig;
            _authenticationProvider = authenticationProvider;
            HttpProvider = httpProvider;
        }

        public IAuthenticationProvider AuthenticationProvider
        {
            get
            {
                return _authenticationProvider;
            }
        }
        public string BaseUrl
        {
            get
            {
                if (string.IsNullOrEmpty( _baseUrl))
                {
                    _baseUrl = HttpProvider.BaseUrl;
                }
                return _baseUrl;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new CoBuilderException(
                        new Error
                        {
                            Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                            Message = "Base URL cannot be null or empty"
                        });
                }

                _baseUrl = value.TrimEnd('/');
            }
        }
        public IHttpProvider HttpProvider { get; }
        public bool IsAuthenticated
        {
            get
            {
                return AuthenticationProvider?.CurrentSession.AccessToken != null && !string.IsNullOrEmpty(BaseUrl);
            }
        }

        public ISession CurrentSession
        {
            get { return AuthenticationProvider?.CurrentSession; }
        }


        //Use when AuthUi is Set
        public async Task<ISession> AuthenticateAsync()
        {

            if (string.IsNullOrEmpty(BaseUrl))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                        Message = "Base URL cannot be null or empty"
                    });
            }

            var authResult = await AuthenticationProvider.AuthenticateAsync();

            return authResult;
        }
        //Pure Code Invocation so Id and Pass required.
        public async Task<ISession> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(BaseUrl))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                        Message = "Base URL cannot be null or empty"
                    });
            }

            var authResult = await AuthenticationProvider.AuthenticateAsync(username, password);

            return authResult;
        }
        public Task SignOutAsync()
        {
            return AuthenticationProvider != null ? AuthenticationProvider.SignOutAsync() : Task.FromResult(0);
        }
    }
}