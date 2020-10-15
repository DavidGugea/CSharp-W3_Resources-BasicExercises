using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_44
{
    class Program
    {
        static string AskForString()
        {
            Console.WriteLine("Input a string: ");
            return Console.ReadLine();
        }
        static string solution()
        {
            string str;
            str = AskForString();

            Func<char, int, bool> predicate = (char c, int index) => index % 2 == 0 ? true : false;
            return String.Concat(str.Where(predicate));
        }
        static void Main(string[] args)
        {
            /*
             * 44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string. Go to the editor
            Test Data:
            Input a string : w3resource
            Sample Output
            wrsuc
            */

            Console.WriteLine(solution());
            Console.ReadKey();
        }
    }
}
