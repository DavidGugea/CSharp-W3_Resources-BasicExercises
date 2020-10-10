using System;
using System.Linq;

namespace Exercise_28
{
    class Program
    {
        static string reverse_words(string sentence)
        {
            return sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().Aggregate((s1, s2) => s1 + ' ' + s2);
        }
        static void Main(string[] args)
        {
            /*
             * 28. Write a C# program to reverse the words of a sentence. Go to the editor
            Sample Output:
            Original String: Display the pattern like pyramid using the alphabet.
            Reverse String: alphabet. the using pyramid like pattern the Display*
            */

            Console.WriteLine(reverse_words("Display the pattern like pyramid using the alphabet."));
        }
    }
}
