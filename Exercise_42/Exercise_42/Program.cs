using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_42
{
    class Program
    {
        static string solution(string str)
        {
            if(str.Length <= 3)
            {
                return str.ToUpper();
            }
            else
            {
                return str.Substring(0, 4).ToLower() + str.Substring(4);
            }
        }
        static void Main(string[] args)
        {
            /*
             * 42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case. Go to the editor
            Test Data:
            Input a string: w3r
            Sample Output
            W3R
            */

            Console.WriteLine(solution("w3r"));
            Console.WriteLine(solution("ASDF"));
            Console.WriteLine(solution("ABCDefgh"));

            Console.ReadKey();
        }
    }
}
