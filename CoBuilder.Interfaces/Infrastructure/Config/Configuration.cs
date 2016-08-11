using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.Infrastructure.Config
{

    public class Configuration
    {
        private readonly IDictionary<DefinitionKey, IDefinition> _definitions;
        private readonly PropertyTree _structure;

        public Configuration()
        {
            var root = GenerateRoot();

           _structure = new PropertyTree(new DefinitionNode(root));
            _definitions = new Dictionary<DefinitionKey, IDefinition> { {KeyBuilder.Build(root), root}};
        }

        private IDefinition GenerateRoot()
        {
            return new ConfigDefinition()
            {
                DisplayName = Name,
                Identifier = ConfigId.ToString()
            };
        }


        public Guid ConfigId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int WorkplaceId { get; set; }

        public PropertyTree Structure
        {
            get { return _structure; }
        }

        public IDictionary<DefinitionKey, IDefinition> Definitions   
        {
            get { return _definitions; }
        }
    }

    public interface IPropertyDefinition :IDefinition
    {
    }

    public enum DefinitionType
    {
        Property,
        Configuration,
        PropertySet
    }

    public class Definition : IDefinition
    {
        private readonly DefinitionType _definitionType;

        protected Definition(DefinitionType definitionType)
        {
            _definitionType = definitionType;
            Constraints = new List<IConstraint>();
        }

        public DefinitionType DefinitionType
        {
            get { return _definitionType; }
        }

        public string DisplayName { get; set; }
        public string Identifier { get; set;  }
        public IList<IConstraint> Constraints { get; set; }
    }

    public class PropertyDefinition : Definition
    {
        public PropertyDefinition() : base(DefinitionType.Property)
        {
        }
    }

    public class ConfigDefinition : Definition
    {
        public ConfigDefinition() : base(DefinitionType.Configuration)
        {
        }
    }

    public class DefinitionKey
    {
        public string DisplayName { get; set; }
        public string Identifier { get; set; }
    }

    public class PropertySetDefinition : Definition
    {
        public PropertySetDefinition() : base(DefinitionType.PropertySet)
        {
        }
    }
}
