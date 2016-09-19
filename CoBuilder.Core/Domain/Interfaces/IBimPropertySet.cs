namespace CoBuilder.Core.Domain
{
    public interface IBimPropertySet
    {
        string Id { get; }
        string Name { get; }
        int TagId { get; }
        string TagName { get; }
    }
}