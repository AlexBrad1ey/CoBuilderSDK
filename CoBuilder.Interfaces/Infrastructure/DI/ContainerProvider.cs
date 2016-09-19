using System;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Interfaces;
using StructureMap;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class ContainerProvider : IContainerProvider
    {
        private readonly IContainer _rootContainer;
        private IContainer _activeContainer;

        public ContainerProvider(IContainer rootContainer)
        {
            _rootContainer = rootContainer;
        }


        public IContainer Container
        {
            get
            {
                if (_activeContainer != null) return _activeContainer;
                _activeContainer = _rootContainer.CreateChildContainer();
                return _activeContainer;
            }
        }
        public void Reset()
        {
            _activeContainer.EjectAllInstancesOf<ISession>();
            _activeContainer.Dispose();
            _activeContainer = _rootContainer.CreateChildContainer();
        }

        public void Dispose()
        {
            _activeContainer?.Dispose();
            _rootContainer?.Dispose();
        }
    }
}