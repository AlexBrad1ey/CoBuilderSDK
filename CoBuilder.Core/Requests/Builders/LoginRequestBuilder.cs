using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class LoginRequestBuilder
    {
        private readonly IHttpProvider _httpProvider;
        private readonly string _requestResource;

        public LoginRequestBuilder(string requestResource, IHttpProvider httpProvider)
        {
            _requestResource = requestResource;
            _httpProvider = httpProvider;
        }


        public LoginRequest Request(string username, string password)
        {
            return new LoginRequest(_requestResource, _httpProvider, username, password);
        }
    }
}