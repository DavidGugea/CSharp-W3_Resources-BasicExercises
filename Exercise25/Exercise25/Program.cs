using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. Go to the editor
            Sample Output:
            Odd numbers from 1 to 99. Prints one number per line.
            1
            3
            5
            7
            9
            ...
            95
            97
            99
            */

            Func<int, bool> predicate = ( int x ) => x % 2 == 0 ? false : true;
            IEnumerable<int> numbers = Enumerable.Range(1, 100).Where(predicate);
            IEnumerator<int> enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
