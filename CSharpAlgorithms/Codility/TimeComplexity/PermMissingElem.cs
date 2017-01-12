using System;

namespace CSharpAlgorithms.Codility.TimeComplexity
{
    public class PermMissingElem
    {
        public static void Run()
        {
            int[] arr = new int[] { 2, 7, 9, 5, 3, 1, 4 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr3 = new int[] { 2 };
            int[] arr4 = new int[] { 5, 6 };
            Console.WriteLine(Solution1(arr));
            Console.WriteLine(Solution1(arr2));
            Console.WriteLine(Solution1(arr3));
            Console.WriteLine(Solution1(arr4));
        }

        private static int Solution1(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 1;
            }

            int missing = 0;
            int len = A.Length - 1;

            Array.Sort(A);

            for (int i = 0; i <= len; i++)
            {
                missing = (i == 0 && A[i] > 1) ? A[i] - 1 : (i == len) ? A[i] + 1 : (A[i] + 1 != A[i + 1]) ? A[i] + 1 : 0;
                if (missing != 0) { break; }
            }

            return missing;
        }
    }
}
