using System;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Infrastructure;

namespace CoBuilder.Service.Sets
{
    public class PropertySetsSet : BaseSet<IBimPropertySet>, IPropertySetsSet
    {
        private ICoBuilderContext _ctx;
        private int _productId;

        public PropertySetsSet(int productId, ICoBuilderContext ctx)
        {
            _productId = productId;
            _ctx = ctx;
        }

        public PropertySetsSet(IPropertySetCollection collection, int productId, ICoBuilderContext ctx)
            : base(collection.Select(x => (IBimPropertySet)new BimPropertySet(x,productId,ctx)).ToList())
        {
            _productId = productId;
            _ctx = ctx;
        }

        public IBimPropertySet this[string id]
        {
            get
            {
                return Items.FirstOrDefault(pSet => pSet.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase));
            }
        }

        public int ProductId
        {
            get { return _productId; }
        }

        internal ICoBuilderContext Ctx
        {
            get { return _ctx; }
        }
    }
}