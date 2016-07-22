using System.Threading.Tasks;

namespace CoBuilder.Core.Interfaces
{
    public interface IProductsCollectionRequest : IBaseRequest
    {
        Task<IProductsCollection> GetAsync();
        int WorkplaceId { get; set; }
        int CountryIndex { get; set; }
        Task<IProductsCollection> PostAsync();
    }
}