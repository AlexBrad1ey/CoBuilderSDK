// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="BaseRequest.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    /// <summary>
    /// Class BaseRequest.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.IBaseRequest" />
    public class BaseRequest : IBaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest" /> class.
        /// </summary>
        /// <param name="requestResource">The request resource.</param>
        /// <param name="client">The client.</param>
        public BaseRequest(
            string requestResource,
            IBaseClient client)
        {
            Method = Method.GET;
            Client = client;
            RequestResource = requestResource;
            Parameters = new List<Parameter>();
        }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        public Method Method { get; set; }

        /// <summary>
        /// Gets or sets the request resource.
        /// </summary>
        /// <value>The request resource.</value>
        public string RequestResource { get; set; }

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>The client.</value>
        public IBaseClient Client { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// send as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<T> SendAsync<T>() where T : new()
        {
            var response = await SendRequestAsync<T>();

            if (response.Data == null) return default(T);
            var auth = response.Data as IAuthenticatedResult;
            if (auth?.Status != AuthenticationRequestStatus.NoSuchToken) return response.Data;

            //GetHashCode new token and try again
            await Client.AuthenticateAsync(Client.CurrentSession.UserId, Client.CurrentSession.Pass);
            response = await SendRequestAsync<T>();
            return response.Data;
        }

        /// <summary>
        /// Gets the rest request message.
        /// </summary>
        /// <returns>IRestRequest.</returns>
        public IRestRequest GetRestRequestMessage()
        {
            var request = new RestRequest(RequestResource, Method);
            foreach (var param in Parameters)
            {
                request.AddParameter(param);
            }

            return request;
        }

        /// <summary>
        /// send request as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Task&lt;IRestResponse&lt;T&gt;&gt;.</returns>
        /// <exception cref="CoBuilder.Core.Exceptions.CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
        /// <exception cref="CoBuilderException"></exception>
        protected virtual async Task<IRestResponse<T>> SendRequestAsync<T>() where T : new()
        {
            // We will generate a new auth token later if that isn't set on the client, so not calling
            // IsAuthenticated. Instead, verify the service info and base URL are initialized to make sure
            // AuthenticateAsync has previously been called on the client.
            if (string.IsNullOrEmpty(Client.BaseUrl))
            {
                throw new CoBuilderException(
                    new Error
                    {
                        Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                        Message = "The client must be authenticated before sending a request."
                    });
            }

            var request = GetRestRequestMessage();
            AuthenticateHttpProvider();
            Client.HttpProvider.BaseUrl = Client.BaseUrl;
            return await Client.HttpProvider.SendAsync<T>(request);
        }

        /// <summary>
        /// Authenticates the HTTP provider.
        /// </summary>
        private void AuthenticateHttpProvider()
        {
            Client.HttpProvider.Authenticator = Client.AuthenticationProvider.GetAuthenticator();
        }
    }
}