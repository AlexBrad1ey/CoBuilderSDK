using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class PropertiesCollectionRequestBuilder : BaseRequestBuilder, IPropertiesCollectionRequestBuilder
    {
        public PropertiesCollectionRequestBuilder(string requestResource, IBaseClient client, int productId,
            string propertySetId)
            : base(requestResource, client)
        {
            ProductId = productId;
            PropertySetId = propertySetId;
        }

        public int ProductId { get; set; }
        public string PropertySetId { get; set; }


        public IPropertiesCollectionRequest Request()
        {
            return new PropertiesCollectionRequest(RequestResource, Client, ProductId, PropertySetId);
        }
    }
}