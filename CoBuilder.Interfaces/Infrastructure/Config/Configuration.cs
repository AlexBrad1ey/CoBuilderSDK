using System;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;
using IConfiguration = CoBuilder.Service.Interfaces.IConfiguration;

namespace CoBuilder.Service.Infrastructure.Config
{

    public class Configuration : IConfiguration
    {
        //private readonly IDictionary<DefinitionKey, IDefinition> _definitions;
        private readonly IConfigDefinition _root;
        

        public Configuration()
        {
            ConfigId = Guid.NewGuid();
        }

        private IConfigDefinition GenerateRoot()
        {
            return new ConfigDefinition(this);

        }


        public Guid ConfigId { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }

        public IConfigDefinition Root
        {
            get { return _root ?? GenerateRoot(); }
        }

        public IPropertyDefinition AddProperty(IPropertyDefinition property, IPropertySetDefinition pSet)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            if (pSet == null) throw new ArgumentNullException(nameof(pSet));
            if (!Root.PropertySets.ContainsKey(KeyBuilder.Build(pSet))) throw new ArgumentException("Property Set Definition Not Present within Configuration",nameof(pSet));

            return pSet.AddProperty(property);
        }
        public IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet)
        {
            if (pSet == null) throw new ArgumentNullException(nameof(pSet));
            //if (_definitions.ContainsKey(KeyBuilder.Build(pSet))) throw new ArgumentException("Property Set Definition Already Present within Configuration", nameof(pSet));

            return Root.AddPropertySet(pSet);
        }

        public IConfiguration Save()
        {
            var serializer = new ConfigurationSerializer();
            serializer.Serialize(this, Constants.FilePathBase + ConfigId + Constants.ConfigFileType);
            return this;
        }

        public static IConfiguration Load(string filename)
        {
            var serializer = new ConfigurationSerializer();
            return serializer.Deserialize(filename);
        }
    }
}
