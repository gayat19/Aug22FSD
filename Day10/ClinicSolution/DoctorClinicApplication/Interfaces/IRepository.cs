using DoctorClinicApplication.Models;

namespace DoctorClinicApplication.Interfaces
{
    public interface IRepository<K,T> where T : class
    {
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(K key);
        public T GetById(K key);
        public ICollection<T> GetAll();
    }
  
}
