using System.Collections.Generic;
using System.Linq;

namespace CSharpAlgorithms.Codility.ArrayLessons
{
    public class OddOccurrencesInArray
    {
        public static void Run()
        {
            int[] arr = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int[] arr2 = new int[] { 9, 3, 9, 3, 9, 5, 9 };
            System.Console.WriteLine(Solution1(arr));
            System.Console.WriteLine(Solution2(arr));
            System.Console.WriteLine(Solution3(arr2));
        }

        private static int Solution1(int[] A)
        {
            Dictionary<int, int> groups = new Dictionary<int, int>();
            foreach (int num in A)
            {
                if (groups.ContainsKey(num))
                {
                    groups[num]++;
                }
                else
                {
                    groups.Add(num, 1);
                }
            }
            return groups.First(g => g.Value % 2 != 0).Key;
        }

        private static int Solution2(int[] A)
        {
            // Thanks to : https://disqus.com/by/tiagobogalho/
            return A.GroupBy(i => i)                    // Group all numbers & get a count
                    .First(f => f.Count() % 2 != 0)     // Paired Numbers will have an even count, so ignore them
                    .Key;                               // select i
        }

        private static int Solution3(int[] A)
        {
            /*
             If we XOR a number with itself even number of times the result is 0, otherwise it's the number itself. 
             Therefore, if we XOR the entire array, the result should be odd occurring element itself.
             */
            int odd = 0;
            for (int i = 0; i < A.Length; i++)
            {
                odd ^= A[i];
            }
            return odd;
        }

    }
}
