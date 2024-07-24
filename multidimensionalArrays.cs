using System.Globalization;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numbers = { { 1, 3, 4, 5 }, { 2, 3, 4, 5 } };
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }/*/

            int[,] num = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < num.GetLength(0); i++) 
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}



/** write a code for creating 3*4 matrix
 * using System;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a 3x4 matrix
            int[,] num = { 
                { 1, 4, 2, 5 }, 
                { 3, 6, 8, 7 }, 
                { 9, 10, 11, 12 } 
            };

            // Loop through the rows
            for (int i = 0; i < num.GetLength(0); i++)
            {
                // Loop through the columns
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    // Print the element at [i, j]
                    Console.Write(num[i, j] + " ");
                }
                // Print a new line after each row
                Console.WriteLine();
            }
        }
    }
}
/*/
