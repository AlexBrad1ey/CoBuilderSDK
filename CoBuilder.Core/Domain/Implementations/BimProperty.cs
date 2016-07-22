namespace CoBuilder.Core.Domain
{
    public class BimProperty : IBimProperty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }
}