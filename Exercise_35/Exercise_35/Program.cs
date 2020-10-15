using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_35
{
    class Program
    {
        static void errorMessage(string msg)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(msg);
            Console.WriteLine("Try again !");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
        static void askForNumber(out int number, string user_request)
        {
            while (true)
            {
                Console.WriteLine(user_request);
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage("You have to input a number.");
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            /*
             * 35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. Go to the editor
            Sample Output:
            Input a first number(<100): 75
            Input a second number(>100): 250
            True
            */

            int first_number, second_number;
            askForNumber(out first_number, "Input a first number(<100): ");
            askForNumber(out second_number, "Input a second number(>100): ");

            if(first_number < 100 && second_number > 100)
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
