using System.Collections.Generic;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class PropertySetCollectionRequestBuilder : BaseRequestBuilder, IPropertySetCollectionRequestBuilder
    {
        private readonly IList<int> _propertySetIds;


        public PropertySetCollectionRequestBuilder(string requestResource, IBaseClient client, int productId)
            : base(requestResource, client)
        {
            ProductId = productId;
            var cBClient = client as CoBuilderClient;
            if (cBClient != null) _propertySetIds = cBClient.PropertySetIds;
        }


        public int ProductId { get; set; }


        public IPropertySetRequestBuilder this[string pSetId]
        {
            get { return new PropertySetRequestBuilder(this, Client, pSetId); }
        }


        public IPropertySetCollectionRequest Request()
        {
            return new PropertySetCollectionRequest(RequestResource, Client, ProductId, _propertySetIds);
        }
    }
}