namespace PizzaStoreModelLibrary
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public void TakePizzaDeatilsFromConsole()
        {
            Console.WriteLine("Please enter the pizza name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the pizza pice");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the pizza initial quantity");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the pizza Veg??If yes Enter Veg else Non-Veg");
            Type = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Pizza Id : {Id} \n " +
                $"Pizza Name : {Name} \n" +
                $"Pizza Price : Rs.{Price} \n" +
                $"Pizza Quantity : {Quantity} \n" +
                $"Pizza Type : {Type}";
        }
        public override bool Equals(object? obj)
        {
            Pizza p1, p2;
            p1 = (Pizza)obj;
            p2 = this;
            if (p1.Id == p2.Id)
                return true;
            return false;
        }
    }
}