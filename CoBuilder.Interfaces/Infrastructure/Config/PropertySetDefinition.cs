using System;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class PropertySetDefinition : Definition, IPropertySetDefinition,IDisposable
    {
        public PropertySetDefinition() : base(DefinitionType.PropertySet)
        {
            Properties = new ObservableDictionary<DefinitionKey, IPropertyDefinition>();
            Properties.CollectionChanged += PropertiesOnCollectionChanged;
        }

        public string PSetId { get; set; }

        public IObservableDictionary<DefinitionKey, IPropertyDefinition> Properties { get; }
        public IPropertyDefinition AddProperty(IPropertyDefinition property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            var key = KeyBuilder.Build(property);

            if (Properties.ContainsKey(key)) throw new ArgumentException("Property Definition with the Same Key Identifier already Present", nameof(property));
            Properties.Add(KeyBuilder.Build(property), property);
            return property;
        }

        public IPropertyDefinition GetPropertyByName(string name)
        {
            return Properties.FirstOrDefault(k => k.Value.DisplayName == name).Value;
        }

        public IPropertyDefinition GetPropertyByIdentifier(string identifier)
        {
            return Properties.FirstOrDefault(k => k.Value.Identifier == identifier).Value;
        }

        public void Dispose()
        {
            if (Properties != null)
            {
                Properties.CollectionChanged -= PropertiesOnCollectionChanged;
            }
        }

        private void PropertiesOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
        }
    }
}