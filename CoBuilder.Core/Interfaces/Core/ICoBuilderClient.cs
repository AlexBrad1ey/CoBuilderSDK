using System.Collections.Generic;

namespace CoBuilder.Core.Interfaces
{
    public interface ICoBuilderClient : IBaseClient
    {
        IList<int> PropertySetIds { get; }
        IWorkplacesCollectionRequestBuilder Workplaces { get; }
        IPropertySetTagsCollectionRequestBuilder PropertySetTags { get; }
        IProductsCollectionRequestBuilder Products { get; }
    }
}