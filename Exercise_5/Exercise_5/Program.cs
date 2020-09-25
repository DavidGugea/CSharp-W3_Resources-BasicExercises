using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
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
        static void get_number(string ask_string, out int number)
        {
            while (true)
            {
                try
                {
                    Console.Write(ask_string);
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
            // Get the first & second number
            get_number("Write here your first number -- > ", out int first_number);
            get_number("Write here your second number -- > ", out int second_number);

            // Print the numbers out in order
            Console.WriteLine(string.Format("First number : {0} | Second number : {1}", first_number, second_number));

            // Swap the numbers
            int swap_number;

            swap_number = second_number;
            second_number = first_number;
            first_number = swap_number;

            Console.WriteLine(string.Format("First number : {0} | Second number : {1}", first_number, second_number));

            Console.ReadKey();
        }
    }
}
