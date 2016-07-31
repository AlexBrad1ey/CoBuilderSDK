using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimProduct : IBimProduct
    {
        public ICoBuilderContext Context { get; set; }
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
                return Context.PropertySetsAsync(Id).Result;
            }
        }

        public static explicit operator BimProduct(Core.Domain.BimProduct product)
        {
            return new BimProduct()
            {
                Id = product.Id,
                Identifier = product.Identifier,
                IsCreatedFromScan = product.IsCreatedFromScan,
                IsRiskAssessed = product.IsRiskAssessed,
                DeliveredBy = product.DeliveredBy,
                DOP = product.DOP,
                Link = product.Link,
                Name = product.Name,
                ProductTypes = product.ProductTypes,
                SupplierName = product.SupplierName
            };
        }
    }
}