using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreApp
{
    internal class ManagePizza
    {
        //Pizza[] pizzas = new Pizza[10];
        //A collection of Pizza objects
        List<Pizza> pizzas = new List<Pizza>();
        public void AddPizza(Pizza pizza)
        {
            int id = pizzas.Count;
            pizza.Id = ++id;
            pizzas.Add(pizza);
        }
        public Pizza TakePizzaDeatilsFromConsole()
        {
            Pizza pizza = new Pizza();
            Console.WriteLine("Please enter the pizza name");
            pizza.Name = Console.ReadLine();
            Console.WriteLine("Please enter the pizza pice");
            pizza.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the pizza initial quantity");
            pizza.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the pizza Veg??If yes Enter Veg else Non-Veg");
            pizza.Type = Console.ReadLine();
            return pizza;
        }
        public List<Pizza> GetPizzas()
        {
             return pizzas;
        }
        public void PrintPizza(Pizza pizza)
        {
            Console.WriteLine($"Pizza Id : {pizza.Id}");
            Console.WriteLine($"Pizza Name : {pizza.Name}");
            Console.WriteLine($"Pizza Price : Rs.{pizza.Price}");
            Console.WriteLine($"Pizza Quantity : {pizza.Quantity}");
            Console.WriteLine($"Pizza Type : {pizza.Type}");
        }
    }
}
