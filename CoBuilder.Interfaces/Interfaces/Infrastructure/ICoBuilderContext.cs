using System.Threading.Tasks;

namespace CoBuilder.Service.Interfaces
{
    public interface ICoBuilderContext
    {
        IProductsSet Products(int workplaceId);

        IPropertiesSet Properties(int productId, string propertySetId);

        IPropertySetsSet PropertySets(int productId);

        IWorkplacesSet Workplaces();
    }
}