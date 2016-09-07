using System;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Repositories
{
    public class WorkPlacesRepository:IWorkplacesRepository
    {
        private IWorkplacesSet _workplacesSet;

        public WorkPlacesRepository(ICoBuilderContext ctx)
        {
            _workplacesSet = ctx.WorkplacesAsync().Result;
        }

        public IWorkplace Get(int key)
        {
            return _workplacesSet.FirstOrDefault(x => x.Id == key);
        }

        public IEnumerable<IWorkplace> FindAll()
        {
            return _workplacesSet;
        }

        public IWorkplace this[int key]
        {
            get { return Get(key); }
        }
    }
}