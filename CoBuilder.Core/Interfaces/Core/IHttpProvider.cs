using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace CoBuilder.Core.Interfaces
{
    public interface IHttpProvider
    {
        IAuthenticator Authenticator { get; set; }
        string BaseUrl { get; set; }
        IRestResponse<T> Send<T>(IRestRequest request) where T : new();
        Task<IRestResponse<T>> SendAsync<T>(IRestRequest request) where T : new();
    }
}