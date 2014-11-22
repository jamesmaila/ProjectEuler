using System;

namespace ProjectEuler
{
    /// <summary>
    ///     Sum square difference
    ///     Problem 6
    /// 
    ///     The sum of the squares of the first ten natural numbers is,
    ///
    ///     1^2 + 2^2 + ... + 10^2 = 385
    ///     The square of the sum of the first ten natural numbers is,
    ///
    ///     (1 + 2 + ... + 10)^2 = 552 = 3025
    ///     Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// 
    ///     Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class _006
    {
        public _006()
        {
            const int range = 100;

            int sumOfSquares = 0;
            for (int i = 1; i <= range; i++)
            {
                sumOfSquares += (int)Math.Pow(i, 2);
            }

            // 1+2+3+...n = n(n+1)/2
            int squareOfSums = (int)Math.Pow((range * (range + 1) / 2), 2);

            int difference = squareOfSums - sumOfSquares;

            Console.WriteLine("{0}", difference);
        }
    }
}

