using System;
using System.Numerics;

namespace ProjectEuler
{
    /// <summary>
    /// Factorial digit sum
    /// Problem 20
    ///     n! means n × (n − 1) × ... × 3 × 2 × 1
    ///
    ///     For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    ///     and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    ///
    ///     Find the sum of the digits in the number 100!
    /// </summary>
    public class _020
    {
        public _020()
        {
            const int num = 100;
            string result = Factorial(new BigInteger(num)).ToString();

            int sum = 0;
            foreach (var digit in result)
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            Console.WriteLine("{0}", sum);
        }

        /// <summary>
        /// Computes the factorial of num.
        /// </summary>
        /// <param name="num"> The number we are computing the factorial of. </param>
        /// <returns> The factorial of num. </returns>
        private static BigInteger Factorial(BigInteger num)
        {
            if (num == 1) { return 1; }

            return num * Factorial(num - 1);
        }
    }
}

