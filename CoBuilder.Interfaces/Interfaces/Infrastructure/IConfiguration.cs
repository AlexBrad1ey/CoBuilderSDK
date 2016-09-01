using System;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfiguration
    {
        string Author { get; }
        Guid ConfigId { get; }
        string Name { get; }
        IConfigDefinition Root { get; }

        IPropertyDefinition AddProperty(IPropertyDefinition property, IPropertySetDefinition pSet);
        IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet);
    }
}