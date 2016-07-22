using System.Collections.Generic;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class GetProductsDataResult
    {
        public AuthenticationRequestStatus Status { get; set; }
        public int ErrorCode { get; set; }
        public List<BimProduct> Products { get; set; }
    }
}