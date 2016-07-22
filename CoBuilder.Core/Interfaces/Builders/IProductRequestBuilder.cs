namespace CoBuilder.Core.Interfaces
{
    public interface IProductRequestBuilder
    {
        int ProductId { get; set; }
        IPropertySetCollectionRequestBuilder PropertySets { get; }
    }
}