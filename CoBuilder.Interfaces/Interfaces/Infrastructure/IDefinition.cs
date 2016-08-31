using System.Collections.Generic;
using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IDefinition
    {
        DefinitionType DefinitionType { get; }
        string DisplayName { get; }
        string Identifier { get; }
        IList<IConstraint> Constraints { get; } 

    }
}