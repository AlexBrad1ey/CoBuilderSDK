namespace CoBuilder.Core.Domain
{
    public interface IBimProperty
    {
        string Id { get; }
        string Name { get; }
        string Value { get; }
        string Unit { get; }
    }
}