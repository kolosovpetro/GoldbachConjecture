using System.Collections.Generic;
using System.Text;

namespace GoldbachConjecture.BertrandValues.Models
{
    public class BertrandIntervalModel
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public List<int> Primes { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"Start {StartValue}, End {EndValue}: ");
            
            foreach (var prime in Primes)
            {
                builder.Append($"{prime}, ");
            }

            return builder.ToString();
        }
    }
}