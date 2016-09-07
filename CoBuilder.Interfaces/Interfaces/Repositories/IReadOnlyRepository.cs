using System.Collections.Generic;

namespace CoBuilder.Service.Interfaces
{
    public interface IReadOnlyRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey key);
        IEnumerable<TEntity> FindAll();
        TEntity this[TKey key] { get; }
    }
}