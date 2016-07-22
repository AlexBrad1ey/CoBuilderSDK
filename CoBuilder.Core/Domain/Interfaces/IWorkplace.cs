using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    public interface IWorkplace
    {
        int Id { get; set; }
        Guid? MsdsId { get; set; }
        bool IsNonCompliantWithFilters { get; set; }
        int ParentId { get; set; }
        string Name { get; set; }
        WorkplaceDataType Type { get; set; }
        string Data { get; set; }
        GeoAddress Coordinates { get; set; }
        string FullAddress { get; set; }
        string WorkplaceName { get; set; }
        bool IsImported { get; set; }
        bool Expired { get; set; }
        double Distance { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string PostCode { get; set; }
    }
}