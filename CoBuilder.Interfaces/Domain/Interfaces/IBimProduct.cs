using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public interface IBimProduct : Core.Domain.IBimProduct, IEntity
    {
        IPropertySetsSet PropertySets { get; }
        int WorkplaceId { get; }
        int ProductId { get; }
    }
}