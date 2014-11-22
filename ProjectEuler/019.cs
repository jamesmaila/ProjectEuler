using System;

namespace ProjectEuler
{
    /// <summary>
    /// Counting Sundays
    /// Problem 19
    ///    
    /// You are given the following information, but you may prefer to do some research for yourself.
    ///
    ///         1 Jan 1900 was a Monday.
    ///         Thirty days has September,
    ///         April, June and November.
    ///         All the rest have thirty-one,
    ///         Saving February alone,
    ///         Which has twenty-eight, rain or shine.
    ///         And on leap years, twenty-nine.
    ///         A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// 
    ///         How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    /// </summary>
    public class _019
    {
        public _019()
        {
            int count = 0;
            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime day = new DateTime(year, month, 1);
                    if (day.DayOfWeek == DayOfWeek.Sunday) { count++; }
                }
            }

            Console.WriteLine("{0}", count);
        }
    }
}

