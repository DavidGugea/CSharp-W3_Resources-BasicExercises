using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_55
{
    class Program
    {
        static int[] solution(int[] array)
        {
            // Create a dictionary where we will store all the pairs of numbers as values will keep the sum of the pairs as key
            Dictionary<int, int[]> all_pairs = new Dictionary<int, int[]>();

            // Fill in the dictionary
            int i = 0;
            int j = 1;

            while(i < j && j < array.Length)
            {
                int sum = array[i] + array[j];
                int[] pair = new int[] { array[i], array[j] };

                all_pairs.Add(sum, pair);

                i++; j++;
            }

            return all_pairs[all_pairs.Keys.Max()];
        }
        static void Main(string[] args)
        {
            /*
             * 55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value.
            */

            int[] array = new int[] { 1, 2, 3, 100, 5, 6, 7, 8, 9 };
            int[] biggest_pair = solution(array);

            Console.WriteLine(string.Format("Pair -- > {0};{1}", biggest_pair[0], biggest_pair[1]));
        }
    }
}
