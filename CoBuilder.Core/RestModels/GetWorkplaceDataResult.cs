using System.Collections.Generic;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class GetWorkplaceDataResult
    {
        public AuthenticationRequestStatus Status { get; set; }
        public int ErrorCode { get; set; }
        public List<Workplace> WorkplaceData { get; set; }
        public WorkplaceResponsible Responsible { get; set; }
        public int ProductsCount { get; set; }
        public int DocumentsCount { get; set; }
        public int PhotosCount { get; set; }
        public int SdsCount { get; set; }
    }
}