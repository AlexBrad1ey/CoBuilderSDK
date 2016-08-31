using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfigDefinition :IDefinition
    {
        IObservableDictionary<DefinitionKey,IPropertySetDefinition> PropertySets { get;}
        IPropertySetDefinition AddPropertySet(IPropertySetDefinition pSet);
    }
}