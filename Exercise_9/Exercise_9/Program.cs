using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
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
             * 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
            Test Data:
                Enter the First number: 10
                Enter the Second number: 15
                Enter the third number: 20
                Enter the four number: 30

            Expected Output:
                The average of 10 , 15 , 20 , 30 is: 18
            */

            double first_number;
            double second_number;
            double third_number;
            double fourth_number;

            // Get the numbers
            get_number("Write here your first number -- > ", out first_number);
            get_number("Write here your second number -- > ", out second_number);
            get_number("Write here your third number -- > ", out third_number);
            get_number("Write here your fourth number -- > ", out fourth_number);

            // Make a list of the numbers and print out their average
            List<double> numbers = new List<double>()
            {
                first_number,
                second_number,
                third_number,
                fourth_number
            };

            // Print the average of the numbers out in the console
            Console.WriteLine(string.Format("The average of {0}, {1}, {2}, {3} is : {4}",
                first_number,
                second_number,
                third_number,
                fourth_number,
                numbers.Average()
            ));

            Console.ReadKey();
        }
    }
}
