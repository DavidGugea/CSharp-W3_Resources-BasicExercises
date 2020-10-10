using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Exercise_26
{
    class Program
    {
        static bool isPrime(int number)
        {
            if(number == 2) { return true; }
            else
            {
                int divisors_counter = 2; // 2 and not 0 because we only count until the sqrt(number) & start iterating from number 1, so we won't be able to include the number itself in the for loop since it doesn't go that far.
                for(int i = 2; i <= (int)Math.Floor(Math.Sqrt(number)); i++)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
        static void Main(string[] args)
        {
            /*
             * 26. Write a C# program to compute the sum of the first 500 prime numbers. Go to the editor
            */

            // pn = prime number
            HashSet<int> pn = new HashSet<int>() ;
            int pn_counter = 0;
            int num = 3;

            while (true)
            {
                if (isPrime(num))
                {
                    pn.Add(num);
                    pn_counter++;

                    if(pn_counter == 500)
                    {
                        break;
                    }
                }

                num++;
                continue;
            }

            int sum = 0;
            IEnumerator<int> enumerator = pn.GetEnumerator();
            while (enumerator.MoveNext())
            {
                sum += enumerator.Current;
            }

            Console.WriteLine(sum);
        }
    }
}
