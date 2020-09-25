using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
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
             * 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
            Test Data:
                Enter first number - 5
                Enter second number - 6
                Enter third number - 7

            Expected Output:
                Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
            */

            int x;
            int y;
            int z;

            // Get the numbers
            get_number("Enter first number -- > ", out x);
            get_number("Enter second number -- > ", out y);
            get_number("Enter third number -- > ", out z);

            // Print the results out in the console
            Console.WriteLine(string.Format("Result of specified numbers {0}, {1} and {2}, (x+y) * z is {3} and x*y + y*z is {4}",
                x,
                y,
                z,
                ( x + y ) * z,
                (x*y + y*z)
            ));

            Console.ReadKey();
        }
    }
}
