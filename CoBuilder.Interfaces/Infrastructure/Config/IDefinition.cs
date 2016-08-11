using System.Collections.Generic;

namespace CoBuilder.Service.Infrastructure.Config
{
    public interface IDefinition
    {
        DefinitionType DefinitionType { get; }
        string DisplayName { get; }
        string Identifier { get; }
        IList<IConstraint> Constraints { get; } 

    }

    public interface IConstraint
    {
    }
}