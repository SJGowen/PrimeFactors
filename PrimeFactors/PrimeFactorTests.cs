using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Primes
{
    public class PrimeFactorTests
    {
        [Fact]
        public void PrimeFactors()  
        {
            Assert.Equal(ExpectedList(), Primes.PrimeFactors.Generate(1));
            Assert.Equal(ExpectedList(2), Primes.PrimeFactors.Generate(2));
            Assert.Equal(ExpectedList(3), Primes.PrimeFactors.Generate(3));
            Assert.Equal(ExpectedList(2, 2), Primes.PrimeFactors.Generate(4));
            Assert.Equal(ExpectedList(5), Primes.PrimeFactors.Generate(5));
            Assert.Equal(ExpectedList(2, 3), Primes.PrimeFactors.Generate(6));
            Assert.Equal(ExpectedList(7), Primes.PrimeFactors.Generate(7));
            Assert.Equal(ExpectedList(2, 2, 2), Primes.PrimeFactors.Generate(8));
            Assert.Equal(ExpectedList(3, 3), Primes.PrimeFactors.Generate(9));
            Assert.Equal(ExpectedList(2, 5), Primes.PrimeFactors.Generate(10));
            Assert.Equal(ExpectedList(11), Primes.PrimeFactors.Generate(11));
            Assert.Equal(ExpectedList(2, 2, 3), Primes.PrimeFactors.Generate(12));
            Assert.Equal(ExpectedList(13), Primes.PrimeFactors.Generate(13));
            Assert.Equal(ExpectedList(2, 7), Primes.PrimeFactors.Generate(14));
            Assert.Equal(ExpectedList(3, 5), Primes.PrimeFactors.Generate(15));
            Assert.Equal(ExpectedList(2, 2, 2, 2), Primes.PrimeFactors.Generate(16));
            Assert.Equal(ExpectedList(17), Primes.PrimeFactors.Generate(17));
            Assert.Equal(ExpectedList(2, 3, 3), Primes.PrimeFactors.Generate(18));
            Assert.Equal(ExpectedList(19), Primes.PrimeFactors.Generate(19));
            Assert.Equal(ExpectedList(2, 2, 5), Primes.PrimeFactors.Generate(20));
            Assert.Equal(ExpectedList(3, 7), Primes.PrimeFactors.Generate(21));
            Assert.Equal(ExpectedList(2, 2, 3, 3, 5, 7, 11, 13), 
                Primes.PrimeFactors.Generate(2 * 2 * 3 * 3 * 5 * 7 * 11 * 13));
        }

        private IList<int> ExpectedList(params int[] expectedFactors)
        {
            return expectedFactors.ToList();
        }
    }
}