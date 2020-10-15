using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_38
{
    class Program
    {
        static string solution(string str)
        {
            return str.Substring(0, 2);
        }
        static void Main(string[] args)
        {
            /*
             * 38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". Go to the editor
            Test Data: PHP
            Sample Output:
            PH
            */

            Console.WriteLine(solution("PHP Tutorial"));
            Console.ReadKey();
        }
    }
}
