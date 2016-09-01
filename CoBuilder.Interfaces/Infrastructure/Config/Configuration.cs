using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Infrastructure.Structures;
using CoBuilder.Service.Interfaces;
using IConfiguration = CoBuilder.Service.Interfaces.IConfiguration;

namespace CoBuilder.Service.Infrastructure.Config
{

    public class Configuration : IConfiguration
    {
        private Guid _configId;
        private string _name;
        private string _author;

        //private readonly IDictionary<DefinitionKey, IDefinition> _definitions;
        private readonly IConfigDefinition _root;
        

        public Configuration(string name, string author)
        {
            _configId = Guid.NewGuid();
            _name = name;
            _author = author;

            var root = GenerateRoot();
            //_definitions = new Dictionary<DefinitionKey, IDefinition> { {KeyBuilder.Build(root), root}};
            _root = root;
        }

        private IConfigDefinition GenerateRoot()
        {
            return new ConfigDefinition()
            {
                DisplayName = Name,
                Identifier = ConfigId.ToString()
            };
        }


        public Guid ConfigId
        {
            get { return _configId; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Author
        {
            get { return _author; }
        }
        public IConfigDefinition Root
        {
            get { return _root; }
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
    }
}
