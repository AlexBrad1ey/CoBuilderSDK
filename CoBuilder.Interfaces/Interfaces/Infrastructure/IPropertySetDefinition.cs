using System.Collections.Generic;
using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IPropertySetDefinition: IDefinition
    {
        IDictionary<string, PropertyDefinition> Properties { get; }
        string PSetId { get; set; }
        IPropertyDefinition AddProperty(IPropertyDefinition property);
        bool RemoveProperty(IPropertyDefinition property);
    }
}