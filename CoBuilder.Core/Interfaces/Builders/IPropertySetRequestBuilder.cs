namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetRequestBuilder
    {
        string PropertySetId { get; set; }
        IPropertiesCollectionRequestBuilder Properties { get; }

        IPropertySetRequest Request();
    }
}