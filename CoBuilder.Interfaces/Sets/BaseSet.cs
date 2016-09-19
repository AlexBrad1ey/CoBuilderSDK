using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoBuilder.Service.Sets
{
    public class BaseSet<TEntity> : ReadOnlyCollection<TEntity>, ICBSet<TEntity> where TEntity : class, IEntity
    {
        internal BaseSet(IList<TEntity> entitySet) : base(entitySet)
        {
        }

        internal BaseSet() : base(new List<TEntity>())
        {
            
        }
    }
}