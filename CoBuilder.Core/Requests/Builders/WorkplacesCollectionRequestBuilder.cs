using System;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class WorkplacesCollectionRequestBuilder : BaseRequestBuilder, IWorkplacesCollectionRequestBuilder
    {
        public WorkplacesCollectionRequestBuilder(string requestResource, IBaseClient client, Guid contactId)
            : base(requestResource, client)
        {
            ContactId = contactId;
        }

        public Guid ContactId { get; set; }

        public IWorkplaceRequestBuilder this[int workplaceId]
        {
            get { return new WorkplaceRequestBuilder(this, Client, workplaceId); }
        }

        public IWorkplaceRequestBuilder this[string workplaceName]
        {
            get { return new WorkplaceRequestBuilder(this, Client, workplaceName); }
        }

        public IWorkplacesCollectionRequest Request()
        {
            return new WorkplacesCollectionRequest(RequestResource, Client, ContactId);
        }
    }
}