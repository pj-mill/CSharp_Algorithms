using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAlgorithms.CodeWars
{
    /*
        The new "Avengers" movie has just been released! 
        There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. 
        A "Avengers" ticket costs 25 dollars.

        Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

        Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the 
        order people follow in the line?

        Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.
    */
    public class Vasya_Clerk
    {
        public static void Run()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            int[] peopleInLine2 = new int[] { 25, 100 };
            int[] peopleInLine3 = new int[] { 50, 25, 100 };
            int[] peopleInLine4 = new int[] { 25, 25, 50, 50, 50 };
            int[] peopleInLine5 = new int[] { 25, 25, 25, 100, 50 };

            Console.WriteLine(Tickets(peopleInLine).Equals("YES") ? "PASSED\n" : "FAILED\n");
            Console.WriteLine(Tickets(peopleInLine2).Equals("YES") ? "FAILED\n" : "PASSED\n");
            Console.WriteLine(Tickets(peopleInLine3).Equals("YES") ? "FAILED\n" : "PASSED\n");
            Console.WriteLine(Tickets(peopleInLine4).Equals("YES") ? "FAILED\n" : "PASSED\n");
            Console.WriteLine(Tickets(peopleInLine5).Equals("YES") ? "FAILED\n" : "PASSED\n");

            // All should be 'PASSED'
        }

        public static string Tickets(int[] peopleInLine)
        {
            int changeToGive = 0, amountGiven = 0, ticketCost = 25;
            Dictionary<int, int> bank = new Dictionary<int, int>() { { 100, 0 }, { 50, 0 }, { 25, 0 } };

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                amountGiven = peopleInLine[i];
                changeToGive = amountGiven - ticketCost;
                if (changeToGive > 0 && !HaveChange(ref bank, changeToGive))
                {
                    return "NO";
                }
                bank[amountGiven] += 1;
            }
            return "YES";
        }

        private static bool HaveChange(ref Dictionary<int, int> bank, int changeToGive)
        {
            foreach (var note in bank.ToList())
            {
                int key = note.Key, value = note.Value;

                while (changeToGive > 0 && value > 0 && key <= changeToGive)
                {
                    bank[note.Key] -= 1;
                    value -= 1;
                    changeToGive -= note.Key;
                }
            }
            return changeToGive == 0;
        }
    }
}
