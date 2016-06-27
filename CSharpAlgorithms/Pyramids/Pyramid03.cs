using CSharp.Algorithms.Utilities;
using System;

/* OUTPUT ...
         * 
        * * 
       * * * 
      * * * * 
     * * * * * 
    * * * * * * 
   * * * * * * * 
  * * * * * * * * 
 * * * * * * * * *  
*/

namespace CSharp.Algorithms.Pyramids
{
    public class Pyramid03
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

                // Print numbers (from 1 to rowCount)
                for (int k = 1; k <= rowCount; k++)
                {
                    Console.Write("* ");
                }

                // Start a new Line
                Console.WriteLine();

                // Increment row count
                rowCount++;
            }
        }
    }
}
