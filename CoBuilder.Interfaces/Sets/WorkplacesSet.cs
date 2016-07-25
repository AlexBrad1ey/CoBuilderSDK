using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Sets
{
    public class WorkplacesSet:ReadOnlyCollection<IWorkplace>, IWorkplacesSet
    {
        public WorkplacesSet(IList<IWorkplace> objectSet):base(objectSet)
        {
        }
    }
}