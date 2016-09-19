using CoBuilder.Service.Infrastructure;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimProperty : IBimProperty
    {
        public BimProperty(Core.Domain.IBimProperty property, int productId, string propertySetId)
        {
            Id = property.Id;
            Name = property.Name;
            Value = property.Value;
            Unit = property.Unit;
            ProductId = productId;
            PropertySetId = propertySetId;
        }

        public BimProperty(Core.Domain.IBimProperty property, int productId, string propertySetId, CoBuilderContext ctx): this(property,productId,propertySetId)
        {
            Context = ctx;
        }

        public ICoBuilderContext Context { get; internal set; }

        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Value { get; internal set; }
        public string Unit { get; internal set; }

        public int ProductId { get; internal set; }
        public string PropertySetId { get; internal set; }
    }
}