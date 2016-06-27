using CSharp.Algorithms.Utilities;
using System;

/* OUTPUT ...
                1 
              1 2 1 
            1 2 3 2 1 
          1 2 3 4 3 2 1 
        1 2 3 4 5 4 3 2 1 
      1 2 3 4 5 6 5 4 3 2 1 
    1 2 3 4 5 6 7 6 5 4 3 2 1 
  1 2 3 4 5 6 7 8 7 6 5 4 3 2 1 
1 2 3 4 5 6 7 8 9 8 7 6 5 4 3 2 1  
*/

namespace CSharp.Algorithms.Pyramids
{
    public class Pyramid04
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("PYRAMIDS EXAMPLE");

            int numberOfRows = 9, rowCount = 1;

            // We start in reverse order to facilitate more preceding spaces at top of pyramid (N-1 for each iteration = 17 >> 0)
            for (int i = numberOfRows; i > 0; i--)
            {
                // Print Preceding Spaces
                for (int j = 1; j < i * 2; j++) // Double up (i*2)
                {
                    Console.Write(" ");
                }

                // Print Numbers Ascending (from 1 to rowCount)
                for (int k = 1; k <= rowCount; k++)
                {
                    Console.Write(k + " ");
                }

                // Print Numbers Descending (from rowCount-1 to 1)
                for (int l = rowCount - 1; l >= 1; l--)
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
