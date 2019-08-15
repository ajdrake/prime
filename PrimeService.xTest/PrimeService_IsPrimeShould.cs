using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = PrimeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var result = PrimeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs65537_ReturnTrue()
        {
            var result = PrimeService.IsPrime(65537);

            Assert.True(result, "65537 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs54321_ReturnTrue()
        {
            Assert.False(54321.IsPrime(), $"54321 should not be prime"); 
        }


        [Fact]
        public void IsPrime_InputList_ReturnTrue()
        {
            ulong [] knownPrimes = new ulong[] { 18351495660265916411, 0xFF3F3176F0042401, 0xE3ED255CA44292AD, 7, 11, 13};
            foreach (ulong prime in knownPrimes)
            {
                var result = PrimeService.IsPrime(prime);
                Assert.True(result, $"{prime} should be prime");
            }
        }
    }
}