using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Repositories
{
    public class ProductsRepository: IProductsRepository
    {
        private readonly IProductsSet _productsSet;

        public ProductsRepository(ICoBuilderContext ctx,IServiceSession session)
        {
            _productsSet = ctx.ProductsAsync(session.CurrentWorkplaceId).Result;
        }

        public IBimProduct Get(int key)
        {
            return _productsSet.FirstOrDefault(x => x.Id == key);
        }

        public IEnumerable<IBimProduct> FindAll()
        {
            return _productsSet;
        }

        public IBimProduct this[int key]
        {
            get { return Get(key); }
        }

        public IEnumerable<string> Suppliers()
        {
            return _productsSet.Suppliers;
        }
    }
}