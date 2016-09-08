using CoBuilder.Core.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimProduct : IBimProduct
    {
        public BimProduct(Core.Domain.IBimProduct product, int workplaceId)
        {

            Id = product.Id;
            Identifier = product.Identifier;
            IsCreatedFromScan = product.IsCreatedFromScan;
            IsRiskAssessed = product.IsRiskAssessed;
            DeliveredBy = product.DeliveredBy;
            DOP = product.DOP;
            Link = product.Link;
            Name = product.Name;
            ProductTypes = product.ProductTypes;
            SupplierName = product.SupplierName;
            WorkplaceId = workplaceId;
        }

        public BimProduct(Core.Domain.IBimProduct product, int workplaceId, ICoBuilderContext ctx) : this(product, workplaceId)
        {
            Context = ctx;
        }

        public ICoBuilderContext Context { get; }
        public string DeliveredBy { get; internal set; }
        public bool? DOP { get; internal set; }
        public int Id { get; internal set; }
        public string Identifier { get; internal set; }
        public bool IsCreatedFromScan { get; internal set; }
        public bool IsRiskAssessed { get; internal set; }
        public string Link { get; internal set; }
        public string Name { get; internal set; }
        public string ProductTypes { get; internal set; }
        public string SupplierName { get; internal set; }

        public virtual IPropertySetsSet PropertySets
        {
            get
            {
                return Context?.PropertySetsAsync(Id).Result;
            }
        }

        public int WorkplaceId { get; }
        public int ProductId
        {
            get { return Id; }
        }
    }
}