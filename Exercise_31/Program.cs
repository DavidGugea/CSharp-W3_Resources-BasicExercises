using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_31
{
    class Program
    {
        static List<int> multiply_corresponding_items(int[] arr1, int[] arr2)
        {
            // Find the longer & smaller arrays
            int[] l_array, s_array;
            if(arr1.Length > arr2.Length)
            {
                l_array = arr1;
                s_array = arr2;
            }
            else
            {
                l_array = arr2;
                s_array = arr1;
            }

            List<int> result = new List<int>();
            for(int i = 0; i < s_array.Length; i++)
            {
                result.Add(s_array[i] * l_array[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            /*
             * 31. Write a C# program to multiply corresponding elements of two arrays of integers. Go to the editor
            Sample Output:
            Array1: [1, 3, -5, 4]
            Array2: [1, 4, -5, -2]
            Multiply corresponding elements of two arrays:
            1 12 25 -8
            */

            int[] arr1 = new int[]{ 1, 3, -5, 4  };
            int[] arr2 = new int[]{ 1, 4, -5, -2 };

            foreach(int element in multiply_corresponding_items(arr1, arr2))
            {
                Console.WriteLine(element);
            }
        }
    }
}
