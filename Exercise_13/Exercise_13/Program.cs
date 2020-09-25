using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
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
             * 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor
            Test Data:
                Enter a number: 5
            Expected Output:
                555
                5 5
                5 5
                5 5
                555
            */

            int number;

            // Get the number
            get_number("Enter a number : ", out number);
            
            for(int i = 0;i < 3; i++) { Console.Write(number); }
            Console.Write("\n");
            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine(string.Format("{0} {0}", number));
            }
            for(int i = 0;i < 3; i++) { Console.Write(number); }

            Console.ReadKey();
        }
    }
}
