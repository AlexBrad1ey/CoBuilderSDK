using System;
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
        private readonly int _productId;
        private readonly string _propertySetId;
        private readonly ICoBuilderContext _ctx;

        public PropertiesSet(int productId, string propertySetId, ICoBuilderContext ctx)
        {
            _productId = productId;
            _propertySetId = propertySetId;
            _ctx = ctx;
        }

        public PropertiesSet(IPropertiesCollection collection, int productId, string propertySetId, ICoBuilderContext ctx)
            : base((IList<IBimProperty>) collection.Select(x => (IBimProperty)new BimProperty(x, productId, propertySetId, ctx)).ToList())
        {
            _productId = productId;
            _propertySetId = propertySetId;
            _ctx = ctx;
        }

        public IBimProperty this[string id]
        {
            get { return Items.FirstOrDefault(p => p.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase)); }
        }

        public int ProductId
        {
            get { return _productId; }
        }

        public string PropertySetId
        {
            get { return _propertySetId; }
        }

        internal ICoBuilderContext Ctx
        {
            get { return _ctx; }
        }
    }
}