using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GoldbachConjecture.BertrandValues.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PrimesTest()
        {
            var interval = new BertrandIntervalGenerator(2);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {3});

            interval = new BertrandIntervalGenerator(3);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {5});

            interval = new BertrandIntervalGenerator(4);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {5, 7});

            interval = new BertrandIntervalGenerator(5);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {7});
            
            interval = new BertrandIntervalGenerator(6);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {7, 11});            
            
            interval = new BertrandIntervalGenerator(7);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {11, 13});
            
            interval = new BertrandIntervalGenerator(8);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {11, 13});
            
            interval = new BertrandIntervalGenerator(9);
            interval.GeneratePrimes();
            interval.Primes.Should().BeEquivalentTo(new List<int> {11, 13, 17});
        }
    }
}