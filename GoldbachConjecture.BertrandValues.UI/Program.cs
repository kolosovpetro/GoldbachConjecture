using System;
using System.Threading.Tasks;
using GoldbachConjecture.BertrandValues.Validators;

namespace GoldbachConjecture.BertrandValues.UI
{
    internal static class Program
    {
        private static async Task Main()
        {
            Console.WriteLine(PrimeValidator.IsPrime(2));
            Console.WriteLine(PrimeValidator.IsPrime(5));

            await BertrandPrimesFileWriter.WritePrimesToFile("PrimesTo20.txt", "../../../", 20);
            var partition = OddPartitionValidator.GenerateOddPartition(41, 23);
            Console.WriteLine(partition);
            await OddPartitionWriter.WritePartitions("../../../", "PartitionsTo5000.txt", 2500);
        }
    }
}