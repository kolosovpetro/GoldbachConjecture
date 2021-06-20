using FluentAssertions;
using GoldbachConjecture.BertrandValues.Validators;
using NUnit.Framework;

namespace GoldbachConjecture.BertrandValues.Tests
{
    [TestFixture]
    public class PrimeValidatorTests
    {
        public void ValidatorTest()
        {
            PrimeValidator.IsPrime(3).Should().BeTrue();
            PrimeValidator.IsPrime(5).Should().BeTrue();
            PrimeValidator.IsPrime(7).Should().BeTrue();
            PrimeValidator.IsPrime(9).Should().BeFalse();
            PrimeValidator.IsPrime(10).Should().BeFalse();
            PrimeValidator.IsPrime(11).Should().BeTrue();
        }
    }
}