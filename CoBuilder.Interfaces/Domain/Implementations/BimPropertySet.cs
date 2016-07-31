using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class BimPropertySet : IBimPropertySet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int ProductId { get; internal set; }

        public virtual IPropertiesSet Properties
        {
            get { return Context.PropertiesAsync(ProductId, Id).Result; }
        }

        public ICoBuilderContext Context { get; set; }

        public static explicit operator BimPropertySet(Core.Domain.BimPropertySet pSet)
        {
            return new BimPropertySet()
            {
                Id = pSet.Id,
                Name = pSet.Name,
                TagId = pSet.TagId,
                TagName = pSet.TagName
            };
        }
    }
}