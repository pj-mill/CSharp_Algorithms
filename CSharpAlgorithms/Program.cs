using CSharp.Algorithms.Strings;
using CSharp.Algorithms.Numbers;
using CSharp.Algorithms.Pyramids;
using CSharp.Algorithms.Search;

namespace CSharp.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /// STRINGS
            FindDuplicateLetters.Run();
            StringReverse.Run();

            /// NUMBERS
            ArmstrongNumbers.Run();
            CalculateFactorial.Run();
            FibonacciRun.Run();
            
            // PYRAMIDS
            Pyramid01.Run();
            Pyramid02.Run();
            Pyramid03.Run();
            Pyramid04.Run();
            Pyramid05.Run();

            // SEARCH
            LinearSearch.Run();
            BinarySearch.Run();
            
        }
    }
}
