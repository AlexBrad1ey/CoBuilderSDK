using System;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Repositories
{
    public class ConnectionStore<TElement> where TElement : class
    {
        private readonly HashSet<Connection<TElement>> _objectSet;

        public ConnectionStore()
        {
            _objectSet = new HashSet<Connection<TElement>>();
        }

        public void Add(Connection<TElement> item)
        {
            _objectSet.Add(item);
        }

        public void Clear()
        {
            _objectSet.Clear();
        }

        public void Remove(Connection<TElement> item)
        {
            _objectSet.Remove(item);
        }

        public bool Exists(Predicate<Connection<TElement>> match)
        {
            return _objectSet.Any(obj => match(obj));
        }

        public IQueryable<Connection<TElement>> GetQuerable()
        {
            return _objectSet.AsQueryable();
        }

        public IEnumerable<Connection<TElement>> GetAll()
        {
            return _objectSet;
        }

        public IEnumerable<Connection<TElement>> Find(Func<Connection<TElement>, bool> @where)
        {
            return _objectSet.Where(where);
        }

        public Connection<TElement> First(Func<Connection<TElement>, bool> @where)
        {
            return _objectSet.FirstOrDefault(where);
        }

        public Connection<TElement> Single(Func<Connection<TElement>, bool> @where)
        {
            return _objectSet.SingleOrDefault(where);
        }

        public bool Contains(Connection<TElement> item)
        {
            return _objectSet.Contains(item);
        }
    }
}