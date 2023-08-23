using PizzaStoreBLLibrary;
using PizzaStoreDALLibrary;
using PizzaStoreModelLibrary;

namespace PizzaStoreApp
{
    internal class Program
    {
        ManagePizza managePizza = new ManagePizza();
        void InitializeStore()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Welcome to the PIzza Store Initial Set-Up");
                Console.WriteLine("1. Enter the Pizza Stock");
                Console.WriteLine("2. List the stock");
                Console.WriteLine("3. List pizza by type");
                Console.WriteLine("4. List pizza by range");
                Console.WriteLine("0. Exit App");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Byeeeeeee");
                        break;
                    case 1:
                        InitiazeStock();
                        break;
                    case 2:
                        ListStock();
                        break;
                    case 3:
                        ListPizzaByType();
                        break;
                    case 4:
                        ListPizzaByRange();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice !=0);
        }

        private void ListPizzaByType()
        {
            Console.WriteLine("Please enter the type of pizaa. Veg/Non-Veg");
            try
            {
                string type = Console.ReadLine();
                List<Pizza> pizzas = managePizza.GetPizzaByType(type).ToList();
                PrintPizzas(pizzas);
            }
            catch (PizzaStackEmptyException psee)
            {
                Console.WriteLine(psee.Message);
            }
            catch(InvalidPizzaTypeException ipte)
            {
                Console.WriteLine(ipte.Message);
            }
        }
        private void ListPizzaByRange()
        {
            try
            {
                Console.WriteLine("Please enter the min price");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the max price");
                int max = Convert.ToInt32(Console.ReadLine());
                List<Pizza> pizzas = managePizza.GetPizzasByRange(min,max).ToList();
                PrintPizzas(pizzas);
            }
            catch (PizzaStackEmptyException psee)
            {
                Console.WriteLine(psee.Message);
            }
            catch (InValidPizzaPriceRangeException ipte)
            {
                Console.WriteLine(ipte.Message);
            }
        }
        void PrintPizzas(ICollection<Pizza> pizzas)
        {
            foreach (Pizza p in pizzas)
            {
                Console.WriteLine(p);
            }
        }
        void ListStock()
        {
            List<Pizza> pizzas = managePizza.GetPizzas().ToList();
            PrintPizzas(pizzas);
        }
        void InitiazeStock()
        {
            do
            {
                Console.WriteLine("Please enter the Pizza Details");
                Pizza pizza = new Pizza();
                pizza.TakePizzaDeatilsFromConsole();
                managePizza.AddANewPizza(pizza);
                Console.WriteLine("Do you want to enter another Pizza??. Enter yes to do so");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                    break;

            } while (true);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitializeStore();
            //int[] scores = { 78, 90, 23, 93, 67, 87, 85 };

            ////var distinction = scores.Where(x => x >70).ToList();
            ////foreach (int score in distinction)
            ////    Console.WriteLine(score);

            //var score = scores.FirstOrDefault(s => s > 80);
            //Console.WriteLine(score);
            Console.ReadKey();
        }
    }
}