using System;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Repositories;
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
            _activeContainer.Model.For<IServiceSession>().Default.EjectObject();
            _activeContainer.Model.For<ISession>().Default.EjectObject();
            _activeContainer.Model.For(typeof(ConnectionRepository<>)).Default.EjectObject();
        }

        public void Dispose()
        {
            _activeContainer?.Dispose();
            _rootContainer?.Dispose();
        }
    }
}