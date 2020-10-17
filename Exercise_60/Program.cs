using System;

namespace Exercise_60
{
    class Program
    {
        static int solution(int[,] matrix)
        {
            // Time complexity -- > O(n^2) from T(n) = n + n^2
            // Space complexity -- > O(1) ( because we only have one variable and that is the number )

            int sum = 0 ;

            // The starting values from the first array in the matrix don't have any elements above, so add all of them
            for (int i = 0; i <= matrix.GetUpperBound(1); i++)
            {
                sum += matrix[0, i];
            }

            // Filter out all the values that don't have a 0 above them and add them to the sum
            for(int i = 1; i <= matrix.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if(matrix[i-1, j] != 0)
                    {
                        sum += matrix[i, j];
                        // Console.WriteLine(matrix[i, j]);
                        // Console.WriteLine(string.Format("Pair, current & up neighbour -- > ({0} < - > {1}, {2})", matrix[i - 1, j], matrix[i, j], matrix[i-1, j] != 0 ));
                        // Console.WriteLine("-------");
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            /*
             * 60. Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0. Go to the editor
            Sample Example:
            matrix = 
            [
            [0, 2, 3, 2],
            [0, 6, 0, 1],
            [4, 0, 3, 0]
            ]
            Eligible integers which will be participated to calculate the sum -
            matrix = 
            [
            [X, 2, 3, 2],
            [X, 6, X, 1],
            [X, X, X, X]
            ]
            Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
            */

            int[,] matrix = new int[,]
            {
                {0, 2, 3, 2 },
                {0, 6, 0, 1 },
                {4, 0, 3, 0 }
            };

            Console.WriteLine(solution(matrix));
        }
    }
}
