using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_62
{
    class Program
    {
        static string solution(string str)
        {
            // Time complexity : O(n)
            // Space complexity : O(n)
            Stack<int> opened_parantheses = new Stack<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    opened_parantheses.Push(i);
                }
                else if (str[i] == ')')
                {
                    // Get the index of the opened parantheses
                    int opened_index = opened_parantheses.Peek();

                    // Get the text in between the parantheses, reverse and replace it
                    string reverse = String.Concat(str.Substring(opened_index + 1, i - opened_index - 1).ToString().Reverse());
                    str = str.Remove(opened_index + 1, i - opened_index - 1);
                    str = str.Insert(opened_index + 1, reverse);

                    opened_parantheses.Pop();
                }
            }

            // Delete all parantheses
            int counter = 0;
            while(counter < str.Length)
            {
                if(str[counter] == '(' || str[counter] == ')')
                {
                    str = str.Remove(str.IndexOf(str[counter]), 1);
                    counter--;
                }

                counter++;
            }

            return str;
        }
        static void Main(string[] args)
        {
            /*
             * 62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string. 
            */

            string str = "(p(rq)st)";
            string str1 = "(ab(cd)ef(gh)ij(klm)nop(q))";
            string str2 = "p(rq)(st)";
            string str3 = "a((xyz))"; // 1 -> 7 ; 2 -> 6

            Console.WriteLine(solution(str2));
        }
    }
}
