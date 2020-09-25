using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
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
             * 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
            Test Data:
                Enter the amount of celsius: 30
            Expected Output:
                Kelvin = 303
                Fahrenheit = 86
            */

            int celsius;

            // Get the number
            get_number("Enter the amount of celsius: ", out celsius);

            Console.WriteLine(string.Format("Kelvin = {0}", celsius + 273));
            Console.WriteLine(string.Format("Fahrenheit = {0}", celsius * 18 / 10 + 32));

            Console.ReadKey();
        }
    }
}
