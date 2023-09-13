using CardValidationAPI.Interfaces;

namespace CardValidationAPI.Services
{
    public class CardService : ICardService
    {
        public bool ValidateCard(string ccNumber)
        {
            var numberCheckResult = CheckCardNumber(ccNumber);
            if (numberCheckResult)
            {
                ccNumber = ReverseCardnumner(ccNumber);
                int[] cardNumber = ConvertStringToArray(ccNumber);
                cardNumber = IdentifyEvenPositionAndProcess(cardNumber);
                int sum = SumTheArray(cardNumber);
                return CheckMod(sum);
            }
            return false;
        }
        bool CheckCardNumber(string ccNumber)
        {
            foreach (var item in ccNumber)
            {
                if(char.IsNumber(item)==false)
                    return false;
            }
            return true;
        }
        string ReverseCardnumner(string ccNumber)
        {
            var reversedNumber = new string(ccNumber.Reverse().ToArray());
            return reversedNumber;
        }
        int[] ConvertStringToArray(string ccNumber)
        {
            int[] cardNumber = new int[ccNumber.Length];
            for (int i = 0; i < ccNumber.Length; i++)
            {
                cardNumber[i] = Convert.ToInt32(ccNumber[i].ToString());
            }
            return cardNumber;
        }
        int[] IdentifyEvenPositionAndProcess(int[] ccNumber)
        {
            for (int i = 0; i < ccNumber.Count(); i++)
            {
                if(i%2 != 0)
                {
                    ccNumber[i] *= 2;
                    if (ccNumber[i] >9)
                    {
                        ccNumber[i] -= 9;
                    }
                }
            }
            return ccNumber;

        }
        int SumTheArray(int[] ccNumber)
        {
            int sum = 0;
            sum = ccNumber.Sum();
            return sum;
        }
        bool CheckMod(int ccNumber)
        {
            if (ccNumber%10 == 0)
                return true;
            return false;
        }
    }
}
