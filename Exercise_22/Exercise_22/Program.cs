using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void spaceUp(int range)
        {
            for (int i = 0; i < range; i++)
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
        static bool solution(int number)
        {
            if ((number >= 80 && number <= 120) || (number >= 180 && number <= 220))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool short_solution(int number)
        {
            return ((number >= 80 && number <= 120) || (number >= 180 && number <= 220)) ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 22. Write a C# program to check if an given integer is within 20 of 100 or 200. Go to the editor
            Sample Output:
            Input an integer:
                25
            Output: 
                False
            */

            int number;
            get_number("Write here your number -- > ", out number);

            Console.WriteLine(solution(number));
            Console.WriteLine(short_solution(number));
            Console.ReadKey();
        }
    }
}
