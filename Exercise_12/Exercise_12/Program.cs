using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void spaceUp(int range)
        {
            for(int i = 0; i < range; i++)
            {
                Console.WriteLine(" ");
            }
        }
        static void errorMessage()
        {
            spaceUp(3);

            Console.WriteLine("You have to give a number.");
            Console.WriteLine("Try again.");

            spaceUp(3);
        }
        static void get_number(string user_request, out int number)
        {
            while (true)
            {
                try
                {
                    Console.Write(user_request);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage();
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            /*
             * 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor
            Test Data:
                Enter a digit: 25
            Expected Output:
                25 25 25 25
                25252525
                25 25 25 25
                25252525
            */

            int number;
            get_number("Enter a number: ", out number);

            IEnumerable<string> list = Enumerable.Repeat(number.ToString(), 4);

            for(int i = 0;i < 2; i++)
            {
                Console.WriteLine(list.Aggregate((a, b) => string.Format("{0} {1}", a, b)));
                Console.WriteLine(list.Aggregate((a, b) => string.Format("{0}{1}", a, b)));
            }

            Console.ReadKey();
        }
    }
}
