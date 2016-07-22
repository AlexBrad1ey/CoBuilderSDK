using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace CoBuilder.Core.Interfaces
{
    public interface IBaseRequest
    {
        string RequestResource { get; set; }
        IBaseClient Client { get; set; }
        List<Parameter> Parameters { get; set; }
        Method Method { get; set; }
        Task<T> SendAsync<T>() where T : new();
        IRestRequest GetRestRequestMessage();
    }
}