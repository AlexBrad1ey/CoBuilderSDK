using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoBuilder.Service.Sets
{
    public class PropertySetsSet : BaseSet<IBimPropertySet>, IPropertySetsSet
    {
        public PropertySetsSet(IPropertySetCollection collection, int productId, ICoBuilderContext ctx)
            : base((IList<IBimPropertySet>)collection.Select(x => new BimPropertySet(x,productId,ctx)))
        {

        }
    }
}