namespace CoBuilder.Service.Interfaces
{
    public interface IAttacher<TElement> where TElement : class
    {
        void RefreshAttachments();
        void RefreshAllAttachments();
    }
}
