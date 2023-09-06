namespace EmployeeApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Employee e1, e2;
            e1 = new Employee { Id = 101, Name = "Ramu" };
            e2 = new Employee { Id = 101, Name = "Ramu" };
            if(e1.Equals(e2) )
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Assert.AreEqual(e1 ,e2);
            Console.ReadKey();
        }
    }
}