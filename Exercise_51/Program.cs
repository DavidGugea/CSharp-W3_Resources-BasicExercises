using System;
using System.Linq;

namespace Exercise_51
{
    class Program
    {
        static int solution(int[] array)
        {
            // -- > return new int[] { array[0], array[array.Length - 1] }.Max();
            // OR : 
            return array[0] > array[array.Length - 1] ? array[0] : array[array.Length - 1];
        }
        static void Main(string[] args)
        {
            /*
             * 51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers. Go to the editor
            Test Data:
            Array1: [1, 2, 5, 7, 8]
            Highest value between first and last values of the said array: 8
            */

            int[] array = new int[] { 1, 2, 5, 7, 8 };
            Console.WriteLine(solution(array));
        }
    }
}
