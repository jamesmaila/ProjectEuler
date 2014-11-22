using System;

namespace ProjectEuler
{
    /// <summary>
    /// Highly divisible triangular number
    /// Problem 12
    ///    
    /// The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
    ///
    ///     1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    ///
    ///     Let us list the factors of the first seven triangle numbers:
    ///
    ///     1: 1
    ///     3: 1,3
    ///     6: 1,2,3,6
    ///     10: 1,2,5,10
    ///     15: 1,3,5,15
    ///     21: 1,3,7,21
    ///     28: 1,2,4,7,14,28
    ///     We can see that 28 is the first triangle number to have over five divisors.
    ///
    ///     What is the value of the first triangle number to have over five hundred divisors?
    /// </summary>
    public class _012
    {
        public _012()
        {
            const int minDivisors = 500;

            // nth triangle number is n * (n + 1) / 2
            int n = 1;
            while (CountDivisors(n * (n + 1) / 2) < minDivisors) { n++; }

            int triangleNum = n * (n + 1) / 2;

            Console.Write("{0}", triangleNum);
        }

        /// <summary>
        /// Counts the number of divisors of a number.
        /// </summary>
        /// <param name="num"> The number to count divisors for. </param>
        /// <returns> The number of divisors of num. </returns>
        private static int CountDivisors(int num)
        {
            int upperBound = (int)Math.Sqrt(num);
            int count = 0;
            for (int i = 1; i <= upperBound; i++)
            {
                if (num % i == 0) { count += 2; }
            }

            // if perfect square, remove double count
            if (upperBound * upperBound == num) { count--; }

            return count;
        }
    }
}

