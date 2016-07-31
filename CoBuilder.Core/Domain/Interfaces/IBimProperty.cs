namespace CoBuilder.Core.Domain
{
    public interface IBimProperty
    {
        string Id { get; set; }
        string Name { get; set; }
        string Value { get; set; }
        string Unit { get; set; }
    }
}