using CoBuilder.Core.Domain;

namespace CoBuilder.Service.Domain
{
    public class BimPropertySet:IBimPropertySet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public virtual PropertiesSet Properties { get; set; }
    }
}