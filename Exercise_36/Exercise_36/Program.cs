using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_36
{
    class Program
    {
        static void errorMessage(string msg)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(msg);
            Console.WriteLine("Try again !");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
        static void askForNumber(out int number, string user_request)
        {
            while (true)
            {
                Console.Write(user_request);

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
             * 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. Go to the editor
            Sample Output:
            Input a first number: -5
            Input a second number: 8
            True
            */

            int first_number, second_number;
            askForNumber(out first_number, "Write here a number in the range -10 to 10 -- > ");
            askForNumber(out second_number, "Write here a number in the range -10 to 10 -- > ");
            IEnumerable<int> range = Enumerable.Range(1, 10);

            if (range.Contains(first_number) || range.Contains(second_number))
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
