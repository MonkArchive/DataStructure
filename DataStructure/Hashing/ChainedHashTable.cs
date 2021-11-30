using System;

namespace Hashing
{
    public class ChainedHashTable<TKey, T> : IHashTable<TKey, T>
    {
        private class HashItem
        {
            internal TKey Key;
            internal T Data;
            internal HashItem Next;

            public HashItem(TKey key, T data)
            {
                Data = data;
                Key = key;
                Next = null;
            }
        }

        HashItem[] _table;
        private readonly int _size;

        private int HashFunc(TKey key)
        {
            var value = Int32.Parse(key.ToString());

            return value % (_size);
        }

        public ChainedHashTable(int size)
        {
            _size = size;
            _table = new HashItem[_size];
        }

        public bool Exists(TKey key)
        {
            // Find The Location for This Key
            int address = HashFunc(key);

            var item = _table[address];

            while ((item != null) && (!item.Key.Equals(key)))
                item = item.Next;

            return item == null ? false : true;
        }

        public T Remove(TKey key)
        {
            // Find The Location for This Key
            int address = HashFunc(key);

            // Start At The Head Of The Chain
            var item = _table[address];

            if (_table[address].Key.Equals(key))
            {
                _table[address] = _table[address].Next;
            } 
            else 
            {
                // Find The Item To Be Removed
                while ((item.Next != null) && (!item.Next.Key.Equals(key)))
                    item = item.Next;

                var prevItem = item;
                item = item.Next;
                prevItem.Next = item.Next;
            }

            return item == null ? default(T) : item.Data;
        }

        public T Retrieve(TKey key)
        {
            // Find The Location for This Key
            int address = HashFunc(key);

            var item = _table[address];

            while ((item != null) && (!item.Key.Equals(key)))
                item = item.Next;

            return item == null ? default(T) : item.Data;

        }

        public T Store(TKey key, T item)
        {
            // Find The Location for This Key
            int address = HashFunc(key);

            // Create A New Hash Item
            var newItem = new HashItem(key, item);

            // Add It To The Begininng Of The Chain (Even If There Is No Chain)
            newItem.Next = _table[address];
            _table[address] = newItem;

            return item;
        }
    }
}
