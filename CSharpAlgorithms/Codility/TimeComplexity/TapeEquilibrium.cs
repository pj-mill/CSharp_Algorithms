using System;
using System.Linq;

namespace CSharpAlgorithms.Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public static void Run()
        {
            int[] arr = new int[] { 3, 1, 2, 4, 3 };
            Console.WriteLine(Solution1(arr));
            Console.WriteLine(Solution2(arr));
        }

        private static int Solution1(int[] A)
        {
            // 100% Correct but very inefficient
            if (A == null || A.Length < 2)
            {
                return 0;
            }

            int min = int.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                int diff = Math.Abs(A.Take(i + 1).Sum() - A.Skip(i + 1).Sum());
                min = (min < diff) ? min : diff;
            }

            return min;
        }

        private static int Solution2(int[] A)
        {
            // 100% Correctness & Performance
            if (A == null || A.Length < 2) { return 0; }

            int min = int.MaxValue, left = 0, total = A.Sum(), diff = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                left += A[i];
                diff = Math.Abs(left - (total - left));
                min = (min < diff) ? min : diff;
                if (min == 1) { break; }
            }

            return min;
        }
    }
}
