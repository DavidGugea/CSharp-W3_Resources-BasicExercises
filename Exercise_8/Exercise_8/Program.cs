using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
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

            Console.WriteLine("You have to write a number.");
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
             * 8. Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor

            Test Data:
                Enter the number: 5
            Expected Output:
                5 * 0 = 0
                5 * 1 = 5
                5 * 2 = 10
                5 * 3 = 15
                ....
                5 * 10 = 50
            */

            int number;
            get_number("Print here your number -- > ", out number);

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0} * {1} = {2}", number, i, number * i));
            }

            Console.ReadKey();
        }
    }
}
