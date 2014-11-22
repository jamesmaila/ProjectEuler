using System;

namespace ProjectEuler
{
    /// <summary>
    ///     Special Pythagorean triplet
    ///     Problem 9
    ///        
    ///     A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    ///
    ///     a^2 + b^2 = c^2
    ///     For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    ///
    ///     There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    ///     Find the product abc.
    /// </summary>
    public class _009
    {
        public _009()
        {
            const int maxSum = 1000;
            int[] abc = new int[3];

            GetPythagoreanTriplet(abc, maxSum);

            int product = abc[0] * abc[1] * abc[2];

            Console.WriteLine("{0}", product);
        }

        /// <summary>
        /// Gets a pythagorean triplet that sums to no greater than maxSum.
        /// </summary>
        /// <param name="abc"> Array of ints to store result values. </param>
        /// <param name="maxSum"> The maximum sum of the triplets. </param>
        private static void GetPythagoreanTriplet(int[] abc, int maxSum)
        {
            for (int a = 1; a <= maxSum - 2; a++)
            {
                for (int b = 1; b <= maxSum - 2; b++)
                {
                    int c = maxSum - (a + b);

                    if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2))
                    {
                        abc[0] = a;
                        abc[1] = b;
                        abc[2] = c;

                        return;
                    }
                }
            }
        }
    }
}

