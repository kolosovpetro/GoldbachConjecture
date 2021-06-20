namespace GoldbachConjecture.BertrandValues.Validators
{
    public static class PrimeValidator
    {
        public static bool IsPrime(int number)
        {
            if (number == 1 || number < 1)
            {
                return false;
            }

            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}