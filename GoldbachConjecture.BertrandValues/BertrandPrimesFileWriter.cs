using System.IO;
using System.Threading.Tasks;
using GoldbachConjecture.BertrandValues.Models;

namespace GoldbachConjecture.BertrandValues
{
    public static class BertrandPrimesFileWriter
    {
        public static async Task WritePrimesToFile(string fileName, string path, int maxValue)
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

                await sw.WriteLineAsync(model.ToString());
            }
        }
    }
}