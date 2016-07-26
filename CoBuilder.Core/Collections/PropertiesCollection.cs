using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    public class PropertiesCollection : ReadOnlyCollection<BimProperty>, IPropertiesCollection
    {
        public PropertiesCollection(IList<BimProperty> properties, int productld) : base(properties)
        {
ProductId = productId;

        }

public int ProductId {get; set; }

    }
}