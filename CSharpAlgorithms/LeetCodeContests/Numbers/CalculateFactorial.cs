using CSharp.Algorithms.Utilities;
namespace CSharp.Algorithms.Numbers
{
    public class CalculateFactorial
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("CALCULATE FACTORIAL EXAMPLE - USING WHILE LOOP");
            PrintUtility.PrintSubTitle($"The factorial of 5 is {calculateFactorial_UsingWhile(5)}");

            PrintUtility.PrintTitle("CALCULATE FACTORIAL EXAMPLE - USING RECURSION");
            PrintUtility.PrintSubTitle($"The factorial of 5 is {calculateFactorial_UsingRecursion(5)}");

        }

        private static int calculateFactorial_UsingWhile(int num)
        {
            int result = 1;

            while (num != 1)
            {
                result = result * num;
                num--;
            }
            return result;
        }

        private static int calculateFactorial_UsingRecursion(int num)
        {
            if (num == 1)
            {
                return num;
            }
            return num * calculateFactorial_UsingRecursion(num - 1);
        }

    }
}
