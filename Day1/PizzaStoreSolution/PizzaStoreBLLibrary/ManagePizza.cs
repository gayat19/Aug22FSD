using PizzaStoreDALLibrary;
using PizzaStoreModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaStoreBLLibrary
{
    public class ManagePizza
    {
        IRepository<int, Pizza> repository = new PizzaRepository();
    
        public ICollection<Pizza> GetPizzas()
        {
            return repository.GetAll();
        }
        /// <summary>
        /// This method will get the pizzas of the type that you provide(Veg/Non-Veg)
        /// </summary>
        /// <param name="type">Veg/Non-Veg</param>
        /// <returns></returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        /// <exception cref="InvalidPizzaTypeException"></exception>
        public ICollection<Pizza> GetPizzaByType(string type)
        {
            var pizzas = GetPizzas();
            if (type == "Veg" || type == "Non-Veg")
            {
                var typeSpecificPizza = pizzas.Where(p => p.Type == type).ToList();
                if (typeSpecificPizza.Count == 0)
                    throw new PizzaStackEmptyException();
                return typeSpecificPizza;
            }
            throw new InvalidPizzaTypeException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        /// <exception cref="InValidPizzaPriceRangeException"></exception>
        public ICollection<Pizza> GetPizzasByRange(int min, int max)
        {
            var pizzas = GetPizzas();
            if (min >=00 || max >0)
            {
                var pizzasInRange = pizzas.Where(p => p.Price>=min && p.Price<=max).ToList();
                if (pizzasInRange.Count == 0)
                    throw new PizzaStackEmptyException();
                return pizzasInRange;
            }
            throw new InValidPizzaPriceRangeException();
        }
        public Pizza AddANewPizza(Pizza pizza)
        {
            repository.Add(pizza);
            return pizza;
        }
    }
}
