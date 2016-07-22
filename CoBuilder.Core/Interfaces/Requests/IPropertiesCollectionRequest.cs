using System.Threading.Tasks;

namespace CoBuilder.Core.Interfaces
{
    public interface IPropertiesCollectionRequest : IBaseRequest
    {
        int ProductId { get; set; }
        string PropertySetId { get; set; }
        Task<IPropertiesCollection> PostAsync();
    }
}