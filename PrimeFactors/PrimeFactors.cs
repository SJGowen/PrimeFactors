using System;
using System.Collections.Generic;

namespace Primes
{
    public static class PrimeFactors
    {
        public static IList<int> Generate(int number)
        {
            var factors = new List<int>();

            for (var divisor = 2; number > 1; divisor++)
            {
                for (; number % divisor == 0; number /= divisor)
                {
                    factors.Add(divisor);
                }
            }

            return factors;
        }
    }
}