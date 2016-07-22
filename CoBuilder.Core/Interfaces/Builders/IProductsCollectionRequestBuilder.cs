namespace CoBuilder.Core.Interfaces
{
    public interface IProductsCollectionRequestBuilder
    {
        int WorkplaceId { get; }


        IProductRequestBuilder this[int productId] { get; }


        IProductsCollectionRequest Request();
    }
}