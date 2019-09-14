using System.Collections.Generic;

namespace Tests
{
    public static class PrimeFactors
    {
        public static IList<int> Generate(int number)
        {
            var factors = new List<int>();

            for (var divisor = 2; number > 1; divisor++)
            {
                while (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number /= divisor;
                }
            }

            return factors;
        }
    }
}