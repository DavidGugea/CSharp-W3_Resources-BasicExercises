using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
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
        static void get_number_from_user(out int number)
        {
            while (true)
            {
                try
                {
                    Console.Write("Give here you number -- > ");
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
            // Create the first numbers

            // Get the first number from the user
            get_number_from_user(out int first_number);

            // Get the second number from the user
            get_number_from_user(out int second_number);

            // Divide them
            Console.WriteLine(string.Format("{0} / {1} = {2}", first_number, second_number, first_number / second_number));

            Console.ReadKey();
        }
    }
}
