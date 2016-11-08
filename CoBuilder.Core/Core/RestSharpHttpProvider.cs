// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="RestSharpHttpProvider.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using RestSharp;
using RestSharp.Authenticators;

namespace CoBuilder.Core
{
    /// <summary>
    /// Class RestSharpHttpProvider.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.IHttpProvider" />
    public class RestSharpHttpProvider : IHttpProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestSharpHttpProvider"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        public RestSharpHttpProvider(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; set; }
        /// <summary>
        /// Gets or sets the authenticator.
        /// </summary>
        /// <value>The authenticator.</value>
        public IAuthenticator Authenticator { get; set; }


        /// <summary>
        /// Sends the specified request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns>IRestResponse&lt;T&gt;.</returns>
        public IRestResponse<T> Send<T>(IRestRequest request) where T : new()
        {
            var client = CreateClient();

            var response = client.Execute<T>(request);

            if (response.ErrorException == null) return response;
            ThrowError(response);
            return null;
        }

        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;IRestResponse&lt;T&gt;&gt;.</returns>
        public Task<IRestResponse<T>> SendAsync<T>(IRestRequest request) where T : new()
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = Authenticator ?? null
            };

            var response = client.ExecuteTaskAsync<T>(request);

            if (response.Result.ErrorException == null) return response;
            ThrowError(response.Result);
            return null;
        }


        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <returns>RestClient.</returns>
        private RestClient CreateClient()
        {
            return new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = Authenticator ?? null
            };
        }

        /// <summary>
        /// Throws the error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response">The response.</param>
        /// <exception cref="CoBuilderException"></exception>
        private void ThrowError<T>(IRestResponse<T> response) where T : new()
        {
            var error = new Error
            {
                Code = CoBuilderErrorCode.HttpException.ToString(),
                Message = "Error Executing request. check inner details for more info."
            };

            throw new CoBuilderException(error, response.ErrorException);
        }
    }
}