using System;
using System.Numerics;
using System.Collections.Generic;
using System.Collections;

namespace BigBoys.Lua
{
    public class Table : IEnumerable<KeyValuePair<object, object>>
    {
        private Dictionary<object, object> _storage = new Dictionary<object, object>();

        public bool Contains(object key) => _storage.ContainsKey(key);

        public IEnumerator<KeyValuePair<object, object>> GetEnumerator() => _storage.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _storage.GetEnumerator();

        public object this[object key]
        {
            get => key != null && _storage.ContainsKey(key) ? _storage[key] : null;
            set => _storage[key] = value;
        }

        public int Count => _storage.Count;
    }
}
