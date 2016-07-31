using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimProperty : IBimProperty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public ICoBuilderContext Context { get; set; }

        public static explicit operator BimProperty(Core.Domain.BimProperty property)
        {
            return new BimProperty()
            {
                Id = property.Id,
                Name = property.Name,
                Value = property.Value,
                Unit = property.Unit
            };
        }
    }
}