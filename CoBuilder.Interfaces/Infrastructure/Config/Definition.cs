using System.Collections.Generic;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
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
}