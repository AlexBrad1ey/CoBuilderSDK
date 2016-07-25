using CoBuilder.Service.Infrastructure;

namespace CoBuilder.Service.Domain
{
    public class BimProduct : IBimProduct
    {
        internal CoBuilderContext _context { get; set; }
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

        public virtual PropertySetsSet PropertySets
        {
            get { return _context.PropertySetsAsync(Id).Result; }
        }
    }
}