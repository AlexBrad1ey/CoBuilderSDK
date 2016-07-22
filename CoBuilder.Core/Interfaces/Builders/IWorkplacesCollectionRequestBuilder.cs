using System;

namespace CoBuilder.Core.Interfaces
{
    public interface IWorkplacesCollectionRequestBuilder
    {
        Guid ContactId { get; }


        IWorkplaceRequestBuilder this[int workplaceId] { get; }
        IWorkplaceRequestBuilder this[string workplaceName] { get; }


        IWorkplacesCollectionRequest Request();
    }
}