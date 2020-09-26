using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
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
             * 19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
             * */

            int first_number, second_number;

            get_number("Write here your first number -- > ", out first_number);
            get_number("Write here your second number -- > ", out second_number);

            if(first_number == second_number) 
            {
                Console.WriteLine(3 * (first_number + second_number));
            }
            else
            {
                Console.WriteLine(first_number + second_number);
            }

            Console.ReadKey();
        }
    }
}
