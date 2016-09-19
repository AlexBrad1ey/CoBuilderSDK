using System;
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
            : base(collection.Select(x => (IBimPropertySet)new BimPropertySet(x,productId,ctx)).ToList())
        {

        }

        public IBimPropertySet this[string id]
        {
            get
            {
                return Items.FirstOrDefault(pSet => pSet.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase));
            }
        }
    }
}