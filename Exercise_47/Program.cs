using System;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace Exercise_47
{
    class Program
    {
        static void errorMessage(string msg)
        {
            for(int i = 0; i < 3; ++i)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(msg);
            Console.WriteLine("Try again !");

            for(int i = 0; i < 3; ++i)
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
            // Ask the user for the array length
            int array_length;
            askForNumber(out array_length, "Write here the length of the array -- > ");
            int[] array = new int[array_length];

            // Fill in the array with user values
            int index_counter = 0;
            while (index_counter < array_length)
            {
                int number;
                askForNumber(out number, string.Format("Write here the number that you want to have in you array at the {0}th positon", index_counter + 1));

                array[index_counter] = number;
                index_counter++;
            }

            return array;
        }
        static int solution(int[] array)
        {
            return array.Sum();
        }
        static void Main(string[] args)
        {
            /*
             * 47. Write a C# program to compute the sum of all the elements of an array of integers. Go to the editor
            Test Data:
            Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            Sample Output
            Sum: 69
            */

            int[] array = createArray();
            Console.WriteLine(string.Format("Sum : {0}", solution(array)));
        }
    }
}
