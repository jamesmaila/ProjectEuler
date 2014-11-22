using System;
using System.Numerics;

namespace ProjectEuler
{
    /// <summary>
    /// Power digit sum
    /// Problem 16
    ///    
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    ///
    /// What is the sum of the digits of the number 2^1000?
    ///
    /// </summary>
    public class _016
    {
        public _016()
        {
            string result = BigInteger.Pow(2, 1000).ToString();

            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += (int)Char.GetNumericValue(result[i]);
            }

            Console.WriteLine("{0}", sum);
        }
    }
}

