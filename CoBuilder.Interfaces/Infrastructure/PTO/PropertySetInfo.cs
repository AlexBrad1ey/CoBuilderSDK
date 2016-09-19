using System.Collections.Generic;

namespace CoBuilder.Service.Infrastructure.PTO
{
    public class PropertySetInfo : Info
    {
        public PropertySetInfo()
        {
            Properties = new Dictionary<string, PropertyInfo>();
        }

        public Dictionary<string, PropertyInfo> Properties { get; }
        public void AddProperty(PropertyInfo property)
        {
            Properties.Add(property.Identifier, property);
        }
    }
}
