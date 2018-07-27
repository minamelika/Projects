// Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.

// Example

//     For year = 1905, the output should be
//     centuryFromYear(year) = 20;
//     For year = 1700, the output should be
//     centuryFromYear(year) = 17.

using System;

namespace getCentury
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, century;
            Console.WriteLine("Please enter the year");
            year = int.Parse(Console.ReadLine());
            if (year%100 == 0)
            {
                century = (year / 100);
            }
            else
            {
                century = (year / 100) + 1; ;
            }
            Console.WriteLine("Century No. {0}", century);
            Console.ReadLine();
            }
        }
 }

