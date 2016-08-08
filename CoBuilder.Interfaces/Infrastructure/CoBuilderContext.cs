using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Sets;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace CoBuilder.Service.Infrastructure
{
    public class CoBuilderContext : ICoBuilderContext
    {
        private readonly ICoBuilderClient _client;
        private readonly ObjectCache _cache = MemoryCache.Default;

        public CoBuilderContext(ICoBuilderClient client)
        {
            _client = client;

            if (!_client.IsAuthenticated)
                throw new CoBuilderException(new Error()
                {
                    Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                    Message = "Context Requires an Authenticated Client"
                });
        }

        public async Task<IWorkplacesSet> WorkplacesAsync()
        {
            var id = _client.CurrentSession.ContactId.ToString();
            var objectSet = GetFromCache<IWorkplacesSet>(KeyBuilder.Build(KeyType.Workplaces, id));

            if (objectSet != null) return objectSet;

            var result = await _client.Workplaces.Request().GetAsync();

            objectSet = new WorkplacesSet(result, this);

            AddToCache(KeyBuilder.Build(KeyType.Workplaces, id), objectSet);

            return objectSet;
        }

        public async Task<IProductsSet> ProductsAsync(int workplaceId)
        {
            var objectSet = GetFromCache<IProductsSet>(KeyBuilder.Build(KeyType.Products, workplaceId.ToString()));

            if (objectSet != null) return objectSet;

            var result = await _client.Workplaces[workplaceId].Products.Request().GetAsync();

            objectSet = new ProductsSet(result, workplaceId, this);

            AddToCache(KeyBuilder.Build(KeyType.Products, workplaceId.ToString()), objectSet);

            return objectSet;
        }

        public async Task<IPropertySetsSet> PropertySetsAsync(int productId)
        {
            var objectSet = GetFromCache<IPropertySetsSet>(KeyBuilder.Build(KeyType.PropertySets, productId.ToString()));

            if (objectSet != null) return objectSet;

            var result = await _client.Products[productId].PropertySets.Request().PostAsync();

            objectSet = new PropertySetsSet(result, productId, this);

            AddToCache(KeyBuilder.Build(KeyType.PropertySets, productId.ToString()), objectSet);

            return objectSet;
        }

        public async Task<IPropertiesSet> PropertiesAsync(int productId, string propertySetId)
        {
            var objectSet =
                GetFromCache<PropertiesSet>(KeyBuilder.Build(KeyType.Properties, $"{productId}-{propertySetId}"));

            if (objectSet != null) return objectSet;

            var result = await _client.Products[productId].PropertySets[propertySetId].Properties.Request().PostAsync();

            objectSet = new PropertiesSet(result, productId, propertySetId, this);

            AddToCache(KeyBuilder.Build(KeyType.Properties, $"{productId}-{propertySetId}"), objectSet);

            return objectSet;
        }

        private void AddToCache<T>(string key, T item)
        {
            var policy = new CoBuilderCacheItemPolicy();

            _cache.Add(key, item, policy);
        }

        private T GetFromCache<T>(string key)
        {
            return (T)_cache.Get(key);
        }
    }
}