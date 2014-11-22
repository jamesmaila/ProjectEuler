using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    ///     Summation of primes
    ///     Problem 10
    ///        
    ///     The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    ///     Find the sum of all the primes below two million.
    /// </summary>
    public class _010
    {
        public _010()
        {
            const int twoMillion = 2000000;

            List<int> primes = new List<int>{0};

            // our first prime number is 2
            primes.Insert(1, 2);

            int n = 2;
            for (int i = 3; i <= twoMillion; i++)
            {
                // fill the prime list
                if (IsPrime(i, primes)) 
                { 
                    primes.Insert(n, i);
                    n++;
                }
            }

            long sum = 0;
            foreach (var prime in primes) { sum += prime; }

            Console.WriteLine("{0}", sum);
        }

        /// <summary>
        /// Determines if a number is prime.
        /// </summary>
        /// <param name="num"> Number we are checking for prime quality. </param>
        /// <param name="primes"> List of known primes. </param>
        /// <returns> True if prime, False if not. </returns>
        private static bool IsPrime(int num, List<int> primes)
        {
            int upperBound = (int)Math.Sqrt(num);

            for (int i = 1; i < upperBound; i++)
            {
                // if number is divisible by a known prime, we know it is not prime
                if (num % primes[i] == 0) { return false; }
            }

            // if number is not divisible by any known primes, we know it is prime
            return true;
        }
    }
}

