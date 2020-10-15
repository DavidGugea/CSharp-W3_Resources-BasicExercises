using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_43
{
    class Program
    {
        static string askForString(out string str)
        {
            Console.WriteLine("Input a string : ");
            str = Console.ReadLine();

            return str;
        }
        static bool solution()
        {
            string str;
            str = askForString(out str);
            return str.StartsWith("wwwww");
        }
        static void Main(string[] args)
        {
            /*
             * 43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor
            Test Data:
            Input a string : www
            Sample Output
            False
            */

            Console.WriteLine(solution());
            Console.ReadKey();
        }
    }
}
