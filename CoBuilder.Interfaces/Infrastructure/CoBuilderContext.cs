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
            var objectSet =
                await
                    GetObjectSetAsync(KeyType.Workplaces, _client.CurrentSession.ContactId,
                        _client.Workplaces.Request().GetAsync());
            var a = new WorkplacesSet((IList<IWorkplace>)objectSet.Select(x => (Workplace)x));

            return new WorkplacesSet((IList<IWorkplace>) objectSet.Select(x => (Workplace) x));
        }


        public async Task<IPropertySetsSet> PropertySetsAsync(int productId)
        {
            return
                await
                    GetObjectSetAsync(KeyType.Products, productId,
                        _client.Products[productId].PropertySets.Request().GetAsync());
        }


        private async Task<T> GetObjectSetAsync<T>(KeyType type, object identifier, Task<T> retrieve)
        {
            var objectSet = GetFromCache<T>(KeyBuilder.Build(type,identifier));

            if (objectSet != null) return objectSet;

            objectSet = await retrieve;

            AddToCache(KeyBuilder.Build(type, identifier), objectSet);

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
        Products
    }

    internal static class KeyBuilder
    {
        public static string Build(KeyType type, object identifier)
        {
            return string.Join(Constants.Caching.Delimiter,type.ToString(),identifier);
        }
    }
}
}
