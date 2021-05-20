using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_5_Logic_Program
{

    public static class Task_18
    {
       public static int FillMass(int[] mass)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0) count++;

            }
            return count;
        }
    }
    public static class Task_11
    {
        public static string Result(string num)
        {
            
            string copy = num.Trim(' ');
            string result = "";
            string numbers = "0123456789";
            char[] chopper = copy.ToCharArray();
            for (int i = 0; i < chopper.Length; i++)
            {
                if (numbers.Contains(chopper[i]) == true) { result += chopper[i]; result += " "; }
            }
            return result;
        }

    }
    public static class MockBaseConvertation
        {
            public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
            {
                const int BitsInLong = 64;
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

                if (decimalNumber == 0)
                    return "0";

                int index = BitsInLong - 1;
                long currentNumber = Math.Abs(decimalNumber);
                char[] charArray = new char[BitsInLong];

                while (currentNumber != 0)
                {
                    int remainder = (int)(currentNumber % radix);
                    charArray[index--] = Digits[remainder];
                    currentNumber = currentNumber / radix;
                }

                string result = new String(charArray, index + 1, BitsInLong - index - 1);
                if (decimalNumber < 0)
                {
                    result = "-" + result;
                }

                return result;
            }
            public static long ArbitraryToDecimalSystem(string number, int radix)
            {
                const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (radix < 2 || radix > Digits.Length)
                    throw new ArgumentException("The radix must be >= 2 and <= " +
                        Digits.Length.ToString());

                if (String.IsNullOrEmpty(number))
                    return 0;
                number = number.ToUpperInvariant();

                long result = 0;
                long multiplier = 1;
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    char c = number[i];
                    if (i == 0 && c == '-')
                    {
                        result = -result;
                        break;
                    }

                    int digit = Digits.IndexOf(c);
                    if (digit == -1)
                        throw new ArgumentException(
                            "Invalid character in the arbitrary numeral system number",
                            "number");

                    result += digit * multiplier;
                    multiplier *= radix;
                }

                return result;
            }
        }
    }

