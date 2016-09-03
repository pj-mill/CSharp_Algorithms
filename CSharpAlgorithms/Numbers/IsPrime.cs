using CSharp.Algorithms.Utilities;
using System;

namespace CSharp.Algorithms.Numbers
{
    public class IsPrime
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("PRIME NUMBERS");
            print(2, IsPrimeNumber(2));
            print(5, IsPrimeNumber(5));
            print(6, IsPrimeNumber(6));
            print(12, IsPrimeNumber(12));
            print(13, IsPrimeNumber(13));
        }

        private static bool IsPrimeNumber(int num)
        {
            if (num == 1) return false;
            if (num == 2) return true;

            var sqrt = Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private static void print(int num, bool isPrime)
        {
            if (isPrime)
            {
                Console.WriteLine($"{num} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a Prime number");
            }
        }
    }
}
