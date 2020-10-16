using System;
using System.Linq;

namespace Exercise_56
{
    class Program
    {
        static bool is_palindrome(string str)
        {
            return str== String.Concat(str.Reverse()) ? true : false;
        }
        static void Main(string[] args)
        {
            /*
             * 56. Write a C# program to check if a given string is a palindrome or not. Go to the editor
            Sample Example:
            For 'aaa' the output should be true
            For 'abcd' the output should be false
            */

            Console.WriteLine(is_palindrome("aaa"));
            Console.WriteLine(is_palindrome("abcd"));
        }
    }
}
