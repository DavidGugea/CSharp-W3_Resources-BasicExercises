using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_57
{
    class Program
    {
        static int[] biggest_product_pair(int[] array)
        {
            // Create a list of key value pairs where we will store all the products of the pairs as keys & the pairs themselves as the values;
            List<KeyValuePair<int, int[]>> pairs = new List<KeyValuePair<int, int[]>>();

            // Fill in the dictionary
            int i = 0;
            int j = 1;

            while(i < j && j < array.Length)
            {
                int product = array[i] * array[j];
                int[] pair = new int[] { array[i], array[j] };

                pairs.Add(new KeyValuePair<int, int[]>(product, pair));

                i++; j++;
            }

            Func<KeyValuePair<int, int[]>, int> max_predicate = (KeyValuePair<int, int[]> kvp) => kvp.Key;
            Func<KeyValuePair<int, int[]>, bool> where_predicate = (KeyValuePair<int, int[]> kvp) => kvp.Key == pairs.Max(max_predicate);

            int[] return_pairs = new int[0];
            IEnumerator<KeyValuePair<int, int[]>> pairs_enumerator = pairs.Where(where_predicate).GetEnumerator();
            while (pairs_enumerator.MoveNext())
            {
                return_pairs = pairs_enumerator.Current.Value;
                break;
            }

            return return_pairs;
        }
        static void Main(string[] args)
        {
            /*
             * 
            57. Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
            */

            int[] array = new int[] { 1, 2, 100, 4, 5, 6, 8, 9 };
            int[] bpp = biggest_product_pair(array);

            Console.WriteLine(string.Format("Biggest product pair -- > {0} & {1}", bpp[0], bpp[1]));
        }
    }
}
