using System;

namespace Exercise_48
{
    class Program
    {
        static bool solution(int[] array)
        {
            return array.Length >= 1 && array[0] == array[array.Length - 1] ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more. Go to the editor
            Test Data:
            Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            Sample Output
            True
            */

            int[] array = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(solution(array));
        }
    }
}
