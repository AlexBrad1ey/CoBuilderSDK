using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Sets
{
    public class ProductsSet : BaseSet<IBimProduct>, IProductsSet
    {
        private SupplierSet _suppliers;

        public ProductsSet(IProductsCollection collection, int workplaceId, ICoBuilderContext ctx)
            : base((IList<IBimProduct>) collection.Select(x => new BimProduct(x, workplaceId, ctx)))
        {
        }

        public SupplierSet Suppliers
        {
            get
            {
                if (_suppliers != null) return _suppliers;
                _suppliers = new SupplierSet(Items.GroupBy(b => b.SupplierName).Select(s => s.Key).ToList());
                return _suppliers;
            }
        }
    }

    public class SupplierSet:ReadOnlyCollection<string>
    {
        public SupplierSet(IList<string> suppliers) : base(suppliers)
        {
        }
    }
}