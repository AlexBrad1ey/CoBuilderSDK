using System;
using System.Collections.Specialized;
using System.Linq;
using CoBuilder.Core.RestModels;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class ConfigDefinition : Definition,IConfigDefinition, IDisposable
    {
        public ConfigDefinition() : base(DefinitionType.Configuration)
        {
            PropertySets = new ObservableDictionary<DefinitionKey, IPropertySetDefinition>();
            PropertySets.CollectionChanged += PropertySetsOnCollectionChanged;
        }

        public ConfigDefinition(IObservableDictionary<DefinitionKey, IPropertySetDefinition> propertySets) : base(DefinitionType.Configuration)
        {
            PropertySets = propertySets;
        }


        public IObservableDictionary<DefinitionKey, IPropertySetDefinition> PropertySets { get; }
        public IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet)
        {
            if (pSet == null) throw new ArgumentNullException(nameof(pSet));
            var key = KeyBuilder.Build(pSet);

            if (PropertySets.ContainsKey(key)) throw new ArgumentException("Property Set Definition with the Same Key Identifier already Present", nameof(pSet));
            PropertySets.Add(KeyBuilder.Build(pSet),pSet);
            return pSet;
        }
        public IPropertySetDefinition GetPropertySetByName(string name)
        {
            return PropertySets.FirstOrDefault(k => k.Key.DisplayName == name).Value;
        }
        public IPropertySetDefinition GetPropertySetByIdentifier(string identifier)
        {
            return PropertySets.FirstOrDefault(k => k.Key.Identifier == identifier).Value;
        }
        public void Dispose()
        {
            if (PropertySets != null)
            {
                PropertySets.CollectionChanged -= PropertySetsOnCollectionChanged;
            }
        }

        private void PropertySetsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
        }
    }
}