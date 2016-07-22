using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Interfaces
{
    public interface IPropertySetTagsCollectionRequestBuilder
    {
        PluginApp AppId { get; set; }

        IPropertySetTagsCollectionRequest Request();
    }
}