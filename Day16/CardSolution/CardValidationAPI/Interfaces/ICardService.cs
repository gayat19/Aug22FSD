namespace CardValidationAPI.Interfaces
{
    public interface ICardService
    {
        bool ValidateCard(string ccNumber);
    }
}
