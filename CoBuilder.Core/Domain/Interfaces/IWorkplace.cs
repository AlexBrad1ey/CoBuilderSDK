using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    public interface IWorkplace
    {
        int Id { get; }
        Guid? MsdsId { get; }
        bool IsNonCompliantWithFilters { get; }
        int ParentId { get; }
        string Name { get; }
        WorkplaceDataType Type { get; }
        string Data { get; }
        GeoAddress Coordinates { get; }
        string FullAddress { get; }
        string WorkplaceName { get; }
        bool IsImported { get; }
        bool Expired { get; }
        double Distance { get; }
        string Address { get; }
        string City { get; }
        string PostCode { get; }
    }
}