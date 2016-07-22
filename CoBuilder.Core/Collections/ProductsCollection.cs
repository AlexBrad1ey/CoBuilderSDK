using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    public class ProductsCollection : ReadOnlyCollection<BimProduct>, IProductsCollection
    {
        public ProductsCollection(IList<BimProduct> products): base(products)
        { 
        }
    }
}