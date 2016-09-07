using System.Collections.Generic;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Logic
{
    internal class AttachProcessor<TElement> where TElement : class
    {
        /// <summary>
        /// The _attacher
        /// </summary>
        private readonly IAppAttacher<TElement> _attacher;

        /// <summary>
        /// The _mapper
        /// </summary>
        private readonly IMapper _mapper;

        public AttachProcessor(IAppAttacher<TElement> attacher, IConfiguration config)
        {
            _attacher = attacher;
            _mapper = new Mapper(config);
        }

        public AttachProcessor()
        {
        }

        internal AttachmentResult Process(IEnumerable<Connection<TElement>> connections)
        {
            var result = AttachmentResult.Null;

            foreach (var connection in connections)
            {
                result = result | Process(connection);
            }

            return result;
        }

        public AttachmentResult Process(Connection<TElement> connection)
        {
            var success = true;
            var pSets = _mapper.Map(connection.BimProduct);

            foreach (var pSet in pSets)
            {
                success = _attacher.Attach(connection.AppElement, pSet) && success;
            }

            return success ? AttachmentResult.AllElementsConnected : AttachmentResult.NoElementsConnected;
        }

        public void AttachMaster(IServiceSession session)
        {
            var pSet = _mapper.GenerateProjectSet(session);
            _attacher.AttachRoot(pSet);
        }
    }
}