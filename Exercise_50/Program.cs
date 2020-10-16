using System;
using System.Collections;

namespace Exercise_50
{
    class Program
    {
        static int[] rotate(int[] array)
        {
            return new int[3]
            {
                array[1],
                array[2],
                array[0]
            };
        }
        static void Main(string[] args)
        {
            /*
             * 50. Write a C# program to rotate an array (length 3) of integers in left direction. Go to the editor
            Test Data:
            Array1: [1, 2, 8]
            After rotating array becomes: [2, 8, 1]
            */

            int[] array = new int[] { 1, 2, 8 };

            int[] solution = rotate(array);
            IEnumerator enumerator = solution.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
