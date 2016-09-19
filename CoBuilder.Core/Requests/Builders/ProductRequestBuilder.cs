using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class ProductRequestBuilder : BaseRequestBuilder, IProductRequestBuilder
    {
        public ProductRequestBuilder(string requestResource, IBaseClient client, int productId)
            : base(requestResource, client)
        {
            ProductId = productId;
        }


        public int ProductId { get; set; }

        
        public IPropertySetCollectionRequestBuilder PropertySets
        {
            get { return new PropertySetCollectionRequestBuilder(Constants.Url.PropertySets, Client, ProductId); }
        }
    }
}