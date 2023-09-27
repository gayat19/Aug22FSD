using PizzaStoreApp.Models;
using PIzzaStoreModelLibrary;

namespace PizzaStoreApp.Interfaces
{
    public interface IPizzaService
    {
        public ICollection<PizzaWithPic> GetPizzasByRange(int min, int max);
        public ICollection<PizzaWithPic> GetPizzaByType(string type);
        public ICollection<PizzaWithPic> GetAllPizzas();
    }
}
