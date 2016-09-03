using System;

namespace CSharpAlgorithms.LeetCodeContests
{

    /*
    LeetCode 390. Elimination Game
    https://leetcode.com/contest/2/problems/elimination-game/

    There is a list of sorted integers from 1 to n. Starting from left to right, remove the first number and every other number afterward until you reach the end of the list.
    Repeat the previous step again, but this time from right to left, remove the right most number and every other number from the remaining numbers.
    We keep repeating the steps again, alternating left to right and right to left, until a single number remains.
    Find the last number that remains starting with a list of length n.
*/

    public class EliminationGame_390
    {
        public static void Run()
        {
            Console.WriteLine(LastRemaining(9)); // 6
            Console.WriteLine(LastRemaining(10)); // 8
            Console.WriteLine(LastRemaining(15)); // 8
            Console.WriteLine(LastRemaining(22)); // 16
            Console.WriteLine(LastRemaining(6)); // 4
            Console.WriteLine(LastRemaining(11)); // 8
            Console.WriteLine(LastRemaining(35)); // 24
            Console.WriteLine(LastRemaining(53)); // 22
            Console.WriteLine(LastRemaining(90000)); // 24534
        }

        private static int LastRemaining(int n)
        {
            // Pre-Check
            if (n == 1) { return 1; }
            if (n <= 3) { return 2; }

            // Vars
            int result = 0;
            int directionCycle = 1;// 0 == L=>R ; 1 == R=>L
            int lower = 2;
            int higher = (n % 2 == 0) ? n : n - 1;
            int possibleNumbers = higher / lower;
            bool even = (possibleNumbers % 2 == 0); // Are there an even amount of possible numbers
            int diff = 2; // The difference between one number and the next for each iteration

            // Iterate
            while (result == 0)
            {
                // Left To Right (directionCycle == 0)
                if (directionCycle % 2 == 0)
                {
                    lower += diff;
                    higher = even ? higher : higher - diff;
                }

                // Right To Left (directionCycle == 1)
                else
                {
                    higher -= diff;
                    lower = even ? lower : lower + diff;
                }

                // Check
                result = (lower == higher || possibleNumbers == 2) ? higher : 0;

                // Prepare for next iteration
                possibleNumbers = possibleNumbers / 2;
                even = (possibleNumbers % 2 == 0);
                diff *= 2;
                directionCycle++;
            }

            return result;
        }
    }
}
