using CSharp.Algorithms.Utilities;
using System;

namespace CSharp.Algorithms.Numbers
{
    public class ArmstrongNumbers
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("ARMSTRONG NUMBERS EXAMPLE - FIRST METHOD");
            check1(153);
            check1(371);
            check1(9474);
            check1(54748);
            check1(407);
            check1(1674);

            PrintUtility.PrintTitle("ARMSTRONG NUMBERS EXAMPLE - SECOND METHOD");
            check2(153);
            check2(371);
            check2(9474);
            check2(54748);
            check2(407);
            check2(1674);

        }

        private static void check1(double originalNumber)
        {
            double exponent = originalNumber.ToString().Length;
            char[] digits = originalNumber.ToString().ToCharArray();
            double result = 0;

            for (int i = 0; i < exponent; i++)
            {
                double num = Char.GetNumericValue(digits[i]);
                result += Math.Pow(num, exponent);
            }

            PrintUtility.PrintSubTitle(result == originalNumber ? $"{originalNumber} IS AN ARMSTRONG NUMBER: RESULT = {result}" : $"{originalNumber} IS NOT AN ARMSTRONG NUMBER: RESULT = {result}");
        }

        private static void check2(int originalNumber)
        {
            int copyOfNumber = originalNumber;
            int exponent = originalNumber.ToString().Length;
            int result = 0;

            // Comments show the results for each iteration for the number 153
            while (copyOfNumber != 0)
            {
                int lastDigit = copyOfNumber % 10;                  // = 3, 5, 1
                int lastDigitToThePowerOfExponent = 1;              // = 1

                for (int i = 0; i < exponent; i++)
                {                                                                                   // 1st iteration {3} = (1 * 3), (3 * 3), (9 * 3) = 27
                    lastDigitToThePowerOfExponent = lastDigitToThePowerOfExponent * lastDigit;      // 2nd iteration {5} = (1 * 5), (5 * 5), (25 * 5) = 125
                }                                                                                   // 3rd iteration {1} = (1 * 1), (1 * 1), (1 * 1) = 1

                result = result + lastDigitToThePowerOfExponent;    // = 27, 152, 153
                copyOfNumber = copyOfNumber / 10;                   // = 15, 1, 0

                // uncomment the following line to see how it works
                //Console.WriteLine($"lastDigit: {lastDigit} - lastDigitToThePowerOfNoOfDigits: {lastDigitToThePowerOfNoOfDigits} - result: {result} - copyOfNumber: {copyOfNumber}");
            }

            PrintUtility.PrintSubTitle(result == originalNumber ? $"{originalNumber} IS AN ARMSTRONG NUMBER: RESULT = {result}" : $"{originalNumber} IS NOT AN ARMSTRONG NUMBER: RESULT = {result}");
        }

    }
}
