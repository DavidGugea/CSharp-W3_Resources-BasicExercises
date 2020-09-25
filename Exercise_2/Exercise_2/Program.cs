using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        public static void errorMessage()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine("You have to give a number.");
            Console.WriteLine("Try again.");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
        public static void Main(string[] args)
        {
            int first_number, second_number;

            // Get the first number
            while (true)
            {
                try
                {
                    Console.Write("Print here your first number -- > ");
                    first_number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage();
                    continue;
                }
            }

            // Get the second number
            while (true)
            {
                try
                {
                    Console.Write("Print here your second number -- > ");
                    second_number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage();
                    continue;
                }
            }

            Console.WriteLine(string.Format("{0} + {1} = {2}", first_number, second_number, first_number + second_number));

            Console.ReadKey();
        }
    }
}
