using System;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Requests
{
    public class ProductsCollectionRequestBuilder : BaseRequestBuilder, IProductsCollectionRequestBuilder
    {
        private readonly ProductRequestType _buildType;

        public ProductsCollectionRequestBuilder(string requestResource, IBaseClient client)
            : this(requestResource, client, ProductRequestType.None)
        {
        }

        public ProductsCollectionRequestBuilder(string requestResource, IBaseClient client, ProductRequestType buildType,
            int workplaceId = 0, int countryIndex = 0)
            : base(requestResource, client)
        {
            if (workplaceId <= 0 && buildType == ProductRequestType.Workplace)
                throw new ArgumentOutOfRangeException(nameof(workplaceId),
                    $"For ProductResquestType.Workplace, {nameof(workplaceId)} must be greater than 0");
            if (countryIndex <= 0 && buildType == ProductRequestType.CountryIndex)
                throw new ArgumentOutOfRangeException(nameof(countryIndex),
                    $"For ProductResquestType.CountryIndex, {nameof(countryIndex)} must be greater than 0");

            _buildType = buildType;
            WorkplaceId = workplaceId;
            this.CountryIndex = countryIndex;
        }

        public int CountryIndex { get; set; }


        public int WorkplaceId { get; set; }

        public IProductRequestBuilder this[int productId]
        {
            get { return new ProductRequestBuilder(RequestResource, Client, productId); }
        }


        public IProductsCollectionRequest Request()
        {
            switch (_buildType)
            {
                case ProductRequestType.None:
                    ThrowError(_buildType);
                    break;
                case ProductRequestType.Workplace:
                    if (WorkplaceId <= 0) ThrowError(_buildType);
                    return new ProductsCollectionRequest(RequestResource, Client, _buildType, WorkplaceId);
                case ProductRequestType.CountryIndex:
                    if (CountryIndex <= 0) ThrowError(_buildType);
                    return new ProductsCollectionRequest(RequestResource, Client, _buildType, countryIndex: CountryIndex);
                default:
                    throw new ArgumentOutOfRangeException(nameof(_buildType),"ProductRequestType Out of Range");
            }
            return null;
        }

        private static void ThrowError(ProductRequestType type)
        {
            var error = new Error
            {
                Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                Message = $"Cannot Execute Request when ProductRequestType is set to {type}"
            };

            throw new CoBuilderException(error);
        }
    }
}