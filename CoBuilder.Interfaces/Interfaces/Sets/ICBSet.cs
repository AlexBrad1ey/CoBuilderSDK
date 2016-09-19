using System.Collections.Generic;

namespace CoBuilder.Service.Interfaces
{
    public interface ICBSet<out T> : IReadOnlyCollection<T>
    {
        
    }
}