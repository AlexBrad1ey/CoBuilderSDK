using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    public class WorkplacesCollection : ReadOnlyCollection<Workplace>, IWorkplacesCollection
    {
        public WorkplacesCollection(IList<Workplace> workplaces):base(workplaces)
        {
        }
    }
}