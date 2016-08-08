using CoBuilder.Core.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimPropertySet : IBimPropertySet
    {
        public BimPropertySet(Core.Domain.IBimPropertySet pSet, int productId)
        {
            Id = pSet.Id;
            Name = pSet.Name;
            TagId = pSet.TagId;
            TagName = pSet.TagName;
            ProductId = productId;
        }

        public BimPropertySet(Core.Domain.IBimPropertySet pSet, int productId, ICoBuilderContext ctx) : this(pSet, productId)
        {
            Context = ctx;
        }

        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public int TagId { get; internal set; }
        public string TagName { get; internal set; }
        public int ProductId { get; internal set; }

        public virtual IPropertiesSet Properties
        {
            get { return Context.PropertiesAsync(ProductId, Id).Result; }
        }

        public ICoBuilderContext Context { get; internal set; }
    }
}