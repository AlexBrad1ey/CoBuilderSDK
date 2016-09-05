using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Logic
{
    // change operation to supply Connection/Connections 
    public class AttachmentManager<TElement> : IAttacher<TElement> where TElement : class
    {
        private readonly IAppAttacher<TElement> _attacher;
        private readonly IAppAccessor<TElement> _accessor;
        private readonly IConfiguration _config;
        private bool _masterAttachment;


        public AttachmentManager(IAppAttacher<TElement> attacher,IAppAccessor<TElement> accessor, IConfiguration config)
        {
            _config = config;
            _attacher = attacher;
            _accessor = accessor;
            _masterAttachment = _attacher.HasProjectPropertySet("CBProject");
        }


        public AttachmentResult AttachProduct(IEnumerable<TElement> elements, BimProduct product)
        {
            var connection = _connector.Connect(elements, product);
            var attachProcessor = new AttachProcessor<TElement>(_attacher, _config);
            if (!_masterAttachment)
            {
                attachProcessor.AttachMaster(_session);
                _masterAttachment = true;
            }
            return attachProcessor.Process(connections);
        }

        public AttachmentResult AttachProduct(TElement element, BimProduct product)
        {
            var connection = _connector.Connect(element, product);
            if (connection == null) return AttachmentResult.Null;

            var attachProcessor = new AttachProcessor<TElement>(_attacher, _config);
            if (!_masterAttachment) attachProcessor.AttachMaster(_session);
            return attachProcessor.Process(connection);
        }

        public RemovalResult RemoveProducts(IEnumerable<TElement> elements)
        {
            var connections = _connector.ConnectionsWith(elements);
            var enumerable = connections as IList<Connection<TElement>> ?? connections.ToList();
            var detachProc = new DetachProcessor<TElement>(_attacher, _config, this);
            var result = detachProc.Process(enumerable);
            _connector.RemoveConnections(enumerable);
            return result;
        }

        public RemovalResult RemoveProducts(TElement element)
        {
            var connections = _connector.ConnectionsWith(element);
            var detachProc = new DetachProcessor<TElement>(_attacher, _config, this);
            var enumerable = connections as IList<Connection<TElement>> ?? connections.ToList();
            _connector.RemoveConnections(enumerable);
            return detachProc.Process(enumerable);
        }

        public RemovalResult RemoveProduct(IEnumerable<TElement> elements, BimProduct product)
        {
            var connections = _connector.ConnectionsBetween(elements, product);
            var detachProc = new DetachProcessor<TElement>(_attacher, _config, this);
            var enumerable = connections as IList<Connection<TElement>> ?? connections.ToList();
            _connector.RemoveConnections(enumerable);
            return detachProc.Process(enumerable);
        }

        public RemovalResult RemoveProduct(TElement element, BimProduct product)
        {
            var connection = _connector.ConnectionBetween(element, product);
            if (connection == null) return RemovalResult.Null;
            _connector.RemoveConnection(connection);
            var detachProc = new DetachProcessor<TElement>(_attacher, _config, this);
            return detachProc.Process(connection);
        }
    }
}
