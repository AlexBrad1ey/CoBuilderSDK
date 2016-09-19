using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Interfaces;
using StructureMap;

namespace CoBuilder.Service
{
    public class ServiceConfiguration : IServiceConfiguration
    {
        public void Dispose()
        {
        }

        public IAppConfig AppConfig { get; set; }
        public bool UseDefinedContainerConfig { get; set; }
        public Registry ContainerConfig { get; set; }
        public ICachePolicy GlobalCachePolicy { get; set; }
    }
}