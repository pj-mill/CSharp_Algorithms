using System;
using System.Linq;

namespace CSharpAlgorithms.Codility_Lessons.Arrays
{
    public class CyclicRotation
    {
        public static void Run()
        {
            Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
        }

        public static int[] Solution(int[] A, int K)
        {
            if (K < 1 || A == null || A.Length == 0)
            {
                return A;
            }

            int[] B = A.Take(K - 1).ToArray();
            int[] C = A.Skip(K - 1).ToArray();
            int[] D = C.Union(B).ToArray();

            Console.WriteLine($"Original:\t{string.Join(" ", A)}");
            Console.WriteLine($"Cycled:\t\t{string.Join(" ", D)}");

            return D;
        }
    }
}
