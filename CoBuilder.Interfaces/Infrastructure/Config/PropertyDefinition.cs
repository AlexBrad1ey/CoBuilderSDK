using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class PropertyDefinition : Definition,IPropertyDefinition
    {
        public PropertyDefinition() : base(DefinitionType.Property)
        {
        }

        public string ConnectedProperty { get; set; }
    }
}