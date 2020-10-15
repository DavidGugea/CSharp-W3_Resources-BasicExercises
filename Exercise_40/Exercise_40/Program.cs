using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_40
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
                    errorMessage("You have to input a number !");
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            /*
             * 40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. Go to the editor
            Test Data:
            Input first integer:
            15
            Input second integer:
            12
            Sample Output
            15
            */

            int fn, sn;
            askForNumber(out fn, "Input first integer:");
            askForNumber(out sn, "Input second integer:");

            int first_difference = Math.Abs(fn - 20);
            int second_difference = Math.Abs(sn - 20);
            int result;
            result = first_difference < second_difference ? fn : sn;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
