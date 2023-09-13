using System.ComponentModel.DataAnnotations;

namespace CardValidationAPI.Models
{
    public class CardResult:Card
    {
        
        public bool IsValid { get; set; }
    }
}
