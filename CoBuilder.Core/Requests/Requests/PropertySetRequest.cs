using System.Linq;
using System.Threading.Tasks;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class PropertySetRequest : BaseRequest, IPropertySetRequest
    {
        public PropertySetRequest(IPropertySetCollectionRequest request, string propertySetId)
            : base(request.RequestResource, request.Client)
        {
            PropertySetId = propertySetId;
            Parameters = request.Parameters;
        }


        public string PropertySetId { get; set; }

        //PARENT says POST??
        public async Task<IBimPropertySet> PostAsync()
        {
            Method = Method.POST;
            var response = await SendAsync<GetProductPropertySetsResult>();

            return response?.PropertySets.FirstOrDefault(w => w.Id == PropertySetId);
        }
    }
}