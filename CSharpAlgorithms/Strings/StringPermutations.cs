using CSharp.Algorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CSharp.Algorithms.Strings
{
    public class StringPermutations
    {
        public static void Run()
        {
            SentenceIterativeApproach("This is the string hello");

        }

        private static void SentenceIterativeApproach(string input)
        {
            PrintUtility.PrintTitle("SENTENCE PERMUTAIONS");

            // Defensive
            if (string.IsNullOrEmpty(input)) return;

            // Start the clock
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Local vars
            List<string> primarySet = input.Split(' ').ToList<string>();
            var len = primarySet.Count();
            var subsetLength = len - 1;
            var subset = new string[subsetLength];
            var subsetPermutations = subset.Length * (subset.Length - 1);

            // No point if only a single word
            if (len == 1)
            {
                Console.WriteLine(primarySet[0]);
                return;
            }

            // Shift Primaryset words
            Action<List<string>, int> shiftPrimarySet = (list, idxFrom) =>
            {
                // Always shifts word to zero index (unless it's zero)
                // Shift next word to top of primary list
                // This allows us to order the output plus
                // it makes it easier for us to grab the rest of the set and 'CopyTo' subset
                // E.G. (The first words reading down reads the same as the first line going across)
                //      This is a string
                //      is This a string
                //      a This is string
                //      string This is a

                if (idxFrom <= 0) return;
                var temp = list[0];
                list[0] = list[idxFrom];
                list[idxFrom] = temp;
            };

            // Shift subset words
            Action<string[], int> shiftSubset = (subsetArray, to) =>
            {
                // We keep shifting from left to right until we reach the upper boundary
                // E.G. Checkout 'This' word
                //      This is a string
                //      is This a string
                //      is a This string
                //      is a string This

                if (to <= 0) return;
                var temp = subsetArray[to];
                subsetArray[to] = subsetArray[to - 1];
                subsetArray[to - 1] = temp;
            };

            // Print permutations
            Action<string, string[]> print = (curWord, subsetArray) =>
            {
                Console.Write($"{curWord} ");
                foreach (var word in subsetArray)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            };

            // Process
            for (int i = 0; i < len; ++i)
            {
                var subsetShiftIndex = 1;

                // Shift words in primary set
                shiftPrimarySet(primarySet, i);
                primarySet.CopyTo(1, subset, 0, subsetLength);

                for (int j = 1; j <= subsetPermutations; j++)
                {
                    // Print Permutation
                    print(primarySet[0], subset);

                    // Shift subset words

                    shiftSubset(subset, subsetShiftIndex);

                    // If we reach the upper boundary of the subset, start at the beginning
                    subsetShiftIndex = (++subsetShiftIndex > subset.Length - 1) ? 1 : subsetShiftIndex;
                }
            }

            sw.Stop();
            Console.WriteLine($"Process took: {sw.ElapsedMilliseconds} ms");
        }

    }
}

