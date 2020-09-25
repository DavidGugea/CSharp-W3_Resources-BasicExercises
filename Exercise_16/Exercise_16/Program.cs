using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static string change_firstWithLast(string s)
        {
            char[] char_array = s.ToCharArray();
            char last_char = s[s.Length - 1];
            char_array[s.Length - 1] = char_array[0];
            char_array[0] = last_char;

            return new string(char_array);
        }
        static void Main(string[] args)
        {
            /*
             * 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor
            Test Data:
                w3resource
                Python
            Sample Output:
                e3resourcw
                nythoP
            */

            Console.WriteLine(change_firstWithLast("w3resource"));
            Console.WriteLine(change_firstWithLast("Python"));

            Console.ReadKey();
        }
    }
}
