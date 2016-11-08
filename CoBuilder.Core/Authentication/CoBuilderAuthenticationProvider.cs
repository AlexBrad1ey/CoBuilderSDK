// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="CoBuilderAuthenticationProvider.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;
using CoBuilder.Core.RestModels;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    /// <summary>
    /// Class CoBuilderAuthenticationProvider.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.IAuthenticationProvider" />
    public class CoBuilderAuthenticationProvider : IAuthenticationProvider
    {
        /// <summary>
        /// The _session
        /// </summary>
        protected ISession _session;
        /// <summary>
        /// The authentication UI
        /// </summary>
        protected IAuthenticationUi AuthenticationUi;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderAuthenticationProvider"/> class.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="authenticationUi">The authentication UI.</param>
        /// <param name="httpProvider">The HTTP provider.</param>
        public CoBuilderAuthenticationProvider(ISession session, IAuthenticationUi authenticationUi, IHttpProvider httpProvider)
        {
            CurrentSession = session;
            HttpProvider = httpProvider;
            AuthenticationUi = authenticationUi;
        }

        /// <summary>
        /// Gets or sets the current session.
        /// </summary>
        /// <value>The current session.</value>
        public ISession CurrentSession { get; set; }

#pragma warning disable 1998
        /// <summary>
        /// sign out as an asynchronous operation.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task SignOutAsync()
#pragma warning restore 1998
        {
            if (CurrentSession.CanSignOut)
            {
                CurrentSession.Clear();
                CurrentSession = null;
            }
        }

        /// <summary>
        /// authenticate as an asynchronous operation.
        /// </summary>
        /// <returns>Task&lt;ISession&gt;.</returns>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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

        /// <summary>
        /// Gets the authentication result asynchronous.
        /// </summary>
        /// <returns>Task&lt;ISession&gt;.</returns>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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
            if (session.Result != null)
            {
                CurrentSession.Update(session.Result);
            }
            return session;
        }

        /// <summary>
        /// get authentication result as an asynchronous operation.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>Task&lt;ISession&gt;.</returns>
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

            CurrentSession.Update(result, username, password, true);

            return CurrentSession;
        }

        /// <summary>
        /// Gets or sets the HTTP provider.
        /// </summary>
        /// <value>The HTTP provider.</value>
        public IHttpProvider HttpProvider { get; set; }

        /// <summary>
        /// Gets the authenticator.
        /// </summary>
        /// <returns>IAuthenticator.</returns>
        public IAuthenticator GetAuthenticator()
        {
            return new CoBuilderAuthenticator(CurrentSession.AccessToken);
        }
    }
}