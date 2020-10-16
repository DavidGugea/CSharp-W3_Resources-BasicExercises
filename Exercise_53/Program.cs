using System;
using System.Linq;

namespace Exercise_53
{
    class Program
    {
        static bool solution(int[] array)
        {
            Func<int, bool> predicate = (int number) => number % 2 != 0;
            return array.Any(predicate);
        }
        static void Main(string[] args)
        {
            /*
             * 53. Write a C# program to check if an array contains an odd number. Go to the editor
            Test Data:
            Original array: [2, 4, 7, 8, 6]
            Check if an array contains an odd number? True
            */
            int[] array = new int[] { 2, 4, 7, 8, 6 };
            Console.WriteLine(solution(array));
        }
    }
}
