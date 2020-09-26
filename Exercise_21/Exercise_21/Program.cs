using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void spaceUp(int range)
        {
            for (int i = 0; i < range; i++)
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
        static bool solution()
        {
            int first_number, second_number;

            get_number("Write here your first number -- > ", out first_number);
            get_number("Write here your second number -- > ", out second_number);

            if ((first_number == 20 || second_number == 20) || (first_number+second_number == 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            /*
             * 21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20. 
             * */

            Console.WriteLine(solution());
            Console.ReadKey();
        }
    }
}
