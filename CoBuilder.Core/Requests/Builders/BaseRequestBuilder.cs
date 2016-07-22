using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class BaseRequestBuilder
    {
        public BaseRequestBuilder(string requestResource, IBaseClient client)
        {
            Client = client;
            RequestResource = requestResource;
        }

        public string RequestResource { get; set; }
        public IBaseClient Client { get; set; }
    }
}