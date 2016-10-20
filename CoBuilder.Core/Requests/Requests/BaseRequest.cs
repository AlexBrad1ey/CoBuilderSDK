using System.Collections.Generic;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class BaseRequest : IBaseRequest
    {
        public BaseRequest(
            string requestResource,
            IBaseClient client)
        {
            Method = Method.GET;
            Client = client;
            RequestResource = requestResource;
            Parameters = new List<Parameter>();
        }

        public Method Method { get; set; }

        public string RequestResource { get; set; }

        public IBaseClient Client { get; set; }

        public List<Parameter> Parameters { get; set; }

        public async Task<T> SendAsync<T>() where T : new()
        {
            var response = await SendRequestAsync<T>();

            if (response.Data != null)
            {
                var auth = response.Data as IAuthenticatedResult;
                if (auth?.Status != AuthenticationRequestStatus.NoSuchToken) return response.Data;

                //GetHashCode new token and try again
                await Client.AuthenticateAsync(Client.CurrentSession.UserId, Client.CurrentSession.Pass);
                response = await SendRequestAsync<T>();
                return response.Data;
            }

            return default(T);
        }

        public IRestRequest GetRestRequestMessage()
        {
            var request = new RestRequest(RequestResource, Method);
            foreach (var param in Parameters)
            {
                request.AddParameter(param);
            }

            return request;
        }

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

        private void AuthenticateHttpProvider()
        {
            Client.HttpProvider.Authenticator = Client.AuthenticationProvider.GetAuthenticator();
        }
    }
}