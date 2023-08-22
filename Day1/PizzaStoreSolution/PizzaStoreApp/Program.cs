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
                Console.WriteLine("3. Exit App");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InitiazeStock();
                        break;
                    case 2:
                        ListStock();
                        break;
                    case 3:
                        Console.WriteLine("Byeeeeeee");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice !=3);
        }
        void ListStock()
        {
            List<Pizza> pizzas = managePizza.GetPizzas();
            foreach (Pizza p in pizzas)
            {
                managePizza.PrintPizza(p);
            }
        }
        void InitiazeStock()
        {
            do
            {
                Console.WriteLine("Please enter the Pizza Details");
                Pizza pizza = managePizza.TakePizzaDeatilsFromConsole();
                managePizza.AddPizza(pizza);
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

            Console.ReadKey();
        }
    }
}