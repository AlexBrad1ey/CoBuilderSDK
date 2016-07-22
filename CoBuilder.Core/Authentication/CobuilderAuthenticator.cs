using System;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Authentication
{
    public class CoBuilderAuthenticator : IAuthenticator
    {
        private readonly string _authHeader;

        public CoBuilderAuthenticator(string accessToken)
        {
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken), "Access token Argument cannot be null");
            }

            _authHeader = $"{accessToken}";
        }

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