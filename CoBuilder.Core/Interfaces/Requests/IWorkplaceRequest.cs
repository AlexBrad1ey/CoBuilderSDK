using System.Threading.Tasks;
using CoBuilder.Core.Domain;

namespace CoBuilder.Core.Interfaces
{
    public interface IWorkplaceRequest : IBaseRequest
    {
        Task<IWorkplace> GetAsync();
        int WorkplaceId { get; set; }
    }
}