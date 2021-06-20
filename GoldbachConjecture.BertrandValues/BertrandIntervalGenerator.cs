using System;
using System.Collections.Generic;
using GoldbachConjecture.BertrandValues.Validators;

namespace GoldbachConjecture.BertrandValues
{
    public class BertrandIntervalGenerator
    {
        private int StartValue { get; }
        private int EndValue { get; }

        public List<int> Primes { get; }

        public BertrandIntervalGenerator(int startValue)
        {
            if (startValue <= 0)
            {
                throw new InvalidOperationException("Start value must be greater or equal to 1");
            }

            StartValue = startValue;
            EndValue = 2 * StartValue;
            Primes = new List<int>();
        }

        public void GeneratePrimes()
        {
            for (int i = StartValue + 1; i < EndValue; i++)
            {
                var isPrime = PrimeValidator.IsPrime(i);

                if (isPrime)
                {
                    Primes.Add(i);
                }
            }
        }
    }
}