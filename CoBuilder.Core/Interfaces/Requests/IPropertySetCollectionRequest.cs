using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetCollectionRequest : IBaseRequest
    {
        int ProductId { get; }
        IList<int> PropertySetIds { get; }
        Task<IPropertySetCollection> PostAsync();
    }
}