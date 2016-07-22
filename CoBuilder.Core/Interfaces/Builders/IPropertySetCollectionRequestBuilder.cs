namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetCollectionRequestBuilder
    {
        int ProductId { get; }


        IPropertySetRequestBuilder this[string pSetId] { get; }


        IPropertySetCollectionRequest Request();
    }
}