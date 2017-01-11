using System;

namespace CSharpAlgorithms.LeetCodeContests
{
    /*
        LeetCode 376. Wiggle Sequence
        Level: Medium
        https://leetcode.com/problems/wiggle-subsequence/

        A sequence of numbers is called a wiggle sequence if the differences between successive numbers strictly 
        alternate between positive and negative. The first difference (if one exists) may be either positive or negative. 
        A sequence with fewer than two elements is trivially a wiggle sequence.

        For example, [1,7,4,9,2,5] is a wiggle sequence because the differences (6,-3,5,-7,3) are alternately positive and negative. 
        In contrast, [1,4,7,2,5] and [1,7,4,5,5] are not wiggle sequences, the first because its first two differences are positive 
        and the second because its last difference is zero.

        Given a sequence of integers, return the length of the longest subsequence that is a wiggle sequence. A subsequence is 
        obtained by deleting some number of elements (eventually, also zero) from the original sequence, leaving the remaining 
        elements in their original order.
    */
    public class WiggleSequence_376
    {
        public static void Run()
        {

            // System.Console.WriteLine(WiggleMaxLength(null)); // 0
            //System.Console.WriteLine(WiggleMaxLength(new int[1])); // 1
            //System.Console.WriteLine(WiggleMaxLength(new int[] { 0, 0 })); // 1
            //System.Console.WriteLine(WiggleMaxLength(new int[] { 1, 7, 4, 9, 2, 5 })); // 6
            System.Console.WriteLine(WiggleMaxLength(new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 })); // 7
            //System.Console.WriteLine(WiggleMaxLength(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })); // 2

            //System.Console.WriteLine(WiggleMaxLength(new int[] { 33, 53, 12, 64, 50, 41, 45, 21, 97, 35, 47, 92, 39, 0, 93, 55, 40, 46, 69, 42, 6, 95, 51, 68, 72, 9, 32, 84, 34, 64, 6, 2, 26, 98, 3, 43, 30, 60, 3, 68, 82, 9, 97, 19, 27, 98, 99, 4, 30, 96, 37, 9, 78, 43, 64, 4, 65, 30, 84, 90, 87, 64, 18, 50, 60, 1, 40, 32, 48, 50, 76, 100, 57, 29, 63, 53, 46, 57, 93, 98, 42, 80, 82, 9, 41, 55, 69, 84, 82, 79, 30, 79, 18, 97, 67, 23, 52, 38, 74, 15 }));
            // 33,53,12,64,50,97,35,47,39,93,55,69,42,95,51,68,9,32,6,26,3,43,30,60,3,68,9,97,19,27,4,30,9,78,43,64,4,65,30,84,64,76,57,63,53,57,42,80,9,41,30,79,18,97,67,74,15
        }

        private static int WiggleMaxLength(int[] nums)
        {
            if (nums == null || nums.Length == 0) { return 0; }
            if (nums.Length == 1) { return 1; }

            int arrayLength = nums.Length;
            int maxLength = 0;
            int currentMax = 1;
            int currentIdx = 0;
            int currentStartPoint = 0;
            bool alternate = true;
            int currentNum = 0;

            Func<int, int, int> IsGreater = (current, next) => { return (current > next) ? 1 : 0; };
            Func<int, int, int> IsLower = (current, next) => { return (current < next) ? 1 : 0; };


            while ((arrayLength - (currentIdx + 1)) > maxLength)
            {
                currentStartPoint = nums[currentIdx];
                currentMax = 1;

                for (int i = currentIdx + 1; i < arrayLength - 1; i++)
                {
                    if (nums[i] > currentStartPoint)
                    {
                        alternate = true; // Next should be greater
                        currentNum = nums[i];
                        currentMax++;

                        for (int j = i + 1; j < arrayLength; j++)
                        {
                            currentMax += alternate ? IsGreater(currentNum, nums[j]) : IsLower(currentNum, nums[j]);
                            alternate = !alternate;

                        }
                        maxLength = (currentMax > maxLength) ? currentMax : maxLength;
                    }
                }

                for (int i = currentIdx + 1; i < arrayLength - 1; i++)
                {
                    if (nums[i] < currentStartPoint)
                    {
                        currentMax++;

                        maxLength = (currentMax > maxLength) ? currentMax : maxLength;
                    }
                }

                currentIdx++;
            }

            return maxLength;
        }
    }
}