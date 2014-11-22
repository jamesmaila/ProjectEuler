using System;

namespace ProjectEuler
{
    /// <summary>
    /// Lattice paths
    /// Problem 15
    ///   
    /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    ///
    /// How many such routes are there through a 20×20 grid?
    /// 
    /// </summary>
    public class _015
    {
        public _015()
        {
            // start (0,0)   ___ ___ 
            //              |___|___|
            //              |___|___|  end (2,-2)
            //
            // for the 2x2 grid, we can decompose the potential shortest paths as follows:
            // RRDD, DDRR, RDRD, DRDR, RDDR, DRRD = 6 paths
            // (where D denotes Down and R denotes Right)
            //
            // using simple combinatorics, we can deduce the amount of shortest paths
            // of an n x n grid to be the binomial coefficient: C(2n, n)
            // or "2n choose n"

            const int gridSize = 20;

            Console.WriteLine("{0}", BinomialCoefficient(2 * gridSize, gridSize));
        }

        /// <summary>
        /// Computes the Binomial Coefficient of n and k.
        /// </summary>
        /// <param name="n"> How many we are choosing from. </param>
        /// <param name="k"> How many we are choosing. </param>
        /// <returns> The Binomial Coefficient of n and k. </returns>
        private static long BinomialCoefficient(int n, int k)
        {
            // using the multipicative formula
            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= (n + 1 - i);
                result /= i;
            }

            return result;
        }
    }
}

