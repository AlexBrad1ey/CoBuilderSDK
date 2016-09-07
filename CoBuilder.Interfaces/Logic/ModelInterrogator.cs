using System;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Logic
{
    public class ModelInterrogator<TElement> : IInterrogator<TElement> where TElement : class
    {
        private readonly IAppAccessor<TElement> _accessor;
        private readonly ConnectionManager<TElement> _connector;
        private readonly IAppSelector<TElement> _selector;
        private readonly IServiceSession _session;

        public ModelInterrogator(ConnectionManager<TElement> connector, IAppAccessor<TElement> accessor,
            IAppSelector<TElement> selector, IServiceSession session)
        {
            _connector = connector;
            _accessor = accessor;
            _selector = selector;
            _session = session;
        }

        public bool Interrogate()
        {
            if (!_session.LoggedIn)
            {
                throw new CoBuilderException(new Error() {Code = CoBuilderErrorCode.GeneralException, Message = "To Interrogate model, User Must be Logged In"});
            }

            var hasProject = _accessor.HasProjectPropertySet(Constants.PropertySets.CoBuilderMaster);

            if (hasProject)
            {
                var projectPropertySetInfo = _accessor.GetProjectPropertySet(Constants.PropertySets.CoBuilderMaster);

                UpdateSession(_session, projectPropertySetInfo);
                Interrogate(_selector.All());
                    return true;
                
            }
            return false;
        }

        public void Interrogate(IEnumerable<TElement> elements)
        {
            foreach (var element in elements)
            {
                var identifiers = _accessor.GetCoBuilderProductsPropertySet(element);
                var coBuilderIds =
                    identifiers.Where(i => i.Item1.StartsWith("CBProducts", StringComparison.InvariantCultureIgnoreCase));

                foreach (var identifier in coBuilderIds)
                {
                    var productId = identifier.Item2;
                    _connector.Connect(element, productId);
                }
            }
        }

        private ISession UpdateSession(IServiceSession session, ProjectPropertySetInfo projectPropertySetInfo)
        {
            session.C = projectPropertySetInfo.WorkplaceName;


            return session;
        }
    }
}