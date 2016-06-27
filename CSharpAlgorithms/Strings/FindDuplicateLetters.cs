using CSharp.Algorithms.Utilities;
using System;
using System.Collections.Generic;

namespace CSharp.Algorithms.Strings
{
    public class FindDuplicateLetters
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("FIND DUPLICATE LETTERS");
            find("Better Be Butter");
            find("Fresh Fish");
            find("Fruity Wuity");
        }

        private static void find(string str)
        {
            PrintUtility.PrintSubTitle($"FINDING DUPLICATES LETTERS IN {str}");

            Dictionary<char, int> characterCount = new Dictionary<char, int>(); // Collection to hold each letter and it's count
            char[] characters = str.ToCharArray();                              // Throw all characters into a char array

            foreach (char c in characters)                                       // Iterate through the array and tally each character
            {
                if (characterCount.ContainsKey(c))                              // Character already exists in the list
                {
                    characterCount[c] += 1;                                     // Increment count
                }
                else
                {
                    characterCount.Add(c, 1);                                   // Add new character to list
                }
            }

            foreach (var pair in characterCount)                                 // Iterate through result set and print those with a value greater than 1.
            {
                if (pair.Key != ' ' && pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }

        }
    }
}
