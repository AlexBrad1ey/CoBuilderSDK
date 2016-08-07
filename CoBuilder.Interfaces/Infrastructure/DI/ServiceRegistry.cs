using CoBuilder.Service.Interfaces;
using StructureMap;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry(IServiceConfiguration config)
        {
            if (config.UseDefinedContainerConfig)
            {
                IncludeRegistry(new CoBuilderServiceRegistry());
                IncludeRegistry(config.ContainerConfig);
            }
            else
            {
                IncludeRegistry(new ScanningRegistry());
            }
        }
    }
}