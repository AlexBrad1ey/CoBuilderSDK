using System;
using System.Threading.Tasks;

namespace CoBuilder.Core.Interfaces
{
    public interface IWorkplacesCollectionRequest : IBaseRequest
    {
        Task<IWorkplacesCollection> GetAsync();
        Guid AppId { get; set; }
    }
}