using System.Linq;
using System.Threading.Tasks;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class WorkplaceRequest : BaseRequest, IWorkplaceRequest
    {
        public WorkplaceRequest(IWorkplacesCollectionRequest request, int workplaceId)
            : base(request.RequestResource, request.Client)
        {
            WorkplaceId = workplaceId;
            Parameters = request.Parameters;
        }


        public int WorkplaceId { get; set; }


        public async Task<IWorkplace> GetAsync()
        {
            Method = Method.GET;
            var response = await SendAsync<GetWorkplaceDataResult>();

            return response?.WorkplaceData.FirstOrDefault(w => w.Id == WorkplaceId);
        }
    }
}