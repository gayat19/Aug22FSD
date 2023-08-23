using PizzaStoreModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDALLibrary
{
    public class PizzaRepository : IRepository<int, Pizza>
    {
        List<Pizza> pizzas = new List<Pizza>();
        public Pizza Add(Pizza item)
        {
            if(item == null) 
                throw new ArgumentNullException("No Pizza object present");
            item.Id = GeterateIndex();
            pizzas.Add(item);
            return item;
        }

        private int GeterateIndex()
        {
            int id = pizzas.Count;
            return ++id;
        }

        public Pizza Delete(int key)
        {
            Pizza pizza = GetById(key);
            pizzas.Remove(pizza);//How will it compare the pizza object???
            return pizza;    
        }

        public List<Pizza> GetAll()
        {
            if (pizzas.Count == 0)
               throw new PizzaStackEmptyException();
            return pizzas;
        }

        public Pizza GetById(int key)
        {
           Pizza pizza = pizzas.FirstOrDefault(p=>p.Id == key);//LINQ -> Language Integrated Query
            if(pizza == null)
                throw new InvalidOperationException("No pizza with id " + key);
            return pizza;
        }

        public Pizza Update(Pizza item)
        {
           Pizza pizza  =GetById(item.Id);
            pizza.Name = item.Name;
            pizza.Price = item.Price;
            pizza.Quantity = item.Quantity;
            pizza.Type = item.Type;
            return pizza;
        }
    }
}
