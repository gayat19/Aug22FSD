namespace UnderstandingTypesAndMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = int.MaxValue;
            //checked
            //{
            //    try
            //    {
            //        Console.WriteLine("Before increment " + num1);
            //        num1++;
            //        Console.WriteLine("After increment " + num1);
            //    }
            //    catch (OverflowException ofe)
            //    {

            //        Console.WriteLine("You have too much money. We are sending the IncomeTax departmnet for audit...");
            //    }
            //}
            int num1, num2;
            
            Console.WriteLine("Please enter the first number ");
            while(int.TryParse(Console.ReadLine(), out num1)==false)
            {
                Console.WriteLine("Invalid input for num1. Try again!!");
            }
            Console.WriteLine("Please enter the second number ");
            num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine($"The result of {num1} divided by {num2} is {result}");
            Console.WriteLine("Bye bye...");
            Console.ReadKey();
        }
    }
}