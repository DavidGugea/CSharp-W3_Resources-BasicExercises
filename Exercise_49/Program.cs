using System;

namespace Exercise_49
{
    class Program
    {
        static bool solution(int[] array1, int[] array2)
        {
            return (array1.Length >= 1 || array2.Length >= 2) && (array1[0] == array1[array1.Length - 1] || array2[0] == array2[array2.Length - 1]) ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. Go to the editor
            Test Data:
            Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
            Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
            Sample Output
            True
            */

            int[] array1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            Console.WriteLine(solution(array1, array2));
        }
    }
}
