// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="CobuilderAuthenticator.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    /// <summary>
    /// Class CoBuilderAuthenticator.
    /// </summary>
    /// <seealso cref="RestSharp.Authenticators.IAuthenticator" />
    public class CoBuilderAuthenticator : IAuthenticator
    {
        /// <summary>
        /// The _auth header
        /// </summary>
        private readonly string _authHeader;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderAuthenticator"/> class.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <exception cref="System.ArgumentNullException">Access token Argument cannot be null</exception>
        public CoBuilderAuthenticator(string accessToken)
        {
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken), "Access token Argument cannot be null");
            }

            _authHeader = $"{accessToken}";
        }

        /// <summary>
        /// Authenticates the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            // only add the Authorization parameter if it hasn't been added by a previous Execute
            var authPresent =
                request.Parameters.Any(
                    p =>
                        p.Type.Equals(ParameterType.HttpHeader) &&
                        p.Name.Equals("Authentication", StringComparison.OrdinalIgnoreCase));
            if (!authPresent)
            {
                request.AddParameter("Authentication", _authHeader, ParameterType.HttpHeader);
            }
        }
    }
}