using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core
{
    public class BaseClient : IBaseClient
    {
        internal readonly IAppConfig AppConfig;
        internal readonly IServiceInfoProvider ServiceInfoProvider;
        private string _baseUrl;

        public BaseClient(IAppConfig appConfig, IHttpProvider httpProvider,
            IServiceInfoProvider serviceInfoProvider)
        {
            if (appConfig == null) throw new ArgumentNullException(nameof(appConfig));
            if (httpProvider == null) throw new ArgumentNullException(nameof(httpProvider));
            if (serviceInfoProvider == null) throw new ArgumentNullException(nameof(serviceInfoProvider));

            AppConfig = appConfig;
            HttpProvider = httpProvider;
            ServiceInfoProvider = serviceInfoProvider;
            try
            {
                var result = AuthenticateAsync(true).Result;
            }
            catch (Exception)
            {
                // ignored
            }
        }


        public IAuthenticationProvider AuthenticationProvider
        {
            get
            {
                return ServiceInfo?.AuthenticationProvider;
            }
        }
        public string BaseUrl
        {
            get { return _baseUrl; }
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
                return ServiceInfo?.AuthenticationProvider?.CurrentSession != null && !string.IsNullOrEmpty(BaseUrl);
            }
        }
        public IServiceInfo ServiceInfo { get; internal set; }

        public ISession CurrentSession
        {
            get { return AuthenticationProvider?.CurrentSession; }
        }


        //Use when AuthUi is Set
        public async Task<ISession> AuthenticateAsync(bool noUi = false)
        {
            if (ServiceInfo == null)
            {
                ServiceInfo = await ServiceInfoProvider.GetServiceInfoAsync(
                    AppConfig,
                    HttpProvider
                    );
            }

            if (string.IsNullOrEmpty(BaseUrl))
            {
                BaseUrl = ServiceInfo.BaseUrl;
                HttpProvider.BaseUrl = BaseUrl;
            }

            var authResult = await ServiceInfo.AuthenticationProvider.AuthenticateAsync(ServiceInfo, noUi);

            return authResult;
        }
        //Pure Code Invocation so Id and Pass required.
        public async Task<ISession> AuthenticateAsync(string username, string password)
        {
            if (ServiceInfo == null)
            {
                ServiceInfo = await ServiceInfoProvider.GetServiceInfoAsync(
                    AppConfig,
                    HttpProvider
                    );
            }

            if (string.IsNullOrEmpty(BaseUrl))
            {
                BaseUrl = ServiceInfo.BaseUrl;
                HttpProvider.BaseUrl = BaseUrl;
            }

            var authResult = await ServiceInfo.AuthenticationProvider.AuthenticateAsync(ServiceInfo, username, password);

            return authResult;
        }
        public Task SignOutAsync()
        {
            return AuthenticationProvider != null ? AuthenticationProvider.SignOutAsync() : Task.FromResult(0);
        }
    }
}