using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IProductsRepository: IReadOnlyRepository<IBimProduct, int>
    {
    }
}