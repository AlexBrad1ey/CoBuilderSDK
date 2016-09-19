using System;
using CoBuilder.Core.Interfaces;
using StructureMap;

namespace CoBuilder.Service.Interfaces
{
    public interface IServiceConfiguration : IDisposable
    {
        IAppConfig AppConfig { get; }
        bool UseDefinedContainerConfig { get; }
        Registry ContainerConfig { get; }
        ICachePolicy GlobalCachePolicy { get; }
    }
}