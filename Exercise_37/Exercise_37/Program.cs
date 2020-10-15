using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_37
{
    class Program
    {
        static string solution(string str)
        {
            if(str.Substring(1, 2) == "HP")
            {
                return str[0] + str.Substring(3);
            }
            else
            {
                return "ERROR";
            }
        }
        static void Main(string[] args)
        {
            /*
             * 37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". Go to the editor
            Test Data: PHP Tutorial
            Sample Output:
            P Tutorial
            */

            Console.WriteLine(solution("PHP Tutorial"));
            Console.WriteLine(solution("asdf"));

            Console.ReadKey();
        }
    }
}
