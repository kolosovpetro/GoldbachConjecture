using GoldbachConjecture.BertrandValues.Models;

namespace GoldbachConjecture.BertrandValues.Validators
{
    public static class OddPartitionValidator
    {
        public static OddPartitionModel GenerateOddPartition(int value, int bertrandPrime)
        {
            var difference = value - bertrandPrime;
            var left = difference / 2;
            var right = left;

            if (PrimeValidator.IsPrime(left) && PrimeValidator.IsPrime(right))
            {
                return new OddPartitionModel
                {
                    OddValue = value,
                    BertrandPrime = bertrandPrime,
                    Prime1 = left,
                    Prime2 = right,
                    ValidPartition = true,
                };
            }

            for (int i = 1; i < right - 1; i++)
            {
                left -= 1;
                right += 1;

                if (PrimeValidator.IsPrime(left) && PrimeValidator.IsPrime(right))
                {
                    return new OddPartitionModel
                    {
                        OddValue = value,
                        BertrandPrime = bertrandPrime,
                        Prime1 = left,
                        Prime2 = right,
                        ValidPartition = true,
                    };
                }
            }

            return new OddPartitionModel {BertrandPrime = bertrandPrime, OddValue = value};
        }
    }
}