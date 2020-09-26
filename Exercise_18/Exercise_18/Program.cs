using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void spaceUp(int range)
        {
            for(int i = 0;i < range; i++)
            {
                Console.WriteLine(" ");;;;
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
                    Console.WriteLine(user_request);
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
             * 18. Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
            Sample Output:
            Input first integer:
                -5
            Input second integer:
                25
            Check if one is negative and one is positive:
                True
            */

            // Create the numbers
            int first_number, second_number;

            // Get the value of the numbers from the user
            get_number("Input first integer:", out first_number);
            get_number("Input second integer:", out second_number);

            Console.WriteLine("Check if one is negative and one is positive:");
            if((first_number < 0 && second_number > 0) || (first_number > 0 && second_number < 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
