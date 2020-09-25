using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void spaceUp(int range)
        {
            for(int i = 0;i < range; i++)
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
             * 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
            Test Data:
                Enter your age - 25
            Expected Output:
                You look older than 25
            */

            int age;

            // Get the number
            get_number("Enter your age - ", out age);
            Console.WriteLine(string.Format("You look older than {0}", age));

            Console.ReadKey();
        }
    }
}
