using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IPropertySetsSet : ICBSet<IBimPropertySet>
    {
        IBimPropertySet this[string id] { get; }
    }
}