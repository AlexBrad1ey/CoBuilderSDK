using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;


namespace CoBuilder.Service.Repositories
{
    public class ConnectionRepository<TElement> where TElement : class
    {
        private readonly ConcurrentDictionary<Connection<TElement>,ConnectionState> _objectSet;

        public ConnectionRepository()
        {
            _objectSet = new ConcurrentDictionary<Connection<TElement>,ConnectionState>();
        }

        public IEnumerable<Connection<TElement>> All()
        {
            return _objectSet.Keys;
        }

        public IEnumerable<Connection<TElement>> Current()
        {
            return
                _objectSet.Where(kvp => kvp.Value.State == State.Current || kvp.Value.State == State.Added)
                    .Select(kvp => kvp.Key);
        }

        public void Add(Connection<TElement> item)
        {
            _objectSet.TryAdd(item, new ConnectionState());
        }

        public void Clear()
        {
            foreach (var connection in _objectSet)
            {
                connection.Value.State = State.Removed;
            }
        }

        public void Remove(Connection<TElement> item)
        {
            ConnectionState state;
            if(_objectSet.TryGetValue(item, out state))
                state.State = State.Removed;
        }

        internal void Clean()
        {
            var removals = new List<Connection<TElement>>();

            foreach (var kvp in _objectSet)
            {
                if (kvp.Value.State == State.Removed)
                {
                    removals.Add(kvp.Key);
                }
            }

            foreach (var connection in removals)
            {
                ConnectionState state;
                _objectSet.TryRemove(connection, out state);
            }
        }

        public IEnumerable<Connection<TElement>> Find(Func<Connection<TElement>, bool> where)
        {
            return _objectSet.Keys.Where(where);
        }

        public Connection<TElement> First(Func<Connection<TElement>, bool> @where)
        {
            return _objectSet.Keys.FirstOrDefault(where);
        }

        public Connection<TElement> Single(Func<Connection<TElement>, bool> @where)
        {
            return _objectSet.Keys.SingleOrDefault(where);
        }

        public bool Contains(Connection<TElement> item)
        {
            return _objectSet.Keys.Contains(item);
        }

        internal IEnumerable<Connection<TElement>> ToBeRemoved()
        {
            return _objectSet.Where(kvp => kvp.Value.State == State.Removed).Select(kvp => kvp.Key);
        }

        internal IEnumerable<Connection<TElement>> ToBeAdded()
        {
            return _objectSet.Where(kvp => kvp.Value.State == State.Added).Select(kvp => kvp.Key);
        }

        internal void UpdateState()
        {
            foreach (var connectionState in _objectSet.Values.Where(x => x.State == State.Added))
            {
                connectionState.State = State.Current;
            }
        }

        
    }

    internal class ConnectionState
    {
        internal ConnectionState()
        {
            State = State.Added;
        }
        internal State State { get; set; }
    }
}