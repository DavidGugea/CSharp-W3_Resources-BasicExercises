using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_41
{
    class Program
    {
        static bool solution(string msg)
        {
            Func<char, bool> predicate = (char c) => c == 'w';
            int count = msg.Count(predicate);

            return (count >= 1 && count <= 3) ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. Go to the editor
            Test Data:
            Input a string (conatins at least one 'w' char) : w3resource
            Test the string contains 'w' character between 1 and 3 times:
            Sample Output
            True
            */

            Console.WriteLine(solution("w3resource"));
            Console.ReadKey();
        }
    }
}
