using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoBuilder.Core.Collections;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class PropertySetCollectionRequest : BaseRequest, IPropertySetCollectionRequest
    {
        public PropertySetCollectionRequest(string requestResource, IBaseClient client, int productId,
            IList<int> propertySetIds = null) : base(requestResource, client)
        {
           Parameters.Add(new Parameter {Name = Constants.Parameters.ProductId, Value = productId, Type = ParameterType.QueryString });

            if (propertySetIds != null && propertySetIds.Count > 0)
            {
                Parameters.Add(new Parameter
                {
                    Name = Constants.Parameters.PropertySetIds,
                    Value = propertySetIds,
                    Type = ParameterType.RequestBody
                });
            }
        }


        public int ProductId
        {
            get { return (int) Parameters.Find(p => p.Name == Constants.Parameters.ProductId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.ProductId).Value = value; }
        }

        public IList<int> PropertySetIds
        {
            get { return (List<int>) Parameters.Find(p => p.Name == Constants.Parameters.PropertySetIds).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.PropertySetIds).Value = value; }
        }

        public async Task<IPropertySetCollection> PostAsync()
        {
            Method = Method.POST;
            var response = await SendAsync<GetProductPropertySetsResult>();

            if (response != null)
            {
                return new PropertySetCollection(response.PropertySets);
            }

            return null;
        }
    }
}