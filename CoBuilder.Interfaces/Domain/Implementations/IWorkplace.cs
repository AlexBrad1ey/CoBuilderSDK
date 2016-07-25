using CoBuilder.Service.Infrastructure;

namespace CoBuilder.Service.Domain
{
    public interface IWorkplace : Core.Domain.IWorkplace
    {
        IProductsSet Products { get; }
        CoBuilderContext Context { get; set; }
    }
}