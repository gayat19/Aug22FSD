namespace PizzaStoreApp.Exceptions
{
    public class InValidPizzaPriceRangeException : Exception
    {
        string message;
        public InValidPizzaPriceRangeException()
        {
            message = "The price range is not valid";
        }
        public override string Message => message;
    }
}
