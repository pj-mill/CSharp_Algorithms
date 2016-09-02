using System;
using System.Collections.Generic;

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

    public class EliminationGame
    {
        public static void Run()
        {
            Console.WriteLine(LastRemaining(9)); // 6
            Console.WriteLine(LastRemaining(6)); // 4
            Console.WriteLine(LastRemaining(11)); // 8
            Console.WriteLine(LastRemaining(1000000));
        }

        private static int LastRemaining(int n)
        {
            int[] currentNums = new int[n];
            // int[] toProcess;
            int cycle = 0;
            int lower = 1;
            int higher = n;
            int count = n;
            int currentLow = 1;
            int currentHigh = n;
            int currentIdx = 0;

            int result = 0;

            while (result == 0)
            {

                if (cycle % 2 == 0)
                {

                    //currentHigh = (higher % 2 == 1) ? higher - 1 : higher;

                    currentIdx = 0;
                    lower = currentLow;
                    for (int i = lower; i <= higher; i++)
                    {
                        if (currentIdx == 1)
                        {
                            currentLow = i;
                        }

                        if (i % 2 == 1)
                        {
                            currentHigh = i;
                        }

                        currentIdx++;
                    }

                    Console.WriteLine($"{currentLow} - {currentHigh}");

                    if (currentLow == currentHigh)
                    {
                        result = currentHigh;
                    }

                }
                else
                {

                }
                cycle++;
            }
            return result;
        }

        private static int LastRemaining2(int n)
        {
            int[] currentNums = new int[n];
            int[] toProcess;// = null;// new int[n];
            int cycle = 0;
            int currentIdx = 0;

            for (int i = 1; i <= n; i++)
            {
                currentNums[i - 1] = i;
            }

            while (currentNums.Length > 1)
            {
                toProcess = new int[currentNums.Length];
                Array.Copy(currentNums, toProcess, currentNums.Length);

                if (cycle % 2 == 0)
                {
                    currentNums = new int[currentNums.Length / 2];
                    currentIdx = 0;
                    for (int i = 0; i < toProcess.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            currentNums[currentIdx] = toProcess[i];
                            currentIdx++;
                        }
                    }

                }
                else
                {
                    int shift = (currentNums.Length % 2 == 0) ? 0 : 1;
                    currentNums = new int[currentNums.Length / 2];
                    currentIdx = currentNums.Length - 1;
                    for (int i = toProcess.Length - 1; i >= 0; i--)
                    {
                        if (i % 2 == shift)
                        {
                            currentNums[currentIdx] = toProcess[i];
                            currentIdx--;
                        }
                    }
                }
                cycle++;
            }

            return currentNums[0];
        }


        private static int LastRemainingAttempt01(int n)
        {
            List<int> currentNums = new List<int>();
            List<int> toProcess = new List<int>();
            int cycle = 0;

            for (int i = 1; i <= n; i++)
            {
                currentNums.Add(i);
            }

            while (currentNums.Count > 1)
            {
                toProcess = new List<int>(currentNums);
                currentNums.Clear();

                if (cycle % 2 == 0)
                {
                    // Left to right
                    for (int i = 0; i < toProcess.Count; i++)
                    {
                        if (i % 2 == 1)
                        {
                            currentNums.Add(toProcess[i]);
                        }
                    }
                }
                else
                {
                    var count = 0;
                    // Right to left
                    for (int i = toProcess.Count - 1; i >= 0; i--)
                    {
                        if (count % 2 == 1)
                        {
                            currentNums.Insert(0, toProcess[i]);
                        }
                        count++;
                    }
                }

                cycle++;
            }
            return currentNums[0];
        }
    }
}
