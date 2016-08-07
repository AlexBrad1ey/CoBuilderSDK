using System;
using StructureMap;

namespace CoBuilder.Service.Interfaces
{
    public interface IContainerProvider : IDisposable
    {
        IContainer Container { get; }
        void Reset();
    }
}