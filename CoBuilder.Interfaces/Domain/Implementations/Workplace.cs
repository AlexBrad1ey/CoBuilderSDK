using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;
using CoBuilder.Service.Interfaces;
using System;

namespace CoBuilder.Service.Domain
{
    public class Workplace : IWorkplace
    {
        public Workplace(Core.Domain.IWorkplace workplace) 
        {
            Id = workplace.Id;
            MsdsId = workplace.MsdsId;
            IsNonCompliantWithFilters = workplace.IsNonCompliantWithFilters;
            ParentId = workplace.ParentId;
            Name = workplace.Name;
            Type = workplace.Type;
            Data = workplace.Data;
            Coordinates = workplace.Coordinates;
            FullAddress = workplace.FullAddress;
            WorkplaceName = workplace.WorkplaceName;
            IsImported = workplace.IsImported;
            Expired = workplace.Expired;
            Distance = workplace.Distance;
            Address = workplace.Address;
            City = workplace.City;
            PostCode = workplace.PostCode;
        }
        public Workplace(Core.Domain.IWorkplace workplace, ICoBuilderContext ctx) : this(workplace)
        {
            Context = ctx;
        }


        public ICoBuilderContext Context { get;  }

        public int Id { get; internal set; }
        public Guid? MsdsId { get; internal set; }
        public bool IsNonCompliantWithFilters { get; internal set; }
        public int ParentId { get; internal set; }
        public string Name { get; internal set; }
        public WorkplaceDataType Type { get; internal set; }
        public string Data { get; internal set; }
        public GeoAddress Coordinates { get; internal set; }
        public string FullAddress { get; internal  set; }
        public string WorkplaceName { get; internal set; }
        public bool IsImported { get; internal set; }
        public bool Expired { get; internal set; }
        public double Distance { get; internal set; }
        public string Address { get; internal set; }
        public string City { get; internal set; }
        public string PostCode { get; internal set; }

        public IProductsSet Products
        {
            get { return Context.ProductsAsync(Id).Result; }
        }
    }
}