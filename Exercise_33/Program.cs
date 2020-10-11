using System;

namespace Exercise_33
{
    class Program
    {
        static bool m_3_or_7(int number)
        {
            return number % 3 == 0 || number % 7 == 0 ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor
            Sample Output:
            Input first integer:
            15
            True
            */

            Console.WriteLine(m_3_or_7(15));
        }
    }
}
