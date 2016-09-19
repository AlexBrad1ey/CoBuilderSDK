using System;
using System.IO;
using System.Reflection;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;
using IConfiguration = CoBuilder.Service.Interfaces.IConfiguration;

namespace CoBuilder.Service.Infrastructure.Config
{

    public class Configuration : IConfiguration
    {
        //private readonly IDictionary<DefinitionKey, IDefinition> _definitions;
        private ConfigDefinition _root;
        

        public Configuration()
        {
            ConfigId = Guid.NewGuid();
        }

        private ConfigDefinition GenerateRoot()
        {
            _root = new ConfigDefinition(this);
            return _root;

        }


        public Guid ConfigId { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }

        public ConfigDefinition Root
        {
            get { return _root ?? GenerateRoot(); }
        }

        public IPropertyDefinition AddProperty(IPropertyDefinition property, IPropertySetDefinition pSet)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            if (pSet == null) throw new ArgumentNullException(nameof(pSet));

            return pSet.AddProperty(property);
        }
        public IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet)
        {
            if (pSet == null) throw new ArgumentNullException(nameof(pSet));

            return Root.AddPropertySet(pSet);
        }

        public IConfiguration Save()
        {
            var serializer = new ConfigurationSerializer();
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var dirPath = Path.Combine(Path.GetDirectoryName(path), "Configurations", ConfigId + Constants.ConfigFileType);
            serializer.Serialize(this, dirPath);
            return this;
        }

        public static IConfiguration Load(string filename)
        {
            var serializer = new ConfigurationSerializer();
            return serializer.Deserialize(filename);
        }
    }
}
