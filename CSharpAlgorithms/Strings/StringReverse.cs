using CSharp.Algorithms.Utilities;
using System;
using System.Text;

namespace CSharp.Algorithms.Strings
{
    public class StringReverse
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("STRING REVERSING EXAMPLES");
            string reverseString = "ReverseString";
            PrintUtility.PrintSubTitle($"REVERSE STRING USING ITERATION: {ReverseStringUsingIteration(reverseString)}");
            PrintUtility.PrintSubTitle($"REVERSE STRING USING RECURSION: {ReverseStringRecursively(reverseString)}");
            PrintUtility.PrintSubTitle($"REVERSE STRING USING ARRAY.REVERSE: {ReverseStringUsingArray(reverseString)}");
        }

        /// <summary>
        /// Reverse a string using iteration
        /// </summary>
        private static string ReverseStringUsingIteration(string reverseString)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = reverseString.Length - 1; i >= 0; i--)
            {
                sb.Append(reverseString[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Reverse a string using recursion
        /// </summary>
        /// <param name="reverseString"></param>
        /// <returns></returns>
        private static string ReverseStringRecursively(String reverseString)
        {
            if (reverseString == null || reverseString.Length <= 1)
            {
                return reverseString;
            }
            return ReverseStringRecursively(reverseString.Substring(1)) + reverseString[0];
        }

        /// <summary>
        /// Reverse a string using Array.Reverse static method
        /// </summary>
        /// <param name="reverseString"></param>
        /// <returns></returns>
        private static string ReverseStringUsingArray(string reverseString)
        {
            char[] inputArray = reverseString.ToCharArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }
    }
}
