using System;

namespace ProjectEuler
{
    /// <summary>
    ///     Smallest multiple
    ///     Problem 5
    ///
    ///     2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    ///     What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class _005
    {
        public _005()
        {
            const int range = 20;
            int num = range;

            while (!IsEvenlyDivisible(num, range)) { num += range; }

            Console.WriteLine("{0}", num);
        }

        /// <summary>
        /// Determines if a number is evenly divisible by all numbers in 1 to range.
        /// </summary>
        /// <param name="num"> Number we are checking for evenly divisible quality. </param>
        /// <param name="range"> The range of numbers starting from 1 we are confirming divisible. </param>
        /// <returns> True if evenly divisible, False if not. </returns>
        private static bool IsEvenlyDivisible(int num, int range)
        {
            for (int i = 2; i <= range; i++)
            {
                if (num % i != 0) { return false; }
            }

            return true;
        }
    }
}

