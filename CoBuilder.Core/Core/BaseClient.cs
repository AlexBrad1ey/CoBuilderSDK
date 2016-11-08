// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="BaseClient.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core
{
    /// <summary>
    /// Class BaseClient.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.IBaseClient" />
    public class BaseClient : IBaseClient
    {
        /// <summary>
        /// The application configuration
        /// </summary>
        internal readonly IAppConfig AppConfig;
        /// <summary>
        /// The _authentication provider
        /// </summary>
        internal readonly IAuthenticationProvider _authenticationProvider;
        /// <summary>
        /// The _base URL
        /// </summary>
        private string _baseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClient"/> class.
        /// </summary>
        /// <param name="appConfig">The application configuration.</param>
        /// <param name="httpProvider">The HTTP provider.</param>
        /// <param name="authenticationProvider">The authentication provider.</param>
        /// <exception cref="System.ArgumentNullException">
        /// </exception>
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

        /// <summary>
        /// Gets the authentication provider.
        /// </summary>
        /// <value>The authentication provider.</value>
        public IAuthenticationProvider AuthenticationProvider
        {
            get
            {
                return _authenticationProvider;
            }
        }
        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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
        /// <summary>
        /// Gets the HTTP provider.
        /// </summary>
        /// <value>The HTTP provider.</value>
        public IHttpProvider HttpProvider { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is authenticated.
        /// </summary>
        /// <value><c>true</c> if this instance is authenticated; otherwise, <c>false</c>.</value>
        public bool IsAuthenticated
        {
            get
            {
                return AuthenticationProvider?.CurrentSession.AccessToken != null && !string.IsNullOrEmpty(BaseUrl);
            }
        }

        /// <summary>
        /// Gets the current session.
        /// </summary>
        /// <value>The current session.</value>
        public ISession CurrentSession
        {
            get { return AuthenticationProvider?.CurrentSession; }
        }


        //Use when AuthUi is Set
        /// <summary>
        /// authenticate as an asynchronous operation.
        /// </summary>
        /// <returns>Task&lt;ISession&gt;.</returns>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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
        /// <summary>
        /// authenticate as an asynchronous operation.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>Task&lt;ISession&gt;.</returns>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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
        /// <summary>
        /// Signs the out asynchronous.
        /// </summary>
        /// <returns>Task.</returns>
        public Task SignOutAsync()
        {
            return AuthenticationProvider != null ? AuthenticationProvider.SignOutAsync() : Task.FromResult(0);
        }
    }
}