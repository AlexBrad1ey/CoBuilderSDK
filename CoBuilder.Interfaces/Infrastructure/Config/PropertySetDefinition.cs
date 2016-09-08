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

            //Mandatory Properties
            AddProperty(new PropertyDefinition()
            {
                ConnectedProperty = Constants.Identifiers.Properties.ProductId,
                DisplayName = "ProductId",
                Visible = false,
                Identifier = Constants.Identifiers.Properties.ProductId
            });

            AddProperty(new PropertyDefinition()
            {
                ConnectedProperty = Constants.Identifiers.Properties.WorkplaceId,
                DisplayName = "WorkplaceId",
                Visible = false,
                Identifier = Constants.Identifiers.Properties.WorkplaceId
            });
        }

        public string PSetId { get; set; }

        public IObservableDictionary<DefinitionKey, IPropertyDefinition> Properties { get; }
        public IPropertyDefinition AddProperty(IPropertyDefinition property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            var key = KeyBuilder.Build(property);

            if (Properties.ContainsKey(key)) throw new ArgumentException("Property Definition with the Same Key Identifier already Present", nameof(property));
            Properties.Add(key, property);
            return property;
        }

        public bool RemoveProperty(IPropertyDefinition property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            var key = KeyBuilder.Build(property);
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