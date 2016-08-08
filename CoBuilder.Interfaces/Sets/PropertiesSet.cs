using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Infrastructure;

namespace CoBuilder.Service.Sets
{
    public class PropertiesSet : BaseSet<IBimProperty>, IPropertiesSet
    {
        public PropertiesSet(IPropertiesCollection collection, int productId, string propertySetId, CoBuilderContext ctx)
            : base((IList<IBimProperty>) collection.Select(x => new BimProperty(x, productId, propertySetId, ctx)))
        {
            
        }
    }
}