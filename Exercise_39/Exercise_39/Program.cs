using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_39
{
    class Program
    {
        static void errorMessage(string msg)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(msg);
            Console.WriteLine("Try again !");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
        static void askForNumber(out int number, string user_request)
        {
            while (true)
            {
                Console.WriteLine(user_request);

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    errorMessage("You have to input a number.");
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            /*
             * 39. Write a C# program to find the largest and lowest values from three integer values. Go to the editor
            Test Data:
            Input first integer:
            15
            Input second integer:
            25
            Input third integer:
            30
            Sample Output
            Largest of three: 30
            Lowest of three: 15\
            */

            int fn, sn, tn;
            askForNumber(out fn, "Input first integer:");
            askForNumber(out sn, "Input second integer:");
            askForNumber(out tn, "Input third integer:");

            HashSet<int> hs = new HashSet<int> { fn, sn, tn };

            Console.WriteLine(string.Format("Largest of three : {0}", hs.Max()));
            Console.WriteLine(string.Format("Lowest of three  : {0}", hs.Min()));

            Console.ReadKey();
        }
    }
}
