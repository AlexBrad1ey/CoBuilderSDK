using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IPropertiesSet : ICBSet<IBimProperty>
    {
        IBimProperty this[string id] { get; }
    }
}