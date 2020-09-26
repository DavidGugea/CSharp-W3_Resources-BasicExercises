using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23
{
    class Program
    {
        static string ConvertToLowercase(string s)
        {
            return s.ToLower();
        }
        static void Main(string[] args)
        {
            /*
             * 23. Write a C# program to convert a given string into lowercase. Go to the editor
            Sample Output:
                write a c# sharp program to display the following pattern using the alphabet.
            */

            Console.WriteLine(ConvertToLowercase("Write a C# program to convert a given string into lowercase."));
            Console.ReadKey();
        }
    }
}
