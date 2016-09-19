using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Sets
{
    public class ProductsSet : BaseSet<IBimProduct>, IProductsSet
    {
        private SupplierSet _suppliers;

        public ProductsSet(IProductsCollection collection, int workplaceId, ICoBuilderContext ctx)
            : base(collection.Select(x => (IBimProduct)(new BimProduct(x, workplaceId, ctx))).ToList())
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