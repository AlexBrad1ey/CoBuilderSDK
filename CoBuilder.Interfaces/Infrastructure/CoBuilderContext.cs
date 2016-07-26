using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Sets;

namespace CoBuilder.Service.Infrastructure
{
    public class CoBuilderContext
    {
        private readonly ICoBuilderClient _client;
        private ObjectCache _cache = MemoryCache.Default;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderContext"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <exception cref="CoBuilderException"></exception>
        /// <exception cref="Error"></exception>
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

            var objectSet =     GetFromCache(KeyBuilder.Build(KeyType.Workplaces,_client.CurrentSession.ContactId));

            if (objectSet != null) return objectSet;

            objectSet = await _client.Workplaces.Request().GetAsync();

            var a = new WorkplacesSet((IList<IWorkplace>)objectSet.Select(x => (Workplace)x));

            AddToCache(KeyBuilder.Build(KeyType.Workplaces, identifier), objectSet);

            return objectSet;
        }

        public async Task<IProductsSet> ProductsAsync(int workplaceId)
        {

            var objectSet =     GetFromCache(KeyBuilder.Build(KeyType.Products,identifier));

            if (objectSet != null) return objectSet;

            objectSet = await _client.workplaces[workplaceId].Products.Request().GetAsync();

            var a = new ProductsSet((IList<IBimProduct>)objectSet.Select(x => (BimProduct)x));

            AddToCache(KeyBuilder.Build(KeyType.Products, identifier), objectSet);

            return objectSet;
        }

        public async Task<IPropertySetsSet> PropertySetsAsync(int productId)
        {

            var objectSet =     GetFromCache(KeyBuilder.Build(KeyType.PropertySets,productId));

            if (objectSet != null) return objectSet;

            objectSet = await _client.Products[productId].Request().GetAsync();

            var a = new PropertySetsSet((IList<IPropertySet>)objectSet.Select(x => (PropertySet)x));

            AddToCache(KeyBuilder.Build(KeyType.PropertySets, productId), objectSet);

            return objectSet;
        }

        public async Task<IPropertiesSet> PropertiesAsync(int productId, int propertySetId)
        {

            var objectSet =     GetFromCache(KeyBuilder.Build(KeyType.Properties,$"{productId}-{propertySet Id}"));

            if (objectSet != null) return objectSet;

            objectSet = await _client.Products[productId].Request().GetAsync();

            var a = new PropertySetsSet((IList<IPropertySet>)objectSet.Select(x => (PropertySet)x));

            AddToCache(KeyBuilder.Build(KeyType.PropertySets, productId), objectSet);

            return objectSet;
        }




09o76             
        private void AddToCache<T>(string key, T item)
        {
            var policy = new CacheItemPolicy()
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(Constants.Caching.AbsoluteEvictionMinutes),
                SlidingExpiration = TimeSpan.FromMinutes(Constants.Caching.SlidingEvictionMinutes)
            };

            _cache.Add(key, item, policy);
        }

        private T GetFromCache<T>(string key)
        {
           return (T) _cache.Get(key);
        }


        public void ProductsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class ProductsSet: IProductsSet
    {
        public ProductsSet(IProductsCollection productsCollection)
        {
            throw new NotImplementedException();
        }
    }

    public interface IProductsSet
    {
    }

    internal enum KeyType
    {
        Workplaces,
        Products,
        PropertySet,
        Properties
    }

    internal static class KeyBuilder
    {
        public static string Build(KeyType type, string identifier)
        {
            return string.Join(Constants.Caching.Delimiter,type.ToString(),identifier);
        }
    }
}
}
