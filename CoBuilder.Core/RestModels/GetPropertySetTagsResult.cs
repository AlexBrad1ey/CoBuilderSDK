using System.Collections.Generic;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class GetPropertySetTagsResult
    {
        public AuthenticationRequestStatus Status { get; set; }
        public int ErrorCode { get; set; }
        public List<BimPropertySetTag> Tags { get; set; }
    }
}