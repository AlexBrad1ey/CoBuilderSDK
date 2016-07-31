using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoBuilder.Service.Sets
{
    public class PropertySetsSet : BaseSet<BimPropertySet>, IPropertySetsSet
    {
        public PropertySetsSet(IPropertySetCollection collection, int productId, ICoBuilderContext ctx)
            : this((IList<BimPropertySet>)collection.Select(x => (BimPropertySet)x), ctx)
        {
            foreach (var item in Items)
            {
                item.ProductId = productId;
            }
        }

        public PropertySetsSet(IList<BimPropertySet> entitySet, ICoBuilderContext ctx) : base(entitySet, ctx)
        {
        }
    }
}