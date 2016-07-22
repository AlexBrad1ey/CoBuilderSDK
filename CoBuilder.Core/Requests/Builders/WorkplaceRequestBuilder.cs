using System;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class WorkplaceRequestBuilder : IWorkplaceRequestBuilder
    {
        private readonly IBaseClient _client;
        private readonly string _workplaceName;
        private readonly IWorkplacesCollectionRequestBuilder _workplacesCollectionRequestBuilder;


        public WorkplaceRequestBuilder(IWorkplacesCollectionRequestBuilder workplacesCollectionRequestBuilder,
            IBaseClient client, int workplaceId)
        {
            _workplacesCollectionRequestBuilder = workplacesCollectionRequestBuilder;
            _client = client;
            WorkplaceId = workplaceId;
        }

        public WorkplaceRequestBuilder(IWorkplacesCollectionRequestBuilder workplacesCollectionRequestBuilder,
            IBaseClient client, string workplaceName)
        {
            _workplacesCollectionRequestBuilder = workplacesCollectionRequestBuilder;
            _client = client;
            _workplaceName = workplaceName;
        }


        public int WorkplaceId { get; set; }

        public IProductsCollectionRequestBuilder Products
        {
            get
            {
                if (WorkplaceId > 0)
                {
                    return new ProductsCollectionRequestBuilder(Constants.Url.Products, _client,
                        ProductRequestType.Workplace, WorkplaceId);
                }
                GetWorkplaces();
                if (WorkplaceId <= 0)
                {
                    ThrowError();
                }
                return new ProductsCollectionRequestBuilder(Constants.Url.Products, _client,
                    ProductRequestType.Workplace, WorkplaceId);
            }
        }

        public IWorkplaceRequest Request()
        {
            return new WorkplaceRequest(_workplacesCollectionRequestBuilder.Request(), WorkplaceId);
        }

        private void ThrowError()
        {
            throw new NotImplementedException();
        }

        private void GetWorkplaces()
        {
            throw new NotImplementedException();
        }
    }
}