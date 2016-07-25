namespace CoBuilder.Service.Domain
{
    public interface IBimProduct: Core.Domain.IBimProduct
    {
        PropertySetsSet PropertySets { get; }
    }
}