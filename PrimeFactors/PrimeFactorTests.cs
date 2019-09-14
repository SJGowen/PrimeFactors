using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class PrimeFactorTests
    {
        [Fact]
        public void PrimeFactors()  
        {
            Assert.Equal(ExpectedList(), Tests.PrimeFactors.Generate(1));
            Assert.Equal(ExpectedList(2), Tests.PrimeFactors.Generate(2));
            Assert.Equal(ExpectedList(3), Tests.PrimeFactors.Generate(3));
            Assert.Equal(ExpectedList(2, 2), Tests.PrimeFactors.Generate(4));
            Assert.Equal(ExpectedList(5), Tests.PrimeFactors.Generate(5));
            Assert.Equal(ExpectedList(2, 3), Tests.PrimeFactors.Generate(6));
            Assert.Equal(ExpectedList(7), Tests.PrimeFactors.Generate(7));
            Assert.Equal(ExpectedList(2, 2, 2), Tests.PrimeFactors.Generate(8));
            Assert.Equal(ExpectedList(3, 3), Tests.PrimeFactors.Generate(9));
            Assert.Equal(ExpectedList(2, 5), Tests.PrimeFactors.Generate(10));
            Assert.Equal(ExpectedList(2, 2, 3, 3, 5, 7, 11, 13), 
                Tests.PrimeFactors.Generate(2 * 2 * 3 * 3 * 5 * 7 * 11 * 13));
        }

        private IList<int> ExpectedList(params int[] expectedFactors)
        {
            return expectedFactors.ToList();
        }
    }
}