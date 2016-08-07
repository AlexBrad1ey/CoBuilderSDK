using CoBuilder.Service.Infrastructure.DI;
using CoBuilder.Service.Interfaces;
using StructureMap;

namespace CoBuilder.Service.Infrastructure
{
    public class ServiceBuilder
    {
        private readonly IServiceConfiguration _config;

        public ServiceBuilder(IServiceConfiguration serviceConfiguration)
        {
            _config = serviceConfiguration;
        }

        public CoBuilderService Build()
        {
            var registry = new ServiceRegistry(_config);
            var container = new Container(registry);
            var containerProvider = new ContainerProvider(container);
            return new CoBuilderService(containerProvider);
        }
    }
}