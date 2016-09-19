using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;
using CoBuilder.Service.Repositories;

namespace CoBuilder.Service.Logic
{
    public class AttachmentManager<TElement> : IAttacher<TElement> where TElement : class
    {
        private readonly IAppAttacher<TElement> _attacher;
        private readonly IAppAccessor<TElement> _accessor;
        private readonly ConnectionRepository<TElement> _connectionRepo;
        private readonly IServiceSession _session;
        private bool _masterAttachment;


        public AttachmentManager(IAppAttacher<TElement> attacher,IAppAccessor<TElement> accessor, ConnectionRepository<TElement> connectionRepo, IServiceSession session )
        {
            _connectionRepo = connectionRepo;
            _session = session;
            _attacher = attacher;
            _accessor = accessor;
            _masterAttachment = _accessor.HasProjectPropertySet(Constants.Identifiers.PropertySets.CoBuilderMaster);
        }

        public void RefreshAttachments()
        {
            var attachProcessor = new AttachProcessor<TElement>(_attacher, _session.CurrentConfiguration);

            if (!_masterAttachment)
            {
                attachProcessor.AttachMaster(_session);
                _masterAttachment = true;
            }
            var toAdd = _connectionRepo.ToBeAdded();

            attachProcessor.Process(toAdd);
            _connectionRepo.UpdateState();

            var detachProcessor = new DetachProcessor<TElement>(_attacher);
            detachProcessor.Process(_connectionRepo.ToBeRemoved());
            _connectionRepo.Clean();
        }

        public void RefreshAllAttachments()
        {
            var attachProcessor = new AttachProcessor<TElement>(_attacher, _session.CurrentConfiguration);
            var detachProcessor = new DetachProcessor<TElement>(_attacher);

            if (!_masterAttachment)
            {
                attachProcessor.AttachMaster(_session);
                _masterAttachment = true;
            }

            detachProcessor.Process(_connectionRepo.All());
            attachProcessor.Process(_connectionRepo.Current());

            _connectionRepo.UpdateState();
            _connectionRepo.Clean();
        }


    }
}
