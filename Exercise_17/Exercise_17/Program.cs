using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static string solution(string s)
        {
            string x = s[0].ToString();
            s = s.Insert(0, x);
            s = s.Insert(s.Length, x);

            return s;
        }
        static void Main(string[] args)
        {
            /*
             * 17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor
            Sample Output:
            Input a string : 
                The quick brown fox jumps over the lazy dog.
            Output: 
                TThe quick brown fox jumps over the lazy dog.T
            */

            string s = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(solution(s));

            Console.ReadKey();
        }
    }
}
