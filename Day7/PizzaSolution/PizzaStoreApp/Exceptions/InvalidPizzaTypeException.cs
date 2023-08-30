namespace PizzaStoreApp.Exceptions
{
    public class InvalidPizzaTypeException : Exception
    {
        string message;
        public InvalidPizzaTypeException()
        {
            message = "YNo such type of pizza ";
        }
        public override string Message => message;
    }
}
