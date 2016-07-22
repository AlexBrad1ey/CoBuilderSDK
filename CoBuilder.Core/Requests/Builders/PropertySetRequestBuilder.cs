using System;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    internal class PropertySetRequestBuilder : IPropertySetRequestBuilder
    {
        private readonly IBaseClient _client;
        private readonly IPropertySetCollectionRequestBuilder _propertySetCollectionRequestBuilder;

        private PropertySetRequestBuilder(IPropertySetCollectionRequestBuilder propertySetCollectionRequestBuilder,
            IBaseClient client)
        {
            _propertySetCollectionRequestBuilder = propertySetCollectionRequestBuilder;
            _client = client;
        }

        public PropertySetRequestBuilder(IPropertySetCollectionRequestBuilder propertySetCollectionRequestBuilder,
            IBaseClient client, string propertySetId) : this(propertySetCollectionRequestBuilder, client)
        {
            PropertySetId = propertySetId;
        }


        public string PropertySetId { get; set; }

        public IPropertiesCollectionRequestBuilder Properties
        {
            get
            {
                return new PropertiesCollectionRequestBuilder(Constants.Url.Properties, _client,
                    _propertySetCollectionRequestBuilder.ProductId, PropertySetId);
            }
        }

        public IPropertySetRequest Request()
        {
            return new PropertySetRequest(_propertySetCollectionRequestBuilder.Request(), PropertySetId);
        }

        private void ThrowError()
        {
            throw new NotImplementedException();
        }

    }
}