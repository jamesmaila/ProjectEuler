using System;

namespace ProjectEuler
{
    /// <summary>
    ///     Largest prime factor
    ///     Problem 3
    /// 
    ///     The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    ///     What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class _003
    {
        public _003()
        {
            long num = 600851475143;

            long i;
            for (i = (long)Math.Sqrt(num); i > 1; i--)
            {
                if (num % i == 0 && IsPrime(i)) { break; }
            }

            Console.WriteLine("{0}", i);
        }

        /// <summary>
        /// Determines if a number is prime.
        /// </summary>
        /// <param name="num"> Number we are checking for prime quality. </param>
        /// <returns> True if prime, False if not. </returns>
        private static bool IsPrime(long num)
        {
            long i = num - 1;

            while (i > 1)
            {
                if (num % i == 0) { return false; }
                i--;
            }

            return true;
        }
    }
}

