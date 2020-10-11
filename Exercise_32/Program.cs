using System;
using System.Collections;
using System.Linq;

namespace Exercise_32
{
    class Program
    {
        static string last_four(string s)
        {
            string last = s.Substring(s.Length - 4);
            string result = "";

            for(int i = 0; i < 4; i++)
            {
                result += last;
            }

            return result;
        }
        static void Main(string[] args)
        {
            /*
             * 32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one. Go to the editor
            Sample Output:
            Input a string : The quick brown fox jumps over the lazy dog.
            dog.dog.dog.dog.
            */

            Console.WriteLine(last_four("The quick brown fox jumps over the lazy dog."));
        }
    }
}
