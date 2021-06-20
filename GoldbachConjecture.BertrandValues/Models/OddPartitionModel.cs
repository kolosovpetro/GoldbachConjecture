namespace GoldbachConjecture.BertrandValues.Models
{
    public class OddPartitionModel
    {
        public int Prime1 { get; set; }
        public int Prime2 { get; set; }
        public int BertrandPrime { get; set; }
        public int OddValue { get; set; }
        public bool ValidPartition { get; set; }

        public override string ToString()
        {
            return $"Number: {OddValue} = {Prime1} + {Prime2} + {BertrandPrime}, " +
                   $"where BertrandPrime = {BertrandPrime}, ValidPartition: {ValidPartition}";
        }
    }
}