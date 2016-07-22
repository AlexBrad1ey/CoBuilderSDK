using System;
using System.Threading.Tasks;
using CoBuilder.Core.Collections;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class WorkplacesCollectionRequest : BaseRequest, IWorkplacesCollectionRequest
    {
        public WorkplacesCollectionRequest(string requestUrl, IBaseClient client, Guid contactId)
            : base(requestUrl, client)
        {
            Parameters.Add(new Parameter {Name = Constants.Parameters.ContactId, Value = contactId, Type = ParameterType.GetOrPost });
        }


        public Guid AppId
        {
            get { return (Guid) Parameters.Find(p => p.Name == Constants.Parameters.ContactId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.ContactId).Value = value; }
        }


        public async Task<IWorkplacesCollection> GetAsync()
        {
            Method = Method.GET;
            var response = await SendAsync<GetWorkplaceDataResult>();

            if (response != null)
            {
                return new WorkplacesCollection(response.WorkplaceData);
            }

            return null;
        }
    }
}