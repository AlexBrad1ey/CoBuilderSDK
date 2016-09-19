using System.Collections.Generic;
using System.Diagnostics;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Service.Logic
{
    public class ModelInterrogator<TElement> : IInterrogator<TElement> where TElement : class
    {
        private readonly IAppAccessor<TElement> _accessor;
        private readonly CoBuilderService _coBuilderService;
        private readonly ConnectionManager<TElement> _connector;
        private readonly IAppSelector<TElement> _selector;
        private readonly IServiceSession _session;

        public ModelInterrogator(ConnectionManager<TElement> connector,  IAppAccessor<TElement> accessor,
            IAppSelector<TElement> selector, IServiceSession session)
        {
            _coBuilderService = CoBuilderService.CurrentService;
            _connector = connector;
            _accessor = accessor;
            _selector = selector;
            _session = session;
        }

        public bool Interrogate()
        {
            if (!_session.LoggedIn)
            {
                throw new CoBuilderException(new Error() {Code = CoBuilderErrorCode.GeneralException.ToString(), Message = "To Interrogate model, User Must be Logged In"});
            }

            var hasProject = _accessor.HasProjectPropertySet(Constants.Identifiers.PropertySets.CoBuilderMaster);

            if (hasProject)
            {
                var projectPropertySetInfo = _accessor.GetProjectPropertySet(Constants.Identifiers.PropertySets.CoBuilderMaster);

                UpdateSession(_session, projectPropertySetInfo);
                _connector.Clear();
                Interrogate(_selector.All());
                    return true;
                
            }
            return false;
        }

        public void Interrogate(IEnumerable<TElement> elements)
        {
            if (_session.WorkplaceSet)
            {
                var productsRepo = _coBuilderService.Products;

                foreach (var element in elements)
                {
                    var keys = _accessor.GetCoBuilderProductKeys(element);

                    foreach (var key in keys)
                    {
                        if (key.WorkplaceId == _session.CurrentWorkplaceId)
                        {
                            var product = (BimProduct) productsRepo[key.ProductId];
                            if (product != null)
                            {
                                _connector.Connect(element, product);
                            }
                            else
                            {
                                Debug.WriteLine("Interrogate() - Identifier not accessible");
                            }
                        }
                        else
                        {
                            Debug.WriteLine("Interrogate() - WorkplaceId does not match Current Workplace");

                        }
                    }
                }

            }
            else
            {
                Debug.WriteLine("Interrogate() - Session has No Workplace");
            }

            
        }

        private IServiceSession UpdateSession(IServiceSession session, ProjectPropertySetInfo projectPropertySetInfo)
        {
            if (session.LoggedIn)
            {
                var workplaceRepo = _coBuilderService.WorkPlaces;
                var workplace = workplaceRepo.Get(projectPropertySetInfo.WorkplaceId);
                _coBuilderService.SetWorkplace(workplace);
            }
            else
            {
                Debug.WriteLine("Interrogate().UpdateSession() - session Not Logged In");
            }

            return session;
        }
    }
}