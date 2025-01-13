using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1, "Not a prime Number")]
        [InlineData(0, "Not a prime Number")]
        [InlineData(1, "Not a prime Number")]
        [InlineData(7, "Not a prime Number")]
        [InlineData(11, "Prime Number")]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value, string statement)
        {
            var result = _primeService.IsPrime(value, statement);

            Assert.True(result, "Answer Not Correct");
        }
    }
}