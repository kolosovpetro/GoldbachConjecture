using System.IO;
using System.Threading.Tasks;
using GoldbachConjecture.BertrandValues.Models;
using GoldbachConjecture.BertrandValues.Validators;

namespace GoldbachConjecture.BertrandValues
{
    public static class OddPartitionWriter
    {
        public static async Task WritePartitions(string path, string fileName, int maxValue)
        {
            await using var sw = new StreamWriter(path + fileName);
            
            for (var i = 1; i <= maxValue; i++)
            {
                var interval = new BertrandIntervalGenerator(i);
                interval.GeneratePrimes();

                var model = new BertrandIntervalModel
                {
                    StartValue = i,
                    EndValue = 2 * i,
                    Primes = interval.Primes
                };

                foreach (var prime in model.Primes)
                {
                    if (prime == 2 * i - 1)
                    {
                        continue;
                    }

                    var partition = OddPartitionValidator
                        .GenerateOddPartition(2 * i + 1, prime);

                    await sw.WriteLineAsync(partition.ToString());
                }
            }
        }
    }
}