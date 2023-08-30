using PizzaStoreApp.Exceptions;
using PizzaStoreApp.Interfaces;
using PizzaStoreApp.Models;
using PIzzaStoreModelLibrary;

namespace PizzaStoreApp.Repositories
{
    public class PizzaRepository :IRepository<int, PizzaWithPic>
    {
        static List<PizzaWithPic> pizzas = new List<PizzaWithPic>()
        {
            new PizzaWithPic{Id=1,Name="Schezwan Margherita", Price=389,Quantity=3,Type="Non-Veg",Pic="/images/Pizza1.jpeg"},
            new PizzaWithPic{Id=2,Name="Ultimate Tandoori Veggie", Price=609,Quantity=2,Type="Veg" ,Pic="/images/Pizza2.jpeg"}
        };
        public PizzaWithPic Add(PizzaWithPic item)
        {
            if (item == null)
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

        public PizzaWithPic Delete(int key)
        {
            PizzaWithPic pizza = GetById(key);
            pizzas.Remove(pizza);//How will it compare the pizza object???
            return pizza;
        }

        public List<PizzaWithPic> GetAll()
        {
            if (pizzas.Count == 0)
                throw new PizzaStackEmptyException();
            return pizzas;
        }

        public PizzaWithPic GetById(int key)
        {
            PizzaWithPic pizza = pizzas.FirstOrDefault(p => p.Id == key);//LINQ -> Language Integrated Query
            if (pizza == null)
                throw new InvalidOperationException("No pizza with id " + key);
            return pizza;
        }

        public PizzaWithPic Update(PizzaWithPic item)
        {
            PizzaWithPic pizza = GetById(item.Id);
            pizza.Name = item.Name;
            pizza.Price = item.Price;
            pizza.Quantity = item.Quantity;
            pizza.Type = item.Type;
            return pizza;
        }
    }
}
