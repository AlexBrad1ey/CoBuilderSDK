using System.Collections.Generic;
using System.Threading.Tasks;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetTagsCollectionRequest : IBaseRequest
    {
        PluginApp AppId { get; }
        Task<IList<IBimPropertySetTag>> GetAsync();
    }
}