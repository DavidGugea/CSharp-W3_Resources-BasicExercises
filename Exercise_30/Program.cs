using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_30
{
    class Program
    {
        static double convert_fromHEX_toDEC(string hex)
        {
            Dictionary<char, int> hex_dict = new Dictionary<char, int>()
            {
                { 'A', 10 },
                { 'B', 11 },
                { 'C', 12 },
                { 'D', 13 },
                { 'E', 14 },
                { 'F', 15 }
            };

            IEnumerable<char> hex_nums = hex.ToCharArray().Reverse();
            IEnumerator<char> enumerator = hex_nums.GetEnumerator();
            double sum = 0;
            int index_counter = 0;

            while(enumerator.MoveNext())
            {
                if (hex_nums.Contains(enumerator.Current))
                {
                    sum += Math.Pow(16, index_counter) * hex_dict[enumerator.Current];
                }
                else
                {
                    sum += Math.Pow(16, index_counter) * enumerator.Current;
                }

                index_counter++;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            /*
             * 30. Write a C# program to convert a hexadecimal number to decimal number. Go to the editor
            Sample Output:
            Hexadecimal number: 4B0
            Convert to-
            Decimal number: 1200
            */

            Console.WriteLine(convert_fromHEX_toDEC("FF"));
            Console.WriteLine(convert_fromHEX_toDEC("FA"));
        }
    }
}
