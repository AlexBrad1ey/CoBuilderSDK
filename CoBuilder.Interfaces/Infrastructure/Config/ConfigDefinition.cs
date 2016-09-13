using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class ConfigDefinition : IConfigDefinition, IDisposable
    {
        private readonly DefinitionType _definitionType;

        protected ConfigDefinition(DefinitionType definitionType)
        {
            _definitionType = definitionType;
            Constraints = new List<IConstraint>();
        }

        public DefinitionType DefinitionType
        {
            get { return _definitionType; }
        }

        public string DisplayName
        {
            get { return _config.Name; }
            set { _config.Name = value; }
        }

        public string Identifier
        {
            get { return _config.ConfigId.ToString(); }
            set {  }
        }

        public bool Visible { get; set; }

        public IList<IConstraint> Constraints { get; set; }

        private readonly Configuration _config;

        public ConfigDefinition(Configuration config) : this(DefinitionType.Configuration)
        {
            _config = config;
            PropertySets = new ObservableDictionary<DefinitionKey, IPropertySetDefinition>();
            PropertySets.CollectionChanged += PropertySetsOnCollectionChanged;
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

        public bool RemovePropertySet(IPropertySetDefinition propertySet)
        {
            if (propertySet == null) throw new ArgumentNullException(nameof(propertySet));
            var key = KeyBuilder.Build(propertySet);
            return PropertySets.Remove(key);
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