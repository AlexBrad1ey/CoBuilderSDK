using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class PropertySetDefinition : Definition, IPropertySetDefinition
    {
        public PropertySetDefinition() : base(DefinitionType.PropertySet)
        {
            Properties = new Dictionary<string, PropertyDefinition>();
        }

        public IDictionary<string, PropertyDefinition> Properties { get; }
        public string PSetId { get; set; }

        public IPropertyDefinition AddProperty(IPropertyDefinition property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            var key = property.Identifier;

            if (Properties.ContainsKey(key)) throw new ArgumentException("Property Definition with the Same Key Identifier already Present", nameof(property));
            Properties.Add(key, (PropertyDefinition) property);
            return property;
        }

        public bool RemoveProperty(IPropertyDefinition property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            var key = property.Identifier;
            return Properties.Remove(key);

        }

        public IPropertyDefinition GetPropertyByName(string name)
        {
            return Properties.FirstOrDefault(k => k.Value.DisplayName == name).Value;
        }

        public IPropertyDefinition GetPropertyByIdentifier(string identifier)
        {
            return Properties.FirstOrDefault(k => k.Value.Identifier == identifier).Value;
        }

        public bool HasProperty(PropertyDefinition definition)
        {
            return definition != null && Properties.ContainsKey(definition.Identifier);
        }
    }
}