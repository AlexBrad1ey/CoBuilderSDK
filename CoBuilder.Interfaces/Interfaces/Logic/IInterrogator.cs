using System.Collections.Generic;

namespace CoBuilder.Service.Interfaces
{
    public interface IInterrogator<in TElement> where TElement : class
    {
        bool Interrogate();
        void Interrogate(IEnumerable<TElement> elements);
    }
}