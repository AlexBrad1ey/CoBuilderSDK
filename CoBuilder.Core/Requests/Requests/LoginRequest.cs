using System.Threading.Tasks;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class LoginRequest : BaseRequest, ILoginRequest
    {
        private readonly IHttpProvider _httpProvider;

        public LoginRequest(string requestResource, IHttpProvider httpProvider, string username, string password)
            : base(requestResource, null)
        {
            _httpProvider = httpProvider;
            Parameters.Add(new Parameter {Name = Constants.Parameters.Username, Value = username, Type = ParameterType.GetOrPost});
            Parameters.Add(new Parameter {Name = Constants.Parameters.Password, Value = password, Type = ParameterType.GetOrPost });
        }


        public string Username
        {
            get { return (string) Parameters.Find(p => p.Name == Constants.Parameters.Username).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.Username).Value = value; }
        }

        public string Password
        {
            get { return (string) Parameters.Find(p => p.Name == Constants.Parameters.Password).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.Password).Value = value; }
        }


        public async Task<LoginResult> GetAsync()
        {
            Method = Method.GET;
            var response = await SendAsync<LoginResult>();

            if (response != null)
            {
                return response;
            }

            return null;
        }

        protected override async Task<IRestResponse<T>> SendRequestAsync<T>()
        {
            var request = GetRestRequestMessage();
            return await _httpProvider.SendAsync<T>(request);
        }
    }
}