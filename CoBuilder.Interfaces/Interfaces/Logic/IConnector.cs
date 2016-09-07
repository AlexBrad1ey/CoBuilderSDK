using System.Collections.Generic;
using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IConnector<TElement> where TElement : class
    {
        Connection<TElement> Connect(TElement element, BimProduct product);
        IEnumerable<Connection<TElement>> Connect(IEnumerable<TElement> elements, BimProduct product);
        Connection<TElement> ConnectionBetween(TElement element, BimProduct product);
        IEnumerable<Connection<TElement>> ConnectionsBetween(IEnumerable<TElement> elements, BimProduct product);
        IEnumerable<Connection<TElement>> ConnectionsWith(IEnumerable<TElement> elements);
        IEnumerable<Connection<TElement>> ConnectionsWith(TElement element);
        IEnumerable<Connection<TElement>> ConnectionsWith(IEnumerable<BimProduct> products);
        IEnumerable<Connection<TElement>> ConnectionsWith(BimProduct product);
        void RemoveConnection(Connection<TElement> connection);
        void RemoveConnections(IEnumerable<Connection<TElement>> connections);
        void Remove(IEnumerable<TElement> selection);
    }
}