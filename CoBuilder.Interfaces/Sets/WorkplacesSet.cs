using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoBuilder.Service.Sets
{
    public class WorkplacesSet : BaseSet<IWorkplace>, IWorkplacesSet
    {
        public WorkplacesSet(IWorkplacesCollection collection, ICoBuilderContext ctx)
            : base((IList<IWorkplace>)collection.Select(x => new Workplace(x,ctx)))
        {

        }
    }
}