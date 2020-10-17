using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_59
{
    class Program
    {
        static bool strictly_increasing(int[] array)
        {
            // Find out if there are any repetitive numbers in the array
            List<int> copy_track = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (copy_track.Contains(array[i]))
                {
                    return false;
                }
                else
                {
                    copy_track.Add(array[i]);
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            /*
             * 59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
             * */

            int[] array1 = new int[] { 1, 3, 5, 6, 9 };
            int[] array2 = new int[] { 0, 10 };
            int[] array3 = new int[] { 1, 3, 1, 3 };

            Console.WriteLine(strictly_increasing(array1));
            Console.WriteLine(strictly_increasing(array2));
            Console.WriteLine(strictly_increasing(array3));
        }
    }
}
