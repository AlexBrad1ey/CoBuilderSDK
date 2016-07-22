using CoBuilder.Core.Collections;

namespace CoBuilder.Core.Domain
{
    public class BimProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Link { get; set; }
        public string ProductTypes { get; set; }
        public string SupplierName { get; set; }
        public string DeliveredBy { get; set; }
        public bool IsRiskAssessed { get; set; }
        public bool? DOP { get; set; }
        public bool IsCreatedFromScan { get; set; }
        public PropertySetCollection PropertySets { get; set; }
    }
}