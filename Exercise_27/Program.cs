using System;

namespace Exercise_27
{
    class Program
    {
        static int return_digits_sum(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            int sum = 0;
            foreach(char digit in digits)
            {
                sum += Int32.Parse(digit.ToString());
            }

            return sum;
        }
        static void Main(string[] args)
        {
            /*
             * 27. Write a C# program and compute the sum of the digits of an integer. Go to the editor
            Sample Output:
            Input a number(integer): 12
            Sum of the digits of the said integer: 3
            */

            Console.WriteLine(return_digits_sum(12));
        }
    }
}
