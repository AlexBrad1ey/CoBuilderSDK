using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces.App
{
    public interface IAppAttacher<in TElement> where TElement : class
    {
        bool Attach(TElement appElement, PropertySetInfo pSetInfo);
        bool AttachRoot(PropertySetInfo pSetInfo);
        bool Remove(TElement appElement, string pSetIndentifierSegment);
        
    }
}