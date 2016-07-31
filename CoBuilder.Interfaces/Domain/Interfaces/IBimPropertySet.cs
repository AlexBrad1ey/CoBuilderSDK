using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public interface IBimPropertySet : Core.Domain.IBimPropertySet, IEntity
    {
        IPropertiesSet Properties { get; }
    }
}