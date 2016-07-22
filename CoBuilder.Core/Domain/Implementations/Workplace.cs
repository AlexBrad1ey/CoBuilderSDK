using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    public class Workplace : IWorkplace
    {
        public int Id { get; set; }
        public Guid? MsdsId { get; set; }
        public bool IsNonCompliantWithFilters { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public WorkplaceDataType Type { get; set; }
        public string Data { get; set; }
        public GeoAddress Coordinates { get; set; }
        public string FullAddress { get; set; }
        public string WorkplaceName { get; set; }
        public bool IsImported { get; set; }
        public bool Expired { get; set; }
        public double Distance { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }
}