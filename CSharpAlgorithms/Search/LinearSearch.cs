using CSharp.Algorithms.Utilities;
using System.Collections.Generic;

namespace CSharp.Algorithms.Search
{
    public class LinearSearch
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("LINEAR SEARCH EXAMPLES");

            List<string> list = new List<string>();

            list.Add("peach");          // 0
            list.Add("acorn");          // 1
            list.Add("onion");          // 2
            list.Add("appliste");       // 3
            list.Add("banana");         // 4
            list.Add("tangerine");      // 5
            list.Add("cantalistoupe");  // 6
            list.Add("squash");         // 7
            list.Add("listettuce");     // 8
            list.Add("pepper");         // 9

            SearchUnsortedlist(list, "banana");
            SearchUnsortedlist(list, "ALLI BABBA");

            SearchSortedlist(list, "banana");
            SearchSortedlist(list, "ALLI BABBA");
        }

        private static void SearchUnsortedlist(List<string> list, string searchValue)
        {
            // Here we iterate from start to finish. If we find the value at any stage, we simply break out of the loop.
            // This means that if we do not find the value, we will not know until we reach the end.
            int searchesPerformed = 0;
            bool found = false;

            for (int i = 0; i < list.Count; i++)
            {
                ++searchesPerformed;
                if (list[i].CompareTo(searchValue) == 0) // case sensitive compare
                {
                    // Found It !
                    found = true;
                    break;
                }
            }
            PrintUtility.PrintSubTitle(found ? $"{searchesPerformed} SEARCHES PERFORMED TO FIND '{searchValue}' (UNSORTED LIST)" : $"{searchesPerformed} SEARCHES PERFORMED: '{searchValue}' COULD NOT BE FOUND (UNSORTED LIST)");
        }

        private static void SearchSortedlist(List<string> list, string searchValue)
        {
            // Again iterate from start to finish and break out of the loop if we find the value we're looking for.
            // However, because the list is sorted, we can compare our values and if the current value is greater than the search value, 
            // we can then safely assume that the search value is not in the list, and break out of the loop without having to traverse to the end.

            list.Sort(); // SORT THE LIST

            int searchesPerformed = 0;
            bool found = false;

            for (int i = 0; i < list.Count; i++)
            {
                ++searchesPerformed;
                if (list[i].CompareTo(searchValue) > 0)  // case sensitive compare
                {
                    // If current value is greater than the search value, then we know that our search value is not in the list.
                    break;
                }
                else if (list[i].CompareTo(searchValue) == 0) // case sensitive compare
                {
                    // Found It !
                    found = true;
                    break;
                }
            }
            PrintUtility.PrintSubTitle(found ? $"{searchesPerformed} SEARCHES PERFORMED TO FIND '{searchValue}' (SORTED LIST)" : $"{searchesPerformed} SEARCHES PERFORMED: '{searchValue}' COULD NOT BE FOUND (SORTED LIST)");
        }

    }
}
