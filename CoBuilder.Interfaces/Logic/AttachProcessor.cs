using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachProcessor{TElement}"/> class.
        /// </summary>
        /// <param name="attacher">The attacher.</param>
        /// <param name="config">The configuration.</param>
        public AttachProcessor(IAppAttacher<TElement> attacher, IConfiguration config)
        {
            _attacher = attacher;
            _mapper = new Mapper(config);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachProcessor{TElement}"/> class.
        /// </summary>
        public AttachProcessor()
        {
        }

        /// <summary>
        /// Processes the specified connections.
        /// </summary>
        /// <param name="connections">The connections.</param>
        /// <returns>AttachmentResult.</returns>
        internal AttachmentResult Process(IEnumerable<Connection<TElement>> connections)
        {
            var result = AttachmentResult.Null;

            foreach (var connection in connections)
            {
                result = result | Process(connection);
            }

            return result;
        }

        /// <summary>
        /// Processes the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <returns>AttachmentResult.</returns>
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

        /// <summary>
        /// Attaches the master.
        /// </summary>
        /// <param name="session">The session.</param>
        public void AttachMaster(ISession session)
        {
            var pSet = _mapper.GenerateProjectSet(session);
            _attacher.AttachRoot(pSet);
        }
    }
}