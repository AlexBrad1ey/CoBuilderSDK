using CoBuilder.Core.Interfaces;
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
            var app = container.GetInstance<IAppConfig>();

            app.AppId = _config.AppConfig.AppId;
            app.ClientId = _config.AppConfig.ClientId;
            app.ProgramVersion = _config.AppConfig.ProgramVersion;

            var containerProvider = new ContainerProvider(container);
            var service = new CoBuilderService(containerProvider);

            return service;
        }
    }
}