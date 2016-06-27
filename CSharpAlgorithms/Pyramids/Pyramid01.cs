using CSharp.Algorithms.Utilities;
using System;

/* OUTPUT ...
         1 
        2 2 
       3 3 3 
      4 4 4 4 
     5 5 5 5 5 
    6 6 6 6 6 6 
   7 7 7 7 7 7 7 
  8 8 8 8 8 8 8 8 
 9 9 9 9 9 9 9 9 9 
*/

namespace CSharp.Algorithms.Pyramids
{
    public class Pyramid01
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("PYRAMIDS EXAMPLE");

            int numberOfRows = 9, rowCount = 1;

            // We start in reverse order to facilitate more preceding spaces at top of pyramid (N-1 for each iteration = 8, 7, 6, 5, 4, 3, 2, 1)
            for (int i = numberOfRows; i > 0; i--)
            {
                // Print Preceding Spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers (rowcount)
                for (int k = 0; k < rowCount; k++)
                {
                    Console.Write(rowCount + " ");
                }

                // Start a new Line
                Console.WriteLine();

                // Increment row count
                rowCount++;
            }
        }
    }
}
