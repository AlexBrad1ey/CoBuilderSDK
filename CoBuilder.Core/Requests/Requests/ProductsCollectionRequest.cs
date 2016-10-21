using System;
using System.Threading.Tasks;
using CoBuilder.Core.Collections;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class ProductsCollectionRequest : BaseRequest, IProductsCollectionRequest
    {
        private readonly ProductRequestType _buildType;

        public ProductsCollectionRequest(string requestResource, IBaseClient client, ProductRequestType buildType,
            int workplaceId = 0, int countryIndex = 0) : base(requestResource, client)
        {
            _buildType = buildType;
            switch (buildType)
            {
                case ProductRequestType.Workplace:
                    if (workplaceId <= 0) ThrowError(buildType);
                    Parameters.Add(new Parameter {Name = Constants.Parameters.WorkplaceId, Value = workplaceId, Type = ParameterType.GetOrPost });
                    break;
                case ProductRequestType.CountryIndex:
                    if (CountryIndex <= 0) ThrowError(buildType);
                    Parameters.Add(new Parameter {Name = Constants.Parameters.CountryIndex, Value = countryIndex, Type = ParameterType.QueryString});
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(buildType), buildType, null);
            }
        }


        public int WorkplaceId
        {
            get { return (int) Parameters.Find(p => p.Name == Constants.Parameters.WorkplaceId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.WorkplaceId).Value = value; }
        }

        public int CountryIndex
        {
            get { return (int) Parameters.Find(p => p.Name == Constants.Parameters.CountryIndex).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.CountryIndex).Value = value; }
        }


        public async Task<IProductsCollection> GetAsync()
        {
            if (_buildType == ProductRequestType.CountryIndex) ThrowError(_buildType);

            Method = Method.GET;
            var response = await SendAsync<GetProductsDataResult>();

            if (response != null)
            {
                return new ProductsCollection(response.Products);
            }

            return null;
        }

        //Country Index is POST??
        public async Task<IProductsCollection> PostAsync()
        {
            if (_buildType == ProductRequestType.Workplace) ThrowError(_buildType);

            Method = Method.POST;
            var response = await SendAsync<GetProductsDataResult>();

            if (response != null)
            {
                return new ProductsCollection(response.Products);
            }

            return null;
        }
        private static void ThrowError(ProductRequestType type)
        {
            var error = new Error
            {
                Code = CoBuilderErrorCode.InvalidRequest.ToString(),
                Message = $"Cannot Create Request when  {type}'s Corresponding property is not valid"
            };

            throw new CoBuilderException(error);
        }
    }
}