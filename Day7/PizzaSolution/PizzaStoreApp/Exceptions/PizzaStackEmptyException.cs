namespace PizzaStoreApp.Exceptions
{
    public class PizzaStackEmptyException : Exception
    {
        string message;
        public PizzaStackEmptyException()
        {
            message = "No Pizzas available at this moment. Sorry";
        }
        public override string Message => message;
    }
}
