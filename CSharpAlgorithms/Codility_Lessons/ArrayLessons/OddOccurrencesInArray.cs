using System.Linq;

namespace CSharpAlgorithms.Codility_Lessons.ArrayLessons
{
    public class OddOccurrencesInArray
    {
        public static void Run()
        {
            int[] arr = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            System.Console.WriteLine(Solution(arr));
        }

        private static int Solution(int[] A)
        {
            return A.GroupBy(i => i)                    // Group all numbers & get a count
                    .First(f => f.Count() % 2 != 0)     // Paired Numbers will have an even count, so ignore them
                    .Key;                               // select i
        }
    }
}
