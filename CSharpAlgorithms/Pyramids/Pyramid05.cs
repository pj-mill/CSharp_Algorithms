using CSharp.Algorithms.Utilities;
using System;

/* OUTPUT ...
1 2 3 4 5 6 7 8 9 8 7 6 5 4 3 2 1 
  1 2 3 4 5 6 7 8 7 6 5 4 3 2 1 
    1 2 3 4 5 6 7 6 5 4 3 2 1 
      1 2 3 4 5 6 5 4 3 2 1 
        1 2 3 4 5 4 3 2 1 
          1 2 3 4 3 2 1 
            1 2 3 2 1 
              1 2 1 
                1 
*/

namespace CSharp.Algorithms.Pyramids
{
    public class Pyramid05
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("PYRAMIDS EXAMPLE");

            int numberOfRows = 9, rowCount = 1;

            // We start in order to facilitate less preceding spaces at top of pyramid (N+1 for each iteration = 0 >> 17)
            for (int i = 1; i <= numberOfRows; i++)
            {
                // Print Preceding Spaces
                for (int j = 0; j <= i * 2 - 2; j++)
                {
                    Console.Write(" ");
                }

                // Print Numbers Ascending
                for (int k = 1; k <= numberOfRows - rowCount + 1; k++)
                {
                    Console.Write(k + " ");
                }

                // Print Numbers Descending
                for (int l = numberOfRows - rowCount; l >= 1; l--)
                {
                    Console.Write(l + " ");
                }

                // Start a new Line
                Console.WriteLine();

                // Increment row count
                rowCount++;
            }
        }
    }
}
