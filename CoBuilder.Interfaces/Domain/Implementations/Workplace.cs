using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;
using CoBuilder.Service.Interfaces;
using System;

namespace CoBuilder.Service.Domain
{
    public class Workplace : IWorkplace
    {
        public ICoBuilderContext Context { get; set; }

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

        public IProductsSet Products
        {
            get { return Context.ProductsAsync(Id).Result; }
        }

        public static explicit operator Workplace(Core.Domain.Workplace workplace)
        {
            return new Workplace()
            {
                Id = workplace.Id,
                MsdsId = workplace.MsdsId,
                IsNonCompliantWithFilters = workplace.IsNonCompliantWithFilters,
                ParentId = workplace.ParentId,
                Name = workplace.Name,
                Type = workplace.Type,
                Data = workplace.Data,
                Coordinates = workplace.Coordinates,
                FullAddress = workplace.FullAddress,
                WorkplaceName = workplace.WorkplaceName,
                IsImported = workplace.IsImported,
                Expired = workplace.Expired,
                Distance = workplace.Distance,
                Address = workplace.Address,
                City = workplace.City,
                PostCode = workplace.PostCode
            };
        }
    }
}