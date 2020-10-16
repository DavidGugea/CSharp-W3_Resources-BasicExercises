using System;
using System.Collections;

namespace Exercise_52
{
    class Program
    {
        static int[] solution(int[] arr1, int[] arr2, int[] arr3)
        {
            return new int[]
            {
                arr1[1],
                arr2[1],
                arr3[1]
            };
        }
        static void Main(string[] args)
        {
            /*
             * 52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. Go to the editor
            Test Data:
            Array1: [1, 2, 5]
            Array2: [0, 3, 8]
            Array3: [-1, 0, 2]
            New array: [2, 3, 0]
            */

            int[] arr1 = new int[] { 1, 2, 5 };
            int[] arr2 = new int[] { 0, 3, 8 };
            int[] arr3 = new int[] { -1, 0, 2 };

            int[] solution_array = solution(arr1, arr2, arr3);
            IEnumerator enumerator = solution_array.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
