using Xunit;
using Prime.Services;

namespace Stack.Value.Tests
{
    public class Stack_Print_Value{

        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        public void IsPrime_ValuesEvenBiggerThan2_ReturnFalse(int value) {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void IsPrime_PrimeValue_ReturnTrue(int value) {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(9)]
        [InlineData(15)]
        public void IsPrime_PrimeValue_ReturnFalse(int value) {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should be prime");
 
        }

        [Theory]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(23)]
        public void IsPrime_PrimeValueGratterThan10_ReturnTrue(int value) {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(28)]
        [InlineData(33)]
        public void IsPrime_ValueGratterThan10NotPrime_ReturnFalse(int value) {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(1471)]
        [InlineData(1483)]
        public void IsPrime_PrimeValueGratterThan1000_ReturnTrue(int value) {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }
 


    }
}