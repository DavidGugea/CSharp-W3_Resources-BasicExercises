using System;

namespace Exercise_34
{
    class Program
    {
        static bool starts_with_hello(string s)
        {
            return s.StartsWith("Hello");
        }
        static void Main(string[] args)
        {
            /*
             * 34. Write a C# program to check if a string starts with a specified word. Go to the editor
            Note: Suppose the sentence starts with "Hello"
            Sample Data: string1 = "Hello how are you?"
            Result: Hello.
            Sample Output:
            Input a string : Hello how are you?
            True
            */

            Console.WriteLine(starts_with_hello("Hello how are you ?"));
        }
    }
}
