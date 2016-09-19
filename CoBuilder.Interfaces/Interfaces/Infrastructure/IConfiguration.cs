using System;
using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfiguration
    {
        string Author { get; set; }
        Guid ConfigId { get; }
        string Name { get; set; }
        ConfigDefinition Root { get; }

        IPropertyDefinition AddProperty(IPropertyDefinition property, IPropertySetDefinition pSet);
        IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet);
        IConfiguration Save();   
    }
}