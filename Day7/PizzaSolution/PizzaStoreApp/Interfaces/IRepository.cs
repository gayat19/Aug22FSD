namespace PizzaStoreApp.Interfaces
{
 
    public interface IRepository<K, T>
    {
        List<T> GetAll();
        T GetById(K key);
        T Add(T item);
        T Update(T item);
        T Delete(K key);

    }
}
