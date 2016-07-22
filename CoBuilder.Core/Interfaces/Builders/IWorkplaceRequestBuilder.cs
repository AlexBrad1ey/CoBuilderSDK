namespace CoBuilder.Core.Interfaces
{
    public interface IWorkplaceRequestBuilder
    {
        int WorkplaceId { get; set; }
        IProductsCollectionRequestBuilder Products { get; }
        IWorkplaceRequest Request();
    }
}