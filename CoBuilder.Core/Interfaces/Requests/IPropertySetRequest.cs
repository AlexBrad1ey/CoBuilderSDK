using System.Threading.Tasks;
using CoBuilder.Core.Domain;

namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetRequest : IBaseRequest
    {
        string PropertySetId { get; set; }
        Task<IBimPropertySet> PostAsync();
    }
}