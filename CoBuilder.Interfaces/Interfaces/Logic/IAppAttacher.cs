using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces
{
    public interface IAppAttacher<in TElement> where TElement : class
    {
        bool Attach(TElement appElement, PropertySetInfo pSetInfo);
        bool AttachRoot(PropertySetInfo pSetInfo);
        bool Remove(TElement appElement, string pSetIndentifierSegment);
        bool HasProjectPropertySet(string identifier);
    }
}