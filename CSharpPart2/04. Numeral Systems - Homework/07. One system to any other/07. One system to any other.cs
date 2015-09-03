//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        
        Console.Write("Enter number to convert: ");
        string number = Console.ReadLine();
        Console.Write("Enter the base of the given number: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter the base in which you want to convert: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(BaseSToBaseD(number, s, d));
        
    }
    static string BaseSToBaseD(string number, int s, int d)
    {
        return DecimalToBase(BaseToDecimal(number, s), d);
    }
    static string DecimalToBase(long decimalNumber,long baseSystem)
    {
        string result = null;
        while (decimalNumber > 0)
        {
            long digit = decimalNumber % baseSystem;
            if (digit >= 0 && digit <= 9)
            {

                result = (char)(digit + '0') + result;

            }
            else 
            {
                result = (char)(digit - 10 + 'A') + result;

            }
            decimalNumber /= baseSystem;
        }
        return result;
    }
    static long BaseToDecimal(string number,int numeralSystem )
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else if (number[i] >= 'A' && number[i] <= 'F')
            {
                digit = number[i] - 'A' + 10;

            }
            decimalNumber += digit * (long)Math.Pow(numeralSystem, number.Length - i - 1);

        }
        return decimalNumber;
    }
}

