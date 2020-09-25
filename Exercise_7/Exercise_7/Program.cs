using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
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
        static void get_number(string user_request, out double number)
        {
            while (true)
            {
                try
                {
                    Console.Write(user_request);
                    number = Convert.ToDouble(Console.ReadLine());
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
             * 
            7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
                Test Data:
            Input the first number: 25
            Input the second number: 4
                Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1
            */

            double first_number, second_number;

            // Get the first & second number
            get_number("Give here your first number -- > ", out first_number);
            get_number("Give here your second number -- > ", out second_number);

            // Write down the addition, substraction, etc. results to the console
            Console.WriteLine(string.Format("{0} + {1} = {2}", first_number, second_number, first_number + second_number));
            Console.WriteLine(string.Format("{0} - {1} = {2}", first_number, second_number, first_number - second_number));
            Console.WriteLine(string.Format("{0} * {1} = {2}", first_number, second_number, first_number * second_number));
            Console.WriteLine(string.Format("{0} / {1} = {2}", first_number, second_number, first_number / second_number));
            Console.WriteLine(string.Format("{0} % {1} = {2}", first_number, second_number, first_number % second_number));

            Console.ReadKey();
        }
    }
}
