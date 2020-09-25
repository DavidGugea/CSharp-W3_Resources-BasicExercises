using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static string remove_at_index(string s, int remove_index)
        {
            string new_string = s.Remove(remove_index, 1);
            return new_string;
        }
        static void Main(string[] args)
        {
            /*
             * 15. Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
            Test Data:
                w3resource
            Sample Output:
                wresource
                w3resourc
                3resource
            */

            string x = "w3resource";

            Console.WriteLine(remove_at_index(x, 1));
            Console.WriteLine(remove_at_index(x, x.Length - 1));
            Console.WriteLine(remove_at_index(x, 0));

            Console.ReadKey();
        }
    }
}
