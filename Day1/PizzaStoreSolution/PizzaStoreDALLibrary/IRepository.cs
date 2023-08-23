using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDALLibrary
{
    public interface IRepository<K,T>
    {
        List<T> GetAll();
        T GetById(K key);
        T Add(T item);
        T Update(T item);
        T Delete(K key);

    }
}
