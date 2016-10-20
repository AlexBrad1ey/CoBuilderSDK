using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Infrastructure;

namespace CoBuilder.Service.Sets
{
    public class WorkplacesSet : BaseSet<IWorkplace>, IWorkplacesSet
    {
        private ICoBuilderContext _ctx;

        public WorkplacesSet(ICoBuilderContext ctx)
        {
            _ctx = ctx;
        }

        public WorkplacesSet(IWorkplacesCollection collection, ICoBuilderContext ctx)
            : base(collection.Select(x => (IWorkplace)new Workplace(x,ctx)).ToList())
        {
            _ctx = ctx;
        }

        internal ICoBuilderContext Ctx
        {
            get { return _ctx; }
        }
    }
}