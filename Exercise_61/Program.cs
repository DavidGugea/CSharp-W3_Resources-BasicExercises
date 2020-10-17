using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_61
{
    class Program
    {
        static int[] solution(int[] array)
        {
            // Order all the values that are not -5
            List<int> order_array = array.Where((int num) => num != -5).OrderBy((int num) => num).ToList<int>();

            // Insert the -5 values at the right position in the new order array
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == -5)
                {
                    order_array.Insert(i, -5);
                }
            }

            return order_array.ToArray();
        }
        static void Main(string[] args)
        {
            /*
             * 
            61. Write a C# program to sort the integers in ascending order without moving the number -5.
            */
            int[] array = new int[] { -5, 236, 120, 70, -5, -5, 698, 280 };

            foreach(int num in solution(array))
            {
                Console.WriteLine(num);
            }
        } 
    }
}
