using System.Collections.Generic;
using System.Threading.Tasks;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class PropertySetTagsCollectionRequest : BaseRequest, IPropertySetTagsCollectionRequest
    {
        public PropertySetTagsCollectionRequest(string requestResource, IBaseClient client, PluginApp appId = 0)
            : base(requestResource, client)
        {
            Parameters.Add(new Parameter {Name = Constants.Parameters.AppId, Value = appId, Type = ParameterType.GetOrPost });
        }


        public PluginApp AppId
        {
            get { return (PluginApp) Parameters.Find(p => p.Name == Constants.Parameters.AppId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.AppId).Value = value; }
        }

        public async Task<IList<IBimPropertySetTag>> GetAsync()
        {
            Method = Method.GET;
            var response = await SendAsync<GetPropertySetTagsResult>();

            if (response != null)
            {
                return new List<IBimPropertySetTag>(response.Tags);
            }

            return null;
        }
    }
}