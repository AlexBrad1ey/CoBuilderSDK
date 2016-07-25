namespace CoBuilder.Core.Domain
{
    public interface IBimPropertySet
    {
        string Id { get; set; }
        string Name { get; set; }
        int TagId { get; set; }
        string TagName { get; set; }
    }
}