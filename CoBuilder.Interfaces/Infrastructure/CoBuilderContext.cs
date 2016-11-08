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
                throw new CoBuilderException(new Error
                {
                    Code = CoBuilderErrorCode.AuthenticationFailure.ToString(),
                    Message = "Context Requires an Authenticated Client"
                });
        }

        public IWorkplacesSet Workplaces()
        {
            var id = _client.CurrentSession.ContactId.ToString();
            var objectSet = GetFromCache<IWorkplacesSet>(KeyBuilder.Build(KeyType.Workplaces, id));

            if (objectSet != null) return objectSet;

            var result = _client.Workplaces.Request().GetAsync().Result;


            if (result != null)
            {
                objectSet = new WorkplacesSet(result, this);

                AddToCache(KeyBuilder.Build(KeyType.Workplaces, id), objectSet);
            }
            else
            {
                objectSet = new WorkplacesSet(this);
            }

            return objectSet;
        }

        public IProductsSet Products(int workplaceId)
        {
            var objectSet = GetFromCache<IProductsSet>(KeyBuilder.Build(KeyType.Products, workplaceId.ToString()));

            if (objectSet != null) return objectSet;

            var result =  _client.Workplaces[workplaceId].Products.Request().GetAsync().Result;


            if (result != null)
            {
                objectSet = new ProductsSet(result, workplaceId, this);

                AddToCache(KeyBuilder.Build(KeyType.Products, workplaceId.ToString()), objectSet);
            }
            else
            {
                objectSet = new ProductsSet(workplaceId, this);
            }

            return objectSet;
        }

        public IPropertySetsSet PropertySets(int productId)
        {
            var objectSet = GetFromCache<IPropertySetsSet>(KeyBuilder.Build(KeyType.PropertySets, productId.ToString()));

            if (objectSet != null) return objectSet;

            var result = _client.Products[productId].PropertySets.Request().PostAsync().Result;

            if (result != null)
            {
                objectSet = new PropertySetsSet(result, productId, this);

                AddToCache(KeyBuilder.Build(KeyType.PropertySets, productId.ToString()), objectSet);
            }
            else
            {
                objectSet = new PropertySetsSet(productId, this);
            }

            return objectSet;
        }

        public IPropertiesSet Properties(int productId, string propertySetId)
        {
            var objectSet =
                GetFromCache<PropertiesSet>(KeyBuilder.Build(KeyType.Properties, $"{productId}-{propertySetId}"));

            if (objectSet != null) return objectSet;

            var result = _client.Products[productId].PropertySets[propertySetId].Properties.Request().PostAsync().Result;

            if (result != null)
            {
                objectSet = new PropertiesSet(result, productId, propertySetId, this);

                AddToCache(KeyBuilder.Build(KeyType.Properties, $"{productId}-{propertySetId}"), objectSet);
            }
            else
            {
                objectSet = new PropertiesSet(productId, propertySetId, this);
            }

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