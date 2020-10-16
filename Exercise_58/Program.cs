using System;
using System.Linq;

namespace Exercise_58
{
    class Program
    {
        static int solution(int[] array)
        {
            int min = array.Min();
            int max = array.Max();

            return (max - min + 1) - array.Length;
        }
        static void Main(string[] args)
        {
            /*
             * 58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range. Go to the editor
            Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.
            */

            int[] array = new int[] { 1, 3, 4, 7, 9 };
            Console.WriteLine(solution(array));
        }
    }
}
