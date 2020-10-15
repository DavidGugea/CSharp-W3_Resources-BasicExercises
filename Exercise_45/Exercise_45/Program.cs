using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_45
{
    class Program
    {
        static void errorMessage(string msg)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(msg);
            Console.WriteLine("Try again !");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
        static void askForNumber(out int number, string user_request)
        {
            while (true)
            {
                Console.WriteLine(user_request);

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage("You have to input a number !");
                    continue;
                }
            }
        }
        static int[] createArray()
        {
            // Ask the user about the length of the array;
            int array_length;
            askForNumber(out array_length, "Print here the length of the array that you want to have -- > ");

            // Build the array
            int[] array = new int[array_length];

            int index_counter = 0;
            while(index_counter + 1 <= array_length)
            {
                // Ask the user for the number
                int current_number;
                askForNumber(out current_number, string.Format("Write down the {0}th number in you array -- > ", index_counter+1));

                // Add the number at the specific index in the array & increase the index to get to the next number until the index reaches the length of the array which means that we have to stop asking the user for numbers because the array is full.
                array[index_counter]  = current_number;
                index_counter++;
            }

            return array;
        }
        static int countNumberInArray(int[] array, int searchNumber)
        {
            Func<int, bool> predicate = (int number) => number == searchNumber ? true : false;
            return array.Count(predicate);
        }
        static void Main(string[] args)
        {
            /*
             * 45. Write a C# program to count a specified number in a given array of integers. Go to the editor
            Test Data:
            Input an integer: 5
            Sample Output
            Number of 5 present in the said array: 2
            */

            int searchNumber;
            askForNumber(out searchNumber, "Input an integer: ");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            int[] array = createArray();

            Console.WriteLine(string.Format("Number of {0} present in the said array : {1}", searchNumber, countNumberInArray(array, searchNumber)));
            Console.ReadKey();
        }
    }
}
