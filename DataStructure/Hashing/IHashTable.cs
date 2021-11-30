namespace Hashing
{
    public interface IHashTable<TKey, T>
    {
        public T Store(TKey key, T item);

        public T Retrieve(TKey key);

        public bool Exists(TKey key);

        public T Remove(TKey key);
    }
}
