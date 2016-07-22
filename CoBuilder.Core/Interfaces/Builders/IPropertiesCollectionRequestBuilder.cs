namespace CoBuilder.Core.Interfaces
{
    public interface IPropertiesCollectionRequestBuilder
    {
        string PropertySetId { get; }


        IPropertiesCollectionRequest Request();
    }
}