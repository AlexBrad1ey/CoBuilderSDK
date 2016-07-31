using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoBuilder.Service.Sets
{
    public class BaseSet<TEntity> : ReadOnlyCollection<TEntity>, ICBSet<TEntity> where TEntity : class, IEntity
    {
        protected readonly ICoBuilderContext Ctx;

        internal BaseSet(IList<TEntity> entitySet, ICoBuilderContext ctx) : base(entitySet)
        {
            Ctx = ctx;
            foreach (var entity in this)
            {
                entity.Context = Ctx;
            }
        }
    }
}