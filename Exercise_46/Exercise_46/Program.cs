using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_46
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
                    errorMessage("You have to input an integer !");
                    continue;
                }
            }
        }
        static int[] createArray()
        {
            // Ask the user about the length of the array
            int array_length;
            askForNumber(out array_length, "Write here the length of the array -- > ");
            int[] array = new int[array_length];

            // Fill out the array
            int index_counter = 0;
            while(index_counter < array_length)
            {
                // Ask the user for a number
                int number;
                askForNumber(out number, string.Format("Write here the {0}th number for your array -- >", index_counter + 1));

                array[index_counter] = number;
                index_counter++;
            }

            return array;
        }
        static bool solution(int[] array, int num)
        {
            return array[0] == num || array[array.Length - 1] == num ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more. Go to the editor
            Test Data:
            Input an integer: 25
            Sample Output
            False
            */

            int[] array = createArray();
            int number;
            askForNumber(out number, "Input an integer: ");
            Console.WriteLine(solution(array, number));

            Console.ReadKey();
        }
    }
}
