namespace FirstApp
{
    internal class Program
    {
        int number1, number2;
        void TakeTwoNumbers()
        {
            Console.WriteLine("Please enter the first number ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number ");
            number2 = Convert.ToInt32(Console.ReadLine());
        }
        int Add(int n1,int n2)
        {
            return n1 + n2;
        }
        void CalculateAndPrint()
        {
            TakeTwoNumbers();
            int result = Add(number1, number2);
            Console.WriteLine($"The sum of {number1} and {number2} is {result}");
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.CalculateAndPrint();
            ManageEmployee manageEmployee = new ManageEmployee();
            Employee employee = manageEmployee.CreateEmployeeByTakingDetailsFromConsole();
            manageEmployee.PrintEmployeeDetails(employee);

            //Ensure the bellow is the last line in the main method. Since it is used to make teh output window stay put
            Console.ReadKey();//Just to make the console wait for user key stroke
        }
    }
}