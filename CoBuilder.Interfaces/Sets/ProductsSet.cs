using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoBuilder.Service.Sets
{
    public class ProductsSet : BaseSet<IBimProduct>, IProductsSet
    {
        public ProductsSet(IProductsCollection collection, ICoBuilderContext ctx)
            : base((IList<IBimProduct>)collection.Select(x => (BimProduct)x), ctx)
        {
        }

        public ProductsSet(IList<IBimProduct> entitySet, ICoBuilderContext ctx) : base(entitySet, ctx)
        {
        }
    }
}