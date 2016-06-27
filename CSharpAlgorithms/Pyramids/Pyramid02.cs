using CSharp.Algorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* OUTPUT ...
         1 
        1 2 
       1 2 3 
      1 2 3 4 
     1 2 3 4 5 
    1 2 3 4 5 6 
   1 2 3 4 5 6 7 
  1 2 3 4 5 6 7 8 
 1 2 3 4 5 6 7 8 9  
*/

namespace CSharp.Algorithms.Pyramids
{
    public class Pyramid02
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
                    Console.Write(k + " ");
                }

                // Start a new Line
                Console.WriteLine();

                // Increment row count
                rowCount++;
            }
        }
    }
}
