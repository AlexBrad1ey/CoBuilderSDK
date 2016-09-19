using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public interface IWorkplace : Core.Domain.IWorkplace, IEntity
    {
        IProductsSet Products { get; }
    }
}