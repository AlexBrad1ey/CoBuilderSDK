using System.Threading.Tasks;

namespace CoBuilder.Service.Interfaces
{
    public interface ICoBuilderContext
    {
        Task<IProductsSet> ProductsAsync(int workplaceId);

        Task<IPropertiesSet> PropertiesAsync(int productId, string propertySetId);

        Task<IPropertySetsSet> PropertySetsAsync(int productId);

        Task<IWorkplacesSet> WorkplacesAsync();
    }
}