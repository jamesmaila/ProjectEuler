using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    /// Number letter counts
    /// Problem 17
    ///   
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    ///
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    ///
    ///
    /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
    /// The use of "and" when writing out numbers is in compliance with British usage.
    /// 
    /// </summary>
    public class _017
    {
        public _017()
        {
            int sum = 0;
            for (int i=1; i <= 1000; i++)
            {
                sum += CountLetters(i); 
            }

            Console.WriteLine("{0}", sum);
        }

        /// <summary>
        /// Counters the number of letters in the UK representation of num.
        /// </summary>
        /// <returns> The amount of letters. </returns>
        /// <param name="num"> The number to ount letters for. </param>
        private static int CountLetters(int num)
        {
            int count = 0;

            if (num >= 1000000000)
            {
                count += CountLetters(num / 1000000000) + 7 + CountLetters(num % 1000000000);
            }
            else if (num >= 1000000)
            {
                count += CountLetters(num / 1000000) + 7 + CountLetters(num % 1000000);
            }
            else if (num >= 1000)
            {
                count += CountLetters(num / 1000) + 8 + CountLetters(num % 1000);
            }
            else if (num >= 100)
            {
                count += CountLetters(num / 100) + 7 + CountLetters(num % 100) + (num % 100 > 0 ? 3 : 0);
            }
            else if (num >= 20)
            {
                switch( num / 10 ) 
                {
                    case 2: count += 6; break;
                    case 3: count += 6; break;
                    case 4: count += 5; break;
                    case 5: count += 5; break;
                    case 6: count += 5; break;
                    case 7: count += 7; break;
                    case 8: count += 6; break;
                    case 9: count += 6; break;
                }
                count += CountLetters( num % 10 );
            }
            else 
            {
                switch( num )
                {
                    case  1: count += 3; break;
                    case  2: count += 3; break;
                    case  3: count += 5; break;
                    case  4: count += 4; break;
                    case  5: count += 4; break;
                    case  6: count += 3; break;
                    case  7: count += 5; break;
                    case  8: count += 5; break;
                    case  9: count += 4; break;
                    case 10: count += 3; break;
                    case 11: count += 6; break;
                    case 12: count += 6; break;
                    case 13: count += 8; break;
                    case 14: count += 8; break;
                    case 15: count += 7; break;
                    case 16: count += 7; break;
                    case 17: count += 9; break;
                    case 18: count += 8; break;
                    case 19: count += 8; break;      
                }
            }

            return count;
        }
    }
}

