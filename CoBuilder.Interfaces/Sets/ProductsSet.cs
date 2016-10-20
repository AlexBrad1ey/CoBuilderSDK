using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Sets
{
    public class ProductsSet : BaseSet<IBimProduct>, IProductsSet
    {
        private ICoBuilderContext _ctx;
        private int _workplaceId;
        private SupplierSet _suppliers;

        public ProductsSet(int workplaceId, ICoBuilderContext ctx)
        {
            _workplaceId = workplaceId;
            _ctx = ctx;
        }

        public ProductsSet(IProductsCollection collection, int workplaceId, ICoBuilderContext ctx)
            : base(collection.Select(x => (IBimProduct)(new BimProduct(x, workplaceId, ctx))).ToList())
        {
            _workplaceId = workplaceId;
            _ctx = ctx;
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

        internal ICoBuilderContext Ctx
        {
            get { return _ctx; }
        }

        public int WorkplaceId
        {
            get { return _workplaceId; }
        }
    }

    public class SupplierSet:ReadOnlyCollection<string>
    {
        public SupplierSet(IList<string> suppliers) : base(suppliers)
        {
        }
    }
}