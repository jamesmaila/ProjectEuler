using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    /// Longest Collatz sequence
    /// Problem 14
    ///        
    /// The following iterative sequence is defined for the set of positive integers:
    ///
    ///         n → n/2 (n is even)
    ///         n → 3n + 1 (n is odd)
    ///
    ///         Using the rule above and starting with 13, we generate the following sequence:
    ///
    ///         13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    ///         It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
    ///         Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    ///
    ///         Which starting number, under one million, produces the longest chain?
    ///
    ///         NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    public class _014
    {
        private static Dictionary<long, long> cachedLengths = new Dictionary<long, long>();

        public _014()
        {
            const long upperBound = 1000000;

            // chain length for 1 is 1
            cachedLengths.Add(1, 1);

            long maxLength = 0;
            long num = 0;
            for (long i = 2; i < upperBound; i++)
            {
                long length = GetChainLength(i);

                if (length > maxLength)
                {
                    maxLength = length;
                    num = i;
                }
            }

            Console.WriteLine("{0}", num);
        }

        /// <summary>
        /// Recursive function that computes the amount of chain lengths for a Collatz sequence.
        /// </summary>
        /// <param name="num"> The number whose length we are computing. </param>
        /// <returns> The chain length of the collatz function for num. </returns>
        private static long GetChainLength(long num)
        {
            // base case, we know the length for this number
            if (cachedLengths.ContainsKey(num)) { return cachedLengths[num]; }

            if (num % 2 == 0) 
            {
                cachedLengths.Add(num, 1 + GetChainLength(num / 2));
                return cachedLengths[num];
            }
            else 
            {
                cachedLengths.Add(num, 1 + GetChainLength(3 * num + 1));
                return cachedLengths[num];
            }
        }
    }
}

