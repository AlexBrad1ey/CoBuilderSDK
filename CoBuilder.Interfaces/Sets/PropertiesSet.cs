using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoBuilder.Service.Sets
{
    public class PropertiesSet : BaseSet<IBimProperty>, IPropertiesSet
    {
        public PropertiesSet(IPropertiesCollection collection, ICoBuilderContext ctx)
            : base((IList<IBimProperty>)collection.Select(x => (BimProperty)x), ctx)
        {
        }

        public PropertiesSet(IList<IBimProperty> entitySet, ICoBuilderContext ctx) : base(entitySet, ctx)
        {
        }
    }
}