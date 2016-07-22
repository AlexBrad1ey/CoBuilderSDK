using System.Collections.Generic;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class GetProductPropertySetsResult
    {
        public AuthenticationRequestStatus Status { get; set; }
        public int ErrorCode { get; set; }
        public List<BimPropertySet> PropertySets { get; set; }
    }
}