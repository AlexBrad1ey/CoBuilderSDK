using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class PropertySetTagsCollectionRequestBuilder : BaseRequestBuilder, IPropertySetTagsCollectionRequestBuilder
    {
        public PropertySetTagsCollectionRequestBuilder(string requestResource, IBaseClient client, PluginApp appId = 0)
            : base(requestResource, client)
        {
            AppId = appId;
        }

        public PluginApp AppId { get; set; }

        public IPropertySetTagsCollectionRequest Request()
        {
            return new PropertySetTagsCollectionRequest(RequestResource, Client, AppId);
        }
    }
}