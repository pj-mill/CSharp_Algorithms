using System;
using System.Linq;

namespace CSharpAlgorithms.Codility_Lessons.Iterations
{
    /*
        A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends
        in the binary representation of N.
        For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
        The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
        The number 20 has binary representation 10100 and contains one binary gap of length 1. 
        The number 15 has binary representation 1111 and has no binary gaps.

    Write a function:
        int solution(int N);

        that, given a positive integer N, returns the length of its longest binary gap. 
        The function should return 0 if N doesn't contain a binary gap.
        For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap 
        is of length 5.

    Assume that:
            N is an integer within the range [1..2,147,483,647].

    Complexity:
            expected worst-case time complexity is O(log(N));
            expected worst-case space complexity is O(1).     
     */
    public class BinaryGap
    {
        public static void Run()
        {
            Console.WriteLine($"First Solution: {Solution(529)}");
            Console.WriteLine($"First Solution: {Solution(1)}");
            Console.WriteLine($"First Solution: {Solution(1000000)}");
            Console.WriteLine($"First Solution: {Solution(2000000000)}");

            Console.WriteLine($"Second Solution: {Solution2(529)}");
            Console.WriteLine($"Second Solution: {Solution2(1)}");
            Console.WriteLine($"Second Solution: {Solution2(1000000)}");
            Console.WriteLine($"Second Solution: {Solution2(2000000000)}");
        }

        public static int Solution(int n)
        {
            String bin = Convert.ToString(n, 2);
            int longest = 0;
            int current = 0;
            int firstIdx = bin.IndexOf("1");
            int lastIdx = bin.LastIndexOf("1");

            // Make sure we have a sequence to check
            if (lastIdx < 0 || firstIdx < 0 || lastIdx == firstIdx)
            {
                return 0;
            }

            // Strip out leading & trailing zeros and put result into an array
            String[] binarr = bin.Substring(firstIdx + 1, lastIdx).Split('1');

            // Find the longest
            for (int i = 0; i < binarr.Length; i++)
            {
                current = binarr[i].Length;
                if (current > longest)
                {
                    longest = current;
                }
            }
            return longest;
        }

        public static int Solution2(int n)
        {
            // Thanks to : http://codereview.stackexchange.com/questions/128105/calculating-the-binary-gap-of-a-number
            return Convert.ToString(n, 2).Trim('0').Split('1').Max(X => X.Length);
        }
    }
}
