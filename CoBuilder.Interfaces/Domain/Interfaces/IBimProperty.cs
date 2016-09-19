namespace CoBuilder.Service.Domain
{
    public interface IBimProperty : Core.Domain.IBimProperty, IEntity
    {
        int ProductId { get; }
        string PropertySetId { get; }
    }
}