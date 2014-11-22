using System;

namespace ProjectEuler
{
    /// <summary>
    ///     Largest palindrome product
    ///     Problem 4
    ///        
    ///     A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    ///
    ///     Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class _004
    {
        public _004()
        {
            int largest = 0;

            for (int num1 = 999; num1 > 99; num1--)
            {
                for (int num2 = 999; num2 > 99; num2--)
                {
                    int product = num1 * num2;
                    if (product > largest && IsPalindrome(product))
                    {
                        largest = num1 * num2;
                    }
                }
            }

            Console.WriteLine("{0}", largest);
        }

        /// <summary>
        /// Determines if a number is a palindrome.
        /// </summary>
        /// <param name="number"> Number to check for palindrome quality. </param>
        /// <returns> True if palindrome, False if not. </returns>
        private static bool IsPalindrome(int number)
        {
            int reverse = 0;
            int n = number;

            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                reverse = 10*reverse + digit;
            }

            return (reverse == number);
        }
    }
}

