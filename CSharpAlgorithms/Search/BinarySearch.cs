using CSharp.Algorithms.Utilities;
using System;
using System.Collections.Generic;

namespace CSharp.Algorithms.Search
{
    public class BinarySearch
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("BINARY SEARCH EXAMPLES");

            List<string> list = new List<string>();
            list.Add("acorn");          // 0
            list.Add("apple");          // 1
            list.Add("banana");         // 2
            list.Add("cantaloupe");     // 3
            list.Add("lettuce");        // 4
            list.Add("onion");          // 5
            list.Add("peach");          // 6
            list.Add("pepper");         // 7
            list.Add("squash");         // 8
            list.Add("tangerine");      // 9

            list.Sort(); // List must be sorted

            BuiltInSearch(list, "cantaloupe");

            CustomSearch(list, "cantaloupe");
            CustomSearch(list, "squash");
        }


        private static void BuiltInSearch(List<String> list, string searchValue)
        {
            // This returns the index of "cantaloupe".
            int i = list.BinarySearch(searchValue);
            PrintUtility.PrintSubTitle($"BUILT-IN SEARCH FACILITY - {searchValue} can be found at index {i}");
        }

        private static void CustomSearch(List<String> list, string searchValue)
        {
            PrintUtility.PrintSubTitle("HAND-BALL APPROACH - DIVIDE & CONQUER");
            int low = 0, high = list.Count - 1, mid = 0, idx = -1;

            while (low <= high)
            {
                mid = (low + high) / 2;     // Divide the list

                Console.WriteLine($"Lower: {low}\t => Higher: {high}\t => Mid: {mid}"); // Print out index positions to show how it actually works.

                if (list[mid].CompareTo(searchValue) < 0)
                {
                    // If the value of the middle element in the list is lesser than the search value, we need to look to the right of the list.
                    // Therefore we set the lower boundary position to the middle + 1;
                    low = mid + 1;
                }
                else if (list[mid].CompareTo(searchValue) > 0)
                {
                    // If the value of the middle element in the list is greater than the search value, we need to look to the left of the list.
                    // Therefore we set the higher boundary position to the middle - 1;
                    high = mid - 1;
                }
                else
                {
                    // We've found it
                    idx = mid;
                    break;
                }

            }
            // Print the index of the 'searchValue' if found, otherwise notify that the search value is not in the list.
            PrintUtility.PrintSubTitle(idx >= 0 ? $"'HandBallSearch' - {searchValue} can be found at index {idx}" : $"'HandBallSearch' - {searchValue} could not be found");
        }

    }
}
