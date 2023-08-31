namespace CompanyApplication.Interfaces
{
    public interface IRepository<K,T>
    {
        public T Add(T entity);
        public T Delete(K key);
        public T Get(K key);

        public T Update(T entity);
        public ICollection<T> GetAll();
    }
}
