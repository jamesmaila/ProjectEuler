using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    ///     10001st prime
    ///     Problem 7
    ///
    ///     By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    ///
    ///     What is the 10,001st prime number?
    /// </summary>
    public class _007
    {
        public _007()
        {
            const int nthPrime = 10001;

            List<int> primes = new List<int>{0};

            // our first prime number is 2
            primes.Insert(1, 2);

            int n = 2;
            for (int i = 3; n <= nthPrime; i++)
            {
                if (IsPrime(i, primes))
                {
                    // fill the prime list
                    primes.Insert(n, i);
                    n++;
                }
            }

            Console.WriteLine("{0}", primes[nthPrime]);
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

