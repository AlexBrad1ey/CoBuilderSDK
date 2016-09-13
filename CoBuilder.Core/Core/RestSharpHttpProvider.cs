using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using RestSharp;
using RestSharp.Authenticators;

namespace CoBuilder.Core
{
    public class RestSharpHttpProvider : IHttpProvider
    {
        public RestSharpHttpProvider(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public string BaseUrl { get; set; }
        public IAuthenticator Authenticator { get; set; }


        public IRestResponse<T> Send<T>(IRestRequest request) where T : new()
        {
            var client = CreateClient();

            var response = client.Execute<T>(request);

            if (response.ErrorException == null) return response;
            ThrowError(response);
            return null;
        }

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


        private RestClient CreateClient()
        {
            return new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = Authenticator ?? null
            };
        }

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