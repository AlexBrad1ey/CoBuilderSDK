namespace CoBuilder.Core.Domain
{
    public interface IBimProduct
    {
        string DeliveredBy { get; }
        bool? DOP { get;}
        int Id { get; }
        string Identifier { get; }
        bool IsCreatedFromScan { get; }
        bool IsRiskAssessed { get; }
        string Link { get; }
        string Name { get; }
        string ProductTypes { get; }
        string SupplierName { get; }
    }
}