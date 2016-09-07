using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Logic
{
    internal class DetachProcessor<TElement> where TElement : class
    {
        private readonly IAppAttacher<TElement> _attacher;

        public DetachProcessor(IAppAttacher<TElement> attacher)
        {
            _attacher = attacher;
        }

        internal RemovalResult Process(IEnumerable<Connection<TElement>> connections)
        {
            var result = RemovalResult.Null;

            foreach (var connection in connections)
            {
                result = result | Process(connection);
            }

            return result;
        }

        public RemovalResult Process(Connection<TElement> connection)
        {
            return _attacher.Remove(connection.AppElement, Identifier.Generate(connection.BimProduct.Id))
                ? RemovalResult.AllElementsDisconnected
                : RemovalResult.NoElementsDisconnected;
        }
    }
}