namespace PizzaStoreApp.Models.DTO
{
    public class PriceRangeDTO
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public ICollection<PizzaWithPic> SearchedPizzas { get; set; }
    }
}
