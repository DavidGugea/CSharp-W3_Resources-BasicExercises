using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24
{
    class Program
    {
        static string find_longest_word(string sentence)
        {
            // Split chars ( split everything when you see a space or any sign of punctuation ( like , or ? etc. )
            char[] split_chars =
            {
                ' ',
                ',',
                '.',
                '?',
            };

            string[] words = sentence.Split(
                split_chars,
                StringSplitOptions.RemoveEmptyEntries
            );

            int longest_word_length = 0;
            string longest_word = "";
            
            foreach(string word in words)
            {
                if(word.Length >= longest_word_length)
                {
                    longest_word = word;
                    longest_word_length = word.Length;
                }
            }

            return longest_word;
        }
        static void Main(string[] args)
        {
            /*
             * 24. Write a C# program to find the longest word in a string. Go to the editor
                Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
            Sample Output:
                following
            */

            /* Learning how to use split in C# 
            char[] mychars =
            {
                ',', '.', '?'
            };
            string myText = "Hello,-how are you-?.-are you okay.?,-asdf asdf asdf-?";

            string[] names = myText.Split(mychars, StringSplitOptions.None);
            foreach(string x in names)
            {
                Console.WriteLine(string.Format(" -- > *{0}*", x));
            }
            */

            string test_string = "Write a C# Sharp Program to display the following pattern using the alphabet";
            Console.WriteLine(find_longest_word(test_string));

            Console.ReadKey();
        }
    }
}
