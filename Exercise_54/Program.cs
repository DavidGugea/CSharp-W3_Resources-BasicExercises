using System;

namespace Exercise_54
{
    class Program
    {
        static int get_century(double year)
        {
            return Convert.ToInt32(Math.Ceiling(year / 100));
        }
        static void Main(string[] args)
        {
            /*
             * 54. Write a C# program to get the century from a year. 
            */

            Console.WriteLine(get_century(2020));
        }
    }
}
