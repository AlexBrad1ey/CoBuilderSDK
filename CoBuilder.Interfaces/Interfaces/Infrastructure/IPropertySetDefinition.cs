using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IPropertySetDefinition: IDefinition
    {
        IObservableDictionary<DefinitionKey, IPropertyDefinition> Properties { get; }
        IPropertyDefinition AddProperty(IPropertyDefinition property);
        bool RemoveProperty(IPropertyDefinition property);
    }
}