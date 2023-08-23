using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBLLibrary
{
    public class InValidPizzaPriceRangeException: Exception
    {
        string message;
        public InValidPizzaPriceRangeException()
        {
            message = "The price range is not valid";
        }
        public override string Message => message;
    }
}
