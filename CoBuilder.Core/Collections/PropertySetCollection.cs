using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    public class PropertySetCollection : ReadOnlyCollection<BimPropertySet>, IPropertySetCollection
    {
        public PropertySetCollection(IList<BimPropertySet> propertySets) : base(propertySets)
        {
        }
    }
}