using System;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfiguration
    {
        string Author { get; set; }
        Guid ConfigId { get; }
        string Name { get; set; }
        IConfigDefinition Root { get; }

        IPropertyDefinition AddProperty(IPropertyDefinition property, IPropertySetDefinition pSet);
        IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet);
        IConfiguration Save();   
    }
}