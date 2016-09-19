using System.Collections.Generic;
using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfigDefinition :IDefinition
    {
        IDictionary<string, PropertySetDefinition> PropertySets { get;}
        IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet);
        bool RemovePropertySet(IPropertySetDefinition propertySet);
    }
}