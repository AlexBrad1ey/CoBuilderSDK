using System.Threading.Tasks;
using CoBuilder.Core.Collections;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;
using RestSharp;

namespace CoBuilder.Core.Requests
{
    public class PropertiesCollectionRequest : BaseRequest, IPropertiesCollectionRequest
    {
        public PropertiesCollectionRequest(string requestResource, IBaseClient client, int productId, string propertySetId)
            : base(requestResource, client)
        {
            Parameters.Add(new Parameter {Name = Constants.Parameters.ProductId, Value = productId, Type = ParameterType.GetOrPost });
            Parameters.Add(new Parameter {Name = Constants.Parameters.PropertySetId, Value = propertySetId, Type = ParameterType.GetOrPost });
        }


        public int ProductId
        {
            get { return (int) Parameters.Find(p => p.Name == Constants.Parameters.ProductId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.ProductId).Value = value; }
        }
        public string PropertySetId
        {
            get { return (string) Parameters.Find(p => p.Name == Constants.Parameters.PropertySetId).Value; }
            set { Parameters.Find(p => p.Name == Constants.Parameters.PropertySetId).Value = value; }
        }



        //Says POST??
        public async Task<IPropertiesCollection> PostAsync()
        {
            Method = Method.GET;
            var response = await SendAsync<GetProductPropertiesResult>();

            if (response != null)
            {
                return new PropertiesCollection(response.Properties, ProductId);
            }

            return null;
        }
    }
}