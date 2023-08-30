using PIzzaStoreModelLibrary;

namespace PizzaStoreApp.Models
{
    public class PizzaWithPic :Pizza
    {
        public string? Pic { get; set; }
        public override bool Equals(object? obj)
        {
            return ((PizzaWithPic)obj).Id== Id;
        }
    }
}
